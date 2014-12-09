using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyNoteBook_v1._0
{
    class TimeClass
    {
        public void getandsettaskdone(string mytask)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyNoteBook_v1._0.Properties.Settings.largedbConnectionString"].ConnectionString)) {


                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand("ActivityLog_sp", cn);
                
                da.InsertCommand.CommandType = CommandType.StoredProcedure;

                da.InsertCommand.Parameters.AddWithValue("@task", mytask);
                da.InsertCommand.Parameters.AddWithValue("@date",System.DateTime.Now.ToLongDateString());
                da.InsertCommand.Parameters.AddWithValue("@time", System.DateTime.Now.ToString("HH:mm:ss tt"));
                cn.Open();
                da.InsertCommand.ExecuteNonQuery();
              
            
            
            
            }
            
        
        
        
        }
    }


}
