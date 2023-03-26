namespace WeightRegulator.View
{
    partial class RoutineWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.boxDifficulties = new System.Windows.Forms.ComboBox();
            this.picDifficulties = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblexerciseInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDifficulties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(661, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(734, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(136, 37);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // boxDifficulties
            // 
            this.boxDifficulties.FormattingEnabled = true;
            this.boxDifficulties.Items.AddRange(new object[] {
            "Advanced",
            "Intermediate",
            "Beginner"});
            this.boxDifficulties.Location = new System.Drawing.Point(172, 61);
            this.boxDifficulties.Name = "boxDifficulties";
            this.boxDifficulties.Size = new System.Drawing.Size(146, 23);
            this.boxDifficulties.TabIndex = 2;
            this.boxDifficulties.SelectedIndexChanged += new System.EventHandler(this.boxDifficulties_SelectedIndexChanged);
            // 
            // picDifficulties
            // 
            this.picDifficulties.Image = global::WeightRegulator.Properties.Resources.Hard;
            this.picDifficulties.Location = new System.Drawing.Point(21, 129);
            this.picDifficulties.Name = "picDifficulties";
            this.picDifficulties.Size = new System.Drawing.Size(471, 307);
            this.picDifficulties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDifficulties.TabIndex = 3;
            this.picDifficulties.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose your routine";
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.Black;
            this.btnReady.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReady.ForeColor = System.Drawing.Color.Red;
            this.btnReady.Location = new System.Drawing.Point(172, 467);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(164, 76);
            this.btnReady.TabIndex = 5;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(549, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exercises here include:";
            // 
            // lblexerciseInfo
            // 
            this.lblexerciseInfo.AutoSize = true;
            this.lblexerciseInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblexerciseInfo.Location = new System.Drawing.Point(549, 102);
            this.lblexerciseInfo.Name = "lblexerciseInfo";
            this.lblexerciseInfo.Size = new System.Drawing.Size(0, 32);
            this.lblexerciseInfo.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(1141, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 48);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.BackColor = System.Drawing.Color.Black;
            this.btnProgress.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProgress.ForeColor = System.Drawing.Color.Red;
            this.btnProgress.Location = new System.Drawing.Point(139, 584);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(235, 76);
            this.btnProgress.TabIndex = 9;
            this.btnProgress.Text = "Show progress";
            this.btnProgress.UseVisualStyleBackColor = false;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // RoutineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 687);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblexerciseInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picDifficulties);
            this.Controls.Add(this.boxDifficulties);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoutineWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoutineWindow";
            ((System.ComponentModel.ISupportInitialize)(this.picDifficulties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label1;
        public Label lblUsername;
        private ComboBox boxDifficulties;
        private PictureBox picDifficulties;
        private Label label2;
        private Button btnReady;
        private Label label3;
        private Label lblexerciseInfo;
        private Button btnClose;
        private Button btnProgress;
    }
}