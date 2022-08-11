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
    public partial class Form32 : Form
    {
        db DBC = new db();

        public int a;
        public int b;
        public int c;


        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
       
        public Form32()
        {

            InitializeComponent();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
          data.G1name = null;
          data.G2name= null;
          data.Vod1name = null;
           data.Vod2name= null;
          data.Mark1name= null;
            data.Top1name= null;
            data.Postavka1name = null;


            data.G1id = null;
                data.G2id = null;
                data.Vod1id = null;
                data.Mark1id1 = null;
                data.Mark1GOS = null;
                data.Top1id = null;
                data.Postavka1id = null;

            data.clientFIOID = null;
            data.clientName1 = null;
            data.clientName2 = null;
            data.clientName3 = null;


            textBox8.Text = null;
            textBox7.Text = null;

  
             //   textBox9.Text = null;
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            
            data.G1name = null;
            data.G2name = null;
            data.Vod1name = null;
            data.Vod2name = null;
            data.Vod3name = null;
            data.Mark1name = null;
            data.Top1name = null;
            data.Postavka1name = null;
            data.AYE1 = null;
            data.AYE2 = null;
            data.AYE3 = null;
            data.AYE1Id = null;



            data.G1id = null;
            data.G2id = null;
            data.Vod1id = null;
            data.Mark1id1 = null;
            data.Mark1GOS = null;
            data.Top1id = null;
            data.Postavka1id = null;


            data.clientName1 = null;
            data.clientName2 = null;
            data.clientName3 = null;

            textBox7.Text = null;
            textBox8.Text = null;
       //     textBox9.Text = null;
       


            dateTimePicker1.CustomFormat = "  ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ошибка2");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Ошибка3");
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Ошибка4");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Ошибка5");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ошибка6");
                return;
            }
         
            if (textBox8.Text == "")
            {
                MessageBox.Show("Ошибка7");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Ошибка8");
                return;
            }
       


            List<string> cols = new List<string>();
            List<string> values = new List<string>();

            cols.Add("Date");
            values.Add(DBC.DateFormat(dateTimePicker1.Text));
           // values.Add(dateTimePicker1.Text);


            cols.Add("Dispatch");
            values.Add(textBox9.Text);



            cols.Add("Id_client");
            values.Add(data.clientFIOID);

            cols.Add("Id_arrival");
            values.Add(data.G2id);

            cols.Add("Id_drivers");
            values.Add(data.Vod1id);


            cols.Add("Id_make");
            values.Add(data.Mark1id1);


            cols.Add("Id_transport");
            values.Add(data.Mark1id2);


            cols.Add("Id_fuel");
            values.Add(data.Top1id);


            cols.Add("Dispatch_quantity");
            values.Add(textBox8.Text);


            cols.Add("Price");
            values.Add(textBox2.Text);

            if (DBC.InsertInto("Transportations", cols, values))
            {
                MessageBox.Show("Успех");
                this.Hide();

                data.G1name = null;
                data.G2name = null;
                data.Vod1name = null;
                data.Vod2name = null;
                data.Vod3name = null;
                data.Mark1name = null;
                data.Top1name = null;
                data.Postavka1name = null;
                data.AYE1 = null;
                data.AYE2 = null;
                data.AYE3 = null;



                data.G1id = null;
                data.G2id = null;
                data.Vod1id = null;
                data.Mark1id1 = null;
                data.Mark1GOS = null;
                data.Top1id = null;
                data.Postavka1id = null;

                data.clientFIOID = null;
                data.clientName1 = null;
                data.clientName2 = null;
                data.clientName3 = null;


                textBox8.Text = null;
                textBox7.Text = null;


            }

            else
            {
                //  Exception()
                //   MessageBox.Show(dsa.ToString());
                MessageBox.Show("Ошибкаfhgf".ToString());
            }



            /*
                string sql = "";
                connect.Open();
                //  sql = "INSERT INTO Транспорт (Тип,Гос_номер,Масса,Id_Марка,Id_Наименование) VALUES (@Тип,@Гос_номер,@Масса,@Id_Марка,@Id_Наименование)";
                sql = "INSERT INTO Перевозки (Дата,Id_отправка,Id_прибытие,Id_водитель,Id_марка,Id_топливо,Количество_отправки,Счет) VALUES (@Дата,@Id_отправка,@Id_прибытие,@Id_водитель,@Id_марка,@Id_топливо,@Количество_отправки,@Счет)";
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;


                command.Parameters.AddWithValue("@Дата", textBox1.Text);
                command.Parameters.AddWithValue("@Id_отправка", data.G1id);
               command.Parameters.AddWithValue("@Id_прибытие",data.G2id );
                   command.Parameters.AddWithValue("@Id_водитель", data.Vod1id);
                  command.Parameters.AddWithValue("@Id_марка",data.Mark1id1 );
                   command.Parameters.AddWithValue("@Id_топливо",data.Top1id );
             
                 command.Parameters.AddWithValue("@Количество_отправки",textBox8.Text );
                       command.Parameters.AddWithValue("@Счет", textBox9.Text);
           
                //    command.Parameters.AddWithValue("@Id_Наименование", data.A3id);

                command.ExecuteNonQuery();

                MessageBox.Show("Добавлено");


                //   Form6 form6 = new Form6();
                //   form6.Hide();
                //   form6.Show();

                this.Hide();
             //   data.z11 = null;
             ////   data.z12 = null;
             //   data.R5 = null;
             //   data.R6 = null;
             //   data.z13id = null;
             //   data.R4 = null;

            */

        }

        /* private void button3_Click(object sender, EventArgs e)
         {
             data.Gorod1 = "1";
             Form19 Fo = new Form19();
             Fo.type11 = "Gorod1";
             Fo.ShowDialog();
         }*/

        private void Form32_Activated(object sender, EventArgs e)
        {
         //   textBox2.Text = data.G1name;
            textBox3.Text = data.G2name;
            textBox4.Text = data.Vod1name + "    " + data.Vod2name + "       " + data.Vod3name;
            textBox5.Text = data.Mark1name + "       " + data.Mark1GOS;
            textBox6.Text = data.Top1name;
            textBox7.Text = data.clientName1 + "    " + data.clientName2 + "       " + data.clientName3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            data.Gorod1 = "1";
            Form19 Fo = new Form19();
            Fo.type11 = "Gorod2";
            Fo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            data.Vod1 = "1";
            Form6 Fo = new Form6();
            Fo.type12 = "Vod1";
            Fo.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*    data.Mark1 = "1";
                Form5 Fo = new Form5();
                Fo.type = "Mark1";
                Fo.ShowDialog();
                */

               data.Mark1 = "1";
           Form13 Fo = new Form13();
           Fo.type = "Mark1";
           Fo.ShowDialog();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            data.Top1 = "1";
            Form22 Fo = new Form22();
            Fo.type = "Top1";
            Fo.ShowDialog();
        }

        /*private void button8_Click(object sender, EventArgs e)
        {
            data.Postavka1 = "1";
            Form16 Fo = new Form16();
            Fo.type = "Postavka1";
            Fo.ShowDialog();
        }*/

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "АИ-92") b = 36;
            if (textBox6.Text == "АИ-80") b = 30;
            if (textBox6.Text == "АИ-95") b = 38;
            if (textBox6.Text == "АИ-98") b = 40;
            if (textBox6.Text == "АИ-100") b = 42;

            textBox2.Text = (a * b).ToString();
            if (textBox8.Text == "") textBox2.Text = null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //  dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // dateTimePicker1.CustomFormat = "dd MMMM yyyy г.";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
  
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            data.Client = "1";
            Form34 Fo = new Form34();
            Fo.type = "Client";
            Fo.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
          
                a = Convert.ToInt32(textBox8.Text);
            }
            catch
            {
               
            }
           
            textBox2.Text = (a * b).ToString();
            if (textBox8.Text == "") textBox2.Text = null;


        }

        private void Form32_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.Top1name = null;
        }
    }
}
