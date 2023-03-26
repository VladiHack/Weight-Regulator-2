using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Business
{
    public class WorkoutBusiness
    {
        WorkoutRepository workoutController = new WorkoutRepository();
        public void AddWorkout(Workout workout)
        {
            workoutController.AddWorkout(workout);
        }
        public List<double> GetWeightChange(int routineId)
        {
            return workoutController.GetWeightChange(routineId);
        }
        public string GetWeightChangeType(int routineId)
        {
            return workoutController.GetWeightChangeType(routineId); 
        }
        public void AddWeightToCurrentWorkout(int routineId)
        {
             workoutController.AddWeightToCurrentWorkout(routineId);
        }
    }

}
