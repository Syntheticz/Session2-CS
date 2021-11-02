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
    public partial class Form3 : Form
    {
        public string AssetName, Department;
        public int assetID, priorityID;
        Op op = new Op();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        Connect con = new Connect();
        public Form3(string AssetSN)
        {
            
            DataTable dt = new DataTable();
            dt = op.getDataTable(dt, " where AssetSN = '"+AssetSN+"'");
            InitializeComponent();
            foreach (DataRow dr in dt.Rows) {
                if (AssetSN.Equals(dr["AssetSN"].ToString())) {
                    AssetName = dr[2].ToString();
                    Department = dr[25].ToString();
                    assetID = Convert.ToInt32(dr[0]);
                    
                }
            }

            label2.Text = AssetSN;
            label3.Text = AssetName;
            label5.Text = Department;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public int getPriority(string priority)
        {
            if (priority.Equals("General"))
            {
                return 1;
            }
            else if (priority.Equals("High"))
            {
                return 2;
            }
            else if (priority.Equals("Very High"))
            {
                return 3;
            }
            else {
                return 0;
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("There are empty fields!");
            }
            else {

                try {
                        priorityID = getPriority(comboBox1.SelectedItem.ToString());

                    if (priorityID < 1)
                    {
                        MessageBox.Show("Please choose a proirity");
                    }
                    else {
                        string query = "insert into emergencymaintenances(AssetID,PriorityID,DescriptionEmergency,OtherConsiderations,EMReportDate) values(@AssetID,@PriorityID,@DescriptionEmergency,@OtherConsidirations,@EMReportDate)";
                        MySqlCommand command = new MySqlCommand(query, con.dbConnect());                 
                        command.Parameters.AddWithValue("@AssetID", assetID);
                        command.Parameters.AddWithValue("@PriorityID", priorityID);
                        command.Parameters.AddWithValue("@DescriptionEmergency", textBox1.Text);
                        command.Parameters.AddWithValue("@OtherConsidirations", textBox2.Text);
                        DateTime thisDay = DateTime.Today;
                        command.Parameters.AddWithValue("@EMReportDate", thisDay);
                        adapter.SelectCommand = command;
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        MessageBox.Show("Emergency request sent sucessfully!");
                        this.Hide();
                        Form2 form = new Form2();
                        form.ShowDialog();
                        this.Close();
                    }

                } catch (Exception e1) {
                    MessageBox.Show(e1.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
