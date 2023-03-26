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
using Business;

namespace WeightRegulator.View
{
    public partial class SignUpWindow : Form
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool created = false; string getUsername = "";
            if (txtEnterPass.Text == txtConfirmPass.Text)
            {
                try
                {
                    User user = new User();
                    user.Username = txtUsername.Text;
                    user.Email = txtEmail.Text;
                    user.Password = txtEnterPass.Text;
                    UserBusiness userRepository = new UserBusiness();
                    string checkIfUnique = userRepository.UniqueUsername(txtUsername.Text) + "\n" + userRepository.UniqueEmail(txtEmail.Text);
                    if (String.IsNullOrWhiteSpace(checkIfUnique))
                    {
                        this.Close();
                        FinishRegistration(user);
                    }
                    else
                    {
                        MessageBox.Show(checkIfUnique);
                        return;
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Warning");
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match!");
            }

        }

        public void FinishRegistration(User user)
        {
            this.Hide();
            FinishRegistrationWindow finishRegistration = new FinishRegistrationWindow(user);
            finishRegistration.ShowDialog();
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
