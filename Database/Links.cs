using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBHelp;

namespace Database
{
    class Links
    {
        public Links() { }

        public static void createLinks(string id, string sid)
        {
            Access ac = new Access();
            string sql = @"insert into links([RecordID], [ReciID]) values (" + id + ", " + sid + ")";
            ac.ExecuteNonQueryAndGetIdentity(sql);
        }

        public static bool checkLinks(string id, string sid)
        {
            Access ac = new Access();
            string sql = @"select * from links where [RecordID] = " + id + " and [ReciID] = " + sid;
            if(ac.GetDataSet(sql).Tables[0].Rows.Count>0)
                return true;
            return false;
        }
    }
}
