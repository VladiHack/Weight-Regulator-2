using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Data.Repositories
{
    public class ExerciseRepository
    {
        public void AddExercise(Exercise exercise)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("INSERT INTO exercise(exercise.name,exercise.exercise_type) VALUES(@name,@exercise_type)", connection);
                command.Parameters.AddWithValue("@name",exercise.Name);
                command.Parameters.AddWithValue("@exercise_type", exercise.exercise_Type);
                command.ExecuteNonQuery();
            }
        }
        public List<Exercise> ReturnExercisesByCategory(string category,int routineId)
        {
            List<Exercise> exercises = new List<Exercise>();
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT * FROM exercise WHERE exercise.exercise_type=@category";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@category", category);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Exercise exercise = new Exercise();
                        exercise.Id=reader.GetInt32(0);
                        exercise.Name=reader.GetString(1);
                        exercise.countTimesSeconds = reader.GetInt32(DetermineDifficultyByRoutineId(routineId));
                        exercise.exercise_measurement_type=reader.GetString(6);
                        exercises.Add(exercise);
                    }

                }
            }
            return exercises;
        }
        public int DetermineDifficultyByRoutineId(int routineId)
        {
            if(routineId%10==1)
            {
                return 3;
            }
            else if(routineId%10==2)
            {
                return 4;
            }
            else if(routineId%10==3)
            {
                return 5;
            }
            return -1;
        }
        public string ExerciseInfo(string difficulty)
        {
            string message="";int difficultyIndex = 0;
            if(difficulty=="hard")
            {
                difficultyIndex = 5;
            }
            else if(difficulty=="intermediate")
            {
                difficultyIndex = 4;
            }
            else
            {
                difficultyIndex = 3;
            }
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT * FROM exercise";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Exercise exercise = new Exercise();
                        exercise.Id = reader.GetInt32(0);
                        exercise.Name = reader.GetString(1);
                        exercise.countTimesSeconds = reader.GetInt32(difficultyIndex);
                        exercise.exercise_measurement_type = reader.GetString(6);
                        message += exercise.ToString()+"\n";
                    }

                }
            }
            return message;
        }
    }
}
