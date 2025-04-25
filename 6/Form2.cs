using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _6
{
    public partial class Form2 : Form
    {
        public ModelEF model { get; set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(iDTextBox.Text, out int id)
                || (!int.TryParse(tradeTextBox.Text, out int trade)))
            {
                MessageBox.Show("Неверный формат данных - " + iDTextBox.Text ,tradeTextBox.Text);
                return;
            }
            if (cityTextBox == null && nameTextBox == null)
            {
                MessageBox.Show("Необходимо присвоить значение!");
                return;
            }

            Companies c1 = new Companies();
            c1.City = cityTextBox.Text;
            c1.ID = id;
            c1.Name = nameTextBox.Text;
            c1.Trade = trade;
            model.Companies.Add(c1);
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
    }
}
