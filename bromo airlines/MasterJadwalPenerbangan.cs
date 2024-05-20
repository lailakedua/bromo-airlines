using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromo_airlines
{
    public partial class MasterJadwalPenerbangan : Form
    {
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)

        {
            dataGridView1.Rows.Add("ID-7518", "Juada", "Halim Perdana Kusuma","Batik Air", "30-01-23", "19:55", "01 jam 45 menit", "98786");
            dataGridView1.Rows.Add("IP-0203", "Surabaya", "Juanda", "Soekarno", "Pelita Air", "39-12-20223", "01 jam 8 menit", "767867");
            dataGridView1.Rows.Add("IP-9903", "Malang", "Juanda", "Soekarno", "Pelita Air", "39-12-20223", "01 jam 8 menit", "767867");
            dataGridView1.Rows.Add("IP-0203", "Bekasi", "Juanda", "Soekarno", "Pelita Air", "39-12-20223", "01 jam 8 menit", "767867");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterMaskapaiValid form = new MasterMaskapaiValid();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterKodePromo form = new MasterKodePromo();
                form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UbahStatusPenerbangan form = new UbahStatusPenerbangan();
            form.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasterKodePromo form = new MasterKodePromo();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UbahStatusPenerbangan form = new UbahStatusPenerbangan();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
