using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class JinShuiDAL
    {


        public DataTable GetJinShuiInfoById()
        {
           
           

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            try
            {
              
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from agent where agentArea='金水'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
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