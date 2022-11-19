using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdisyonBilgiSistemi_ABS_
{
    public partial class KasaIslemleri : Form
    {
        public KasaIslemleri()
        {
            InitializeComponent();
        }
        public static ABSDataSetTableAdapters.KasaIslemlerTableAdapter ks = new ABSDataSetTableAdapters.KasaIslemlerTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.ShowDialog();
            this.Close();
        }

        private void KasaIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ks.GetData();
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            lblsonuc.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ks.GetData();
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            lblsonuc.Text = toplam.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ks.GetDataKasaTarih(Convert.ToDateTime(maskedTextBox1.Text), Convert.ToDateTime(maskedTextBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ks.GetDataKasaMasaAd(textBox1.Text);
        }
    }
}
