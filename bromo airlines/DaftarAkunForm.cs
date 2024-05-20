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
    public partial class DaftarAkunForm : Form
    {
        public DaftarAkunForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           AdminMainFormValid formValid = new AdminMainFormValid();
            formValid.ShowDialog();
           



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();


        }

        private void DaftarAkunForm_Load(object sender, EventArgs e)
        {

        }
    }
}
