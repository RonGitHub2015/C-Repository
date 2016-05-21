namespace ArrayUsage
{
    partial class Form2
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
            this.btnForm2LINQ = new System.Windows.Forms.Button();
            this.btnForm2Loop = new System.Windows.Forms.Button();
            this.btnForm2Conditional = new System.Windows.Forms.Button();
            this.btnForm2Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm2LINQ
            // 
            this.btnForm2LINQ.Location = new System.Drawing.Point(334, 41);
            this.btnForm2LINQ.Name = "btnForm2LINQ";
            this.btnForm2LINQ.Size = new System.Drawing.Size(75, 23);
            this.btnForm2LINQ.TabIndex = 0;
            this.btnForm2LINQ.Text = "LINQ";
            this.btnForm2LINQ.UseVisualStyleBackColor = true;
            this.btnForm2LINQ.Click += new System.EventHandler(this.btnForm2LINQ_Click);
            // 
            // btnForm2Loop
            // 
            this.btnForm2Loop.Location = new System.Drawing.Point(334, 70);
            this.btnForm2Loop.Name = "btnForm2Loop";
            this.btnForm2Loop.Size = new System.Drawing.Size(75, 23);
            this.btnForm2Loop.TabIndex = 1;
            this.btnForm2Loop.Text = "Loop";
            this.btnForm2Loop.UseVisualStyleBackColor = true;
            this.btnForm2Loop.Click += new System.EventHandler(this.btnForm2Loop_Click);
            // 
            // btnForm2Conditional
            // 
            this.btnForm2Conditional.Location = new System.Drawing.Point(334, 115);
            this.btnForm2Conditional.Name = "btnForm2Conditional";
            this.btnForm2Conditional.Size = new System.Drawing.Size(75, 23);
            this.btnForm2Conditional.TabIndex = 2;
            this.btnForm2Conditional.Text = "Conditional";
            this.btnForm2Conditional.UseVisualStyleBackColor = true;
            this.btnForm2Conditional.Click += new System.EventHandler(this.btnForm2Conditional_Click);
            // 
            // btnForm2Quit
            // 
            this.btnForm2Quit.Location = new System.Drawing.Point(334, 157);
            this.btnForm2Quit.Name = "btnForm2Quit";
            this.btnForm2Quit.Size = new System.Drawing.Size(75, 23);
            this.btnForm2Quit.TabIndex = 3;
            this.btnForm2Quit.Text = "Quit";
            this.btnForm2Quit.UseVisualStyleBackColor = true;
            this.btnForm2Quit.Click += new System.EventHandler(this.btnForm2Quit_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.btnForm2Quit);
            this.Controls.Add(this.btnForm2Conditional);
            this.Controls.Add(this.btnForm2Loop);
            this.Controls.Add(this.btnForm2LINQ);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnConditional;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForm2LINQ;
        private System.Windows.Forms.Button btnForm2Loop;
        private System.Windows.Forms.Button btnForm2Conditional;
        private System.Windows.Forms.Button btnForm2Quit;
    }
}