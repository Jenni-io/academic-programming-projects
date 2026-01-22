namespace NumberingSystemConverter3000
{
    partial class FrmNumberSysConverter
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
            lblFromValue = new Label();
            lblTo = new Label();
            txtNumtoConvert = new TextBox();
            lblOutPutBase = new Label();
            lblCurrentBase = new Label();
            lblTargetBase = new Label();
            cboCurrentBase = new ComboBox();
            cboTargetBase = new ComboBox();
            grpConvertingBases = new GroupBox();
            btnConvert = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpConvertingBases.SuspendLayout();
            SuspendLayout();
            // 
            // lblFromValue
            // 
            lblFromValue.AutoSize = true;
            lblFromValue.Location = new Point(28, 35);
            lblFromValue.Name = "lblFromValue";
            lblFromValue.Size = new Size(59, 25);
            lblFromValue.TabIndex = 0;
            lblFromValue.Text = "From:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(52, 77);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(35, 25);
            lblTo.TabIndex = 4;
            lblTo.Text = "To:";
            // 
            // txtNumtoConvert
            // 
            txtNumtoConvert.Location = new Point(93, 32);
            txtNumtoConvert.Name = "txtNumtoConvert";
            txtNumtoConvert.Size = new Size(150, 33);
            txtNumtoConvert.TabIndex = 1;
            // 
            // lblOutPutBase
            // 
            lblOutPutBase.BorderStyle = BorderStyle.Fixed3D;
            lblOutPutBase.Location = new Point(93, 76);
            lblOutPutBase.Name = "lblOutPutBase";
            lblOutPutBase.Size = new Size(150, 33);
            lblOutPutBase.TabIndex = 5;
            // 
            // lblCurrentBase
            // 
            lblCurrentBase.AutoSize = true;
            lblCurrentBase.Location = new Point(265, 35);
            lblCurrentBase.Name = "lblCurrentBase";
            lblCurrentBase.Size = new Size(51, 25);
            lblCurrentBase.TabIndex = 2;
            lblCurrentBase.Text = "base";
            // 
            // lblTargetBase
            // 
            lblTargetBase.AutoSize = true;
            lblTargetBase.Location = new Point(265, 77);
            lblTargetBase.Name = "lblTargetBase";
            lblTargetBase.Size = new Size(51, 25);
            lblTargetBase.TabIndex = 6;
            lblTargetBase.Text = "base";
            // 
            // cboCurrentBase
            // 
            cboCurrentBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrentBase.DropDownWidth = 72;
            cboCurrentBase.FormattingEnabled = true;
            cboCurrentBase.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboCurrentBase.Location = new Point(323, 32);
            cboCurrentBase.Name = "cboCurrentBase";
            cboCurrentBase.Size = new Size(72, 33);
            cboCurrentBase.TabIndex = 3;
            cboCurrentBase.SelectedIndexChanged += cmb_SelectedIndexChanged;
            // 
            // cboTargetBase
            // 
            cboTargetBase.AllowDrop = true;
            cboTargetBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTargetBase.FormattingEnabled = true;
            cboTargetBase.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboTargetBase.Location = new Point(323, 77);
            cboTargetBase.MaxDropDownItems = 10;
            cboTargetBase.MaxLength = 10;
            cboTargetBase.Name = "cboTargetBase";
            cboTargetBase.Size = new Size(72, 33);
            cboTargetBase.TabIndex = 7;
            cboTargetBase.SelectedIndexChanged += cmb_SelectedIndexChanged;
            // 
            // grpConvertingBases
            // 
            grpConvertingBases.Controls.Add(txtNumtoConvert);
            grpConvertingBases.Controls.Add(cboTargetBase);
            grpConvertingBases.Controls.Add(lblFromValue);
            grpConvertingBases.Controls.Add(cboCurrentBase);
            grpConvertingBases.Controls.Add(lblTo);
            grpConvertingBases.Controls.Add(lblTargetBase);
            grpConvertingBases.Controls.Add(lblOutPutBase);
            grpConvertingBases.Controls.Add(lblCurrentBase);
            grpConvertingBases.Location = new Point(12, 12);
            grpConvertingBases.Name = "grpConvertingBases";
            grpConvertingBases.Size = new Size(419, 145);
            grpConvertingBases.TabIndex = 0;
            grpConvertingBases.TabStop = false;
            grpConvertingBases.Text = "Converting from base # to base #";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.ControlLight;
            btnConvert.FlatStyle = FlatStyle.Popup;
            btnConvert.Location = new Point(12, 164);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(233, 52);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "&Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ControlLight;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Location = new Point(251, 163);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 52);
            btnReset.TabIndex = 2;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlLight;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(352, 163);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(79, 52);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmNumberSysConverter
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(443, 228);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnConvert);
            Controls.Add(grpConvertingBases);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmNumberSysConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Numbering System Converter 3000";
            Load += FrmNumberSysConverter_Load;
            grpConvertingBases.ResumeLayout(false);
            grpConvertingBases.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblFromValue;
        private Label lblTo;
        private TextBox txtNumtoConvert;
        private Label lblOutPutBase;
        private Label lblCurrentBase;
        private Label lblTargetBase;
        private ComboBox cboCurrentBase;
        private ComboBox cboTargetBase;
        private GroupBox grpConvertingBases;
        private Button btnConvert;
        private Button btnReset;
        private Button btnExit;
    }
}
