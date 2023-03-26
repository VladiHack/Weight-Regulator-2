using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Business
{
    public class RoutineBusiness
    {
        RoutineRepository managerRoutine = new RoutineRepository();
        public void AddRoutine(Routine routine)
        {
            managerRoutine.AddRoutine(routine);
        }
        public bool CheckIfRoutineExists(Routine routine)
        {
            return managerRoutine.CheckIfRoutineExists(routine);
        }
       public string GetUsernameByRoutineId(Routine routine)
        {
            return managerRoutine.GetUsernameByRoutineId(routine);
        }
        public bool CheckIfRoutineExists(string username)
        {
            return managerRoutine.CheckIfRoutineExists(username);
        }
        public int GetRoutineIdByUsername(string username)
        {
            return managerRoutine.GetRoutineIdByUsername(username);
        }
        public int GetDayById(int id)
        {
            return managerRoutine.GetDayById(id);
        }
        public void UpdateDaysById(int id)
        {
             managerRoutine.UpdateDaysById(id);
        }
        public void UpdateFinishDate(int id)
        {
            managerRoutine.UpdateFinishDate(id);
        }
    }
}
