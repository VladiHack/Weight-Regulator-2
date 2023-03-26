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

namespace WeightRegulator.View
{
    public partial class ChooseWorkoutWindow : Form
    {
        private int routineId;

        public ChooseWorkoutWindow()
        {
            InitializeComponent();
        }

        public ChooseWorkoutWindow(int RoutineId)
        {
            this.routineId = RoutineId;
            InitializeComponent();
        }


        private void btnReadyy_Click(object sender, EventArgs e)
        {
            if (boxWorkout.SelectedIndex >= 0)
            {
                string selectedWorkout = boxWorkout.SelectedItem.ToString();
                this.Hide();
                ExercisesWindow exerciseWindow = new ExercisesWindow(routineId, selectedWorkout);
                exerciseWindow.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You haven't chosen workout!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
