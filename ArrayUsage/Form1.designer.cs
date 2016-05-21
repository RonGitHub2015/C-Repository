namespace ArrayUsage
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
            this.btnLINQ = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnConditional = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLINQ
            // 
            this.btnLINQ.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLINQ.Location = new System.Drawing.Point(197, 13);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(75, 23);
            this.btnLINQ.TabIndex = 0;
            this.btnLINQ.Text = "LIN&Q";
            this.btnLINQ.UseVisualStyleBackColor = true;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoop.Location = new System.Drawing.Point(197, 43);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "&Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnConditional
            // 
            this.btnConditional.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConditional.Location = new System.Drawing.Point(197, 73);
            this.btnConditional.Name = "btnConditional";
            this.btnConditional.Size = new System.Drawing.Size(75, 23);
            this.btnConditional.TabIndex = 2;
            this.btnConditional.Text = "&Conditional";
            this.btnConditional.UseVisualStyleBackColor = true;
            this.btnConditional.Click += new System.EventHandler(this.btnConditional_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(197, 103);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLINQ;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnConditional);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnLINQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Using an Array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnConditional;
        private System.Windows.Forms.Button btnQuit;
    }
}

