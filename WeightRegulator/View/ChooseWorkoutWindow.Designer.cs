namespace WeightRegulator.View
{
    partial class ChooseWorkoutWindow
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
            this.lblDay = new System.Windows.Forms.Label();
            this.boxWorkout = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadyy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day number:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay.Location = new System.Drawing.Point(287, 2);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(33, 40);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "0";
            // 
            // boxWorkout
            // 
            this.boxWorkout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxWorkout.FormattingEnabled = true;
            this.boxWorkout.Items.AddRange(new object[] {
            "arms",
            "legs",
            "back"});
            this.boxWorkout.Location = new System.Drawing.Point(91, 358);
            this.boxWorkout.Name = "boxWorkout";
            this.boxWorkout.Size = new System.Drawing.Size(201, 40);
            this.boxWorkout.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select workout for the day!";
            // 
            // btnReadyy
            // 
            this.btnReadyy.BackColor = System.Drawing.Color.MediumPurple;
            this.btnReadyy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReadyy.Location = new System.Drawing.Point(298, 358);
            this.btnReadyy.Name = "btnReadyy";
            this.btnReadyy.Size = new System.Drawing.Size(107, 40);
            this.btnReadyy.TabIndex = 4;
            this.btnReadyy.Text = "READY";
            this.btnReadyy.UseVisualStyleBackColor = false;
            this.btnReadyy.Click += new System.EventHandler(this.btnReadyy_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(376, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChooseWorkoutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeightRegulator.Properties.Resources.chooseWorkout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReadyy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxWorkout);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseWorkoutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseWorkoutWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox boxWorkout;
        private Label label3;
        public Label lblDay;
        private Button btnReadyy;
        private Button btnClose;
    }
}