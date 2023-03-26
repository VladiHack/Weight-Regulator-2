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

namespace WeightRegulator.View
{
    public partial class ShowProgressWindow : Form
    {
        RoutineBusiness routineController = new RoutineBusiness();
        WorkoutBusiness workoutController=new WorkoutBusiness();
        WeightBusiness weightController = new WeightBusiness();
        Routine routine = new Routine();
        int days = 0;
        private int routineId;
        public ShowProgressWindow()
        {
            InitializeComponent();
          
         //lblDay1.Size = new Size(35,455);
         //Po 3 na kilogram
        }
        public ShowProgressWindow(int RoutineId)
        {
            this.routineId = RoutineId;
            this.days= routineController.GetDayById(routineId);
            InitializeComponent();
            routine.Routine_id=routineId;
            if(weightController.CheckIfRoutineMeasured(routine)==false)
            {
                workoutController.AddWeightToCurrentWorkout(routineId);
            }
            ReturnNewSize();
            if (days == 30)
            {
                MessageBox.Show("Successfully completed the routine!");
                routineController.UpdateFinishDate(routineId);
            }
        }
        public void ReturnNewSize()
        {
            List<double> weightCollector = new List<double>();
            weightCollector = workoutController.GetWeightChange(routineId);
            string weight_type =workoutController.GetWeightChangeType(routineId);
            lblTypeWeight.Text = $"({weight_type})";
         
            int counter = 1;
            while(counter<=weightCollector.Count)
            {
                double weight = weightCollector[counter-1];
                int newHeight = ChangeLabelWeightInfo(weight,weight_type);
                switch (counter)
                {
                    case 1:
                        lblDay1.Height+=newHeight;
                        lblDay1.Top -= newHeight;
                        lblDay1.Visible = true;
                        lblDay1.Text = $"{weight:F2}";
                        break;
                    case 2:
                        lblDay2.Height+= newHeight;
                        lblDay2.Top -= newHeight;
                        lblDay2.Visible = true;
                        lblDay2.Text = $"{weight:F2}";
                        break;
                    case 3:
                        lblDay3.Height += newHeight;
                        lblDay3.Top -= newHeight;
                        lblDay3.Visible = true;
                        lblDay3.Text = $"{weight:F2}";
                        break;
                    case 4:
                        lblDay4.Height += newHeight;
                        lblDay4.Top -= newHeight;
                        lblDay4.Visible = true;
                        lblDay4.Text = $"{weight:F2}";
                        break;
                    case 5:
                        lblDay5.Height += newHeight;
                        lblDay5.Top -= newHeight;
                        lblDay5.Visible = true;
                        lblDay5.Text = $"{weight:F2}";
                        break;
                    case 6:
                        lblDay6.Height += newHeight;
                        lblDay6.Top -= newHeight;
                        lblDay6.Visible = true;
                        lblDay6.Text = $"{weight:F2}";
                        break;
                    case 7:
                        lblDay7.Height += newHeight;
                        lblDay7.Top -= newHeight;
                        lblDay7.Visible = true;
                        lblDay7.Text = $"{weight:F2}";
                        break;
                    case 8:
                        lblDay8.Height += newHeight;
                        lblDay8.Top -= newHeight;
                        lblDay8.Visible = true;
                        lblDay8.Text = $"{weight:F2}";
                        break;
                    case 9:
                        lblDay9.Height += newHeight;
                        lblDay9.Top -= newHeight;
                        lblDay9.Visible = true;
                        lblDay9.Text = $"{weight:F2}";
                        break;
                    case 10:
                        lblDay10.Height += newHeight;
                        lblDay10.Top -= newHeight;
                        lblDay10.Visible = true;
                        lblDay10.Text = $"{weight:F2}";
                        break;
                    case 11:
                        lblDay11.Height += newHeight;
                        lblDay11.Top -= newHeight;
                        lblDay11.Visible = true;
                        lblDay11.Text = $"{weight:F2}";
                        break;
                    case 12:
                        lblDay12.Height += newHeight;
                        lblDay12.Top -= newHeight;
                        lblDay12.Visible = true;
                        lblDay12.Text = $"{weight:F2}";
                        break;
                    case 13:
                        lblDay13.Height += newHeight;
                        lblDay13.Top -= newHeight;
                        lblDay13.Visible = true;
                        lblDay13.Text = $"{weight:F2}";
                        break;
                    case 14:
                        lblDay14.Height += newHeight;
                        lblDay14.Top -= newHeight;
                        lblDay14.Visible = true;
                        lblDay14.Text = $"{weight:F2}";
                        break;
                    case 15:
                        lblDay15.Height += newHeight;
                        lblDay15.Top -= newHeight;
                        lblDay15.Visible = true;
                        lblDay15.Text = $"{weight:F2}";
                        break;
                    case 16:
                        lblDay16.Height += newHeight;
                        lblDay16.Top -= newHeight;
                        lblDay16.Visible = true;
                        lblDay16.Text = $"{weight:F2}";
                        break;
                    case 17:
                        lblDay17.Height += newHeight;
                        lblDay17.Top -= newHeight;
                        lblDay17.Visible = true;
                        lblDay17.Text = $"{weight:F2}";
                        break;
                    case 18:
                        lblDay18.Height += newHeight;
                        lblDay18.Top -= newHeight;
                        lblDay18.Visible = true;
                        lblDay18.Text = $"{weight:F2}";
                        break;
                    case 19:
                        lblDay19.Height += newHeight;
                        lblDay19.Top -= newHeight;
                        lblDay19.Visible = true;
                        lblDay19.Text = $"{weight:F2}";
                        break;
                    case 20:
                        lblDay20.Height += newHeight;
                        lblDay20.Top -= newHeight;
                        lblDay20.Visible = true;
                        lblDay20.Text = $"{weight:F2}";
                        break;
                    case 21:
                        lblDay21.Height += newHeight;
                        lblDay21.Top -= newHeight;
                        lblDay21.Visible = true;
                        lblDay21.Text = $"{weight:F2}";
                        break;
                    case 22:
                        lblDay22.Height += newHeight;
                        lblDay22.Top -= newHeight;
                        lblDay22.Visible = true;
                        lblDay22.Text = $"{weight:F2}";
                        break;
                    case 23:
                        lblDay23.Height += newHeight;
                        lblDay23.Top -= newHeight;
                        lblDay23.Visible = true;
                        lblDay23.Text = $"{weight:F2}";
                        break;
                    case 24:
                        lblDay24.Height += newHeight;
                        lblDay24.Top -= newHeight;
                        lblDay24.Visible = true;
                        lblDay25.Text = $"{weight:F2}";
                        break;
                    case 25:
                        lblDay25.Height += newHeight;
                        lblDay25.Top -= newHeight;
                        lblDay25.Visible = true;
                        lblDay25.Text = $"{weight:F2}";
                        break;
                    case 26:
                        lblDay26.Height += newHeight;
                        lblDay26.Top -= newHeight;
                        lblDay26.Visible = true;
                        lblDay26.Text = $"{weight:F2}";
                        break;
                    case 27:
                        lblDay27.Height += newHeight;
                        lblDay27.Top -= newHeight;
                        lblDay27.Visible = true;
                        lblDay27.Text = $"{weight:F2}";
                        break;
                    case 28:
                        lblDay28.Height += newHeight;
                        lblDay28.Top -= newHeight;
                        lblDay28.Visible = true;
                        lblDay28.Text = $"{weight:F2}";
                        break;
                    case 29:
                        lblDay29.Height += newHeight;
                        lblDay29.Top -= newHeight;
                        lblDay29.Visible = true;
                        lblDay29.Text = $"{weight:F2}";
                        break;
                    case 30:
                        lblDay30.Height += newHeight;
                        lblDay30.Top -= newHeight;
                        lblDay30.Visible = true;
                        lblDay30.Text = $"{weight:F2}";
                        break;
                }
                counter++;
            }
            
        }
        public int ChangeLabelWeightInfo(double weight,string weight_type)
        {
            int height = 0;
            if (weight_type == "kg")
            {
                height = Convert.ToInt32(weight *3);
            }
            else
            {
                height = Convert.ToInt32(weight *3/2.2);
            }
            return height;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
