using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    public class Ems
    {
     
        Op op = new Op();
        public List<Ems> ems { get; set; }

        public string assetSn { get; set; }
        public string assetName { get; set; }
        public string endDate { get; set; }
        public int emNumber { get; set; }
       
        public List<Ems> getData(DataTable dt)
        {

            op.getDataTable(dt, "order by AssetName Desc");

            var list = new List<Ems>();
            string buffer = "", edate = "--";
            int em = 0, i = 0;

            
            foreach (DataRow dr in dt.Rows)
            {

                if (dr["AssetName"].ToString().Equals(buffer))
                {
                    list.RemoveAt(i - 1);
                    em++;         
                }

                if (!dr["EMReportDate"].ToString().Equals(""))
                {
                    em++;
                }

                if (!dr["EMEndDate"].ToString().Equals(""))
                {
                    
                    DateTime date = Convert.ToDateTime(dr["EMEndDate"].ToString()); 
                    edate = date.ToString("yyyy/MM/dd");

                }
                else {
                    edate = "--";
                
                }

                list.Add(new Ems()
                {
                    assetSn = dr["AssetSn"].ToString(),
                    assetName = dr["AssetName"].ToString(),
                    endDate = edate,
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
