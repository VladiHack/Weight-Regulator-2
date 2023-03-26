using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightRegulator.Data.Model
{
    public class User
    {
        public int id { get; set;}
        private string username;
        private string email;
        private string password;
        private char gender;
        private double height;
        private string heightType;
       public User(string username,string email,string password,char gender,double height)
       {
            this.Username = username;
            this.Email = email;
            this.Password = password;
       }
        public User()
        {

        }
        public User(int id,string username,string email,string password)
        {
            this.id = id;
            this.Username= username;
            this.Email = email;
            this.Password = password;
        }
        public string Username
        { 
            get
            {
                return this.username;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Username can't be empty");
                }
                this.username = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Password can't be empty");
                }
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (value.Length<7)
                {
                    throw new ArgumentNullException("Password can't be less than 7 symbols!");
                }
                this.password = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(value<=0)
                {
                    throw new ArgumentException("Height can't be negative or 0");
                }
                 this.height = value;
            }
        }
        public char Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value!='f'&&value!='m')
                {
                    throw new ArgumentException("Incorrect gender type!");
                }
                this.gender = value;
            }
        }
        public string HeightType
        {
            get
            {
                return this.heightType;
            }
            set
            {
                if (value!="cm"&&value!="inches")
                {
                    throw new ArgumentException("Incorrect height type!");
                }
                this.heightType = value;
            }
        }
    }
}
