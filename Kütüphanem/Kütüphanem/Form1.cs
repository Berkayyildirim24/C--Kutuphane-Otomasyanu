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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection a= new SqlConnection("Data Source=BERKAY\\SQLEXPRESS; Initial Catalog = Kütüphanem; Integrated Security = True");



        private void Form1_Load(object sender, EventArgs e)
        {
            t1.Enabled = false;
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.kütüphanemDataSet.kitap);
        }
        

        private void btntemizle_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            rt1.Text = "";          
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            a.Open();
            SqlCommand c = new SqlCommand("insert into kitap (kitapad, kitapyazar, sayfasayisi, puan, konusu) values (@p1, @p2, @p3, @p4, @p5)", a );
            c.Parameters.AddWithValue("@p1",t2.Text);
            c.Parameters.AddWithValue("@p2", t3.Text);
            c.Parameters.AddWithValue("@p3", t4.Text);
            c.Parameters.AddWithValue("@p4", t5.Text);
            c.Parameters.AddWithValue("@p5", rt1.Text);

            c.ExecuteNonQuery();
            a.Close();
            MessageBox.Show("Kitap Eklendi!");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int v = dataGridView1.SelectedCells[0].RowIndex;

            t1.Text = dataGridView1.Rows[v].Cells[0].Value.ToString();
            t2.Text = dataGridView1.Rows[v].Cells[1].Value.ToString();
            t3.Text = dataGridView1.Rows[v].Cells[2].Value.ToString();
            t4.Text = dataGridView1.Rows[v].Cells[3].Value.ToString();
            t5.Text = dataGridView1.Rows[v].Cells[5].Value.ToString();
            rt1.Text = dataGridView1.Rows[v].Cells[4].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            a.Open();
            SqlCommand sil = new SqlCommand("delete from kitap where kitapid=@k1", a);
            sil.Parameters.AddWithValue("@k1", t1.Text);
            sil.ExecuteNonQuery();
            a.Close();
            MessageBox.Show("Başarıyla Silindi");


        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {

            a.Open();
            SqlCommand g = new SqlCommand("Update kitap set kitapad = @p1, kitapyazar = @p2, sayfasayisi = @p3, puan = @p4, konusu = @p5 where kitapid=@p6", a);

            g.Parameters.AddWithValue("@p1", t2.Text);
            g.Parameters.AddWithValue("@p2", t3.Text);
            g.Parameters.AddWithValue("@p3", t4.Text);
            g.Parameters.AddWithValue("@p4", t5.Text);
            g.Parameters.AddWithValue("@p5", rt1.Text);
            g.Parameters.AddWithValue("@p6", t1.Text);

            g.ExecuteNonQuery();
           
            a.Close();
            MessageBox.Show("Başarıyla Güncellendi");
        }
    }
}
