namespace WindowsFormRestWebService
{
    partial class Form1bUsingJSON
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
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.btnGetForecast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.wbIcon = new System.Windows.Forms.WebBrowser();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblForecast = new System.Windows.Forms.Label();
            this.txtForecast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(12, 24);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(130, 20);
            this.txtBoxCountry.TabIndex = 0;
            // 
            // btnGetForecast
            // 
            this.btnGetForecast.Location = new System.Drawing.Point(328, 22);
            this.btnGetForecast.Name = "btnGetForecast";
            this.btnGetForecast.Size = new System.Drawing.Size(112, 23);
            this.btnGetForecast.TabIndex = 1;
            this.btnGetForecast.Text = "Get Forecast";
            this.btnGetForecast.UseVisualStyleBackColor = true;
            this.btnGetForecast.Click += new System.EventHandler(this.btnGetForecast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(161, 24);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(127, 20);
            this.txtBoxCity.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(348, 65);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(348, 94);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(348, 123);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // wbIcon
            // 
            this.wbIcon.Location = new System.Drawing.Point(15, 60);
            this.wbIcon.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbIcon.Name = "wbIcon";
            this.wbIcon.Size = new System.Drawing.Size(100, 95);
            this.wbIcon.TabIndex = 10;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 182);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 166);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "&Title";
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Location = new System.Drawing.Point(12, 214);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(48, 13);
            this.lblForecast.TabIndex = 13;
            this.lblForecast.Text = "&Forecast";
            // 
            // txtForecast
            // 
            this.txtForecast.Location = new System.Drawing.Point(15, 230);
            this.txtForecast.Multiline = true;
            this.txtForecast.Name = "txtForecast";
            this.txtForecast.ReadOnly = true;
            this.txtForecast.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtForecast.Size = new System.Drawing.Size(260, 83);
            this.txtForecast.TabIndex = 14;
            // 
            // Form1bUsingJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 359);
            this.Controls.Add(this.txtForecast);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.wbIcon);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetForecast);
            this.Controls.Add(this.txtBoxCountry);
            this.Name = "Form1bUsingJSON";
            this.Text = "Form1bUsingJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.Button btnGetForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.WebBrowser wbIcon;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.TextBox txtForecast;
    }
}