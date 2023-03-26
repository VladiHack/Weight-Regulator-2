
namespace WeightRegulator
{
    partial class StartingWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPass = new TextBox();
            btnLog = new Button();
            wr_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            eyeBtn = new Button();
            btnsignUp = new Button();
            label3 = new Label();
            btnClose = new Button();
            label4 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(442, 268);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 37);
            txtUsername.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(442, 340);
            txtPass.Margin = new Padding(4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(302, 37);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.Black;
            btnLog.ForeColor = SystemColors.ControlLightLight;
            btnLog.Location = new Point(540, 379);
            btnLog.Margin = new Padding(4);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(262, 49);
            btnLog.TabIndex = 3;
            btnLog.Text = "Log in";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // wr_lbl
            // 
            wr_lbl.AutoSize = true;
            wr_lbl.BackColor = Color.Transparent;
            wr_lbl.Font = new Font("Papyrus", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            wr_lbl.Location = new Point(516, 58);
            wr_lbl.Margin = new Padding(4, 0, 4, 0);
            wr_lbl.Name = "wr_lbl";
            wr_lbl.Size = new Size(287, 54);
            wr_lbl.TabIndex = 4;
            wr_lbl.Text = "Weight Regulator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Papyrus", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(577, 154);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 54);
            label2.TabIndex = 5;
            label2.Text = "Log in";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(458, 72);
            label1.TabIndex = 6;
            label1.Text = "Weight Regulator";
            // 
            // eyeBtn
            // 
            eyeBtn.BackgroundImage = Properties.Resources.изтеглен_файл;
            eyeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            eyeBtn.Location = new Point(771, 340);
            eyeBtn.Margin = new Padding(4);
            eyeBtn.Name = "eyeBtn";
            eyeBtn.Size = new Size(31, 31);
            eyeBtn.TabIndex = 7;
            eyeBtn.UseVisualStyleBackColor = true;
            eyeBtn.Click += eyeBtn_Click;
            // 
            // btnsignUp
            // 
            btnsignUp.BackColor = Color.White;
            btnsignUp.Location = new Point(788, 435);
            btnsignUp.Name = "btnsignUp";
            btnsignUp.Size = new Size(81, 34);
            btnsignUp.TabIndex = 8;
            btnsignUp.Text = "sign up";
            btnsignUp.UseVisualStyleBackColor = false;
            btnsignUp.Click += btnsignUp_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(364, 435);
            label3.Name = "label3";
            label3.Size = new Size(418, 33);
            label3.TabIndex = 9;
            label3.Text = "If you don't have an account you can";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaptionText;
            btnClose.ForeColor = SystemColors.ButtonFace;
            btnClose.Location = new Point(788, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 51);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(442, 225);
            label4.Name = "label4";
            label4.Size = new Size(300, 33);
            label4.TabIndex = 11;
            label4.Text = "Enter your  username here:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(438, 311);
            label5.Name = "label5";
            label5.Size = new Size(297, 33);
            label5.TabIndex = 12;
            label5.Text = "Enter your password here:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaptionText;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(399, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 49);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // StartingWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0_simple_running_outdoor_health_exercise_physical_education_courseware_fitness_sports_business_plan_powerpoint_background_817cd87917__960_540;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(961, 517);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(btnsignUp);
            Controls.Add(eyeBtn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(wr_lbl);
            Controls.Add(btnLog);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StartingWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPass;
        private Button btnLog;
        private Label wr_lbl;
        private Label label2;
        private Label label1;
        private Button eyeBtn;
        private Button btnsignUp;
        private Label label3;
        private Button btnClose;
        private Label label4;
        private Label label5;
        private Button btnDelete;
    }
}