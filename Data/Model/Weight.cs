using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Weight
    {
        private int weightId;
        private double currentWeight;
        private string weightType;
        public Weight(double currentWeight,int routine_id,string weightType)
        {
            this.CurrentWeight = currentWeight;
            this.routine_id = routine_id;
            this.WeightType = weightType;
            this.date_measure = DateTime.Today;
        }
        public double CurrentWeight
        {
            get
            {
                return this.currentWeight;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Impossible weight value!");
                }
                this.currentWeight = value;
            }
        }
        public string WeightType
        {
            get
            {
                return this.weightType;
            }
            set
            {
                if (value!="pounds"&&value!="kg")
                {
                    throw new ArgumentException("Invalid weight type!");
                }
                this.weightType = value;
            }
        }
        public int routine_id {get; set;}
        public DateTime date_measure {get; set;}
    }
}
