using Data.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Data.Repositories
{
    public class WeightRepository
    {
        public void AddWeight(Weight weight)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("INSERT INTO weight(weight.current_weight,weight.routine_id,weight.date_measure,weight.weight_type) VALUES (@currentWeight,@routine_id,@date_measure,@weight_type)", connection);
                command.Parameters.AddWithValue("@currentWeight", weight.CurrentWeight);
                command.Parameters.AddWithValue("@routine_id", weight.routine_id);
                command.Parameters.AddWithValue("@date_measure", weight.date_measure);
                command.Parameters.AddWithValue("@weight_type", weight.WeightType);
                command.ExecuteNonQuery();
            }
        }
        public bool CheckIfUserMeasuredToday(User user)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT COUNT(*) FROM weight INNER JOIN routine ON routine.routine_id=weight.routine_id WHERE routine.user_id =@user_id AND weight.date_measure = @date", connection);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd")));
                command.Parameters.AddWithValue("@user_id", user.id);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        if (reader.GetInt32(0)>=1)
                        {
                            return true;
                        }
                    }


                }
            }
            return false;
        }
        public bool CheckIfRoutineMeasured(Routine routine)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT COUNT(*) FROM weight INNER JOIN routine ON routine.routine_id=weight.routine_id WHERE routine.routine_id =@routine_id AND weight.date_measure = @date", connection);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd")));
                command.Parameters.AddWithValue("@routine_id", routine.Routine_id);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        if (reader.GetInt32(0) >= 1)
                        {
                            return true;
                        }
                    }


                }
            }
            return false;
        }

    }
}
