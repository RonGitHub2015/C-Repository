namespace WindowsFormRestWebService
{
    partial class Form1JavaScript
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
            this.btnGetWeatherForecast = new System.Windows.Forms.Button();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxForecast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetWeatherForecast
            // 
            this.btnGetWeatherForecast.Location = new System.Drawing.Point(182, 24);
            this.btnGetWeatherForecast.Name = "btnGetWeatherForecast";
            this.btnGetWeatherForecast.Size = new System.Drawing.Size(75, 23);
            this.btnGetWeatherForecast.TabIndex = 0;
            this.btnGetWeatherForecast.Text = "btnGetWeather";
            this.btnGetWeatherForecast.UseVisualStyleBackColor = true;
            this.btnGetWeatherForecast.Click += new System.EventHandler(this.btnGetWeatherForecast_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(12, 27);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(143, 20);
            this.textBoxLocation.TabIndex = 1;
            // 
            // textBoxForecast
            // 
            this.textBoxForecast.Location = new System.Drawing.Point(12, 64);
            this.textBoxForecast.Name = "textBoxForecast";
            this.textBoxForecast.Size = new System.Drawing.Size(232, 20);
            this.textBoxForecast.TabIndex = 2;
            // 
            // Form1bJavaScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxForecast);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.btnGetWeatherForecast);
            this.Name = "Form1bJavaScript";
            this.Text = "Form1bJavaScript";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeatherForecast;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxForecast;
    }
}