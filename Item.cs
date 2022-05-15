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

namespace SuperShopManagement
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
            ItemTableShow();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SAIKAT-PC\SQLEXPRESS;Initial Catalog=SuperShopDB;Integrated Security=True");
        private void ItemTableShow()
        {
            con.Open();
            String query = "SELECT * From ItemTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void ItSaveBtn_Click(object sender, EventArgs e)
        {

            if (ItemNameTb.Text == "" || ItemQtyTb.Text == "" || ItemPriceTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ItemTable values ('" + ItemNameTb.Text + "','" + ItemQtyTb.Text + "', '" + ItemPriceTb.Text + "','" + CatCb.SelectedItem.ToString ()+ "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Information Saved Successfully");

                    con.Close();
                    ItemTableShow();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void clear()
        {
            ItemNameTb.Text = "";
            ItemQtyTb.Text = "";
            ItemPriceTb.Text = "";
            CatCb.SelectedIndex = -1;
            key = 0;
        }
        int key = 0;
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNameTb.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            ItemQtyTb.Text = ItemDGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPriceTb.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedItem= ItemDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (ItemNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ItemDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void ItClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void iDeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Product Item to be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Delete From ItemTable where ItemId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Information Deleted Successfully");

                    con.Close();
                    ItemTableShow();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ItEditBtn_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Select Item to be Updated");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update ItemTable set ItemName='" + ItemNameTb.Text + "',ItemQuantity='" + ItemQtyTb.Text + "',ItemPrice='" + ItemPriceTb.Text + "',ItemCategory='" + CatCb.SelectedItem.ToString() + "' where ItemId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Information Updeted Successfully");

                    con.Close();
                    ItemTableShow();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BacktoEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }
    }
}
