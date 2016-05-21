namespace WindowsFormsApplication5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboRon2TextFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRon1Table = new System.Windows.Forms.DataGridView();
            this.Ron1UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ron2FID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ron2Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ron1Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ron1ThisOrThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ron1YesNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridYesNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ron1Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboYesNoFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboThisOrThatFilter = new System.Windows.Forms.ComboBox();
            this.txtRon1Text = new System.Windows.Forms.TextBox();
            this.comboRon2Fid = new System.Windows.Forms.ComboBox();
            this.comboYesNo = new System.Windows.Forms.ComboBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.comboThisOrThat = new System.Windows.Forms.ComboBox();
            this.btbAdd = new System.Windows.Forms.Button();
            this.txtFilterComments = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboRon1TextFilter = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRon1Table)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRon2TextFilter
            // 
            this.comboRon2TextFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRon2TextFilter.FormattingEnabled = true;
            this.comboRon2TextFilter.Location = new System.Drawing.Point(80, 16);
            this.comboRon2TextFilter.Name = "comboRon2TextFilter";
            this.comboRon2TextFilter.Size = new System.Drawing.Size(154, 21);
            this.comboRon2TextFilter.TabIndex = 0;
            this.comboRon2TextFilter.SelectedIndexChanged += new System.EventHandler(this.comboRon2TextFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ron2Text";
            // 
            // dataGridViewRon1Table
            // 
            this.dataGridViewRon1Table.AllowUserToAddRows = false;
            this.dataGridViewRon1Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRon1Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRon1Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ron1UID,
            this.Ron2FID,
            this.Ron2Text,
            this.Ron1Text,
            this.Ron1ThisOrThat,
            this.Ron1YesNo,
            this.gridYesNo,
            this.Ron1Comments});
            this.dataGridViewRon1Table.Location = new System.Drawing.Point(70, 273);
            this.dataGridViewRon1Table.Name = "dataGridViewRon1Table";
            this.dataGridViewRon1Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRon1Table.Size = new System.Drawing.Size(839, 303);
            this.dataGridViewRon1Table.TabIndex = 15;
            this.dataGridViewRon1Table.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRon1Table_CellContentDoubleClick);
            // 
            // Ron1UID
            // 
            this.Ron1UID.HeaderText = "Ron1UID";
            this.Ron1UID.Name = "Ron1UID";
            this.Ron1UID.ReadOnly = true;
            this.Ron1UID.Visible = false;
            // 
            // Ron2FID
            // 
            this.Ron2FID.HeaderText = "Ron2FID";
            this.Ron2FID.Name = "Ron2FID";
            this.Ron2FID.Visible = false;
            // 
            // Ron2Text
            // 
            this.Ron2Text.HeaderText = "Ron2Text";
            this.Ron2Text.Name = "Ron2Text";
            this.Ron2Text.Width = 142;
            // 
            // Ron1Text
            // 
            this.Ron1Text.HeaderText = "Ron1Text";
            this.Ron1Text.Name = "Ron1Text";
            this.Ron1Text.Width = 142;
            // 
            // Ron1ThisOrThat
            // 
            this.Ron1ThisOrThat.HeaderText = "Ron1ThisOrThat";
            this.Ron1ThisOrThat.Name = "Ron1ThisOrThat";
            this.Ron1ThisOrThat.Width = 141;
            // 
            // Ron1YesNo
            // 
            this.Ron1YesNo.HeaderText = "Ron1YesNo";
            this.Ron1YesNo.Name = "Ron1YesNo";
            this.Ron1YesNo.Visible = false;
            // 
            // gridYesNo
            // 
            this.gridYesNo.HeaderText = "Ron1YesNo";
            this.gridYesNo.Name = "gridYesNo";
            this.gridYesNo.Width = 142;
            // 
            // Ron1Comments
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Ron1Comments.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ron1Comments.HeaderText = "Ron1Comments";
            this.Ron1Comments.Name = "Ron1Comments";
            this.Ron1Comments.Width = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "YesNo";
            // 
            // comboYesNoFilter
            // 
            this.comboYesNoFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYesNoFilter.FormattingEnabled = true;
            this.comboYesNoFilter.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.comboYesNoFilter.Location = new System.Drawing.Point(569, 22);
            this.comboYesNoFilter.Name = "comboYesNoFilter";
            this.comboYesNoFilter.Size = new System.Drawing.Size(46, 21);
            this.comboYesNoFilter.TabIndex = 3;
            this.comboYesNoFilter.SelectedIndexChanged += new System.EventHandler(this.comboYesNoFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ThisOrThat";
            // 
            // comboThisOrThatFilter
            // 
            this.comboThisOrThatFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboThisOrThatFilter.FormattingEnabled = true;
            this.comboThisOrThatFilter.Items.AddRange(new object[] {
            "",
            "This",
            "That"});
            this.comboThisOrThatFilter.Location = new System.Drawing.Point(481, 22);
            this.comboThisOrThatFilter.Name = "comboThisOrThatFilter";
            this.comboThisOrThatFilter.Size = new System.Drawing.Size(75, 21);
            this.comboThisOrThatFilter.TabIndex = 2;
            this.comboThisOrThatFilter.SelectedIndexChanged += new System.EventHandler(this.comboThisOrThatFilter_SelectedIndexChanged);
            // 
            // txtRon1Text
            // 
            this.txtRon1Text.Location = new System.Drawing.Point(264, 125);
            this.txtRon1Text.Name = "txtRon1Text";
            this.txtRon1Text.Size = new System.Drawing.Size(193, 20);
            this.txtRon1Text.TabIndex = 8;
            // 
            // comboRon2Fid
            // 
            this.comboRon2Fid.FormattingEnabled = true;
            this.comboRon2Fid.Location = new System.Drawing.Point(80, 124);
            this.comboRon2Fid.Name = "comboRon2Fid";
            this.comboRon2Fid.Size = new System.Drawing.Size(165, 21);
            this.comboRon2Fid.TabIndex = 7;
            // 
            // comboYesNo
            // 
            this.comboYesNo.FormattingEnabled = true;
            this.comboYesNo.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.comboYesNo.Location = new System.Drawing.Point(577, 128);
            this.comboYesNo.Name = "comboYesNo";
            this.comboYesNo.Size = new System.Drawing.Size(49, 21);
            this.comboYesNo.TabIndex = 10;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(632, 128);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(196, 100);
            this.txtComments.TabIndex = 11;
            // 
            // comboThisOrThat
            // 
            this.comboThisOrThat.FormattingEnabled = true;
            this.comboThisOrThat.Items.AddRange(new object[] {
            "",
            "This",
            "That"});
            this.comboThisOrThat.Location = new System.Drawing.Point(481, 128);
            this.comboThisOrThat.Name = "comboThisOrThat";
            this.comboThisOrThat.Size = new System.Drawing.Size(75, 21);
            this.comboThisOrThat.TabIndex = 9;
            // 
            // btbAdd
            // 
            this.btbAdd.Location = new System.Drawing.Point(834, 90);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(75, 23);
            this.btbAdd.TabIndex = 12;
            this.btbAdd.Text = "Add New";
            this.btbAdd.UseVisualStyleBackColor = true;
            this.btbAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFilterComments
            // 
            this.txtFilterComments.Location = new System.Drawing.Point(632, 23);
            this.txtFilterComments.Name = "txtFilterComments";
            this.txtFilterComments.Size = new System.Drawing.Size(196, 20);
            this.txtFilterComments.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(629, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Comments contains text string";
            // 
            // comboRon1TextFilter
            // 
            this.comboRon1TextFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRon1TextFilter.FormattingEnabled = true;
            this.comboRon1TextFilter.Location = new System.Drawing.Point(264, 16);
            this.comboRon1TextFilter.Name = "comboRon1TextFilter";
            this.comboRon1TextFilter.Size = new System.Drawing.Size(193, 21);
            this.comboRon1TextFilter.TabIndex = 1;
            this.comboRon1TextFilter.SelectedIndexChanged += new System.EventHandler(this.comboRon1TextFilter_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(261, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Ron1Text";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(834, 21);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 44);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(834, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(834, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(-1, 122);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 622);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboRon1TextFilter);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtFilterComments);
            this.Controls.Add(this.btbAdd);
            this.Controls.Add(this.comboThisOrThat);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.comboYesNo);
            this.Controls.Add(this.comboRon2Fid);
            this.Controls.Add(this.txtRon1Text);
            this.Controls.Add(this.comboThisOrThatFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboYesNoFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRon1Table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRon2TextFilter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRon1Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRon2TextFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboYesNoFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboThisOrThatFilter;
        private System.Windows.Forms.DataGridView dataGridViewRon1Table;
        private System.Windows.Forms.TextBox txtRon1Text;
        private System.Windows.Forms.ComboBox comboRon2Fid;
        private System.Windows.Forms.ComboBox comboYesNo;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.ComboBox comboThisOrThat;
        private System.Windows.Forms.Button btbAdd;
        private System.Windows.Forms.TextBox txtFilterComments;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboRon1TextFilter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ron1UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ron2FID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ron2Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ron1Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ron1ThisOrThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ron1YesNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridYesNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ron1Comments;
    }
}

