using KutuphaneOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName, passWord = "";
            userName = txt_username.Text;
            passWord = txt_password.Text;
            bool check = false;

            foreach (Person person in persons)
            {
                if (userName.ToLower() == person.getusername() && passWord == person.getpassword() && person.authority == "admin")
                {
                    Admin admin = new Admin(persons, books);
                    admin.Show();
                    this.Hide();
                    check = true;
                    break;
                }
                else if (userName.ToLower() == person.getusername() && passWord == person.getpassword() && person.authority == "member")
                {
                    Member member = new Member();
                    member.Show();
                    this.Hide();
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Hatalı giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            persons.Add(new Person(1, "Alper", "OZ", DateTime.Now, "alper", "1", "admin"));
            persons.Add(new Person(2, "Çağlar", "OZ", DateTime.Now, "caglar", "2", "member"));
            persons.Add(new Person(3, "Can", "Şahin", DateTime.Now, "caggnn", "3", "member"));
            persons.Add(new Person(4, "Rumeysa", "Karataş", DateTime.Now, "rums", "4", "member"));

            books.Add(new Book(1, "11 Dakika", "Jasa Soremasa", "Fransızca", "Kronik", "Roman", 247, 180, 2001));
            books.Add(new Book(2, "Kürk Mantolu Madonna", "Sabahattin Ali", "Türkçe", "Yapı Kredi", "Roman", 250, 194, 1994));
            books.Add(new Book(3, "Fahrenheit 451", "Ray Bradbury", "İngilizce", "Kronik", "Fantastik Roman", 125, 303, 2012));
            books.Add(new Book(4, "Dune", "Frank Herbert", "İngilizce", "Destek", "Fantastik Kurgu", 1000, 603, 2018));
        }
    }
}
