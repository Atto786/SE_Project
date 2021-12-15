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

namespace Mockup
{
    public partial class ManageUserInfo : Form
    {
        public ManageUserInfo()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=RAHATXLAPTOP;Initial Catalog=SE;Integrated Security=True";

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select *FROM Usser";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into Usser (id,name,phone, gender, country) values ('" + textBox2.Text + "', '" + textBox1.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "' )";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("done!");


                }
                else { MessageBox.Show("Error!"); }
                con.Close();
            }
            else { MessageBox.Show("Error!"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("update Usser set name=@name, phone=@pn, gender=@gender, country=@cn where id=@id", connection);


            connection.Open();
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@pn", textBox4.Text);
            cmd.Parameters.AddWithValue("@gender", textBox5.Text);
            cmd.Parameters.AddWithValue("@cn", textBox6.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Update successful !");

            }

            else
            {
                MessageBox.Show("Update failed!", "Enter valide information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("delete Usser where id=@id", connection);


            connection.Open();
            cmd.Parameters.AddWithValue("@id", textBox2.Text);


            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {

                MessageBox.Show("DELETED !");
                textBox2.Clear();

            }

            else
            {
                MessageBox.Show("Delete failed!", "Enter valide information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
