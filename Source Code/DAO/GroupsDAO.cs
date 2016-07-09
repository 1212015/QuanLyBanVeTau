using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;


namespace DAO
{
    public class GroupsDAO
    {
        public static DataTable LayDSQuyen()
        {
            //string sql = "select * from groups where GroupName != 'Admin'";
            string sql = "Exec sp_LayDSQuyen";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
    }
}
