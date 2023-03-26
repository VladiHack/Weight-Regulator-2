using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightRegulator.Data.Model;

namespace Business
{
    public class ExerciseBusiness
    {
        ExerciseRepository managerExercise = new ExerciseRepository();
        public void AddExercise(Exercise exercise)
        {
            managerExercise.AddExercise(exercise);
        }
        public List<Exercise> ReturnExercisesByCategory(string category,int routineId)
        {
            return managerExercise.ReturnExercisesByCategory(category, routineId);
        }
        public string ExerciseInfo(string difficulty)
        {
            return managerExercise.ExerciseInfo(difficulty);
        }
    }
}
