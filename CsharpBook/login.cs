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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter da;


        public login()




        {


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Firstpage().Show();
            this.Hide();
        }

        
        private void loginlbl_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Csharpusers Where Username = '" + usernametxtbx.Text + "'and  Password = '" + psstxtbx.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)

            {
                new Firstpage().Show();
                this.Hide();
            }

            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Not valid";

            }

            





        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Admin_Login Where Username = '" + usernametxtbx.Text + "'and  Password = '" + psstxtbx.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)

            {
                new Admin().Show();
                this.Hide();
            }

            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Not valid User";

            }
        }
    }
}
