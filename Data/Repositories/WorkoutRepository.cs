using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Data.Repositories
{
    public class WorkoutRepository
    {
        public void AddWorkout(Workout workout)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("INSERT INTO workout(date_workout,type_workout,routine_id) VALUES (@date_workout,@type_workout,@routine_id)", connection);
                command.Parameters.AddWithValue("@date_workout",workout.date_workout);
                command.Parameters.AddWithValue("@type_workout",workout.Type_workout);
                command.Parameters.AddWithValue("@routine_id",workout.Routine_id);
                command.ExecuteNonQuery();
            }
        }
        public List<double> GetWeightChange(int routineId)
        {
            List<double> weightCollector = new List<double>();
            string weight_type = "";
             MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT weight.current_weight,weight.weight_type FROM workout INNER JOIN weight ON weight.routine_id = workout.routine_id WHERE workout.date_workout = weight.date_measure AND workout.routine_id =@routine_id GROUP BY weight.date_measure ORDER BY weight.date_measure", connection);
                command.Parameters.AddWithValue("@routine_id", routineId);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    int count = 0;
                    while (reader.Read())
                    {
                        double weight = 0;
                        if (count == 0)
                        {
                            weight_type = reader.GetString(1);
                            weight = reader.GetDouble(0);
                            count++;
                        }
                        else
                        {
                            if (reader.GetString(1)!=weight_type)
                            {
                                weight = ConvertToKilosOrPounds(weight_type, reader.GetDouble(0));
                            }
                            else
                            {
                                weight=reader.GetDouble(0);
                            }
                        }
                        weightCollector.Add(weight);
                    }


                }
            }
            return weightCollector;
        }
        public string GetWeightChangeType(int routineId)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT weight.current_weight,weight.weight_type FROM workout INNER JOIN weight ON weight.routine_id = workout.routine_id WHERE workout.date_workout = weight.date_measure AND workout.routine_id =@routine_id ORDER BY weight.date_measure", connection);
                command.Parameters.AddWithValue("@routine_id", routineId);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                          return reader.GetString(1);
                       
                    }
                }
            }
            return "";
        }
        public double ConvertToKilosOrPounds(string convertTo,double weight)
        {
            double weight_return = 0;
            if(convertTo=="pounds")
            {
                weight_return = weight * 2.2;
            }
            else
            {
                weight_return = weight / 2.2;
            }
            return weight_return;
        }
        public void AddWeightToCurrentWorkout(int routineId)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("INSERT INTO weight (current_weight,routine_id,date_measure,weight_type) SELECT weight.current_weight, @routine_id, weight.date_measure, weight.weight_type FROM weight INNER JOIN routine ON weight.routine_id = routine.routine_id WHERE routine.routine_id - routine.routine_id % 10 =@routine_id-@routine_id%10 AND weight.date_measure =@date_measure", connection);
                command.Parameters.AddWithValue("@date_measure", Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd")));
                command.Parameters.AddWithValue("@routine_id",routineId);
                command.ExecuteNonQuery();
            }
        }
    }
}
