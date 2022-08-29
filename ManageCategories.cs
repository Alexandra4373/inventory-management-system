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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace management_system
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HER EXCELLENCY\OneDrive\Documents\inventory.db.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl(" + catID.Text + " , " + catName.Text + "," + catDesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Category succesfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }


        private void populate(SqlDataAdapter sqlDataAdapter) 
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter:sqlDataAdapter);
            DataTable ds = new DataTable();
            int v = sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = DataBindings[0];
            Con.Close();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        { }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            catName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            catDesc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(catID.Text =="")
                {
                    MessageBox.Show("Select the category you want to delete");
                }

                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId=" + catID.Text + "CatDesc=" +catDesc.Text+ "CatName=" +catName.Text+ "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully deleted");
                    Con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (catID.Text == "" || catName.Text == "" || catDesc.Text == "")
                {
                    MessageBox.Show("Message Information");
                }


                else
                {
                    Con.Open();
                    string query = "dupdate to CategoryTbl where CatId=" + catID.Text + "CatDesc=" + catDesc.Text + "CatName=" + catName.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully updated");
                    Con.Close();
                    populate();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
