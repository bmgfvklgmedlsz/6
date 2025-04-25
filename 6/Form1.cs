using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        ModelEF model = new ModelEF();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            companiesBindingSource.DataSource = model.Companies.ToList();
          

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.model = model;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                companiesBindingSource.DataSource = model.Companies.ToList();
            }
        }
    }
}
