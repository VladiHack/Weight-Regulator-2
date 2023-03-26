
using WeightRegulator.View;
using Business;
using Data.Repositories;
using WeightRegulator.Data.Model;

namespace WeightRegulator
{
    public partial class StartingWindow : Form
    {
        UserBusiness userController = new UserBusiness();
        public StartingWindow()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Email")
            {
                txtUsername.Text = "";
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
            }
        }


        private void eyeBtn_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                txtPass.PasswordChar = '*';
            }
            else
            {
                txtPass.PasswordChar = '\0';
            }
        }


        private void btnsignUp_Click_1(object sender, EventArgs e)
        {
            SignUpWindow signForm = new SignUpWindow();
            signForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string pass = txtPass.Text;
            bool result = userController.LoginCheck(username, pass);//Check if username and password match the recording
            if (result)
            {
                MessageBox.Show($"Successfully logged!:{username}");
                ClearTextBoxes();
                RoutineWindow routine = new RoutineWindow();
                this.Hide();
                routine.lblUsername.Text = username;
                routine.ShowDialog();
                this.Close();



            }
            else
            {
                MessageBox.Show("Username or password are incorrect!");
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPass.Text;
            bool result = userController.LoginCheck(username, pass);
            if (result)
            {
                userController.DeleteUser(username, pass);
                MessageBox.Show($"Successfully removed user:{username}");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Can not delete the user because username or password isn't correct!");
                ClearTextBoxes();
            }
        }
        public void ClearTextBoxes()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
        }
        /*
private void button1_Click(object sender, EventArgs e)
{
   RoutineWindow routine = new RoutineWindow();
   routine.ShowDialog();
}

private void btnOpenWeight_Click(object sender, EventArgs e)
{
   WeightWindow weight = new WeightWindow();
   weight.ShowDialog();
}

private void btnRemoveAll_Click(object sender, EventArgs e)
{
   UserRepository userRepo = new UserRepository();
   userRepo.DeleteAllUsers();
}

private void fillExercises_Click(object sender, EventArgs e)
{
   FillExercise();
}
public void FillExercise()
{
   Exercise exercise = new Exercise();
   ExerciseRepository exerciseRepo = new ExerciseRepository();
   List<string> namesArmsExercises = new List<string>(){ "Barbell biceps curls", "Cable triceps extension","Dumbbell hammer curls","Bench dumbbell triceps extensions","Wrist flexion"};
   List<string> namesLegsExercises = new List<string>() { "Squat to press", "Single-leg dumbbell scaption", "Lunges", "Step ups", "Calf raises"};
   List<string> namesBackExercises = new List<string>() { "Glute bridge", "Knees to chest", "Child's pose", "Kettlebell Swings", "Barbell Deadlift" };
   for (int i = 0; i <namesArmsExercises.Count(); i++)
   {
       exercise.Name=namesArmsExercises[i];
       exercise.exercise_Type = "arms";
       exerciseRepo.AddExercise(exercise);
   }
   for (int i = 0; i < namesLegsExercises.Count(); i++)
   {
       exercise.Name = namesLegsExercises[i];
       exercise.exercise_Type = "legs";
       exerciseRepo.AddExercise(exercise);
   }
   for (int i = 0; i < namesBackExercises.Count(); i++)
   {
       exercise.Name = namesBackExercises[i];
       exercise.exercise_Type = "back";
       exerciseRepo.AddExercise(exercise);
   }

}

private void button1_Click_1(object sender, EventArgs e)
{
   ShowProgressWindow progress = new ShowProgressWindow();
   progress.ShowDialog();
}
*/
    }
}