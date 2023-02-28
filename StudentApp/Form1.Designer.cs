namespace StudentApp
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
            this.DGVIEW = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.stdID = new System.Windows.Forms.TextBox();
            this.stdName = new System.Windows.Forms.TextBox();
            this.CGPA = new System.Windows.Forms.TextBox();
            this.SEMESTER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVIEW
            // 
            this.DGVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIEW.Location = new System.Drawing.Point(12, 325);
            this.DGVIEW.Name = "DGVIEW";
            this.DGVIEW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVIEW.Size = new System.Drawing.Size(689, 150);
            this.DGVIEW.TabIndex = 0;
            this.DGVIEW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVIEW_CellClick);
            this.DGVIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVIEW_CellContentClick);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(61, 251);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // EDIT
            // 
            this.EDIT.Location = new System.Drawing.Point(252, 251);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(75, 23);
            this.EDIT.TabIndex = 2;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(435, 251);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(75, 23);
            this.DELETE.TabIndex = 3;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(579, 251);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 23);
            this.CLEAR.TabIndex = 4;
            this.CLEAR.Text = "REFRESH";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // stdID
            // 
            this.stdID.Location = new System.Drawing.Point(252, 51);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(270, 20);
            this.stdID.TabIndex = 5;
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(252, 94);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(270, 20);
            this.stdName.TabIndex = 6;
            // 
            // CGPA
            // 
            this.CGPA.Location = new System.Drawing.Point(252, 143);
            this.CGPA.Name = "CGPA";
            this.CGPA.Size = new System.Drawing.Size(270, 20);
            this.CGPA.TabIndex = 7;
            // 
            // SEMESTER
            // 
            this.SEMESTER.Location = new System.Drawing.Point(252, 189);
            this.SEMESTER.Name = "SEMESTER";
            this.SEMESTER.Size = new System.Drawing.Size(270, 20);
            this.SEMESTER.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "STUDENT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CGPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SEMESTER";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(713, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SEMESTER);
            this.Controls.Add(this.CGPA);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.stdID);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.DGVIEW);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView DGVIEW;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.TextBox stdID;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.TextBox CGPA;
        private System.Windows.Forms.TextBox SEMESTER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

