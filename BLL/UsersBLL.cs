
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UsersBLL
    {               // 创建业务方法(调用数据访问层对象方法的）
        public DataTable GetUsersInfoById(UsersModel model)
        {                                  
            UsersDAL dal = new UsersDAL();
            DataTable dt = dal.GetUsersInfoById(model);    

            return dt;
        }
        public int InsertUsersInfo(UsersModel model)
        {
            UsersDAL dal = new UsersDAL();    

            return  dal.InsertUsersInfo(model);
        }
    }
}