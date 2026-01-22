namespace TextStatGUI {
    partial class FrmTextStat {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            TxtboxUserInput = new RichTextBox();
            lvOutputDictonary = new ListView();
            lsvWords = new ColumnHeader();
            lsvCount = new ColumnHeader();
            lblNumOfSentences = new Label();
            lblOpNumOfSen = new Label();
            lblNumOfUnqWords = new Label();
            lblOPUniqueWordCount = new Label();
            grpGroupButtons = new GroupBox();
            btnAnalyze = new Button();
            btnExit = new Button();
            btnClear = new Button();
            stsMain = new StatusStrip();
            tsOutputValidation = new ToolStripStatusLabel();
            sslOutptErrors = new ToolStripStatusLabel();
            txtSearch = new TextBox();
            lblTotalWordCount = new Label();
            lblOPTotalWordCount = new Label();
            mnuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addFileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            grpGroupButtons.SuspendLayout();
            stsMain.SuspendLayout();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // TxtboxUserInput
            // 
            TxtboxUserInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtboxUserInput.ForeColor = SystemColors.Desktop;
            TxtboxUserInput.Location = new Point(12, 27);
            TxtboxUserInput.Margin = new Padding(3, 4, 3, 4);
            TxtboxUserInput.Name = "TxtboxUserInput";
            TxtboxUserInput.Size = new Size(372, 331);
            TxtboxUserInput.TabIndex = 0;
            TxtboxUserInput.Text = "";
            // 
            // lvOutputDictonary
            // 
            lvOutputDictonary.Columns.AddRange(new ColumnHeader[] { lsvWords, lsvCount });
            lvOutputDictonary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvOutputDictonary.Location = new Point(404, 59);
            lvOutputDictonary.Margin = new Padding(3, 4, 3, 4);
            lvOutputDictonary.MultiSelect = false;
            lvOutputDictonary.Name = "lvOutputDictonary";
            lvOutputDictonary.Size = new Size(170, 300);
            lvOutputDictonary.TabIndex = 5;
            lvOutputDictonary.UseCompatibleStateImageBehavior = false;
            lvOutputDictonary.View = View.Details;
            // 
            // lsvWords
            // 
            lsvWords.Text = "Words";
            lsvWords.Width = 100;
            // 
            // lsvCount
            // 
            lsvCount.Text = "Count";
            lsvCount.Width = 100;
            // 
            // lblNumOfSentences
            // 
            lblNumOfSentences.AutoSize = true;
            lblNumOfSentences.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumOfSentences.Location = new Point(12, 369);
            lblNumOfSentences.Name = "lblNumOfSentences";
            lblNumOfSentences.Size = new Size(170, 21);
            lblNumOfSentences.TabIndex = 1;
            lblNumOfSentences.Text = "Number Of Sentences :";
            // 
            // lblOpNumOfSen
            // 
            lblOpNumOfSen.BackColor = SystemColors.Control;
            lblOpNumOfSen.BorderStyle = BorderStyle.Fixed3D;
            lblOpNumOfSen.Location = new Point(188, 369);
            lblOpNumOfSen.Name = "lblOpNumOfSen";
            lblOpNumOfSen.Size = new Size(74, 25);
            lblOpNumOfSen.TabIndex = 2;
            // 
            // lblNumOfUnqWords
            // 
            lblNumOfUnqWords.AutoSize = true;
            lblNumOfUnqWords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumOfUnqWords.Location = new Point(350, 369);
            lblNumOfUnqWords.Name = "lblNumOfUnqWords";
            lblNumOfUnqWords.Size = new Size(159, 21);
            lblNumOfUnqWords.TabIndex = 6;
            lblNumOfUnqWords.Text = "Unique Words count :";
            // 
            // lblOPUniqueWordCount
            // 
            lblOPUniqueWordCount.BackColor = SystemColors.Control;
            lblOPUniqueWordCount.BorderStyle = BorderStyle.Fixed3D;
            lblOPUniqueWordCount.Location = new Point(515, 369);
            lblOPUniqueWordCount.Name = "lblOPUniqueWordCount";
            lblOPUniqueWordCount.Size = new Size(54, 25);
            lblOPUniqueWordCount.TabIndex = 7;
            // 
            // grpGroupButtons
            // 
            grpGroupButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpGroupButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpGroupButtons.Controls.Add(btnAnalyze);
            grpGroupButtons.Controls.Add(btnExit);
            grpGroupButtons.Controls.Add(btnClear);
            grpGroupButtons.Location = new Point(13, 393);
            grpGroupButtons.Margin = new Padding(3, 4, 3, 4);
            grpGroupButtons.Name = "grpGroupButtons";
            grpGroupButtons.Padding = new Padding(3, 4, 3, 4);
            grpGroupButtons.RightToLeft = RightToLeft.Yes;
            grpGroupButtons.Size = new Size(573, 100);
            grpGroupButtons.TabIndex = 3;
            grpGroupButtons.TabStop = false;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnalyze.Location = new Point(367, 21);
            btnAnalyze.Margin = new Padding(3, 4, 3, 4);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(98, 49);
            btnAnalyze.TabIndex = 1;
            btnAnalyze.Text = "&Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(471, 21);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 49);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.FlatStyle = FlatStyle.System;
            btnClear.Location = new Point(267, 21);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 49);
            btnClear.TabIndex = 0;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // stsMain
            // 
            stsMain.Items.AddRange(new ToolStripItem[] { tsOutputValidation, sslOutptErrors });
            stsMain.Location = new Point(0, 476);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(584, 25);
            stsMain.TabIndex = 8;
            stsMain.Text = "Please enter the text you wish to analyze";
            // 
            // tsOutputValidation
            // 
            tsOutputValidation.Name = "tsOutputValidation";
            tsOutputValidation.Size = new Size(0, 20);
            // 
            // sslOutptErrors
            // 
            sslOutptErrors.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sslOutptErrors.Name = "sslOutptErrors";
            sslOutptErrors.Size = new Size(276, 20);
            sslOutptErrors.Text = "Please enter the text you wish to analyze";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(404, 24);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔎 Search ...";
            txtSearch.Size = new Size(170, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotalWordCount
            // 
            lblTotalWordCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalWordCount.AutoSize = true;
            lblTotalWordCount.BackColor = SystemColors.Window;
            lblTotalWordCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalWordCount.ForeColor = Color.Gray;
            lblTotalWordCount.Location = new Point(14, 336);
            lblTotalWordCount.Name = "lblTotalWordCount";
            lblTotalWordCount.Size = new Size(95, 20);
            lblTotalWordCount.TabIndex = 9;
            lblTotalWordCount.Text = "Word Count :";
            // 
            // lblOPTotalWordCount
            // 
            lblOPTotalWordCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblOPTotalWordCount.BackColor = SystemColors.Window;
            lblOPTotalWordCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOPTotalWordCount.ForeColor = Color.Gray;
            lblOPTotalWordCount.Location = new Point(315, 335);
            lblOPTotalWordCount.Name = "lblOPTotalWordCount";
            lblOPTotalWordCount.Size = new Size(65, 21);
            lblOPTotalWordCount.TabIndex = 10;
            lblOPTotalWordCount.Text = "0";
            lblOPTotalWordCount.TextAlign = ContentAlignment.TopRight;
            // 
            // mnuMain
            // 
            mnuMain.BackColor = SystemColors.Control;
            mnuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(584, 24);
            mnuMain.TabIndex = 11;
            mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addFileToolStripMenuItem
            // 
            addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            addFileToolStripMenuItem.Size = new Size(106, 22);
            addFileToolStripMenuItem.Text = "Open ";
            addFileToolStripMenuItem.Click += addFileToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(102, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(102, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(102, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // FrmTextStat
            // 
            AcceptButton = btnAnalyze;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            CancelButton = btnExit;
            ClientSize = new Size(584, 501);
            Controls.Add(lblOPTotalWordCount);
            Controls.Add(lblTotalWordCount);
            Controls.Add(txtSearch);
            Controls.Add(stsMain);
            Controls.Add(mnuMain);
            Controls.Add(grpGroupButtons);
            Controls.Add(lblOPUniqueWordCount);
            Controls.Add(lblNumOfUnqWords);
            Controls.Add(lblOpNumOfSen);
            Controls.Add(lblNumOfSentences);
            Controls.Add(lvOutputDictonary);
            Controls.Add(TxtboxUserInput);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mnuMain;
            Margin = new Padding(6, 5, 6, 5);
            MaximumSize = new Size(600, 540);
            MinimumSize = new Size(420, 540);
            Name = "FrmTextStat";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Analyzer";
            Load += FrmTextStat_Load;
            grpGroupButtons.ResumeLayout(false);
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TxtboxUserInput;
        private ListView lvOutputDictonary;
        private Label lblNumOfSentences;
        private Label lblOpNumOfSen;
        private Label lblNumOfUnqWords;
        private Label lblOPUniqueWordCount;
        private GroupBox grpGroupButtons;
        private StatusStrip stsMain;
        private ToolStripStatusLabel tsOutputValidation;
        private ToolStripStatusLabel sslOutptErrors;
        private ColumnHeader lsvWords;
        private ColumnHeader lsvCount;
        private Button btnAnalyze;
        private Button btnExit;
        private Button btnClear;
        private TextBox txtSearch;
        private Label lblTotalWordCount;
        private Label lblOPTotalWordCount;
        private MenuStrip mnuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem addFileToolStripMenuItem;
    }
}
