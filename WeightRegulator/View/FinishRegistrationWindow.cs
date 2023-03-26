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
using WeightRegulator.Data.Model;

namespace WeightRegulator.View
{
    public partial class FinishRegistrationWindow : Form
    {
        private User user;
        public FinishRegistrationWindow(User User)
        {
            this.user = User;
            InitializeComponent();
        }

        private void btnFinishRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                user.Gender = char.Parse(txtGender.Text);
                user.Height = double.Parse(txtHeight.Text);
                user.HeightType = boxHeightType.SelectedItem.ToString();
                UserRepository userRepo = new UserRepository();
                userRepo.AddUser(user);
                MessageBox.Show("Successfully registered!");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Warning:"+exception.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
