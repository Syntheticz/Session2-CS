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

            try {

                MySqlCommand command = new MySqlCommand("SELECT * FROM assets left join emergencymaintenances" +
           " on assets.ID = emergencymaintenances.AssetID left join employees on assets.EmployeeID = employees.ID left join assetgroups " +
           "on assets.AssetGroupID = assetgroups.ID left join departmentlocations on assets.DepartmentLocationID = departmentlocations.ID left join departments " +
           "on departmentlocations.DepartmentID = departments.id left join locations on departmentlocations.LocationID = locations.ID left join changedparts on " +
           "emergencymaintenances.ID = changedparts.ID left join priorities on emergencymaintenances.PriorityID = priorities.ID left join parts" +
           " on changedparts.PartID = parts.ID", con.dbConnect());
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows) {

                    Console.WriteLine(ds.Tables[0]);
                
                }
                

                
                dv.DataSource = dt;

            }
            catch (Exception e) {
                MessageBox.Show(Convert.ToString(e));
            }
    
        }

       
    }
}
