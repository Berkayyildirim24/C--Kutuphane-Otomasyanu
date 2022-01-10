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

namespace Kütüphanem
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        SqlConnection a = new SqlConnection("Data Source=BERKAY\\SQLEXPRESS; Initial Catalog = Kütüphanem; Integrated Security = True");



        private void btn1_Click(object sender, EventArgs e)
        {

            a.Open();
            SqlCommand h = new SqlCommand("select * from kullanici where adi=@p1 and sifre=@p2 ", a);
            h.Parameters.AddWithValue("@p1", t1.Text);
            h.Parameters.AddWithValue("@p2", t2.Text);
            SqlDataReader dr = h.ExecuteReader();
            if(dr.Read())
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
                
            }
            else 
                    {

                MessageBox.Show("Hatalı Giriş!");
            }
            
            a.Close();


        }
    }
}
