namespace Body_Mass_Index_GUI_CH14_Lab3
{
    partial class frmBMICalculator
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
            grpMesurementSystem = new GroupBox();
            rdoMetric = new RadioButton();
            rdoImperial = new RadioButton();
            grpMeasurements = new GroupBox();
            lblHeightMeasurement = new Label();
            lblWeightMeasurements = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            lblWeight = new Label();
            lblHeight = new Label();
            grpResult = new GroupBox();
            lblOutputResult = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpMesurementSystem.SuspendLayout();
            grpMeasurements.SuspendLayout();
            grpResult.SuspendLayout();
            SuspendLayout();
            // 
            // grpMesurementSystem
            // 
            grpMesurementSystem.Controls.Add(rdoMetric);
            grpMesurementSystem.Controls.Add(rdoImperial);
            grpMesurementSystem.Location = new Point(12, 12);
            grpMesurementSystem.Name = "grpMesurementSystem";
            grpMesurementSystem.Size = new Size(324, 86);
            grpMesurementSystem.TabIndex = 0;
            grpMesurementSystem.TabStop = false;
            grpMesurementSystem.Text = "Measurement System";
            // 
            // rdoMetric
            // 
            rdoMetric.AutoSize = true;
            rdoMetric.Location = new Point(212, 32);
            rdoMetric.Name = "rdoMetric";
            rdoMetric.Size = new Size(84, 29);
            rdoMetric.TabIndex = 1;
            rdoMetric.TabStop = true;
            rdoMetric.Text = "&Metric";
            rdoMetric.UseVisualStyleBackColor = true;
            rdoMetric.CheckedChanged += MeasurementSys_CheckedChanged;
            // 
            // rdoImperial
            // 
            rdoImperial.AutoSize = true;
            rdoImperial.Checked = true;
            rdoImperial.Location = new Point(16, 32);
            rdoImperial.Name = "rdoImperial";
            rdoImperial.Size = new Size(99, 29);
            rdoImperial.TabIndex = 0;
            rdoImperial.TabStop = true;
            rdoImperial.Text = "&Imperial";
            rdoImperial.UseVisualStyleBackColor = true;
            rdoImperial.CheckedChanged += MeasurementSys_CheckedChanged;
            // 
            // grpMeasurements
            // 
            grpMeasurements.Controls.Add(lblHeightMeasurement);
            grpMeasurements.Controls.Add(lblWeightMeasurements);
            grpMeasurements.Controls.Add(txtWeight);
            grpMeasurements.Controls.Add(txtHeight);
            grpMeasurements.Controls.Add(lblWeight);
            grpMeasurements.Controls.Add(lblHeight);
            grpMeasurements.Location = new Point(12, 97);
            grpMeasurements.Name = "grpMeasurements";
            grpMeasurements.Size = new Size(324, 149);
            grpMeasurements.TabIndex = 1;
            grpMeasurements.TabStop = false;
            grpMeasurements.Text = "Measurements";
            // 
            // lblHeightMeasurement
            // 
            lblHeightMeasurement.Location = new Point(266, 39);
            lblHeightMeasurement.Name = "lblHeightMeasurement";
            lblHeightMeasurement.Size = new Size(46, 25);
            lblHeightMeasurement.TabIndex = 2;
            lblHeightMeasurement.Text = "in";
            // 
            // lblWeightMeasurements
            // 
            lblWeightMeasurements.Location = new Point(266, 85);
            lblWeightMeasurements.Name = "lblWeightMeasurements";
            lblWeightMeasurements.Size = new Size(46, 25);
            lblWeightMeasurements.TabIndex = 5;
            lblWeightMeasurements.Text = "lbs";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(98, 77);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(162, 33);
            txtWeight.TabIndex = 4;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(98, 36);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(162, 33);
            txtHeight.TabIndex = 1;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(16, 85);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(76, 25);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "&Weight:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(20, 39);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(72, 25);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "&Height:";
            // 
            // grpResult
            // 
            grpResult.Controls.Add(lblOutputResult);
            grpResult.Location = new Point(12, 246);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(324, 158);
            grpResult.TabIndex = 2;
            grpResult.TabStop = false;
            grpResult.Text = "Result";
            // 
            // lblOutputResult
            // 
            lblOutputResult.BorderStyle = BorderStyle.Fixed3D;
            lblOutputResult.Location = new Point(8, 29);
            lblOutputResult.Name = "lblOutputResult";
            lblOutputResult.Size = new Size(306, 114);
            lblOutputResult.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ControlLight;
            btnCalculate.FlatStyle = FlatStyle.Popup;
            btnCalculate.Location = new Point(12, 410);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(152, 47);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ControlLight;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Location = new Point(170, 410);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(80, 47);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlLight;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(256, 410);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 47);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmBMICalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(348, 463);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(grpResult);
            Controls.Add(grpMeasurements);
            Controls.Add(grpMesurementSystem);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frmBMICalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator";
            Load += Form1_Load;
            grpMesurementSystem.ResumeLayout(false);
            grpMesurementSystem.PerformLayout();
            grpMeasurements.ResumeLayout(false);
            grpMeasurements.PerformLayout();
            grpResult.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMesurementSystem;
        private RadioButton rdoMetric;
        private RadioButton rdoImperial;
        private GroupBox grpMeasurements;
        private Label lblWeight;
        private Label lblHeight;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblWeightMeasurements;
        private GroupBox grpResult;
        private Label lblOutputResult;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Label lblHeightMeasurement;
    }
}
