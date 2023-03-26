using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Data.Repositories
{
    public class RoutineRepository
    {
        public void AddRoutine(Routine routine)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                    var command = new MySqlCommand("INSERT INTO routine(routine.routine_id, routine.date_start, routine.user_id,routine.count_workouts) VALUES(@routine_id,@date_start,@user_id,0)", connection);
                    command.Parameters.AddWithValue("@routine_id",routine.Routine_id);
                    command.Parameters.AddWithValue("@date_start",Convert.ToDateTime(routine.date_start.ToString("yyyy-MM-dd")));
                    command.Parameters.AddWithValue("@user_id",routine.user_id);
                    command.ExecuteNonQuery();
            }
        }
        public bool CheckIfRoutineExists(Routine routine)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT COUNT(*) FROM routine WHERE routine.routine_id=@routine_id", connection);
                command.Parameters.AddWithValue("@routine_id",routine.Routine_id);
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
        public string GetUsernameByRoutineId(Routine routine)
        {
            string username = "";
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT user.user_name FROM user INNER JOIN routine ON routine.user_id = user.user_id WHERE routine.routine_id =@routine_id", connection);
                command.Parameters.AddWithValue("@routine_id", routine.Routine_id);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }


                }
            }
            return username;
        }

        public bool CheckIfRoutineExists(string username)
        {

            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT IF(routine.routine_id IS NULL,'YES','No') FROM routine RIGHT JOIN user ON user.user_id = routine.user_id WHERE user.user_name =@username", connection);
                command.Parameters.AddWithValue("@username",username);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0)=="YES")
                        {
                            return false;
                        }
                    }


                }
            }
            return true;
        }

        public int GetRoutineIdByUsername(string username)
        {

            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT * FROM routine RIGHT JOIN user ON user.user_id = routine.user_id WHERE user.user_name =@username", connection);
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }


                }
            }
            return -1;
        }

        public int GetDayById(int id)
        {

            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("SELECT routine.count_workouts FROM routine WHERE routine.routine_id =@routine_id", connection);
                command.Parameters.AddWithValue("@routine_id", id);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0)+1;
                    }
                }
            }
            return -1;
        }

        public void UpdateDaysById(int id)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("UPDATE routine SET routine.count_workouts=routine.count_workouts+1 WHERE routine_id=@routine_id", connection);
                command.Parameters.AddWithValue("@routine_id", id);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateFinishDate(int id)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("UPDATE routine SET routine.date_finished=@date WHERE routine_id=@routine_id", connection);
                command.Parameters.AddWithValue("@routine_id", id);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd")));
                command.ExecuteNonQuery();
            }
        }
    }
}
