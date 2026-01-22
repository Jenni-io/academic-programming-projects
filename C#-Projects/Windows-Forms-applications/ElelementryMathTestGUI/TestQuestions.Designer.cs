namespace ElelementryMathTestGUI
{
    partial class frmTestQuestions
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            grpQuestionsContainer = new GroupBox();
            lblIsAnswerRight = new Label();
            txtUsersAns = new TextBox();
            lblMathQuestion = new Label();
            btnCheckAnser = new Button();
            btnGradeQuestionsAnswered = new Button();
            btnExit = new Button();
            Mainttip = new ToolTip(components);
            grpQuestionsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // grpQuestionsContainer
            // 
            grpQuestionsContainer.Controls.Add(lblIsAnswerRight);
            grpQuestionsContainer.Controls.Add(txtUsersAns);
            grpQuestionsContainer.Controls.Add(lblMathQuestion);
            grpQuestionsContainer.Location = new Point(12, 12);
            grpQuestionsContainer.Name = "grpQuestionsContainer";
            grpQuestionsContainer.Size = new Size(349, 103);
            grpQuestionsContainer.TabIndex = 0;
            grpQuestionsContainer.TabStop = false;
            grpQuestionsContainer.Text = "Question 1";
            // 
            // lblIsAnswerRight
            // 
            lblIsAnswerRight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsAnswerRight.Location = new Point(181, 29);
            lblIsAnswerRight.Name = "lblIsAnswerRight";
            lblIsAnswerRight.Size = new Size(162, 58);
            lblIsAnswerRight.TabIndex = 2;
            lblIsAnswerRight.Text = "label1";
            // 
            // txtUsersAns
            // 
            txtUsersAns.Location = new Point(116, 40);
            txtUsersAns.Name = "txtUsersAns";
            txtUsersAns.Size = new Size(59, 33);
            txtUsersAns.TabIndex = 1;
            // 
            // lblMathQuestion
            // 
            lblMathQuestion.BackColor = SystemColors.ButtonFace;
            lblMathQuestion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMathQuestion.Location = new Point(18, 39);
            lblMathQuestion.Name = "lblMathQuestion";
            lblMathQuestion.Size = new Size(109, 36);
            lblMathQuestion.TabIndex = 0;
            lblMathQuestion.Text = "81 + 11 =";
            // 
            // btnCheckAnser
            // 
            btnCheckAnser.Location = new Point(12, 121);
            btnCheckAnser.Name = "btnCheckAnser";
            btnCheckAnser.Size = new Size(147, 35);
            btnCheckAnser.TabIndex = 1;
            btnCheckAnser.Text = "&Submit Answer";
            Mainttip.SetToolTip(btnCheckAnser, "Click to submit and check your answer for this question");
            btnCheckAnser.UseVisualStyleBackColor = true;
            btnCheckAnser.Click += btnCheckAnser_Click;
            // 
            // btnGradeQuestionsAnswered
            // 
            btnGradeQuestionsAnswered.Location = new Point(165, 121);
            btnGradeQuestionsAnswered.Name = "btnGradeQuestionsAnswered";
            btnGradeQuestionsAnswered.Size = new Size(95, 35);
            btnGradeQuestionsAnswered.TabIndex = 2;
            btnGradeQuestionsAnswered.Text = "End &Test";
            Mainttip.SetToolTip(btnGradeQuestionsAnswered, "End the Test now and see your score");
            btnGradeQuestionsAnswered.UseVisualStyleBackColor = true;
            btnGradeQuestionsAnswered.Click += btnGradeQuestionsAnswered_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(266, 121);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 35);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // frmTestQuestions
            // 
            AcceptButton = btnCheckAnser;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(373, 182);
            Controls.Add(btnExit);
            Controls.Add(btnGradeQuestionsAnswered);
            Controls.Add(btnCheckAnser);
            Controls.Add(grpQuestionsContainer);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frmTestQuestions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestQuestions";
            Load += frmTestQuestions_Load;
            grpQuestionsContainer.ResumeLayout(false);
            grpQuestionsContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpQuestionsContainer;
        private Label lblMathQuestion;
        private TextBox txtUsersAns;
        private Button btnCheckAnser;
        private Button btnGradeQuestionsAnswered;
        private Button btnExit;
        private Label lblIsAnswerRight;
        private ToolTip Mainttip;
    }
}