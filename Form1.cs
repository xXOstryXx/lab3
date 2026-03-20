using System.Data;

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
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow Row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(Row);
                }
            }
            else
            {
                MessageBox.Show("Wybierz ca³y wiersz do usuniêcia", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|All files (*.*)|*.*";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
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
            DataTable csvTable = new DataTable();
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                csvTable.Columns.Add(header);
            }
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                DataRow row = csvTable.NewRow();
                for (int j = 0; j < headers.Length; j++)
                {
                    row[j] = fields[j];
                }
                pracownicyTable.Rows.Add(row);
                dataGridView1.DataSource = csvTable;
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
    }
}
