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

namespace DatabaseConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SqlString;
            
            SqlConnection conn;

            //Connection string...
            SqlString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shihab Rayhan\source\repos\DatabaseConnect\DatabaseConnect\DatabaseConnect.mdf;Integrated Security=True";

            //Creeate connection
            conn = new SqlConnection(SqlString);


            try {
                conn.Open();
                MessageBox.Show("Successfully Connected!");

            } catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
