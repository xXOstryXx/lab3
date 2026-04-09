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
            btnZapiszCSV = new Button();
            btnOdczyt = new Button();
            btnDodaj = new Button();
            btnUsun = new Button();
            dataGridView1 = new DataGridView();
            txtSzukaj = new TextBox();
            lSzukaj = new Label();
            btnZapiszXML = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnZapiszCSV
            // 
            btnZapiszCSV.Location = new Point(19, 293);
            btnZapiszCSV.Name = "btnZapiszCSV";
            btnZapiszCSV.Size = new Size(153, 42);
            btnZapiszCSV.TabIndex = 0;
            btnZapiszCSV.Text = "Zapisz do .csv";
            btnZapiszCSV.UseVisualStyleBackColor = true;
            btnZapiszCSV.Click += btnZapiszCSV_Click;
            // 
            // btnOdczyt
            // 
            btnOdczyt.Location = new Point(512, 293);
            btnOdczyt.Name = "btnOdczyt";
            btnOdczyt.Size = new Size(153, 42);
            btnOdczyt.TabIndex = 1;
            btnOdczyt.Text = "Odczyt z .csv";
            btnOdczyt.UseVisualStyleBackColor = true;
            btnOdczyt.Click += btnOdczyt_Click;
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
            // txtSzukaj
            // 
            txtSzukaj.Location = new Point(63, 263);
            txtSzukaj.Name = "txtSzukaj";
            txtSzukaj.Size = new Size(100, 23);
            txtSzukaj.TabIndex = 5;
            txtSzukaj.TextChanged += txtSzukaj_TextChanged;
            // 
            // lSzukaj
            // 
            lSzukaj.AutoSize = true;
            lSzukaj.Location = new Point(19, 266);
            lSzukaj.Name = "lSzukaj";
            lSzukaj.Size = new Size(40, 15);
            lSzukaj.TabIndex = 6;
            lSzukaj.Text = "Szukaj";
            // 
            // btnZapiszXML
            // 
            btnZapiszXML.Location = new Point(178, 293);
            btnZapiszXML.Name = "btnZapiszXML";
            btnZapiszXML.Size = new Size(153, 42);
            btnZapiszXML.TabIndex = 7;
            btnZapiszXML.Text = "Zapisz do .xml";
            btnZapiszXML.UseVisualStyleBackColor = true;
            btnZapiszXML.Click += btnZapiszXML_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 360);
            Controls.Add(btnZapiszXML);
            Controls.Add(lSzukaj);
            Controls.Add(txtSzukaj);
            Controls.Add(dataGridView1);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Controls.Add(btnOdczyt);
            Controls.Add(btnZapiszCSV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZapiszCSV;
        private Button btnOdczyt;
        private Button btnDodaj;
        private Button btnUsun;
        private DataGridView dataGridView1;
        private TextBox txtSzukaj;
        private Label lSzukaj;
        private Button btnZapiszXML;
    }
}
