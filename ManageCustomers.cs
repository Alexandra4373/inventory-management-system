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

namespace management_system
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("@Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\HER EXCELLENCY\\OneDrive\\Documents\\inventory.db.mdf\";Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                con.Open();
                string query = "select * from  CustomerTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                //SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var da = new DataSet();
               // da.Fill(ds);
               // dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into CustomersTbl(" + CusID.Text + " , " + CusName.Text + "," + CusPhone.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer succesfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
