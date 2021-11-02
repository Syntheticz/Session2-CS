using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            op.getDataTable(dt, "\0");

            var list = new List<Ems>();
            string  edate = "--";
            int em = 0, i = -1, j = 0, buffer = 0;

            
            foreach (DataRow dr in dt.Rows)
            {
               
                int assetID = Convert.ToInt32(dr[0]);
                if (assetID == buffer)
                {
                    
                    em++;
                    list.RemoveAt(j);
                    
                }
                else {
                    i++;
                    j = i;
                    Console.WriteLine(i);
                    if (!string.IsNullOrEmpty(dr["EMReportDate"].ToString()))
                    {
                        em = 1;
                    }
                    else {
                        em = 0;
                    }
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

                
                buffer = Convert.ToInt32(dr[0]);
                
               
                
            }
            return list;
        }


    }
}
