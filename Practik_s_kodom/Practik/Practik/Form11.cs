using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Practik
{

    public partial class Form11 : Form
    {

        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox1.Text = data.A10;
            textBox2.Text = data.A11;
 
            label1.Focus();
          
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

            {
                string t2 = textBox2.Text;
                int z = 0;
                for (int i = 0; i < t2.Length; i++)
                {
                    if (t2[i] == '-')
                    {
                        z++;
                    }
                }
                if (z == 1)
                {
                    if (DBC.Update("Make", "Make_Model = '" + textBox2.Text + "'", "Id = '" + textBox1.Text + "'"))

                    {
                        MessageBox.Show("Изменено");
                        Hide();
                        data.C1 = null;
                        data.C2 = null;
                    }
                    else
                    {
                        MessageBox.Show("Неизвестная ошибка");
                    }
                }
                else
                {
                    if (z == 0)
                        MessageBox.Show("Введите Модель");
                    else MessageBox.Show("Ошибка");
                }

            }
          
        }

              private void button2_Click(object sender, EventArgs e)
              {
                
              }

              private void button2_Click_1(object sender, EventArgs e)
              {
                  this.Hide();
                  data.A10 = null;
                  data.A11 = null;
              }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.A10 = null;
            data.A11 = null;
        }
    }
}
