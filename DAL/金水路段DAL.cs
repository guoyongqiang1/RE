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
    public class 金水路段DAL
    {

        public DataTable GetUsersInfoById(UsersModel model)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from users where userID=" + "'" + model.userID + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                // 使用数据适配器填充数据集的时候，需要进行分页数据的处理
                sda.Fill(ds, "users");
                return ds.Tables["users"];
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
        public int InsertUsersInfo(UsersModel model)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";

            try
            {
                con.Open();
                string sql = "insert into users (userID,userPwd,UserName,UserPhone,UserAge) values('" + model.userID +
                    "','" + model.userPwd + "','" + model.userName + "','" + model.userPhone + "'," + model.userAge + ")";
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