using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Connection_With_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-50BB7SC\SQLEXPRESS;Initial Catalog=apoorva;Integrated Security=True");
            try
            {
                con.Open();

                MessageBox.Show("Connection Open");
                con.Close();
            }
            catch
            {

                MessageBox.Show("Connection Cant open");


            }
            }

        }
    }