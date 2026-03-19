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
        public string Imie => txtImie.Text;
        public string _Nazwisko => txtNazwisko.Text;
        public int _Wiek => (int)numWiek.Value;
        public string Stanowisko => cmbStanowisko.SelectedItem?.ToString() ?? "";

        public AddEmployeForm()
        {
            InitializeComponent();
            cmbStanowisko.Items.AddRange(new string[] { "Kierownik", "Programista", "Analityk", "Tester" });
            cmbStanowisko.SelectedIndex = 0;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Imie) || string.IsNullOrWhiteSpace(_Nazwisko))
            {
                MessageBox.Show("Imię i nazwisko nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {

        }
    }
}