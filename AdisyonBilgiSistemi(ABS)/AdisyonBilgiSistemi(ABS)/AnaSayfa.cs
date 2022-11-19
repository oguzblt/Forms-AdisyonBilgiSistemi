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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            DialogResult msj;
            msj = MessageBox.Show("Program kapatılsın mı ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msj == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            KasaIslemleri kasa = new KasaIslemleri();
            kasa.ShowDialog();
            this.Close();
        }

        private void btnmasa1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masa001 ms1 = new Masa001();
            ms1.ShowDialog();
            this.Close();
        }

        private void btnmasa2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masa002 ms2 = new Masa002();
            ms2.ShowDialog();
            this.Close();
        }

        private void btnmasa3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masa003 ms3 = new Masa003();
            ms3.ShowDialog();
            this.Close();
        }

        private void btnmasa4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masa004 ms4 = new Masa004();
            ms4.ShowDialog();
            this.Close();
        }

        private void btnmasa5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masa005 ms5 = new Masa005();
            ms5.ShowDialog();
            this.Close();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
