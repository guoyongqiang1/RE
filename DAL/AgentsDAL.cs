
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
    public class AgentsDAL
    {
        public DataTable GetAgentsInfoById(AgentsModel model)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from agent where agentID = " + "'" + model.agentID + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                // 使用数据适配器填充数据集的时候，需要进行分页数据的处理
                sda.Fill(ds, "agents");
                return ds.Tables["agents"];
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
        public int InsertAgentsInfo(AgentsModel model)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";

            try
            {
                con.Open();
                string sql = "insert into agent (agentID,agentPwd,agentTel,agentName,agentAge) values('" + 
                    model.agentID + "','" + model.agentPwd + "','" + model.agentTel + "','" +
                    model.agentName + "'," +model.agentAge + ")";

                SqlCommand cmd = new SqlCommand(sql, con);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                return -1;
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