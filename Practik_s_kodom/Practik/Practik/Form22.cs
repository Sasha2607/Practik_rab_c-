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
    public partial class Form22 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");

        public Form22()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        void table5()
        {
            string sql;
            sql = "SELECT Fuel.Id, Fuel.Name AS Наименование, SUM(Waybill.Amount) AS Количество FROM Fuel LEFT JOIN Waybill ON Waybill.Id_fuel = Fuel.Id GROUP BY Fuel.Id";
            dataGridView1.DataSource = DBC.Select(sql).DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form22_Activated(object sender, EventArgs e)
        {
            table5();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;


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
                    if (DBC.Delete("Fuel", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
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

            
            sql = "SELECT Fuel.Id, Fuel.Name AS Наименование, SUM(Waybill.Amount) AS Количество FROM Fuel LEFT JOIN Waybill ON Waybill.Id_fuel = Fuel.Id  where Fuel.Name like '%" + t1 + "%'  GROUP BY Fuel.Id";
            dataGridView1.DataSource = DBC.Select(sql).DefaultView;


          
        }
        public string type = "";
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.Hide();
            form23.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          

                string t1 = textBox3.Text;
                string sql = "";


            sql = "SELECT Fuel.Id, Fuel.Name AS Наименование, SUM(Waybill.Amount) AS Количество FROM Fuel LEFT JOIN Waybill ON Waybill.Id_fuel = Fuel.Id GROUP BY Fuel.Id HAVING SUM(Waybill.Amount) like '%" + t1 + "%'";
            dataGridView1.DataSource = DBC.Select(sql).DefaultView;
            dataGridView1.DataSource = DBC.Select(sql).DefaultView;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.Hide();
            form24.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case "toplivo":
                 //   data.R6 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    data.R5 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data.R4 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case "Top1":
                    data.Top1id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.Top1name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.R1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.R2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //data.R3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (data.toplivo == "1")
            {
                this.Close();
                data.toplivo = "";
            }
            if (data.Top1 == "1")
            {
                this.Close();
                data.Top1 = "";
            }
        }

    }
}
