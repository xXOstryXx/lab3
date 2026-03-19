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
            
        }
    }
}
