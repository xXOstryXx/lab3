namespace lab3
{
    partial class AddEmployeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            numWiek = new NumericUpDown();
            cmbStanowsiko = new ComboBox();
            btnZatwierdz = new Button();
            btnAnuluj = new Button();
            Imię = new Label();
            Nazwisko = new Label();
            Wiek = new Label();
            Stanowsiko = new Label();
            ((System.ComponentModel.ISupportInitialize)numWiek).BeginInit();
            SuspendLayout();
            // 
            // txtImie
            // 
            txtImie.Location = new Point(57, 28);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 0;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(57, 69);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(100, 23);
            txtNazwisko.TabIndex = 1;
            // 
            // numWiek
            // 
            numWiek.Location = new Point(57, 111);
            numWiek.Name = "numWiek";
            numWiek.Size = new Size(100, 23);
            numWiek.TabIndex = 2;
            numWiek.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cmbStanowsiko
            // 
            cmbStanowsiko.FormattingEnabled = true;
            cmbStanowsiko.Location = new Point(57, 152);
            cmbStanowsiko.Name = "cmbStanowsiko";
            cmbStanowsiko.Size = new Size(100, 23);
            cmbStanowsiko.TabIndex = 3;
            cmbStanowsiko.Text = "Stanowisko";
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.Location = new Point(57, 202);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(75, 23);
            btnZatwierdz.TabIndex = 4;
            btnZatwierdz.Text = "Zatwierdź";
            btnZatwierdz.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(173, 202);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(75, 23);
            btnAnuluj.TabIndex = 5;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // Imię
            // 
            Imię.AutoSize = true;
            Imię.Location = new Point(195, 31);
            Imię.Name = "Imię";
            Imię.Size = new Size(30, 15);
            Imię.TabIndex = 6;
            Imię.Text = "Imię";
            Imię.Click += label1_Click;
            // 
            // Nazwisko
            // 
            Nazwisko.AutoSize = true;
            Nazwisko.Location = new Point(182, 72);
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Size = new Size(57, 15);
            Nazwisko.TabIndex = 7;
            Nazwisko.Text = "Nazwisko";
            // 
            // Wiek
            // 
            Wiek.AutoSize = true;
            Wiek.Location = new Point(192, 113);
            Wiek.Name = "Wiek";
            Wiek.Size = new Size(33, 15);
            Wiek.TabIndex = 8;
            Wiek.Text = "Wiek";
            // 
            // Stanowsiko
            // 
            Stanowsiko.AutoSize = true;
            Stanowsiko.Location = new Point(182, 155);
            Stanowsiko.Name = "Stanowsiko";
            Stanowsiko.Size = new Size(67, 15);
            Stanowsiko.TabIndex = 9;
            Stanowsiko.Text = "Stanowisko";
            // 
            // AddEmployeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 259);
            Controls.Add(Stanowsiko);
            Controls.Add(Wiek);
            Controls.Add(Nazwisko);
            Controls.Add(Imię);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZatwierdz);
            Controls.Add(cmbStanowsiko);
            Controls.Add(numWiek);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Name = "AddEmployeForm";
            Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)numWiek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImie;
        private TextBox txtNazwisko;
        private NumericUpDown numWiek;
        private ComboBox cmbStanowsiko;
        private Button btnZatwierdz;
        private Button btnAnuluj;
        private Label Imię;
        private Label Nazwisko;
        private Label Wiek;
        private Label Stanowsiko;
    }
}