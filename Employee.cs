using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SuperShopManagement
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            EmployeeTableShow();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SAIKAT-PC\SQLEXPRESS;Initial Catalog=SuperShopDB;Integrated Security=True");
        private void EmployeeTableShow()
        {
            con.Open();
            String query = "SELECT * From EmployeeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            if (EmpNameTb.Text == "" || EmpAddressTb.Text == "" || EmpPassTb.Text == "" || EmpPhoneTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTable values ('"+EmpNameTb.Text+ "','" + EmpPhoneTb.Text + "', '" + EmpAddressTb.Text + "','" + EmpPassTb.Text + "' )",con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Information Saved Successfully");

                    con.Close();
                    EmployeeTableShow();
                    clear();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ItemBtnInEmp_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }
        private void clear()
        {
            EmpNameTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpAddressTb.Text = "";
            EmpPassTb.Text = "";
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        int key = 0;

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine(e.RowIndex);
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpAddressTb.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPassTb.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            
            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Select Employee to be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query="Delete From EmployeeTable where EmpId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Information Deleted Successfully");

                    con.Close();
                    EmployeeTableShow();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Select Employee to be Updated");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update EmployeeTable set EmpName='"+EmpNameTb.Text+"',EmpPhone='"+EmpPhoneTb.Text+"',EmpAdd='"+EmpAddressTb.Text+"',EmpPassword='"+EmpPassTb.Text+"' where EmpId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Information Updeted Successfully");

                    con.Close();
                    EmployeeTableShow();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
