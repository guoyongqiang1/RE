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
    public class JinShuiBLL
    {
        public DataTable getJinShuiTable()
      {
            JinShuiDAL jinShuiDAL = new JinShuiDAL();
            DataTable dt = JinShui.GetJinShuiInfoById();
            return dt;
      }

   }
}


