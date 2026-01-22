namespace ElelementryMathTestGUI
{
    partial class frmMathTest
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
            components = new System.ComponentModel.Container();
            lblAskNumQuestions = new Label();
            txtNumOfQuestions = new TextBox();
            btnStartTest = new Button();
            mainTtip = new ToolTip(components);
            groupBox1 = new GroupBox();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAskNumQuestions
            // 
            lblAskNumQuestions.AutoSize = true;
            lblAskNumQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAskNumQuestions.Location = new Point(6, 45);
            lblAskNumQuestions.Name = "lblAskNumQuestions";
            lblAskNumQuestions.Size = new Size(268, 21);
            lblAskNumQuestions.TabIndex = 0;
            lblAskNumQuestions.Text = "How many questions would you like :";
            // 
            // txtNumOfQuestions
            // 
            txtNumOfQuestions.Location = new Point(280, 45);
            txtNumOfQuestions.Name = "txtNumOfQuestions";
            txtNumOfQuestions.Size = new Size(68, 33);
            txtNumOfQuestions.TabIndex = 1;
            txtNumOfQuestions.Tag = "";
            mainTtip.SetToolTip(txtNumOfQuestions, "NOTE: The test will generate and grade indicated amount of questions");
            // 
            // btnStartTest
            // 
            btnStartTest.Location = new Point(54, 114);
            btnStartTest.Name = "btnStartTest";
            btnStartTest.Size = new Size(204, 37);
            btnStartTest.TabIndex = 2;
            btnStartTest.Text = "&Start Test";
            mainTtip.SetToolTip(btnStartTest, "NOTE: The test will generate and grade indicated amount of questions");
            btnStartTest.UseVisualStyleBackColor = true;
            btnStartTest.Click += btnStartTest_Click;
            // 
            // mainTtip
            // 
            mainTtip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(lblAskNumQuestions);
            groupBox1.Controls.Add(btnStartTest);
            groupBox1.Controls.Add(txtNumOfQuestions);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome to the Math Test Generator";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(264, 114);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(58, 37);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMathTest
            // 
            AcceptButton = btnStartTest;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(434, 225);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frmMathTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elementary Math Test";
            Load += frmMathTest_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblDirectUser;
        private Label lblAskNumQuestions;
        private TextBox txtNumOfQuestions;
        private Button btnStartTest;
        private ToolTip mainTtip;
        private GroupBox groupBox1;
        private Button btnExit;
    }
}
