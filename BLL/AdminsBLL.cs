
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
    public  class AdminsBLL
    {
        public DataTable GetAdminsInfoById(AdminsModel model)
        {
            AdminsDAL dal = new AdminsDAL();
            DataTable dt = dal.GetAdminsInfoById(model);

            return dt;
        }
        public int InsertAdminsInfo(AdminsModel model)
        {
            AdminsDAL dal = new AdminsDAL();

            return dal.InsertAdminsInfo(model);
        }
    }
}