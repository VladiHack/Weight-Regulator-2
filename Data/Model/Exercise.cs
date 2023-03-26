using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightRegulator.Data.Model
{
    public class Exercise
    {
        private int id;
        private string name;
        private string exercise_type;
        public int countTimesSeconds {get; set;}
        public string exercise_measurement_type { get; set;}
        public Exercise(int id, string name, string Exercise_type)
        {
            this.Id = id;
            this.Name = name;
            this.exercise_Type = Exercise_type;
        }
        public Exercise()
        {

        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Exercise id can't be negative");
                }
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be an empty string!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public string exercise_Type
        {
            get
            {
                return this.exercise_type;
            }
            set
            {
                if (value != "legs" && value != "arms" && value != "back")
                {
                    throw new ArgumentException("Incorrect exercise type!");
                }
                this.exercise_type = value;
            }

        }

        public override string ToString()
        {
            return $"Exercise name:{name}, duration:{countTimesSeconds} {exercise_measurement_type}";
        }
    }
}
