namespace ksiązka_kucharska
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblImie = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(13, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(276, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "KSIĄŻKA TELEFONICZNA";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(401, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 381);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Atualizuj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(260, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(42, 111);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(26, 13);
            this.lblImie.TabIndex = 6;
            this.lblImie.Text = "Imię";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(98, 108);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(161, 20);
            this.tboxName.TabIndex = 7;
            // 
            // tboxSurname
            // 
            this.tboxSurname.Location = new System.Drawing.Point(98, 149);
            this.tboxSurname.Name = "tboxSurname";
            this.tboxSurname.Size = new System.Drawing.Size(161, 20);
            this.tboxSurname.TabIndex = 9;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(42, 152);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(53, 13);
            this.lbSurname.TabIndex = 8;
            this.lbSurname.Text = "Nazwisko";
            // 
            // tboxPhone
            // 
            this.tboxPhone.Location = new System.Drawing.Point(98, 191);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(161, 20);
            this.tboxPhone.TabIndex = 11;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(42, 194);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 13);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "by Jonasz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tboxSurname);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Książka telefoniczna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
    }
}

