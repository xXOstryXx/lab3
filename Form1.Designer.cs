namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnZapisz = new Button();
            btnOdczyt = new Button();
            btnDodaj = new Button();
            btnUsun = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(19, 264);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(153, 42);
            btnZapisz.TabIndex = 0;
            btnZapisz.Text = "Zapisz do .csv";
            btnZapisz.UseVisualStyleBackColor = true;
            // 
            // btnOdczyt
            // 
            btnOdczyt.Location = new Point(512, 264);
            btnOdczyt.Name = "btnOdczyt";
            btnOdczyt.Size = new Size(153, 42);
            btnOdczyt.TabIndex = 1;
            btnOdczyt.Text = "Odczyt z .csv";
            btnOdczyt.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(610, 42);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(610, 92);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(75, 23);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 215);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 360);
            Controls.Add(dataGridView1);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Controls.Add(btnOdczyt);
            Controls.Add(btnZapisz);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnZapisz;
        private Button btnOdczyt;
        private Button btnDodaj;
        private Button btnUsun;
        private DataGridView dataGridView1;
    }
}
