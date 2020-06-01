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
    public class OwnersBLL
    {
        public DataTable GetUsersInfoById(OwnersModel model)
        {
            OwnersDAL dal = new OwnersDAL();
            DataTable dt = dal.GetOwnersInfoById(model);

            return dt;
        }
        public int InsertOwnersInfo(OwnersModel model)
        {
            OwnersDAL dal = new OwnersDAL();

            return dal.InsertOwnersInfo(model);
        }
    }
}