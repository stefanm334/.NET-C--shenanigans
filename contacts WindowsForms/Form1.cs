using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Contact[] phoneBook = new Contact[1];

        public Form1()
        {
            InitializeComponent();
        }

        private void Write( Contact obj)
        {
            StreamWriter sw = new StreamWriter("Contacts.txt");
            sw.WriteLine(phoneBook.Length + 1);
            sw.WriteLine(obj.FirstName);
            sw.WriteLine(obj.LastName);
            sw.WriteLine(obj.PhoneNumber);

            for (int x =0; x< phoneBook.Length; x++)
            {
                sw.WriteLine(phoneBook[x].FirstName);
                sw.WriteLine(phoneBook[x].LastName);
                sw.WriteLine(phoneBook[x].PhoneNumber);
            }

            sw.Close();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Contacts.txt");
            phoneBook = new Contact[Convert.ToInt32(sr.ReadLine())];

            for (int x = 0; x < phoneBook.Length; x++)
            {
                phoneBook[x] = new Contact();
                phoneBook[x].FirstName = sr.ReadLine();
                phoneBook[x].LastName = sr.ReadLine();
                phoneBook[x].PhoneNumber = sr.ReadLine();

            }

            sr.Close();

        }


        private void Display()
        {
            listBox.Items.Clear();

            for (int x = 0; x < phoneBook.Length; x++)
            {
                listBox.Items.Add(phoneBook[x].ToString());
            }
        }


        private void ClearForm()
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;

        }


        private void addToContacts_Click(object sender, EventArgs e)
        {
            Contact obj = new Contact();
            obj.FirstName = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.PhoneNumber = txtPhoneNumber.Text;

            Write(obj);
            Read();
            Display();
            ClearForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            Display();
        }
    }
}
