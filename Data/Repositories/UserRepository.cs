using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;
using MySqlConnector;

namespace Data.Repositories
{
    public class UserRepository
    {
        public void AddUser(User user)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("INSERT INTO`user`(user.user_name,user.email,user.`password`,user.gender,user.height,user.height_type) VALUES (@user_name,@email,@password,@gender,@height,@height_type)", connection);
                command.Parameters.AddWithValue("user_name", user.Username);
                command.Parameters.AddWithValue("email", user.Email);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("gender", user.Gender);
                command.Parameters.AddWithValue("height", user.Height);
                command.Parameters.AddWithValue("height_type", user.HeightType);
                command.ExecuteNonQuery();
            }
        }
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT * FROM user";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        string email = reader.GetString(2);
                        string password = reader.GetString(3);
                        User user = new User(id, username, email,password);
                        users.Add(user);
                    }

                    return users;
                }
            }
        }
        public string UniqueUsername(string username)
        {
            int count = 0;
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT COUNT(*) FROM user WHERE user.user_name =@username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        count=reader.GetInt32(0);
                    }

                }
               
            }
            if (count == 1)
            {
                return "There is already an account with that username!";
            }
            return " ";
        }
        public string UniqueEmail(string email)
        {
            int count = 0;
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT COUNT(*) FROM user WHERE user.user_name =@email";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@email",email);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }

                }

            }
            if (count == 1)
            {
                return "There is already an account with that email!";
            }
            return " ";
        }
        public bool LoginCheck(string username,string password)
        {
            int count = 0;
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT COUNT(*) FROM user WHERE user.user_name =@username AND user.password=@password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }

                }

            }
            if (count == 1)
            {
                return true;
            }
            return false;
        }
        public int FindIndexByUsername(string username)
        {
            int returnId =-1;
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT * FROM user AS u WHERE u.user_name=@username";
                MySqlCommand command=new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@username",username);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while(reader.Read())
                    {
                        returnId = reader.GetInt32(0);
                    }

                }
            }
            return returnId;
        }
        public void DeleteAllUsers()
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "Truncate table user";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
        public User FindUserByUsername(string username)
        {
            User user = new User();
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "SELECT * FROM user WHERE user.user_name=@username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        user.id = reader.GetInt32(0);
                        user.Username = reader.GetString(1);
                        user.Email = reader.GetString(2);
                        user.Password= reader.GetString(3);
                    }

                    return user;
                }
            }
        }

        public void DeleteUser(string username,string password)
        {
            MySqlConnection connection = DataBase.GetConnection();
            connection.Open();
            using (connection)
            {
                string query = "DELETE FROM user WHERE user.user_name=@username AND user.`password`=@password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }
        }
        
    }
}
