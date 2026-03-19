using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class AddEmployeForm : Form
    {
        public string Imie  => txtImie.Text;
        public string Nazwisko => txtNazwisko.Text;
        public int Wiek => (int)numWiek.Value;
        public string Stanowisko => txtStanowisko.Text;
        public AddEmployeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
