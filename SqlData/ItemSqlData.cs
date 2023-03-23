using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
namespace SqlData
{
    public class ItemSqlData
    {
        public ItemSqlData()
        {

        }
        public DataTable GetItemsSql()
        {
            DataTable tbl = new DataTable();
            try
            {
                string query = @"exec getAll";
                SqlQuery.RunCommand(query, tbl.Load);
            }
            catch (Exception ex)
            {
                return null;
            }

            return tbl;
        }
        public DataTable GetItemsSumSql()
        {
            DataTable tbl = new DataTable();
            try
            {
                string query = @"exec getAllAfterSum";
                SqlQuery.RunCommand(query, tbl.Load);
            }
            catch (Exception ex)
            {
                return null;
            }

            return tbl;
        }

    }
}
