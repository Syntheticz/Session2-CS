using MySql.Data.MySqlClient;
using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public class Op
    {
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        Connect con = new Connect();
        DataSet ds = new DataSet();
       


        public void login(string user, string pass) {
            try
            {
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM employees where Username = '" + user + "' and Password = '" + pass + "'", con.dbConnect());      
                command1.Parameters.Add("", MySqlDbType.VarChar).Value = user;
                command1.Parameters.Add("", MySqlDbType.VarChar).Value = pass;
                adapter.SelectCommand = command1;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Success...");
                    Form1 form1 = new Form1();
                    form1.Hide();
                    Form2 form = new Form2();
                    form.ShowDialog();
                    form1.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password...");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(Convert.ToString(e1));
            }
        }

        public void getAssetData(DataTable dt, DataGridView dv) {
            DataTable dt1 = new DataTable();
            try {

                string query = "SELECT * FROM assets left join emergencymaintenances" +
           " on assets.ID = emergencymaintenances.AssetID left join employees on assets.EmployeeID = employees.ID left join assetgroups " +
           "on assets.AssetGroupID = assetgroups.ID left join departmentlocations on assets.DepartmentLocationID = departmentlocations.ID left join departments " +
           "on departmentlocations.DepartmentID = departments.id left join locations on departmentlocations.LocationID = locations.ID left join changedparts on " +
           "emergencymaintenances.ID = changedparts.ID left join priorities on emergencymaintenances.PriorityID = priorities.ID left join parts" +
           " on changedparts.PartID = parts.ID";

                con.Open();
                MySqlCommand command = new MySqlCommand(query, con.dbConnect());
                adapter.SelectCommand = command;
                
                adapter.Fill(dt);

                dt.Columns.Add("End Date", typeof(Int64));
                dt.Columns.Add("Asset Name", typeof(string));
               

                foreach (DataRow dr in dt.Rows) {
                    string AssetSn = dr["EMEndDate"].ToString();
                    
                    dt.Rows.Add(AssetSn);
                   
                }

                
                dv.DataSource = dt;
                con.Close();
            }
            catch (Exception e) {
                MessageBox.Show(Convert.ToString(e));
            }
    
        }

       
    }
}
