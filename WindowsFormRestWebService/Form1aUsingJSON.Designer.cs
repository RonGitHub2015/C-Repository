namespace WindowsFormRestWebService
{
    partial class Form1aUsingJSON
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
            this.txtLocatiom = new System.Windows.Forms.TextBox();
            this.wbIcon = new System.Windows.Forms.WebBrowser();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblForecast = new System.Windows.Forms.Label();
            this.txtForecast = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocatiom
            // 
            this.txtLocatiom.Location = new System.Drawing.Point(12, 32);
            this.txtLocatiom.Name = "txtLocatiom";
            this.txtLocatiom.Size = new System.Drawing.Size(100, 20);
            this.txtLocatiom.TabIndex = 0;
            // 
            // wbIcon
            // 
            this.wbIcon.Location = new System.Drawing.Point(12, 58);
            this.wbIcon.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbIcon.Name = "wbIcon";
            this.wbIcon.Size = new System.Drawing.Size(100, 95);
            this.wbIcon.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 176);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 160);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "&Title";
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Location = new System.Drawing.Point(12, 199);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(48, 13);
            this.lblForecast.TabIndex = 12;
            this.lblForecast.Text = "&Forecast";
            // 
            // txtForecast
            // 
            this.txtForecast.Location = new System.Drawing.Point(15, 215);
            this.txtForecast.Multiline = true;
            this.txtForecast.Name = "txtForecast";
            this.txtForecast.ReadOnly = true;
            this.txtForecast.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtForecast.Size = new System.Drawing.Size(260, 61);
            this.txtForecast.TabIndex = 13;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 12);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "&Location";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(210, 61);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(210, 32);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(210, 90);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1aUsingJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 305);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtForecast);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.wbIcon);
            this.Controls.Add(this.txtLocatiom);
            this.Name = "Form1aUsingJSON";
            this.Text = "Form1aUsingJSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocatiom;
        private System.Windows.Forms.WebBrowser wbIcon;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.TextBox txtForecast;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnQuit;
    }
}