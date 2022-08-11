using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik
{

  
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            textBox2.Select();


        }

    

        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "admin")
            {
                Form2 form1 = new Form2(this);

                Hide();
                form1.ShowDialog();


                //  Form2 Form1 = new Form2();
                //  Form1.Show();
                //  this.Hide();

            }
            else
                MessageBox.Show("Неправильный пароль!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Form2 Form1 = new Form2();
            //Form1.Show();
            // this.Hide();
            Form2 form1 = new Form2(this);
            Hide();
            form1.ShowDialog();

            // Form6 form = new Form6(this);





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователь")
            {

                label3.Visible = false;

                textBox2.Visible = false;

                button3.Visible = false;
                button4.Visible = true;
            }
            if (comboBox1.Text == "Администратор")
            {

                label3.Visible = true;

                textBox2.Visible = true;

                button3.Visible = true;
                button4.Visible = false;

            }
            if (comboBox1.Text == "")
            {

                label3.Visible = false;

                textBox2.Visible = false;

                button3.Visible = false;
                button4.Visible = false;

            }
            data.box = comboBox1.Text;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Form6 form9 = new Form6(this);
            //  Hide();
            //form9.ShowDialog();

            // Form6 form6 = new Form6();
            //  form6.Show();
        }

       


        }
    }

