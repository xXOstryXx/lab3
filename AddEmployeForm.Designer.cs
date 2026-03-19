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
            cmbStanowisko = new ComboBox();
            btnZatwierdz = new Button();
            btnAnuluj = new Button();
            LImię = new Label();
            LNazwisko = new Label();
            LWiek = new Label();
            LStanowsiko = new Label();
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
            numWiek.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numWiek.Name = "numWiek";
            numWiek.Size = new Size(100, 23);
            numWiek.TabIndex = 2;
            numWiek.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Location = new Point(57, 152);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(100, 23);
            cmbStanowisko.TabIndex = 3;
            cmbStanowisko.Text = "Stanowisko";
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.Location = new Point(57, 202);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(75, 23);
            btnZatwierdz.TabIndex = 4;
            btnZatwierdz.Text = "Zatwierdź";
            btnZatwierdz.UseVisualStyleBackColor = true;
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(173, 202);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(75, 23);
            btnAnuluj.TabIndex = 5;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // LImię
            // 
            LImię.AutoSize = true;
            LImię.Location = new Point(195, 31);
            LImię.Name = "LImię";
            LImię.Size = new Size(30, 15);
            LImię.TabIndex = 6;
            LImię.Text = "Imię";
            // 
            // LNazwisko
            // 
            LNazwisko.AutoSize = true;
            LNazwisko.Location = new Point(182, 72);
            LNazwisko.Name = "LNazwisko";
            LNazwisko.Size = new Size(57, 15);
            LNazwisko.TabIndex = 7;
            LNazwisko.Text = "Nazwisko";
            // 
            // LWiek
            // 
            LWiek.AutoSize = true;
            LWiek.Location = new Point(192, 113);
            LWiek.Name = "LWiek";
            LWiek.Size = new Size(33, 15);
            LWiek.TabIndex = 8;
            LWiek.Text = "Wiek";
            // 
            // LStanowsiko
            // 
            LStanowsiko.AutoSize = true;
            LStanowsiko.Location = new Point(182, 155);
            LStanowsiko.Name = "LStanowsiko";
            LStanowsiko.Size = new Size(67, 15);
            LStanowsiko.TabIndex = 9;
            LStanowsiko.Text = "Stanowisko";
            // 
            // AddEmployeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 259);
            Controls.Add(LStanowsiko);
            Controls.Add(LWiek);
            Controls.Add(LNazwisko);
            Controls.Add(LImię);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZatwierdz);
            Controls.Add(cmbStanowisko);
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
        private ComboBox cmbStanowisko;
        private Button btnZatwierdz;
        private Button btnAnuluj;
        private Label LImię;
        private Label LNazwisko;
        private Label LWiek;
        private Label LStanowsiko;
    }
}