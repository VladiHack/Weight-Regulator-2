using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightRegulator.Data.Model
{
    public class Routine
    {
        private int routine_id;
        public Routine(int routineId,int UserId)
        {
            this.Routine_id = routineId;
            this.user_id =UserId;
            this.countWorkouts = 0;
            date_start=DateTime.Today;

        }
        public Routine()
        {

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
                    throw new ArgumentException("Routine id can not be negative!");
                }
                this.routine_id= value;
            }
        }
        public DateTime date_start { get; set;}
        public DateTime date_finished { get; set;}
        public int countWorkouts { get; set;}
        public int user_id {get; set;}

    }
}
