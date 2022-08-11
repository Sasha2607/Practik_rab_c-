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
    public partial class Form13 : Form
    {

        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
       

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;


            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form13_Activated(object sender, EventArgs e)
        {
    

          dataGridView1.DataSource = DBC.Select("SELECT Transport.Id, Make.Make_Model AS 'Наименование', Transport.Type AS Тип, Transport.Gos_nomer AS 'Гос номер', Transport.carrying_capacity AS 'Грузоподъемность', Transport.Id_marka FROM Transport " +
                " Join Make on Transport.Id_marka = Make.id").DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Hide();
            form14.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Hide();
            form15.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
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
                    if (DBC.Delete("Transport", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
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
            //    string sql = "";

            dataGridView1.DataSource = DBC.Select("SELECT Transport.Id, Make.Make_Model AS 'Наименование', Transport.Type AS Тип, Transport.Gos_nomer AS 'Гос номер', Transport.carrying_capacity AS 'Грузоподъемность', Transport.Id_marka FROM Transport " +
                " Join Make on Transport.Id_marka = Make.id where Make.Make_Model like '%" + t1 + "%' ").DefaultView;

            dataGridView1.Columns[0].Visible = false;

          


          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         

                string t1 = textBox3.Text;
            // string sql = "";


            dataGridView1.DataSource = DBC.Select("SELECT Transport.Id, Make.Make_Model AS 'Наименование', Transport.Type AS Тип, Transport.Gos_nomer AS 'Гос номер', Transport.carrying_capacity AS 'Грузоподъемность', Transport.Id_marka FROM Transport " +
                " Join Make on Transport.Id_marka = Make.id where Transport.Type like '%" + t1 + "%' ").DefaultView;

            //    dataGridView1.Columns[0].Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
                string t1 = textBox4.Text;
               //string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Transport.Id, Make.Make_Model AS 'Наименование', Transport.Type AS Тип, Transport.Gos_nomer AS 'Гос номер', Transport.carrying_capacity AS 'Грузоподъемность', Transport.Id_marka FROM Transport " +
                " Join Make on Transport.Id_marka = Make.id where Transport.Gos_nomer like '%" + t1 + "%' ").DefaultView;
            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
 
          

                string t1 = textBox5.Text;
               // string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Transport.Id, Make.Make_Model AS 'Наименование', Transport.Type AS Тип, Transport.Gos_nomer AS 'Гос номер', Transport.carrying_capacity AS 'Грузоподъемность', Transport.Id_marka FROM Transport " +
                " Join Make on Transport.Id_marka = Make.id where Transport.carrying_capacity like '%" + t1 + "%' ").DefaultView;


        }

        public string type = "";

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case "Mark1":
                    data.Mark1id1 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    data.Mark1id2 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.Mark1name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data.Mark1GOS = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    break;

            }




                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.E1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.E2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            data.E3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            data.E4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            data.E5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            data.A2 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            data.A3 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            data.A2id = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            // data.A3id = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();


            if (data.Mark1 == "1")
            {
                this.Close();
                data.Mark1 = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

