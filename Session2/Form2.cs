﻿using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        Connect con = new Connect();
        Op op = new Op();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
       


        public Form2()
        {
            InitializeComponent();
            Ems ems = new Ems();
            ems.ems = ems.getData();
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            var emsa = ems.ems;
            dataGridView1.DataSource = emsa;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }
    }
}
