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
    public partial class TiketSaya : Form
    {
        public TiketSaya()
        {
            InitializeComponent();
        }

        private void TiketSaya_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IP-0203", "Pelita Air Service", "Juanda", "Soekarno-Hatta", "22-05-2023", "Delay selama 30 menit");
            dataGridView1.Rows.Add("PP-0203", "Pelita Air Service", "Juanda", "Soekarno-Hatta", "22-05-2023", "Delay selama 30 menit");
            dataGridView1.Rows.Add("TU-0203", "Pelita Air Service", "Juanda", "Soekarno-Hatta", "22-05-2023", "Delay selama 30 menit");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomMainForm form = new CustomMainForm();
            form.ShowDialog();
        }
    }
}
