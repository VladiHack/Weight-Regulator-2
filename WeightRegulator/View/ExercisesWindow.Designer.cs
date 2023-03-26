namespace WeightRegulator.View
{
    partial class ExercisesWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picExercise = new PictureBox();
            lblExerciseFormat = new Label();
            CountDownTimer = new System.Windows.Forms.Timer(components);
            lblExerciseName = new Label();
            label3 = new Label();
            lblCountExercise = new Label();
            label5 = new Label();
            btnREADYY = new Button();
            lblNumber = new Label();
            btnBeginWorkout = new Button();
            btnPause = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picExercise).BeginInit();
            SuspendLayout();
            // 
            // picExercise
            // 
            picExercise.Image = Properties.Resources.barbell_deadlift;
            picExercise.Location = new Point(115, 197);
            picExercise.Margin = new Padding(3, 4, 3, 4);
            picExercise.Name = "picExercise";
            picExercise.Size = new Size(545, 539);
            picExercise.SizeMode = PictureBoxSizeMode.StretchImage;
            picExercise.TabIndex = 0;
            picExercise.TabStop = false;
            picExercise.Visible = false;
            // 
            // lblExerciseFormat
            // 
            lblExerciseFormat.AutoSize = true;
            lblExerciseFormat.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblExerciseFormat.Location = new Point(294, 764);
            lblExerciseFormat.Name = "lblExerciseFormat";
            lblExerciseFormat.Size = new Size(327, 62);
            lblExerciseFormat.TabIndex = 1;
            lblExerciseFormat.Text = "seconds/times";
            lblExerciseFormat.Visible = false;
            // 
            // CountDownTimer
            // 
            CountDownTimer.Interval = 1500;
            CountDownTimer.Tick += CountDownTimer_Tick;
            // 
            // lblExerciseName
            // 
            lblExerciseName.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExerciseName.Location = new Point(115, 112);
            lblExerciseName.Name = "lblExerciseName";
            lblExerciseName.Size = new Size(545, 63);
            lblExerciseName.TabIndex = 2;
            lblExerciseName.Text = "Barbell biceps curls";
            lblExerciseName.TextAlign = ContentAlignment.MiddleCenter;
            lblExerciseName.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(524, 12);
            label3.Name = "label3";
            label3.Size = new Size(151, 50);
            label3.TabIndex = 9;
            label3.Text = "Exercise";
            label3.Visible = false;
            // 
            // lblCountExercise
            // 
            lblCountExercise.AutoSize = true;
            lblCountExercise.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountExercise.Location = new Point(681, 12);
            lblCountExercise.Name = "lblCountExercise";
            lblCountExercise.Size = new Size(42, 50);
            lblCountExercise.TabIndex = 10;
            lblCountExercise.Text = "1";
            lblCountExercise.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(711, 12);
            label5.Name = "label5";
            label5.Size = new Size(86, 50);
            label5.TabIndex = 11;
            label5.Text = "of 5";
            label5.Visible = false;
            // 
            // btnREADYY
            // 
            btnREADYY.BackColor = Color.Black;
            btnREADYY.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnREADYY.ForeColor = Color.Red;
            btnREADYY.Location = new Point(587, 744);
            btnREADYY.Margin = new Padding(3, 4, 3, 4);
            btnREADYY.Name = "btnREADYY";
            btnREADYY.Size = new Size(197, 117);
            btnREADYY.TabIndex = 12;
            btnREADYY.Text = "Ready";
            btnREADYY.UseVisualStyleBackColor = false;
            btnREADYY.Visible = false;
            btnREADYY.Click += btnREADYY_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber.Location = new Point(219, 767);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(97, 60);
            lblNumber.TabIndex = 13;
            lblNumber.Text = "120";
            lblNumber.Visible = false;
            // 
            // btnBeginWorkout
            // 
            btnBeginWorkout.BackColor = Color.Indigo;
            btnBeginWorkout.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            btnBeginWorkout.ForeColor = Color.Gold;
            btnBeginWorkout.Location = new Point(115, 197);
            btnBeginWorkout.Margin = new Padding(3, 4, 3, 4);
            btnBeginWorkout.Name = "btnBeginWorkout";
            btnBeginWorkout.Size = new Size(545, 539);
            btnBeginWorkout.TabIndex = 14;
            btnBeginWorkout.Text = "BEGIN WORKOUT";
            btnBeginWorkout.UseVisualStyleBackColor = false;
            btnBeginWorkout.Click += btnBeginWorkout_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.LightSkyBlue;
            btnPause.BackgroundImage = Properties.Resources.pauseButtonCorrect;
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPause.Location = new Point(88, 764);
            btnPause.Margin = new Padding(3, 4, 3, 4);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(80, 69);
            btnPause.TabIndex = 15;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Visible = false;
            btnPause.Click += btnPause_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Indigo;
            btnClose.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Yellow;
            btnClose.Location = new Point(14, 8);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 81);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ExercisesWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(798, 877);
            Controls.Add(btnClose);
            Controls.Add(btnPause);
            Controls.Add(btnBeginWorkout);
            Controls.Add(lblNumber);
            Controls.Add(btnREADYY);
            Controls.Add(label5);
            Controls.Add(lblCountExercise);
            Controls.Add(label3);
            Controls.Add(lblExerciseName);
            Controls.Add(lblExerciseFormat);
            Controls.Add(picExercise);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ExercisesWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExercisesWindow";
            ((System.ComponentModel.ISupportInitialize)picExercise).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picExercise;
        private Label lblExerciseFormat;
        private System.Windows.Forms.Timer CountDownTimer;
        private Label lblExerciseName;
        private Label label3;
        private Label lblCountExercise;
        private Label label5;
        private Button btnREADYY;
        private Label lblNumber;
        private Button btnBeginWorkout;
        private Button btnPause;
        private Button btnClose;
    }
}