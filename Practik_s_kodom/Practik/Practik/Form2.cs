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
    public partial class Form2 : Form
    {
        public int a;


        public Form2(Form1 form)
        {
            InitializeComponent();

            Form2 form1 = new Form2();

            switch (form.comboBox1.Text)
            {
                case "Пользователь":

                    a = 1;
                    break;
                case "Администратор":

                    a = 2;
                    break;

            }



        }

        public Form2()
        {
            InitializeComponent();



        }

        private void Form2_Load(object sender, EventArgs e)
        {
      

            //  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Focus();



            if (a == 2)
            {
                Form4 Form4 = new Form4();
                Form4.Show();




            }
            if (a == 1)
            {
                Form3 form3 = new Form3();
                form3.Show();



            }



        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {





        }

        private void спраочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Focus();



            if (a == 2)
            {
                Form4 Form4 = new Form4();
                Form4.Show();




            }
            if (a == 1)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Form6 form6 = new Form6();
            //  form6.Show();

            Form6 form5 = new Form6(this);
            Hide();
            //   form5.ShowDialog();



        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31();
            form31.Show();
        }

        private void водителиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 form5 = new Form6(this);
            form5.Show();


        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void пToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.Show();
        }

        private void приходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.Show();
        }

        private void накладнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();
            form28.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Width = 270;
            pictureBox3.Height = 240;

        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Width = 300;
            pictureBox3.Height = 270;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Width = 290;
            pictureBox2.Height = 256;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 320;
            pictureBox2.Height = 280;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Width = 270;
            pictureBox1.Height = 240;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 300;
            pictureBox1.Height = 270;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31();
            form31.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();
            form28.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form34 form34 = new Form34();
            form34.Show();
        }
    }
}



