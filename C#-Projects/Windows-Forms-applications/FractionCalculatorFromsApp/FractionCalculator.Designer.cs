namespace FractionCalculatorFromsApp
{
    partial class FrmFractionCalculator
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
        private void InitializeComponent() {
            txtNumerator1 = new TextBox();
            txtDenominator1 = new TextBox();
            txtNumerator2 = new TextBox();
            txtDenominator2 = new TextBox();
            lblFractionLine = new Label();
            label1 = new Label();
            cboOperation = new ComboBox();
            lblTopOfequal = new Label();
            label2 = new Label();
            lblOutputFrac = new Label();
            stsMainOutput = new StatusStrip();
            statOutputDecimal = new ToolStripStatusLabel();
            btnCalculate = new Button();
            btnClear = new Button();
            lblFormLineDivider = new Label();
            stsMainOutput.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumerator1
            // 
            txtNumerator1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumerator1.Location = new Point(18, 17);
            txtNumerator1.Name = "txtNumerator1";
            txtNumerator1.Size = new Size(66, 43);
            txtNumerator1.TabIndex = 0;
            txtNumerator1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDenominator1
            // 
            txtDenominator1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDenominator1.Location = new Point(18, 69);
            txtDenominator1.Name = "txtDenominator1";
            txtDenominator1.Size = new Size(66, 43);
            txtDenominator1.TabIndex = 1;
            txtDenominator1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumerator2
            // 
            txtNumerator2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumerator2.Location = new Point(147, 17);
            txtNumerator2.Name = "txtNumerator2";
            txtNumerator2.Size = new Size(66, 43);
            txtNumerator2.TabIndex = 3;
            txtNumerator2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDenominator2
            // 
            txtDenominator2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDenominator2.Location = new Point(147, 69);
            txtDenominator2.Name = "txtDenominator2";
            txtDenominator2.Size = new Size(66, 43);
            txtDenominator2.TabIndex = 4;
            txtDenominator2.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFractionLine
            // 
            lblFractionLine.BackColor = SystemColors.ActiveCaptionText;
            lblFractionLine.Location = new Point(18, 63);
            lblFractionLine.Name = "lblFractionLine";
            lblFractionLine.Size = new Size(66, 3);
            lblFractionLine.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(147, 63);
            label1.Name = "label1";
            label1.Size = new Size(66, 3);
            label1.TabIndex = 5;
            // 
            // cboOperation
            // 
            cboOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOperation.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboOperation.FormattingEnabled = true;
            cboOperation.Items.AddRange(new object[] { "+", "-", "*", "÷" });
            cboOperation.Location = new Point(90, 42);
            cboOperation.Name = "cboOperation";
            cboOperation.Size = new Size(51, 45);
            cboOperation.TabIndex = 2;
            // 
            // lblTopOfequal
            // 
            lblTopOfequal.BackColor = SystemColors.ActiveCaptionText;
            lblTopOfequal.Location = new Point(231, 56);
            lblTopOfequal.Name = "lblTopOfequal";
            lblTopOfequal.Size = new Size(30, 5);
            lblTopOfequal.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(231, 69);
            label2.Name = "label2";
            label2.Size = new Size(30, 5);
            label2.TabIndex = 6;
            // 
            // lblOutputFrac
            // 
            lblOutputFrac.BorderStyle = BorderStyle.Fixed3D;
            lblOutputFrac.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutputFrac.Location = new Point(279, 17);
            lblOutputFrac.Name = "lblOutputFrac";
            lblOutputFrac.Size = new Size(203, 95);
            lblOutputFrac.TabIndex = 7;
            // 
            // stsMainOutput
            // 
            stsMainOutput.Items.AddRange(new ToolStripItem[] { statOutputDecimal });
            stsMainOutput.Location = new Point(0, 186);
            stsMainOutput.Name = "stsMainOutput";
            stsMainOutput.Size = new Size(494, 22);
            stsMainOutput.TabIndex = 11;
            stsMainOutput.Text = "statusStrip1";
            // 
            // statOutputDecimal
            // 
            statOutputDecimal.Name = "statOutputDecimal";
            statOutputDecimal.Size = new Size(306, 17);
            statOutputDecimal.Text = "This program preforms calculations on fractions inserted";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ControlLight;
            btnCalculate.FlatStyle = FlatStyle.Popup;
            btnCalculate.Location = new Point(232, 135);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(159, 45);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Location = new Point(397, 135);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 45);
            btnClear.TabIndex = 10;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblFormLineDivider
            // 
            lblFormLineDivider.BackColor = SystemColors.ControlDark;
            lblFormLineDivider.Location = new Point(18, 124);
            lblFormLineDivider.Name = "lblFormLineDivider";
            lblFormLineDivider.Size = new Size(464, 1);
            lblFormLineDivider.TabIndex = 8;
            // 
            // FrmFractionCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 208);
            Controls.Add(lblFormLineDivider);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(stsMainOutput);
            Controls.Add(lblOutputFrac);
            Controls.Add(label2);
            Controls.Add(lblTopOfequal);
            Controls.Add(cboOperation);
            Controls.Add(label1);
            Controls.Add(lblFractionLine);
            Controls.Add(txtDenominator2);
            Controls.Add(txtNumerator2);
            Controls.Add(txtDenominator1);
            Controls.Add(txtNumerator1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmFractionCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractions Calculator";
            Load += FrmFractionCalculator_Load;
            stsMainOutput.ResumeLayout(false);
            stsMainOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumerator1;
        private TextBox txtDenominator1;
        private TextBox txtNumerator2;
        private TextBox txtDenominator2;
        private Label lblFractionLine;
        private Label label1;
        private ComboBox cboOperation;
        private Label lblTopOfequal;
        private Label label2;
        private Label lblOutputFrac;
        private StatusStrip stsMainOutput;
        private ToolStripStatusLabel statOutputDecimal;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblFormLineDivider;
        private MaskedTextBox maskedTextBox1;
    }
}
