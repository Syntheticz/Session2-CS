using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class Form1 : Form
    {
        Connect con = new Connect();
        Op op = new Op();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            op.login(textBox1.Text, maskedTextBox1.Text);
            if (op.isLogin)
            {
                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
                this.Close();
            }
            
        }

        }
    }

