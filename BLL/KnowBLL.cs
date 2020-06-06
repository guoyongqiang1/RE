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
    public class KnowBLL
    {
        public DataTable GetKnowALL(KnowModel model)
        {
            KnowDAL dal = new KnowDAL();
            DataTable dt = dal.GetKnowAll(model);

            return dt;
        }

    }
}