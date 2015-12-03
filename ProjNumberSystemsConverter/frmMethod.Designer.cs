namespace ProjNumberSystemsConverter
{
    partial class frmMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMethod));
            this.rtbDtB = new System.Windows.Forms.RichTextBox();
            this.rtbBtD = new System.Windows.Forms.RichTextBox();
            this.rtbHtD = new System.Windows.Forms.RichTextBox();
            this.rtbDtH = new System.Windows.Forms.RichTextBox();
            this.rtbBtH = new System.Windows.Forms.RichTextBox();
            this.rtbHtB = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDtB
            // 
            this.rtbDtB.Location = new System.Drawing.Point(0, 0);
            this.rtbDtB.Name = "rtbDtB";
            this.rtbDtB.ReadOnly = true;
            this.rtbDtB.Size = new System.Drawing.Size(395, 458);
            this.rtbDtB.TabIndex = 0;
            this.rtbDtB.Text = resources.GetString("rtbDtB.Text");
            this.rtbDtB.Visible = false;
            // 
            // rtbBtD
            // 
            this.rtbBtD.Location = new System.Drawing.Point(0, 0);
            this.rtbBtD.Name = "rtbBtD";
            this.rtbBtD.ReadOnly = true;
            this.rtbBtD.Size = new System.Drawing.Size(395, 458);
            this.rtbBtD.TabIndex = 1;
            this.rtbBtD.Text = resources.GetString("rtbBtD.Text");
            this.rtbBtD.Visible = false;
            // 
            // rtbHtD
            // 
            this.rtbHtD.Location = new System.Drawing.Point(0, 0);
            this.rtbHtD.Name = "rtbHtD";
            this.rtbHtD.ReadOnly = true;
            this.rtbHtD.Size = new System.Drawing.Size(395, 458);
            this.rtbHtD.TabIndex = 2;
            this.rtbHtD.Text = resources.GetString("rtbHtD.Text");
            this.rtbHtD.Visible = false;
            // 
            // rtbDtH
            // 
            this.rtbDtH.Location = new System.Drawing.Point(0, 0);
            this.rtbDtH.Name = "rtbDtH";
            this.rtbDtH.ReadOnly = true;
            this.rtbDtH.Size = new System.Drawing.Size(395, 458);
            this.rtbDtH.TabIndex = 3;
            this.rtbDtH.Text = resources.GetString("rtbDtH.Text");
            this.rtbDtH.Visible = false;
            // 
            // rtbBtH
            // 
            this.rtbBtH.Location = new System.Drawing.Point(0, 0);
            this.rtbBtH.Name = "rtbBtH";
            this.rtbBtH.ReadOnly = true;
            this.rtbBtH.Size = new System.Drawing.Size(395, 458);
            this.rtbBtH.TabIndex = 4;
            this.rtbBtH.Text = resources.GetString("rtbBtH.Text");
            this.rtbBtH.Visible = false;
            // 
            // rtbHtB
            // 
            this.rtbHtB.Location = new System.Drawing.Point(0, 0);
            this.rtbHtB.Name = "rtbHtB";
            this.rtbHtB.ReadOnly = true;
            this.rtbHtB.Size = new System.Drawing.Size(395, 458);
            this.rtbHtB.TabIndex = 5;
            this.rtbHtB.Text = resources.GetString("rtbHtB.Text");
            this.rtbHtB.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(105, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 54);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(398, 549);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbDtB);
            this.Controls.Add(this.rtbHtB);
            this.Controls.Add(this.rtbBtH);
            this.Controls.Add(this.rtbDtH);
            this.Controls.Add(this.rtbHtD);
            this.Controls.Add(this.rtbBtD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMethod";
            this.Text = "Conversion Method";
            this.Load += new System.EventHandler(this.frmMethod_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDtB;
        private System.Windows.Forms.RichTextBox rtbBtD;
        private System.Windows.Forms.RichTextBox rtbHtD;
        private System.Windows.Forms.RichTextBox rtbDtH;
        private System.Windows.Forms.RichTextBox rtbBtH;
        private System.Windows.Forms.RichTextBox rtbHtB;
        private System.Windows.Forms.Button btnClose;
    }
}