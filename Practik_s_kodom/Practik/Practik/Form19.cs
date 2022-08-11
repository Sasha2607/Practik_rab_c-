using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace Practik
{
    public partial class Form19 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form19()
        {
            InitializeComponent();
        }

        void table6()
        {
            dataGridView1.DataSource = DBC.Select("SELECT Id, Name AS Наименование FROM City").DefaultView;
        }

        private void Form19_Activated(object sender, EventArgs e)
        {
         //   string sql = "";
         //   sql = "SELECT * FROM Город";
        //    connect.Open();
       //     SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
        //    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
        //    DataTable DATA = new DataTable();
         //   sda.Fill(DATA);
         //   dataGridView1.DataSource = DATA;

           // connect.Close();
            table6();
            dataGridView1.Columns[0].Visible = false;
        }


        private void Form19_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;


            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           // textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          //  data.C1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          //  data.C2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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
                    if (DBC.Delete("City", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
                    else MessageBox.Show("Произошла ошибка. Возможно, вы пытаетесь удалить запись, которая используется в другой таблице. Действие прервано.");

                }

                if (result == DialogResult.No)
                {

                }

            }


            textBox1.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.Hide();
            form20.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Hide();
            form21.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
       

                string t1 = textBox2.Text;
               // string sql = "";

            //sql = "select * from Марки where Марка_Модель like N'%" + t1 + "%'";


            dataGridView1.DataSource = DBC.Select("SELECT Id, Name AS Наименование FROM City  where  Наименование like  '%" +  t1 + "%'").DefaultView;
           // dataGridView1.Columns[0].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public string type11 = "";

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type11)
            {
                case "Gorod1":
                    data.G1id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.G1name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "Gorod2":
                      data.G2id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.G2name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.C1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.C2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (data.Gorod1 == "1")
            {
                this.Close();
                data.avto = "";
            }

           
        
        }

        private void Form19_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
