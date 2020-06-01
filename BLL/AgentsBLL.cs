
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
    public class AgentsBLL
    {
        public DataTable GetAgentsInfoById(AgentsModel model)
        {
            AgentsDAL dal = new AgentsDAL();
            DataTable dt = dal.GetAgentsInfoById(model);

            return dt;
        }
        public int InsertAentsInfo(AgentsModel model)
        {
            AgentsDAL dal = new AgentsDAL();

            return dal.InsertAgentsInfo(model);
        }
    }
}