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
using System.Configuration;

namespace CsharpBook
{
    public partial class Admin : Form

    {
      
        public Admin()

        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(dbString);
            

            con.Open();
            String Query = "SELECT * FROM Csharpusers";
            SqlDataAdapter SDA = new SqlDataAdapter(Query,con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            



        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            
        }


        
    }
}
