using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeightRegulator.Data.Model;
using WeightRegulator.Properties;

namespace WeightRegulator.View
{
    public partial class ExercisesWindow : Form
    {
        private int routineId;
        private string? selectedWorkout;
        private List<Exercise> exercises = new List<Exercise>();
        private ExerciseBusiness exerciseController = new ExerciseBusiness();
        private int countExerciseIds = 0;
        int secondsTimer = 0;
        public ExercisesWindow(int routineId, string? SelectedWorkout)
        {
            this.routineId = routineId;
            this.selectedWorkout = SelectedWorkout;
            exercises = exerciseController.ReturnExercisesByCategory(selectedWorkout, routineId);
            // btnREADYY.Visible = false;
            InitializeComponent();
        }

        private void btnREADYY_Click(object sender, EventArgs e)
        {
            if (countExerciseIds == exercises.Count())
            {
                MessageBox.Show("Workout finished!");
                try
                {
                    Workout workout = new Workout();
                    workout.Type_workout = selectedWorkout;
                    workout.Routine_id = routineId;
                    WorkoutBusiness workoutController = new WorkoutBusiness();
                    workoutController.AddWorkout(workout);
                    MessageBox.Show("Workout added successfully!");
                    RoutineBusiness routineController = new RoutineBusiness();
                    routineController.UpdateDaysById(routineId);
                    MessageBox.Show("Days updated successfully!");
                    ShowProgressWindow progress = new ShowProgressWindow(routineId);
                    this.Hide();
                    progress.ShowDialog();
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                //Adds the workout to the database and adds +1 to count_workouts if(count_workouts=30) then open a new window congratulating the user on passing the program

            }
            else
            {
                CountDownTimer.Stop(); btnPause.Visible = false;
                SwitchExercise();
                if (lblExerciseFormat.Text == "seconds")
                {
                    secondsTimer = int.Parse(lblNumber.Text);
                    btnPause.Visible = true;
                    CountDownTimer.Start();
                }
            }


        }
        private void SwitchExercise()
        {
            Exercise exercise = new Exercise();
            exercise = exercises[countExerciseIds];
            lblCountExercise.Text = (countExerciseIds + 1).ToString();
            lblExerciseFormat.Text = exercise.exercise_measurement_type;
            lblNumber.Text = exercise.countTimesSeconds.ToString();
            lblExerciseName.Text = exercise.Name;
            switch (exercise.Id)
            {
                case 1:
                    picExercise.Image = Resources.Barbell_Curl;
                    break;
                case 2:
                    picExercise.Image = Resources.cable_tricep_pushdown;
                    break;
                case 3:
                    picExercise.Image = Resources.Hammer_Curl;
                    break;
                case 4:
                    picExercise.Image = Resources.Decline_Dumbbell_Triceps_Extension;
                    break;
                case 5:
                    picExercise.Image = Resources.wrist_flexion;
                    break;
                case 6:
                    picExercise.Image = Resources.SQUAT_TO_PRESS;
                    break;
                case 7:
                    picExercise.Image = Resources.Single_Leg;
                    break;
                case 8:
                    picExercise.Image = Resources.lunges;
                    break;
                case 9:
                    picExercise.Image = Resources.stepup;
                    break;
                case 10:
                    picExercise.Image = Resources.Dumbbell_Calf_Raise;
                    break;
                case 11:
                    picExercise.Image = Resources.glutebridge;
                    break;
                case 12:
                    picExercise.Image = Resources.kness_to_chest;
                    break;
                case 13:
                    picExercise.Image = Resources.child_s_pose;
                    break;
                case 14:
                    picExercise.Image = Resources.russian_kettlebell_swing;
                    break;
                case 15:
                    picExercise.Image = Resources.Barbell_Curl;
                    break;
                default:
                    break;
            }
            countExerciseIds++;
            return;
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            lblNumber.Text = secondsTimer--.ToString();
        }

        private void btnBeginWorkout_Click(object sender, EventArgs e)
        {
            SwitchExercise();
            TurnVisible();
            if (lblExerciseFormat.Text == "seconds")
            {
                secondsTimer = int.Parse(lblNumber.Text);
                btnPause.Visible = true;
                CountDownTimer.Start();
            }
        }
        private void TurnVisible()
        {
            btnBeginWorkout.Visible = false;
            lblExerciseFormat.Visible = true;
            lblCountExercise.Visible = true;
            lblExerciseName.Visible = true;
            lblNumber.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            picExercise.Visible = true;
            btnREADYY.Visible = true;
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (CountDownTimer.Enabled == true)
            {
                CountDownTimer.Stop();
                btnPause.BackgroundImage = Resources.playButton;

            }
            else
            {
                CountDownTimer.Start();
                btnPause.BackgroundImage = Resources.pauseButtonCorrect;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
