namespace ProjNumberSystemsConverter
{
    partial class frmNSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNSC));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rdoDtB = new System.Windows.Forms.RadioButton();
            this.rdoBtD = new System.Windows.Forms.RadioButton();
            this.rdoDtH = new System.Windows.Forms.RadioButton();
            this.rdoHtD = new System.Windows.Forms.RadioButton();
            this.rdoBtH = new System.Windows.Forms.RadioButton();
            this.rdoHtB = new System.Windows.Forms.RadioButton();
            this.rtbWorking = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblWorking = new System.Windows.Forms.Label();
            this.lblChooseConversion = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMethod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(42, 79);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(219, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // rdoDtB
            // 
            this.rdoDtB.AutoSize = true;
            this.rdoDtB.Location = new System.Drawing.Point(50, 198);
            this.rdoDtB.Name = "rdoDtB";
            this.rdoDtB.Size = new System.Drawing.Size(151, 24);
            this.rdoDtB.TabIndex = 1;
            this.rdoDtB.TabStop = true;
            this.rdoDtB.Text = "Denary to Binary";
            this.rdoDtB.UseVisualStyleBackColor = true;
            this.rdoDtB.CheckedChanged += new System.EventHandler(this.rdoDtB_CheckedChanged);
            // 
            // rdoBtD
            // 
            this.rdoBtD.AutoSize = true;
            this.rdoBtD.Location = new System.Drawing.Point(50, 257);
            this.rdoBtD.Name = "rdoBtD";
            this.rdoBtD.Size = new System.Drawing.Size(151, 24);
            this.rdoBtD.TabIndex = 2;
            this.rdoBtD.TabStop = true;
            this.rdoBtD.Text = "Binary to Denary";
            this.rdoBtD.UseVisualStyleBackColor = true;
            // 
            // rdoDtH
            // 
            this.rdoDtH.AutoSize = true;
            this.rdoDtH.Location = new System.Drawing.Point(50, 315);
            this.rdoDtH.Name = "rdoDtH";
            this.rdoDtH.Size = new System.Drawing.Size(198, 24);
            this.rdoDtH.TabIndex = 3;
            this.rdoDtH.TabStop = true;
            this.rdoDtH.Text = "Denary to Hexadecimal";
            this.rdoDtH.UseVisualStyleBackColor = true;
            // 
            // rdoHtD
            // 
            this.rdoHtD.AutoSize = true;
            this.rdoHtD.Location = new System.Drawing.Point(50, 373);
            this.rdoHtD.Name = "rdoHtD";
            this.rdoHtD.Size = new System.Drawing.Size(198, 24);
            this.rdoHtD.TabIndex = 4;
            this.rdoHtD.TabStop = true;
            this.rdoHtD.Text = "Hexadecimal to Denary";
            this.rdoHtD.UseVisualStyleBackColor = true;
            this.rdoHtD.CheckedChanged += new System.EventHandler(this.rdoHtD_CheckedChanged);
            // 
            // rdoBtH
            // 
            this.rdoBtH.AutoSize = true;
            this.rdoBtH.Location = new System.Drawing.Point(50, 428);
            this.rdoBtH.Name = "rdoBtH";
            this.rdoBtH.Size = new System.Drawing.Size(191, 24);
            this.rdoBtH.TabIndex = 5;
            this.rdoBtH.TabStop = true;
            this.rdoBtH.Text = "Binary to Hexadecimal";
            this.rdoBtH.UseVisualStyleBackColor = true;
            // 
            // rdoHtB
            // 
            this.rdoHtB.AutoSize = true;
            this.rdoHtB.Location = new System.Drawing.Point(50, 486);
            this.rdoHtB.Name = "rdoHtB";
            this.rdoHtB.Size = new System.Drawing.Size(191, 24);
            this.rdoHtB.TabIndex = 6;
            this.rdoHtB.TabStop = true;
            this.rdoHtB.Text = "Hexadecimal to Binary";
            this.rdoHtB.UseVisualStyleBackColor = true;
            // 
            // rtbWorking
            // 
            this.rtbWorking.Location = new System.Drawing.Point(285, 79);
            this.rtbWorking.Name = "rtbWorking";
            this.rtbWorking.ReadOnly = true;
            this.rtbWorking.Size = new System.Drawing.Size(512, 692);
            this.rtbWorking.TabIndex = 7;
            this.rtbWorking.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(42, 788);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(755, 26);
            this.txtOutput.TabIndex = 8;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOuput_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInput.Location = new System.Drawing.Point(45, 51);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(55, 25);
            this.lblInput.TabIndex = 9;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutput.Location = new System.Drawing.Point(46, 760);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 25);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Output";
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWorking.Location = new System.Drawing.Point(280, 51);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(85, 25);
            this.lblWorking.TabIndex = 11;
            this.lblWorking.Text = "Working";
            // 
            // lblChooseConversion
            // 
            this.lblChooseConversion.AutoSize = true;
            this.lblChooseConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChooseConversion.Location = new System.Drawing.Point(46, 160);
            this.lblChooseConversion.Name = "lblChooseConversion";
            this.lblChooseConversion.Size = new System.Drawing.Size(197, 25);
            this.lblChooseConversion.TabIndex = 12;
            this.lblChooseConversion.Text = "Choose a conversion";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(51, 544);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(171, 50);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(602, 820);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 43);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(61, 29);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Enabled = false;
            this.btnMethod.Location = new System.Drawing.Point(51, 618);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(171, 50);
            this.btnMethod.TabIndex = 16;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // frmNSC
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(811, 875);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.rtbWorking);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblChooseConversion);
            this.Controls.Add(this.lblWorking);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.rdoHtB);
            this.Controls.Add(this.rdoBtH);
            this.Controls.Add(this.rdoHtD);
            this.Controls.Add(this.rdoDtH);
            this.Controls.Add(this.rdoBtD);
            this.Controls.Add(this.rdoDtB);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Number System Converter 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rdoDtB;
        private System.Windows.Forms.RadioButton rdoBtD;
        private System.Windows.Forms.RadioButton rdoDtH;
        private System.Windows.Forms.RadioButton rdoHtD;
        private System.Windows.Forms.RadioButton rdoBtH;
        private System.Windows.Forms.RadioButton rdoHtB;
        private System.Windows.Forms.RichTextBox rtbWorking;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.Label lblChooseConversion;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem btnHelp;
        public System.Windows.Forms.Button btnMethod;
    }
}

