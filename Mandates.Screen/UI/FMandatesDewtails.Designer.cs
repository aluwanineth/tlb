namespace Mandates.Screen.UI
{
    partial class FMandatesDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.wbMandateDetails = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wbMandateDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 874);
            this.panel1.TabIndex = 0;
            // 
            // wbMandateDetails
            // 
            this.wbMandateDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMandateDetails.Location = new System.Drawing.Point(0, 0);
            this.wbMandateDetails.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMandateDetails.Name = "wbMandateDetails";
            this.wbMandateDetails.Size = new System.Drawing.Size(1191, 874);
            this.wbMandateDetails.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 821);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 53);
            this.panel2.TabIndex = 1;
            // 
            // FMandatesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 874);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FMandatesDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mandates Details";
            this.Load += new System.EventHandler(this.FMandatesDetails_Load);
            this.Shown += new System.EventHandler(this.FMandatesDetails_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser wbMandateDetails;
        private System.Windows.Forms.Panel panel2;
    }
}