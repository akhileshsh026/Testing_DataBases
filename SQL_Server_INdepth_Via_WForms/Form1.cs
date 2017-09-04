using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SQL_Server_INdepth_Via_WForms
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        DataSet ds;
        int rno=0;
        public Form1()
        {
            InitializeComponent();
             con = new SqlConnection("Data Source=52.163.221.206;User Id=sa;Password=Akhilesh@123;DataBase=Company");
             con.Open();
            da = new SqlDataAdapter("Select * from Employee", con);
            ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Employee");
            ShowData();
        }


        public void ShowData()
        {
            textBox_Eno.Text = ds.Tables[0].Rows[rno][0].ToString();
            textBox_Ename.Text = ds.Tables[0].Rows[rno][1].ToString();
            textBox_Job.Text = ds.Tables[0].Rows[rno][2].ToString();
            textBox_Salary.Text = ds.Tables[0].Rows[rno][3].ToString();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            rno = 0;
            ShowData();
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            if (rno > 0)
            {
                rno -= 1;
                if (ds.Tables[0].Rows[rno].RowState == DataRowState.Deleted)
                {
                    MessageBox.Show("Deleted row data");
                    return;
                }
                ShowData();
            }
            else
            {
                MessageBox.Show("First record of the Table");
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (rno < ds.Tables[0].Rows.Count - 1)
            {
                rno += 1;
                if (ds.Tables[0].Rows[rno].RowState == DataRowState.Deleted)
                {
                    MessageBox.Show("Data Cannot be acced becuase it is deleted");
                    return;
                }
                ShowData();
            }
            else
            {
                MessageBox.Show("Last recoed of the data");
            }

        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            rno = ds.Tables[0].Rows.Count - 1;
            ShowData();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            textBox_Eno.Text = textBox_Ename.Text = textBox_Job.Text = textBox_Salary.Text = "";
            int index = ds.Tables[0].Rows.Count - 1;
            int eno = Convert.ToInt32(ds.Tables[0].Rows[index][0])+1;
            textBox_Eno.Text = eno.ToString();
            textBox_Ename.Focus();

        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].NewRow();

            dr[0] = textBox_Eno.Text;
            dr[1] = textBox_Ename.Text;
            dr[2] = textBox_Job.Text;
            dr[3] = textBox_Salary.Text;

            ds.Tables[0].Rows.Add(dr);
            rno = ds.Tables[0].Rows.Count - 1;
            MessageBox.Show("Record Inserted");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Rows[rno][1] = textBox_Ename.Text;
            ds.Tables[0].Rows[rno][2] = textBox_Job.Text;
            ds.Tables[0].Rows[rno][3] = textBox_Salary.Text;
            MessageBox.Show("data updated sucessfully");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Rows[rno].Delete();
            MessageBox.Show("Deleting Row");
        }

        private void button_Save_To_DB_Click(object sender, EventArgs e)
        {
            cb = new SqlCommandBuilder(da);
            da.Update(ds, "Employee");
            MessageBox.Show("Data Saved to Server");
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
