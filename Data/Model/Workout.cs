using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightRegulator.Data.Model
{
    public class Workout
    {
        private int id;
        private string type_workout;
        public DateTime date_workout;
        private int routine_id;

        public string Type_workout
        {
            get
            {
                return this.type_workout;
            }
            set
            {
                if (value!="legs"&&value!="arms"&&value!="back")
                {
                    throw new ArgumentException("Incorrect workout type!");
                }
                this.type_workout = value;
            }
        }
        public int Routine_id
        {
            get
            {
                return this.routine_id;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Routine id can't be less than zero!");
                }
                this.routine_id = value;
            }
        }
        public Workout(int Id,string type_workout, DateTime date,int routine_id)
        {
           this.id = Id;
            this.Type_workout = type_workout;
            this.date_workout = date;
            this.Routine_id = routine_id;
        }
        public Workout()
        {
            this.date_workout = DateTime.Today;
        }
    }
}
