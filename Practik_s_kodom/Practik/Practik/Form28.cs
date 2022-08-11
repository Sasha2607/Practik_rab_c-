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
    public partial class Form28 : Form
    {
        db DBC = new db();
     
        public Form28()
        {
            InitializeComponent();
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;
            }
        }

        private void Form28_Activated(object sender, EventArgs e)
        {
       
            table4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29();
            form29.Hide();
            form29.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            form30.Hide();
            form30.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         



            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            data.z13id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            data.z12 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            data.z11 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            data.R4 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            data.R5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            data.R6 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            data.z14 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            data.z15 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();



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
                    if (DBC.Delete("Waybill", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
                    else MessageBox.Show("Произошла ошибка. Возможно, вы пытаетесь удалить запись, которая используется в другой таблице. Действие прервано.");

                }

                if (result == DialogResult.No)
                {

                }

            }


            textBox1.Text = "";
        }



        void table4()
         {
           string sql;
            sql = "SELECT Waybill.Id, Waybill.Id_coming, Waybill.Id_fuel, Receipt_fuel.Date AS 'Дата прихода', Fuel.Name AS 'Наименование топлива', Provider.Name AS 'Наименование поставщика',   Waybill.Amount AS 'Количество топлива', Waybill.Price AS Цена, Waybill.Id_provider  FROM Waybill " +
           "LEFT JOIN Receipt_fuel on Waybill.Id_coming = Receipt_fuel.id " +
           "LEFT JOIN Provider on Waybill.Id_provider = Provider.id " +
           "LEFT JOIN Fuel on Waybill.Id_fuel = Fuel.Id";

          //  string sql;
           //  sql = "SELECT Waybill.Id, Waybill.Id_coming, Waybill.Id_fuel, Receipt_fuel.Date AS Дата_прихода, Fuel.Name AS Наименование_топлива, Provider.Name AS Наименование_поставщика,   Waybill.Amount AS Количество_топлива, Waybill.Price AS Цена  FROM Waybill " +
          //  "LEFT JOIN Receipt_fuel on Waybill.Id_coming = Receipt_fuel.id " +
          //  "LEFT JOIN Provider on Waybill.Id_coming = Provider.Id " +
        //    "LEFT JOIN Fuel on Waybill.Id_fuel = Fuel.Id";
         

             dataGridView1.DataSource = DBC.Select(sql).DefaultView;

            

                 dataGridView1.Columns[0].Visible = false;
               dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
  
                string t1 = textBox2.Text;
                string sql = "";



                sql = "SELECT Waybill.Id, Waybill.Id_coming, Waybill.Id_fuel, Receipt_fuel.Date AS 'Дата прихода', Fuel.Name AS 'Наименование топлива', Provider.Name AS 'Наименование поставщика',   Waybill.Amount AS 'Количество топлива', Waybill.Price AS Цена, Waybill.Id_provider  FROM Waybill " +
            "LEFT JOIN Receipt_fuel on Waybill.Id_coming = Receipt_fuel.id " +
            "LEFT JOIN Provider on Waybill.Id_coming = Provider.Id " +
            "LEFT JOIN Fuel on Waybill.Id_fuel = Fuel.Id where Receipt_fuel.Date like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;



            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

                string t1 = textBox3.Text;
                string sql = "";


               

                sql = "SELECT Waybill.Id, Waybill.Id_coming, Waybill.Id_fuel, Receipt_fuel.Date AS 'Дата прихода', Fuel.Name AS 'Наименование топлива', Provider.Name AS 'Наименование поставщика',   Waybill.Amount AS 'Количество топлива', Waybill.Price AS Цена, Waybill.Id_provider  FROM Waybill " +
               "LEFT JOIN Receipt_fuel on Waybill.Id_coming = Receipt_fuel.id " +
               "LEFT JOIN Provider on Waybill.Id_coming = Provider.Id " +
               "LEFT JOIN Fuel on Waybill.Id_fuel = Fuel.Id where Fuel.Name like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           

                string t1 = textBox4.Text;
                string sql = "";


            

            sql = "SELECT Waybill.Id, Waybill.Id_coming, Waybill.Id_fuel, Receipt_fuel.Date AS 'Дата прихода', Fuel.Name AS 'Наименование топлива', Provider.Name AS 'Наименование поставщика',   Waybill.Amount AS 'Количество топлива', Waybill.Price AS Цена, Waybill.Id_provider  FROM Waybill " +
            "LEFT JOIN Receipt_fuel on Waybill.Id_coming = Receipt_fuel.id " +
            "LEFT JOIN Provider on Waybill.Id_coming = Provider.Id " +
            "LEFT JOIN Fuel on Waybill.Id_fuel = Fuel.Id where Provider.Name like '%" + t1 + "%'";
            dataGridView1.DataSource = DBC.Select(sql).DefaultView;



            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
       

                string t1 = textBox5.Text;
                string sql = "";





            sql = "SELECT Waybill.Id, Waybill.Id_coming, Waybill.Id_fuel, Receipt_fuel.Date AS 'Дата прихода', Fuel.Name AS 'Наименование топлива', Provider.Name AS 'Наименование поставщика',   Waybill.Amount AS 'Количество топлива', Waybill.Price AS Цена, Waybill.Id_provider  FROM Waybill " +
              "LEFT JOIN Receipt_fuel on Waybill.Id_coming = Receipt_fuel.id " +
              "LEFT JOIN Provider on Waybill.Id_coming = Provider.Id " +
              "LEFT JOIN Fuel on Waybill.Id_fuel = Fuel.Id where Waybill.Amount like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;



            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            

                string t1 = textBox6.Text;
                string sql = "";




            sql = "SELECT Waybill.Id, Waybill.Id_coming, Waybill.Id_fuel, Receipt_fuel.Date AS 'Дата прихода', Fuel.Name AS 'Наименование топлива', Provider.Name AS 'Наименование поставщика',   Waybill.Amount AS 'Количество топлива', Waybill.Price AS Цена, Waybill.Id_provider  FROM Waybill " +
          "LEFT JOIN Receipt_fuel on Waybill.Id_coming = Receipt_fuel.id " +
          "LEFT JOIN Provider on Waybill.Id_coming = Provider.Id " +
          "LEFT JOIN Fuel on Waybill.Id_fuel = Fuel.Id where  Waybill.Price like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;



            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
