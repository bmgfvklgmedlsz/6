using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form3 : Form
    {
        public ModelEF model {get;set;}
        public Companies c1 { get;set;}

  

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cityTextBox.Text =  c1.City;
            iDTextBox.Text = c1.ID.ToString();
            nameTextBox.Text = c1.Name;
            tradeTextBox.Text = c1.Trade.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.City = cityTextBox.Text;
            c1.ID = iDTextBox.Text;
            c1.Name = nameTextBox.Text;
            c1.Trade = tradeTextBox.Text;

            try 
            {
                model.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
