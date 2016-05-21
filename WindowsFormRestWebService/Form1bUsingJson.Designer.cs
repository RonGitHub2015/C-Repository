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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblWeather = new System.Windows.Forms.Label();
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
            this.btnGetForecast.Location = new System.Drawing.Point(15, 104);
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
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(15, 67);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(127, 20);
            this.txtBoxCity.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(12, 144);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(48, 13);
            this.lblWeather.TabIndex = 6;
            this.lblWeather.Text = "Weather";
            // 
            // Form1bUsingJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetForecast);
            this.Controls.Add(this.txtBoxCountry);
            this.Name = "Form1bUsingJson";
            this.Text = "Form1cJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.Button btnGetForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblWeather;
    }
}