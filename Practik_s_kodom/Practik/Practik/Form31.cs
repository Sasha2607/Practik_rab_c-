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
    public partial class Form31 : Form
    {
        db DBC = new db();

        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
      
        public Form31()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form32 form32 = new Form32();
            form32.Hide();
            form32.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form33 form33 = new Form33();
            form33.Hide();
            form33.Show();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;
            }
        }

        void table4()
        {
           
        }

        private void Form31_Activated(object sender, EventArgs e)
        {

            data.Vod2name = null;
            data.Vod3name = null;



            string sql;
        


            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         // " LEFT JOIN City on Transportations.Id_dispatch = City.id " +
          " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
          " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
          " LEFT JOIN Make on Transportations.Id_make = Make.id " +
          " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
          " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
          " LEFT JOIN Client on Transportations.Id_client = Client.id ";

            
            dataGridView1.DataSource = DBC.Select(sql).DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
           dataGridView1.Columns[5].Visible = false;
           dataGridView1.Columns[6].Visible = false;



     

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

          //  data.z13id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          // // data.z12 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
         //   data.z11 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
         //   data.R4 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
         //   data.R5 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
         //   data.R6 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.AYE1Id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          //  data.G1id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            data.G2id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            data.Vod1id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            data.Mark1id1 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            data.Mark1id2 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            data.Top1id = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
         //   data.Postavka1id = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

          //  data.G1name = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            data.G2name = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            data.clientFIOID = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            data.clientName1 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
         //   data.clientName2 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
         //   data.clientName3 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();




            data.Vod1name = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
          //  data.Vod2name = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            //data.Vod3name = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();

            data.Mark1name = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

            data.Top1name = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();

          //  data.Postavka1name = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();

            data.AYE1 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            data.AYE2 = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            data.AYE3 = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox2.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where Transportations.Date like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox3.Text;
            string sql = "";

           

            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox4.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where Transportations.Dispatch like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox5.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where X1. Name like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox6.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where (Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox7.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where (Make.Make_Model || ' ' ||Transport.Gos_nomer ) like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox8.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where Fuel.Name like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;

        }

        

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox10.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where Transportations.Dispatch_quantity like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string t1 = textBox11.Text;
            string sql = "";



            sql = "SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1. Name AS 'Пункт прибытия',(Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' ||Transport.Gos_nomer ) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
         " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
         " LEFT JOIN Make on Transportations.Id_make = Make.id " +
         " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
         " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
         " LEFT JOIN Client on Transportations.Id_client = Client.id where Transportations.Price like '%" + t1 + "%'";

            dataGridView1.DataSource = DBC.Select(sql).DefaultView;


        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBC.SaveExcel("SELECT Transportations.Id, Transportations.Id_drivers, Transportations.Id_arrival, Transportations.Id_make, Transportations.Id_transport, Transportations.Id_fuel, Transportations.Id_client, Date AS 'Дата перевозки', (Client.Last_name || ' ' || Client.Name || ' ' || Client.Middle_name) AS 'ФИО клиента', Transportations.Dispatch AS 'Пункт отправки', X1.Name AS 'Пункт прибытия', (Drivers.Last_name || ' ' || Drivers.Name || ' ' || Drivers.Middle_name) AS 'ФИО водителя', (Make.Make_Model || ' ' || Transport.Gos_nomer) AS 'Транспорт', Fuel.Name AS 'Наименование топлива', Transportations.Dispatch_quantity AS 'Количество отправленного топлива', Transportations.Price AS Счет  FROM Transportations " +
         // " LEFT JOIN City on Transportations.Id_dispatch = City.id " +
          " LEFT JOIN City AS X1 on Transportations.Id_arrival = X1.id " +
          " LEFT JOIN Drivers on Transportations.Id_drivers = Drivers.id " +
          " LEFT JOIN Make on Transportations.Id_make = Make.id " +
          " LEFT JOIN Transport on Transportations.Id_transport = Transport.id " +
          " LEFT JOIN Fuel on Transportations.Id_fuel = Fuel.id " +
          " LEFT JOIN Client on Transportations.Id_client = Client.id ");
        }
    }
}
