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
    public partial class RoutineWindow : Form
    {
        RoutineBusiness routineController = new RoutineBusiness();
        UserBusiness userController = new UserBusiness();
        ExerciseBusiness exerciseController = new ExerciseBusiness();
        public RoutineWindow()
        {
            InitializeComponent();
        }

        private void boxDifficulties_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (boxDifficulties.SelectedIndex==2)
            {
                picDifficulties.Image = Resources.EasyDiff;
                lblexerciseInfo.Text= exerciseController.ExerciseInfo("easy");
            }
            else if(boxDifficulties.SelectedIndex==1)
            {
                picDifficulties.Image = Resources.intermediate;
                lblexerciseInfo.Text = exerciseController.ExerciseInfo("intermediate");
            }
            else
            {
                picDifficulties.Image= Resources.Hard;
                lblexerciseInfo.Text = exerciseController.ExerciseInfo("hard");
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            WeightBusiness weightController = new WeightBusiness();
            UserBusiness userController = new UserBusiness();
            try
            {
                if(boxDifficulties.SelectedIndex>=0)
                {
                    int userId = userController.FindIndexByUsername(lblUsername.Text);
                    int routineId = boxDifficulties.SelectedIndex + 1 + userId * 10;//Creating the routine id by combining the userId and the selected difficulty
                    Routine routine = new Routine(routineId, userId);
 
                    if (routineController.CheckIfRoutineExists(routine))
                    {
                        if(routineController.GetDayById(routineId)==30)
                        {
                            MessageBox.Show("You've already finished this difficulty!Please choose a new one!");
                            return;
                        }
                    }
                    else
                    {
                        routineController.AddRoutine(routine);
                        MessageBox.Show("Successfully added a new routine!");
                       
                    }
                    User user = new User();
                    user = user = userController.FindUserByUsername(lblUsername.Text);
                    if (weightController.CheckIfUserMeasuredToday(user) == true)
                    {
                        ChooseWorkoutWindow workout = new ChooseWorkoutWindow(routineId);
                        workout.lblDay.Text=(routineController.GetDayById(routineId)).ToString();
                        this.Hide();
                        workout.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        WeightWindow weight = new WeightWindow(routineId);
                        weight.lblUser.Text = this.lblUsername.Text;
                        this.Hide();
                        weight.ShowDialog();
                        this.Close();

                    }



                }
                else
                {
                    MessageBox.Show("You haven't chosen category!");
                }
            
            }
            catch (Exception exception)
            {
                MessageBox.Show("Program failed due to:" + exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            if (boxDifficulties.SelectedIndex >= 0)
            {
                int userId = userController.FindIndexByUsername(lblUsername.Text);
                int routineId = boxDifficulties.SelectedIndex + 1 + userId * 10;
                Routine routine = new Routine(routineId, userId);

               
                if (routineController.CheckIfRoutineExists(routine))
                {
                    ShowProgressWindow progress = new ShowProgressWindow(routineId);
                    this.Hide();
                    progress.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Routine doesn't exist!");
                }
            }
            else
            {
                MessageBox.Show("You haven't chosen difficulty!");
            }
              
        }
    }
}
