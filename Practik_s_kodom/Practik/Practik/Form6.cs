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
    public partial class Form6 : Form
    {
        db DBC = new db();

        public Form6(Form2 form5)
        {
            InitializeComponent();
        //    if (form5.a == 1) 
         //   {
        //        button3.Visible=false;
          //  }
            

        
        }


        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        
        public Form6()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // form7.Show();

          
            Form7 form7 = new Form7();
            form7.Hide();
            form7.Show();
      
         //   form7.ShowDialog();
           // this.Close();
            
            

            //Form7 Form6 = new Form7(this);
           // Form6.Show();
 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Hide();
            form8.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            if (data.box == "Пользователь")
            {
                button6.Visible = false;
   }

          
          

        }
        public void LoadData()
        {
     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Hide();
            form9.Show();
      
        
        }

       void table5()
        {
            /*
         
            */
        

            //    dataGridView1.DataSource = DBC.Select("SELECT Id,  Last_name AS Фамилия,Name AS Имя,Middle_name AS Отчество, Age AS Возраст, DATEDIFF(year,Age,getDate()) AS age, Phone_number AS номер_телефона FROM Drivers").DefaultView;
            dataGridView1.DataSource = DBC.Select("SELECT Id, Last_name AS Фамилия,Name AS Имя, Middle_name AS Отчество,(strftime('%Y', 'now') - strftime('%Y', Age)) - (strftime('%m-%d', 'now') < strftime('%m-%d', Age)) AS Возраст,Phone_number AS 'Номер телефона' FROM Drivers").DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }
        

        private void Form6_Activated(object sender, EventArgs e)
        {
            
            table5();
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
                    if (DBC.Delete("Drivers", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
                    else MessageBox.Show("Произошла ошибка. Возможно, вы пытаетесь удалить запись, которая используется в другой таблице. Действие прервано.");

                }

                if (result == DialogResult.No)
                {

                }

            }


            textBox1.Text = "";
        }

        public string type12 = "";

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          

                string t1 = textBox2.Text;
            //  string sql = "";
           
            dataGridView1.DataSource = DBC.Select("SELECT Id, Last_name AS Фамилия,Name AS Имя, Middle_name AS Отчество,(strftime('%Y', 'now') - strftime('%Y', Age)) - (strftime('%m-%d', 'now') < strftime('%m-%d', Age)) AS Возраст,Phone_number AS 'Номер телефона' FROM Drivers where Фамилия like '%" + t1 + "%'").DefaultView;
        
            
            
            //  dataGridView1.DataSource = DBC.Select("SELECT Id,Last_name AS Фамилия,Name AS Имя,Middle_name AS Отчество,Age AS Возраст,Phone_number AS номер_телефона FROM Drivers where Фамилия like '%" + t1 + "%'").DefaultView;
            dataGridView1.Columns[0].Visible = false;
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

                string t2 = textBox3.Text;
                //string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Id, Last_name AS Фамилия,Name AS Имя, Middle_name AS Отчество,(strftime('%Y', 'now') - strftime('%Y', Age)) - (strftime('%m-%d', 'now') < strftime('%m-%d', Age)) AS Возраст,Phone_number AS 'Номер телефона' FROM Drivers where Имя like '%" + t2 + "%'").DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            

                string t3 = textBox4.Text;
               // string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Id, Last_name AS Фамилия,Name AS Имя, Middle_name AS Отчество,(strftime('%Y', 'now') - strftime('%Y', Age)) - (strftime('%m-%d', 'now') < strftime('%m-%d', Age)) AS Возраст,Phone_number AS 'Номер телефона' FROM Drivers where Отчество like '%" + t3 + "%'").DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }
        

       
         private void textBox5_TextChanged(object sender, EventArgs e)
        {
            

                string t4 = textBox5.Text;
            //    string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Id, Last_name AS Фамилия,Name AS Имя, Middle_name AS Отчество,(strftime('%Y', 'now') - strftime('%Y', Age)) - (strftime('%m-%d', 'now') < strftime('%m-%d', Age)) AS Возраст,Phone_number AS 'Номер телефона' FROM Drivers where Возраст like '%" + t4 + "%'").DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }

         private void textBox6_TextChanged(object sender, EventArgs e)
         {
           

                 string t5 = textBox6.Text;
               //  string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Id, Last_name AS Фамилия,Name AS Имя, Middle_name AS Отчество,(strftime('%Y', 'now') - strftime('%Y', Age)) - (strftime('%m-%d', 'now') < strftime('%m-%d', Age)) AS Возраст,Phone_number AS 'Номер телефона' FROM Drivers where Phone_number like '%" + t5 + "%'").DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }

         private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
             switch (type12)
             {
                 case "Vod1":
                     data.Vod1id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                     data.Vod1name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                     data.Vod2name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    data.Vod3name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    break;
                     

             }


             textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
             data.D1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
             data.D2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
             data.D3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
             data.D4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
             data.D5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
             data.D6 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

             if (data.Vod1 == "1")
             {
                 this.Close();
                 data.Vod1 = "";
             }

         }
        }
       
    }

