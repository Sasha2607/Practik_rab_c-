using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik
{
    public partial class Form34 : Form
    {

        db DBC = new db();


        public Form34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form35 form35 = new Form35();
            form35.Hide();
            form35.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form36 form36 = new Form36();
            form36.Hide();
            form36.Show();
        }

        private void Form34_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBC.Select("SELECT Id,Last_name As Фамилия,Name AS Имя, Middle_name AS Отчество,Phone_number AS Номер_Телефона FROM Client ").DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;
            }
        }

        public string type = "";


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case "Client":

                    //   data.R6 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    data.clientName3 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    data.clientName2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    data.clientName1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data.clientFIOID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
            }


            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.clientID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.client1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            data.client2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            data.client3 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            data.client4 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (data.Client == "1")
            {
                this.Close();
                data.Client = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {

                DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DBC.Delete("Transportations", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
                    else MessageBox.Show("Произошла ошибка. Возможно, вы пытаетесь удалить запись, которая используется в другой таблице. Действие прервано.");

                }

                if (result == DialogResult.No)
                {

                }

            }


            textBox1.Text = "";
        }
    }
}
