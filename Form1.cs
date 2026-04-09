using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace lab3
{
    public partial class Form1 : Form
    {
        private DataTable pracownicyTable;
        public Form1()
        {
            InitializeComponent();
            InitializeTable();
        }
        private void InitializeTable()
        {
            pracownicyTable = new DataTable();
            DataColumn idColumn = new DataColumn("ID", typeof(int));
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            idColumn.AutoIncrementStep = 1;
            pracownicyTable.Columns.Add(idColumn);
            pracownicyTable.Columns.Add("Imie", typeof(string));
            pracownicyTable.Columns.Add("Nazwisko", typeof(string));
            pracownicyTable.Columns.Add("Wiek", typeof(int));
            pracownicyTable.Columns.Add("Stanowisko", typeof(string));
            dataGridView1.DataSource = pracownicyTable;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (AddEmployeForm addForm = new AddEmployeForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var row = pracownicyTable.NewRow();
                    row["Imie"] = addForm.Imie;
                    row["Nazwisko"] = addForm.Nazwisko;
                    row["Wiek"] = addForm.Wiek;
                    row["Stanowisko"] = addForm.Stanowisko;
                    pracownicyTable.Rows.Add(row);
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult odpowiedz = MessageBox.Show("Czy na pewno chcesz usun¹æ zaznaczony wiersz?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (odpowiedz == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                    {
                        if (!selectedRow.IsNewRow)
                        {
                            dataGridView1.Rows.Remove(selectedRow);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono ¿adnego wiersza do usuniêcia.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZapiszCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvContent = "ID,Imie,Nazwisko,Wiek,Stanowisko\n";
                foreach (DataRow row in pracownicyTable.Rows)
                {
                    csvContent += $"{row["ID"]},{row["Imie"]},{row["Nazwisko"]},{row["Wiek"]},{row["Stanowisko"]}\n";
                }
                File.WriteAllText(saveFileDialog.FileName, csvContent);
            }
        }

        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length <= 1)
            {
                MessageBox.Show("Plik jest pusty.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pracownicyTable.Columns["ID"].AutoIncrement = false;
            string[] headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                string[] fields = lines[i].Split(',');

                DataRow row = pracownicyTable.NewRow();

                row["ID"] = int.Parse(fields[0]);
                row["Imie"] = fields[1];
                row["Nazwisko"] = fields[2];
                row["Wiek"] = int.Parse(fields[3]);
                row["Stanowisko"] = fields[4];
                pracownicyTable.Rows.Add(row);
            }
            pracownicyTable.Columns["ID"].AutoIncrement = true;

            if (pracownicyTable.Rows.Count > 0)
            {
                int maxId = pracownicyTable.AsEnumerable().Max(row => row.Field<int>("ID"));
                pracownicyTable.Columns["ID"].AutoIncrementSeed = maxId + 1;
            }
        }


        private void btnOdczyt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadCSVToDataGridView(openFileDialog.FileName);
            }
        }

        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            if (pracownicyTable != null)
            {
                string szukanyTekst = txtSzukaj.Text.Trim();

                if (string.IsNullOrEmpty(szukanyTekst))
                {
                    pracownicyTable.DefaultView.RowFilter = "";
                }
                else
                {
                    string filter = $"Imie LIKE '%{szukanyTekst}%' OR Nazwisko LIKE '%{szukanyTekst}%' OR Stanowisko LIKE '%{szukanyTekst}%'";
                    pracownicyTable.DefaultView.RowFilter = filter;
                }

            }
        }

        private List<Osoba> PobierzListeOsob()
        {
            List<Osoba> lista = new List<Osoba>();

            foreach (DataRow row in pracownicyTable.Rows)
            {
                Osoba o = new Osoba();
                o.ID = Convert.ToInt32(row["ID"]);
                o.Imie = row["Imie"]?.ToString() ?? "";
                o.Nazwisko = row["Nazwisko"]?.ToString() ?? "";
                o.Wiek = Convert.ToInt32(row["Wiek"]);
                o.Stanowisko = row["Stanowisko"]?.ToString() ?? "";

                lista.Add(o);
            }

            return lista;
        }
        private void btnZapiszXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Osoba> dane = PobierzListeOsob();
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Osoba>));

                    using (TextWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        serializer.Serialize(writer, dane);
                    }

                    MessageBox.Show("Zapisano pomyœlnie do XML", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d zapisu: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnZapiszJSON_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Osoba> dane = PobierzListeOsob();

                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    string jsonString = JsonSerializer.Serialize(dane, options);
                    File.WriteAllText(saveFileDialog.FileName, jsonString);

                    MessageBox.Show("Zapisano pomyœlnie do JSON!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d zapisu: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
