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
    public partial class Form33 : Form
    {
        db DBC = new db();


        public int a;
        public int b;
        public int c;


        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");

        public Form33()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Text = null;
            dateTimePicker1.CustomFormat = "  ";

       
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
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
            data.AYE1Id = null;



            data.G1id = null;
            data.G2id = null;
            data.Vod1id = null;
            data.Mark1id1 = null;
            data.Mark1GOS = null;
            data.Top1id = null;
            data.Postavka1id = null;

            data.Mark1GOS = null;
            data.clientName1 = null;
            data.clientName2 = null;
            data.clientName3 = null;

            ///  textBox7.Text = null;
            textBox8.Text = null;









            /*
            data.AYE1Id = null;
            data.G1id = null;
            data.G2id = null;
            data.Vod1id = null;
            data.Mark1id1 =null ;
            data.Top1id =null ;
            data.Postavka1id =null;

            data.G1name =null ;
            data.G2name =null ;

            data.Vod1name =null;
            data.Vod2name =null ;

            data.Mark1name = null;

            data.Top1name = null;

            data.Postavka1name = null;

            data.AYE1 = null;
            data.AYE2 = null;
            data.AYE3 = null;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
          
            if (textBox8.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
                        
            /*
                        if (DBC.Update("Transportations", "Date='" + dateTimePicker1.Text + "', Id_client='" + data.clientFIOID + "', Dispatch='" + textBox2.Text + "" +
                            "',Id_arrival='" + data.G2id + "',Id_drivers='" + data.Vod1id + "', Id_make = '" + data.Mark1id1 + "', Id_transport = '" + data.Mark1id2 + "'" +
                            "', Id_fuel='" + data.Top1id + "',Dispatch_quantity='" + textBox8.Text + "',Price='" + textBox9.Text + "'"," Id = '" + textBox10.Text + "'"))

             */







          
      if (DBC.Update("Transportations", "Date='" + dateTimePicker1.Text + "', Id_client='" + data.clientFIOID + "', Dispatch='" + textBox2.Text + "" +
           "',Id_arrival='" + data.G2id + "', Id_drivers='" + data.Vod1id + "',Id_make = '" + data.Mark1id1 + "', Id_transport = '" + data.Mark1id2 + ""+
     "',Id_fuel='" + data.Top1id + "', Dispatch_quantity='" + textBox8.Text + "',Price='" + textBox9.Text + "'", " Id = '" + textBox10.Text + "'"))
     
            {
                MessageBox.Show("Изменено");
          Hide();

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

                ///  textBox7.Text = null;
                textBox8.Text = null;


            }
      else
      {
          MessageBox.Show("Неизвестная ошибка");
      }




      
     


        }

        private void Form33_Activated(object sender, EventArgs e)
        {
            dateTimePicker1.Text = data.AYE1;
           // textBox1.Text = data.AYE1;
           // textBox2.Text = data.G1name;
            textBox3.Text = data.G2name;
              textBox4.Text = data.Vod1name + "    " + data.Vod2name + "       " + data.Vod3name;
            //  textBox4.Text = data.Vod1name;
            //   textBox5.Text = data.Mark1name;
            textBox5.Text = data.Mark1name + "       " + data.Mark1GOS;
            textBox6.Text = data.Top1name;

            textBox8.Text = data.AYE2;
            textBox9.Text = data.AYE3;
            textBox10.Text = data.AYE1Id;


            textBox1.Text = data.clientName1 + "    " + data.clientName2 + "       " + data.clientName3;
        //    textBox1.Text = data.clientName1 ;


            if (textBox10.Text == "")
            {
                pictureBox1.Visible = true;
                dateTimePicker1.Visible = false;
                //textBox2 = (sender as TextBox).Text.Length > 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.Client = "1";
            Form34 Fo = new Form34();
            Fo.type = "Client";
            Fo.ShowDialog();
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
            /*
            data.Mark1 = "1";
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

        private void button8_Click(object sender, EventArgs e)
        {
            data.Postavka1 = "1";
            Form16 Fo = new Form16();
            Fo.type = "Postavka1";
            Fo.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

            textBox9.Text = (a * b).ToString();
            if (textBox8.Text == "") textBox9.Text = null;


        }


        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 0)
            {
                pictureBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void Form33_FormClosed(object sender, FormClosedEventArgs e)
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

          ///  textBox7.Text = null;
            textBox8.Text = null;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "") textBox9.Text = null;

            if (textBox6.Text == "АИ-92") b = 36;
            if (textBox6.Text == "АИ-80") b = 30;
            if (textBox6.Text == "АИ-95") b = 38;
            if (textBox6.Text == "АИ-98") b = 40;
            if (textBox6.Text == "АИ-100") b = 42;

            textBox9.Text = (a * b).ToString();
          
        }
    }
}
