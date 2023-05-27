using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksiązka_kucharska
{
    public partial class Form1 : Form
    {
        private List<Kontakt> kontakty;
        public Form1()
        {
            kontakty = new List<Kontakt>();
            InitializeComponent();
        }

        private void ClearForm()
        {
            tboxName.Text = "";
            tboxSurname.Text = "";
            tboxPhone.Text = "";
        }

        private void UpdateContactList()
        {
            listBox1.Items.Clear();
            foreach (Kontakt kontakt in kontakty)
            {
                listBox1.Items.Add(kontakt);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tboxName.Text;
            string surname = tboxSurname.Text;
            string phoneNumber = tboxPhone.Text;
            

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(phoneNumber))
            {
                if (!IsPhoneNumberValid(phoneNumber))
                {
                    MessageBox.Show("Zły format numeru telefonicznego!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Kontakt kontakt = new Kontakt(name, surname, phoneNumber);
                    kontakty.Add(kontakt);
                    ClearForm();
                    UpdateContactList();
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int indeks = listBox1.SelectedIndex;
            if (indeks >= 0)
            {
                string name = tboxName.Text;
                string surname = tboxSurname.Text;
                string phoneNumber = tboxPhone.Text;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(phoneNumber))
                {
                    if (!IsPhoneNumberValid(phoneNumber)) 
                    {
                        MessageBox.Show("Zły format numeru telefonicznego!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        kontakty[indeks].Name = name;
                        kontakty[indeks].Surname = surname;
                        kontakty[indeks].PhoneNumber = phoneNumber;
                        ClearForm();
                        UpdateContactList();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wybierz kontakt do edycji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indeks = listBox1.SelectedIndex;
            if (indeks >= 0)
            {
                kontakty.RemoveAt(indeks);
                ClearForm();
                UpdateContactList();
            }
            else
            {
                MessageBox.Show("Wybierz kontakt do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = listBox1.SelectedIndex;
            if (indeks >= 0)
            {
                Kontakt kontakt = kontakty[indeks];
                tboxName.Text = kontakt.Name;
                tboxSurname.Text = kontakt.Surname;
                tboxPhone.Text = kontakt.PhoneNumber;
            }
        }

        private bool IsPhoneNumberValid(string number)
        {
            if(number.Length != 9) 
            {
                return false;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    char charNumber = (char)number[i];
                    if (char.IsDigit(charNumber)) continue;
                    else return false;
                }
                return true;
            }
            
        }
    }
    public class Kontakt
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public Kontakt(string imie, string surname, string phoneNumber)
        {
            Name = imie;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} - {PhoneNumber}";
        }
    }

}
