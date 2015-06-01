using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBHelp;
using System.Data;

namespace DBClass
{
    public class FromMail
    {
        public string[] fromName = new string[] { };
        public Access ac;
        public string[] fromMail = new string[] { };

        public FromMail()
        { 
            ac = new Access();

            DataSet ds1 = ac.GetDataSet("select * from [allFromMail]");
            DataTable dt1 = ds1.Tables[0];

            this.fromName = getArrayFromTable(dt1);

            DataSet ds2 = ac.GetDataSet("select UserName from [froms]");
            DataTable dt2 = ds2.Tables[0];

            this.fromMail = getArrayFromTable(dt2);
        }

        private string[] getArrayFromTable(DataTable dt)
        {
            string[] strArr = new string[]{};
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                DataRow dr = dt.Rows[j];
                strArr[j] = dr[0].ToString();
            }
            return strArr;
        }
        public string[] getFromName()
        {
            return fromName;
        }

        public string[] getFromMail()
        {
            return fromMail;
        }


    }
}
