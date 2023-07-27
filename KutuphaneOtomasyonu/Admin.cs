using KutuphaneOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Admin : Form
    {
        List<Person> persons;
        List<Book> books;
        public Admin(List<Person> persons, List<Book> books)
        {
            InitializeComponent();
            this.persons = persons;
            this.books = books;
        }

        private void groupBox_Member_Enter(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            foreach (Person person in this.persons)
            {
                dataGridView1.Rows.Add(person.getId(), person.getFirstName(), person.getLastName(), person.getAddedTime(), person.getusername(), person.getpassword(), person.getauthority());
            }

            foreach (Book book in this.books)
            {
                dataGridView2.Rows.Add(book.getBOOKID(), book.getBookName(), book.getBookWriter(), book.getLanguage(), book.getPublisher(), book.getType(), book.getPiece(), book.getPageNumber(), book.getPublishYear());
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_ID.Text), txt_FirstName.Text, txt_LastName.Text, maskedTextBox1.Text, txt_Username.Text, txt_Password.Text, txt_Authority.Text, txt_piece.Text);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void fillText()
        {
            txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_FirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_LastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Username.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Password.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Authority.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillText();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id =txt_ID.Text;
            string firstName =txt_FirstName.Text;
            string lastName =txt_LastName.Text;
            string username =txt_Username.Text;
            string date = maskedTextBox1.Text;
            string password =txt_Password.Text;
            string authority =txt_Authority.Text;
            //fillText();
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, firstName, lastName, username, password, authority, date);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_Member.Controls.Count; i++)
            {
                if (groupBox_Member.Controls[i] is TextBox || groupBox_Member.Controls[i] is MaskedTextBox)
                {
                    groupBox_Member.Controls[i].Text = string.Empty;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_bookadd_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_bookid.Text, txt_bookname.Text, txt_bookwriter.Text, txt_language.Text, txt_type.Text, txt_publisher.Text,txt_pagenumber.Text, maskedTextBox2.Text);
        }

        private void btn_bookdelete_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_bookupdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_bookid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_bookname.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_bookwriter.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_language.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_publisher.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString() ;
            txt_type.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_piece.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_pagenumber.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            maskedTextBox2.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
