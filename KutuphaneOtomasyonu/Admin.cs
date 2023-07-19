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
        public Admin(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
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
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_ID.Text), txt_FirstName.Text, txt_LastName.Text, maskedTextBox1.Text, txt_Username.Text, txt_Password.Text, txt_Authority.Text);
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
            fillText();
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(txt_ID.Text,txt_FirstName.Text,txt_LastName.Text,maskedTextBox1.Text,txt_Username.Text,txt_Password.Text,txt_Authority.Text);
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
    }
}
