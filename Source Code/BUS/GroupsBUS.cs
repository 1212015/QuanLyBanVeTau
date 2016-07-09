using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class GroupsBUS
    {
        public static DataTable LayDSQuyen()
        {
            DataTable dt = GroupsDAO.LayDSQuyen();
            return dt;
        }
    }
}
