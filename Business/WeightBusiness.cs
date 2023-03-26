using Data.Model;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Business
{
    public class WeightBusiness
    {
        WeightRepository managerWeight = new WeightRepository();
        public void AddWeight(Weight weight)
        {
            managerWeight.AddWeight(weight);
        }
        public bool CheckIfUserMeasuredToday(User user)
        {
            return managerWeight.CheckIfUserMeasuredToday(user);
        }
        public bool CheckIfRoutineMeasured(Routine routine)
        {
            return managerWeight.CheckIfRoutineMeasured(routine);
        }
    }
}
