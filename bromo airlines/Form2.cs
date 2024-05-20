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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add("IP-7869", "Pelita Air", "Jaunda", "Soekarno-Hatta", "53577", "24-03-2023", "15.10 - 20.30", "Beli tiket");
            dataGridView1.Rows.Add("UI-7789", "lion Air", "Jaunda", "Soekarno-Hatta", "75457", "30-03-2023", "08.10 - 20.30", "Beli tiket");
            dataGridView1.Rows.Add("JP-4569", "Pelita Air", "Jaunda", "Soekarno-Hatta", "54566", "12-03-2023", "01.10 - 20.30", "Beli tiket");
            dataGridView1.Rows.Add("PP-6769", "Lion Air", "Jaunda", "Soekarno-Hatta", "88685", "17-03-2023", "19.10 - 20.30", "Beli tiket");
            dataGridView1.Rows.Add("TP-7239", "Jaunda Air", "Jaunda", "Soekarno-Hatta", "97868", "29-03-2023", "20.10 - 20.30", "Beli tiket");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomMainForm form = new CustomMainForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            BeliTiket form = new BeliTiket();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomMainForm form = new CustomMainForm();
            form.ShowDialog();
        }
    }
}
