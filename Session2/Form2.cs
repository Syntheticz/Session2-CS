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
    public partial class Form2 : Form
    {
        Connect con = new Connect();
        Op op = new Op();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
       


        public Form2()
        {
            DataTable dt = new DataTable();
            InitializeComponent();
            Ems ems = new Ems();
            ems.ems = ems.getData(dt);

            var emsa = ems.ems;

            
            this.Load += UserControl_Load; // or form or any control that is parent of the datagridview
            dataGridView1.VisibleChanged += DataGridView1_VisibleChanged;

            dataGridView1.DataSource = emsa;

           
        }

        private bool _firstLoaded;
        private void UserControl_Load(object sender, EventArgs e)
        {
            _firstLoaded = true;
        }

        private void DataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (_firstLoaded && dataGridView1.Visible)
            {
                _firstLoaded = false;
                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    dc.SortMode = DataGridViewColumnSortMode.NotSortable;

                }

                foreach (DataGridViewRow dr in this.dataGridView1.Rows)
                {

                    if (dr.Cells[2].Value.ToString().Equals("--"))
                    {

                        dr.DefaultCellStyle.BackColor = Color.Red;

                    }

                }
            }
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
