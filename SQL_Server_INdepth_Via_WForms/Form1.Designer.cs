namespace SQL_Server_INdepth_Via_WForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Eno = new System.Windows.Forms.TextBox();
            this.textBox_Ename = new System.Windows.Forms.TextBox();
            this.textBox_Job = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Save_To_DB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eno :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ename :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Job";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salary :";
            // 
            // textBox_Eno
            // 
            this.textBox_Eno.Location = new System.Drawing.Point(240, 124);
            this.textBox_Eno.Name = "textBox_Eno";
            this.textBox_Eno.Size = new System.Drawing.Size(195, 20);
            this.textBox_Eno.TabIndex = 2;
            // 
            // textBox_Ename
            // 
            this.textBox_Ename.Location = new System.Drawing.Point(240, 166);
            this.textBox_Ename.Name = "textBox_Ename";
            this.textBox_Ename.Size = new System.Drawing.Size(195, 20);
            this.textBox_Ename.TabIndex = 2;
            // 
            // textBox_Job
            // 
            this.textBox_Job.Location = new System.Drawing.Point(240, 209);
            this.textBox_Job.Name = "textBox_Job";
            this.textBox_Job.Size = new System.Drawing.Size(195, 20);
            this.textBox_Job.TabIndex = 2;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(240, 262);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(195, 20);
            this.textBox_Salary.TabIndex = 2;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(85, 376);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 3;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // button_Prev
            // 
            this.button_Prev.Location = new System.Drawing.Point(185, 376);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(75, 23);
            this.button_Prev.TabIndex = 3;
            this.button_Prev.Text = "Prev";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(292, 376);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 3;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(395, 376);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(75, 23);
            this.button_Last.TabIndex = 3;
            this.button_Last.Text = "Last";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(85, 418);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 3;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(185, 418);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(75, 23);
            this.button_Insert.TabIndex = 3;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(292, 418);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(395, 418);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(292, 464);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(395, 464);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Save_To_DB
            // 
            this.button_Save_To_DB.Location = new System.Drawing.Point(85, 463);
            this.button_Save_To_DB.Name = "button_Save_To_DB";
            this.button_Save_To_DB.Size = new System.Drawing.Size(175, 23);
            this.button_Save_To_DB.TabIndex = 4;
            this.button_Save_To_DB.Text = "Save To DB";
            this.button_Save_To_DB.UseVisualStyleBackColor = true;
            this.button_Save_To_DB.Click += new System.EventHandler(this.button_Save_To_DB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 522);
            this.Controls.Add(this.button_Save_To_DB);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Prev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.textBox_Job);
            this.Controls.Add(this.textBox_Ename);
            this.Controls.Add(this.textBox_Eno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Eno;
        private System.Windows.Forms.TextBox textBox_Ename;
        private System.Windows.Forms.TextBox textBox_Job;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Save_To_DB;
    }
}

