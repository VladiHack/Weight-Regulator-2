using Business;
using Data.Model;
using Data.Repositories;
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
    public partial class WeightWindow : Form
    {
        private int routineId;

        public WeightWindow()
        {
            InitializeComponent();
        }

        public WeightWindow(int RoutineId)
        {
            this.routineId = RoutineId;
            InitializeComponent();
        }

        private void btnRegisterWeight_Click(object sender, EventArgs e)
        {
            try
            {
           
                Weight weight = new Weight(double.Parse(txtWeight.Text), routineId, boxConvertWeight.SelectedItem.ToString());
                WeightBusiness weightController = new WeightBusiness();
                RoutineBusiness routineController = new RoutineBusiness();
                weightController.AddWeight(weight);
                MessageBox.Show("Weight successfully added!");
                this.Hide();
                ChooseWorkoutWindow workoutWindow = new ChooseWorkoutWindow(routineId);
                workoutWindow.lblDay.Text = (routineController.GetDayById(routineId)).ToString();
                workoutWindow.ShowDialog();
                this.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
