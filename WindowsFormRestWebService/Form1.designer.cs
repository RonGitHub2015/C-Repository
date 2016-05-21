namespace RESTService
{
    partial class Form1
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.wbIcon = new System.Windows.Forms.WebBrowser();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblForecast = new System.Windows.Forms.Label();
            this.txtForecast = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.IconSelect = new System.Windows.Forms.NumericUpDown();
            this.lblIconSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(197, 70);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "&Location";
            // 
            // txtLocation
            // 
            this.txtLocation.AcceptsReturn = true;
            this.txtLocation.Location = new System.Drawing.Point(12, 25);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(179, 20);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.Text = "Milwaukee,WI";
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            this.txtLocation.Leave += new System.EventHandler(this.txtLocation_Leave);
            // 
            // wbIcon
            // 
            this.wbIcon.Location = new System.Drawing.Point(12, 51);
            this.wbIcon.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbIcon.Name = "wbIcon";
            this.wbIcon.ScrollBarsEnabled = false;
            this.wbIcon.Size = new System.Drawing.Size(80, 80);
            this.wbIcon.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 134);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "&Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 150);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 9;
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Location = new System.Drawing.Point(12, 173);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(48, 13);
            this.lblForecast.TabIndex = 10;
            this.lblForecast.Text = "&Forecast";
            // 
            // txtForecast
            // 
            this.txtForecast.Location = new System.Drawing.Point(12, 189);
            this.txtForecast.Multiline = true;
            this.txtForecast.Name = "txtForecast";
            this.txtForecast.ReadOnly = true;
            this.txtForecast.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtForecast.Size = new System.Drawing.Size(260, 61);
            this.txtForecast.TabIndex = 11;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(197, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(197, 41);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // IconSelect
            // 
            this.IconSelect.Location = new System.Drawing.Point(98, 64);
            this.IconSelect.Name = "IconSelect";
            this.IconSelect.Size = new System.Drawing.Size(44, 20);
            this.IconSelect.TabIndex = 7;
            this.IconSelect.ValueChanged += new System.EventHandler(this.IconSelect_ValueChanged);
            // 
            // lblIconSelect
            // 
            this.lblIconSelect.AutoSize = true;
            this.lblIconSelect.Location = new System.Drawing.Point(98, 48);
            this.lblIconSelect.Name = "lblIconSelect";
            this.lblIconSelect.Size = new System.Drawing.Size(75, 13);
            this.lblIconSelect.TabIndex = 6;
            this.lblIconSelect.Text = "&Icon Selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblIconSelect);
            this.Controls.Add(this.IconSelect);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtForecast);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.wbIcon);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Weather Forecaster";
            ((System.ComponentModel.ISupportInitialize)(this.IconSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.WebBrowser wbIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.TextBox txtForecast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.NumericUpDown IconSelect;
        private System.Windows.Forms.Label lblIconSelect;
    }
}

