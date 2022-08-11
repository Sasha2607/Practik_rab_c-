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
    public partial class Form25 : Form
    {

        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Activated(object sender, EventArgs e)
        {
            table3();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form26 form26 = new Form26();
            form26.Hide();
            form26.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27();
            form27.Hide();
            form27.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          //  textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
         //   data.z2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          //  data.z3 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        public string type = "";
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case "prixod":
                    data.z13id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.z12 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    data.z11 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data.z35 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                    break;
                 
            }
              textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
              data.z1 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            data.z2 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.z3 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            data.z2id = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            if (data.prixod == "1")
            {
                this.Close();
                data.prixod = "";
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
                    if (DBC.Delete("Receipt_fuel", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
                    else MessageBox.Show("Произошла ошибка. Возможно, вы пытаетесь удалить запись, которая используется в другой таблице. Действие прервано.");

                }

                if (result == DialogResult.No)
                {

                }

            }


            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        

                string t1 = textBox2.Text;
                //string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Receipt_fuel.Id, Receipt_fuel.Date AS Дата, Provider.Name  AS Наименование,  Receipt_fuel.Id_provider  FROM Receipt_fuel " +
                   " join Provider on Receipt_fuel.Id_provider = Provider.Id where Date like '%" + t1 + "%'").DefaultView;
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         

                string t1 = textBox3.Text;
//                string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Receipt_fuel.Id, Receipt_fuel.Date AS Дата, Provider.Name  AS Наименование,  Receipt_fuel.Id_provider  FROM Receipt_fuel " +
                     " join Provider on Receipt_fuel.Id_provider = Provider.Id where Name like '%" + t1 + "%'").DefaultView;
            }
        void table3()
        {

            dataGridView1.DataSource = DBC.Select("SELECT Receipt_fuel.Id, Receipt_fuel.Date AS Дата, Provider.Name  AS Наименование,  Receipt_fuel.Id_provider  FROM Receipt_fuel " +
                " join Provider on Receipt_fuel.Id_provider = Provider.Id").DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            /* if (connect.State.ToString() == "Closed") connect.Open();
             //MessageBox.Show(connect.State.ToString());
             string sql = "";
             sql = "SELECT Приход_топлива.Id_Приход,Приход_топлива.Дата,Z1.Наименование,Z1.Id_поставщик AS Idm From Приход_топлива join Поставщик AS Z1 on Приход_топлива.Id_поставщик = Z1.Id_поставщик";

             SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
             SqlCommandBuilder scb = new SqlCommandBuilder(sda);
             DataTable DATA = new DataTable();
             sda.Fill(DATA);
             dataGridView1.DataSource = DATA;
             dataGridView1.Columns[0].Visible = false;
             dataGridView1.Columns[3].Visible = false;

             if (connect.State.ToString() == "Open") connect.Close();
             */
        }
        }
    }

