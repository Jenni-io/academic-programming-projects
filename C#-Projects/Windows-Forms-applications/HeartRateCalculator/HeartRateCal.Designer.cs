namespace HreatRateCalculater
{
    partial class FrmHeartRateCal
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
            llbBDate = new Label();
            btnCalculate = new Button();
            dtpDateOfBirth = new DateTimePicker();
            lblOutput = new Label();
            lblMedicalWarning = new Label();
            SuspendLayout();
            // 
            // llbBDate
            // 
            llbBDate.Location = new Point(11, 12);
            llbBDate.Margin = new Padding(5, 0, 5, 0);
            llbBDate.Name = "llbBDate";
            llbBDate.Size = new Size(97, 38);
            llbBDate.TabIndex = 0;
            llbBDate.Text = "&Birthdate:";
            llbBDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.FlatStyle = FlatStyle.Popup;
            btnCalculate.Location = new Point(267, 15);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(118, 33);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(110, 15);
            dtpDateOfBirth.MaxDate = new DateTime(2025, 10, 5, 0, 0, 0, 0);
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(151, 33);
            dtpDateOfBirth.TabIndex = 1;
            dtpDateOfBirth.Value = new DateTime(2025, 10, 5, 0, 0, 0, 0);
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.Fixed3D;
            lblOutput.FlatStyle = FlatStyle.Flat;
            lblOutput.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(11, 60);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(377, 195);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "Enter your birthdate and click the \"Calculate\" button";
            // 
            // lblMedicalWarning
            // 
            lblMedicalWarning.BackColor = Color.Maroon;
            lblMedicalWarning.BorderStyle = BorderStyle.FixedSingle;
            lblMedicalWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicalWarning.ForeColor = SystemColors.ControlLight;
            lblMedicalWarning.Location = new Point(12, 264);
            lblMedicalWarning.Name = "lblMedicalWarning";
            lblMedicalWarning.Size = new Size(376, 40);
            lblMedicalWarning.TabIndex = 4;
            lblMedicalWarning.Text = "Always consult a physician or qualified health professional before beginning or modifying an exercise program";
            lblMedicalWarning.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmHeartRateCal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(400, 313);
            Controls.Add(lblMedicalWarning);
            Controls.Add(lblOutput);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(btnCalculate);
            Controls.Add(llbBDate);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHeartRateCal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Target Heart Rate Calculator";
            Load += FrmHeartRateCal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label llbBDate;
        private Button btnCalculate;
        private DateTimePicker dtpDateOfBirth;
        private Label lblOutput;
        private Label lblMedicalWarning;
    }
}
