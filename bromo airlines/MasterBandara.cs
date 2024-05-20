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
    public partial class MasterBandara : Form
    {
        public MasterBandara()
        {
            InitializeComponent();
        }

        private void ubahStatusPenerbangaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("abresso", "MLG", "Malang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Abdul", "RSK", "Malang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Yani", "YTG", "Malang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Adisumarno", "LLG", "Malang", "Indonesia", "2", "Semarang");
        }

        private void masterJadwalPenerbanganToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void masterMaskapaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
           MasterMaskapaiValid form = new MasterMaskapaiValid();
                form.ShowDialog();
        }

        private void ubahJadwalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterKodePromo form = new MasterKodePromo();   
            form.ShowDialog();
        }

        private void ubahJadwalToolStripMenuItem1_Click(object sender, EventArgs e)
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
    }
}