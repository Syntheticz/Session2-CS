using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    public class Ems
    {
        Connect con = new Connect();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public List<Ems> ems { get; set; }

        public string assetSn { get; set; }
        public string assetName { get; set; }
        public string endDate { get; set; }
        public int emNumber { get; set; }

        public List<Ems> getData()
        {

            string query = "SELECT * FROM assets left join emergencymaintenances" +
           " on assets.ID = emergencymaintenances.AssetID left join employees on assets.EmployeeID = employees.ID left join assetgroups " +
           "on assets.AssetGroupID = assetgroups.ID left join departmentlocations on assets.DepartmentLocationID = departmentlocations.ID left join departments " +
           "on departmentlocations.DepartmentID = departments.id left join locations on departmentlocations.LocationID = locations.ID left join changedparts on " +
           "emergencymaintenances.ID = changedparts.ID left join priorities on emergencymaintenances.PriorityID = priorities.ID left join parts" +
           " on changedparts.PartID = parts.ID";

            con.Open();
            MySqlCommand command = new MySqlCommand(query, con.dbConnect());
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            var list = new List<Ems>();
            string buffer = "";
            int em = 0, i = 0;
            foreach (DataRow dr in dt.Rows)
            {

                if (dr["AssetName"].ToString().Equals(buffer))
                {
                    em++;
                    list.RemoveAt(i - 1);
                }

                if (!dr["EMReportDate"].ToString().Equals(""))
                {
                    em++;
                }




                list.Add(new Ems()
                {
                    assetSn = dr["AssetSn"].ToString(),
                    assetName = dr["AssetName"].ToString(),
                    endDate = dr["EMEndDate"].ToString(),
                    emNumber = em
                });
                buffer = dr["AssetName"].ToString();

                em = 0;
                i++;
            }




            return list;

        }


    }
}
