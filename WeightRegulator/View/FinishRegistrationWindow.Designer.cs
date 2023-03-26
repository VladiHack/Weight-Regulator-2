namespace WeightRegulator.View
{
    partial class FinishRegistrationWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.boxHeightType = new System.Windows.Forms.ComboBox();
            this.btnFinishRegistration = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your gender (f/m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your height";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGender.Location = new System.Drawing.Point(78, 172);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(266, 39);
            this.txtGender.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.Location = new System.Drawing.Point(78, 276);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(200, 39);
            this.txtHeight.TabIndex = 3;
            // 
            // boxHeightType
            // 
            this.boxHeightType.FormattingEnabled = true;
            this.boxHeightType.Items.AddRange(new object[] {
            "cm",
            "inches"});
            this.boxHeightType.Location = new System.Drawing.Point(284, 292);
            this.boxHeightType.Name = "boxHeightType";
            this.boxHeightType.Size = new System.Drawing.Size(60, 23);
            this.boxHeightType.TabIndex = 4;
            // 
            // btnFinishRegistration
            // 
            this.btnFinishRegistration.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFinishRegistration.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinishRegistration.Location = new System.Drawing.Point(66, 362);
            this.btnFinishRegistration.Name = "btnFinishRegistration";
            this.btnFinishRegistration.Size = new System.Drawing.Size(293, 50);
            this.btnFinishRegistration.TabIndex = 5;
            this.btnFinishRegistration.Text = "Finish Registration";
            this.btnFinishRegistration.UseVisualStyleBackColor = false;
            this.btnFinishRegistration.Click += new System.EventHandler(this.btnFinishRegistration_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(664, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FinishRegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::WeightRegulator.Properties.Resources.finishRegistrationPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 457);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFinishRegistration);
            this.Controls.Add(this.boxHeightType);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishRegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinishRegistrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox boxHeightType;
        private Button btnFinishRegistration;
        public TextBox txtGender;
        public TextBox txtHeight;
        private Button btnClose;
    }
}