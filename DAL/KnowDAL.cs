
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL
{
    public class KnowDAL
    {
        public DataTable GetKnowALL()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from know", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                // 使用数据适配器填充数据集的时候，需要进行分页数据的处理
                sda.Fill(ds, "know");
                return ds.Tables["know"];
            }
            catch (Exception e)
            {

                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
       
       
        }
    }
}