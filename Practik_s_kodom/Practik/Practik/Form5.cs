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
    public partial class Form5 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");

       // SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");


        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
           form10.Hide();
            form10.Show();


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;
            }
            //LoadData();
        }

        public void LoadData()
        {
  
            
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11. Hide();
            form11.Show();
        }  

        private void Form5_Activated(object sender, EventArgs e)
        {
            table();
        }

        void table()
        {
            dataGridView1.DataSource = DBC.Select("SELECT Id,Make_Model As 'Марка-Модель' FROM Make ").DefaultView;
            dataGridView1.Columns[0].Visible = false;

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
                   if (DBC.Delete("Make", "Id='" + textBox1.Text + "'"))MessageBox.Show("Удалено") ; 
                    else MessageBox.Show("Произошла ошибка. Возможно, вы пытаетесь удалить запись, которая используется в другой таблице. Действие прервано.");
          
                }

                if (result == DialogResult.No)
                {

                }

            }


            textBox1.Text = "";
        }

        public string type = "";

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
    

                string t1 = textBox2.Text;
              //  string sql = "";

                dataGridView1.DataSource = DBC.Select("SELECT Id,Make_Model As 'Марка-Модель' FROM Make where Make_Model like '%" + t1 + "%' ").DefaultView;
                dataGridView1.Columns[0].Visible = false;
               
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case "marka":
                    data.A2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data.A2id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case "name":
                    data.A3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    data.A3id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case "Mark1":
                    data.Mark1id1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.Mark1name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.A10 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.A11 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            //data.E02 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //data.E01 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            if (data.avto == "1")
            {
                this.Close();
                data.avto = "";
            }
            if (data.Mark1 == "1")
            {
                this.Close();
                data.Mark1 = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DBC.SaveExcel("SELECT Id,Make_Model As Марка_Модель FROM Make ");
        }
    }
}
