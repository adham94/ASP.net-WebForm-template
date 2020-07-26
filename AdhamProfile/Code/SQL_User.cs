using System.Data;
using Ns_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ns_SQL
{
    public class SQL_User_Object
    {
        protected string sFULLNAME = "";
        protected string sEMAIL = "";
        protected string sPASSWORD = "";
        protected string sSTATUS = "";

        public string FULLNAME   // property
        {
            get { return sFULLNAME; }   // get method
            set { sFULLNAME = value; }  // set method
        }
        public string EMAIL   // property
        {
            get { return sEMAIL; }   // get method
            set { sEMAIL = value; }  // set method
        }
        public string PASSWORD   // property
        {
            get { return sPASSWORD; }   // get method
            set { sPASSWORD = value; }  // set method
        }
        public string STATUS   // property
        {
            get { return sSTATUS; }   // get method
            set { sSTATUS = value; }  // set method
        }
        public class SQL_User_DA_Access
        {
            public bool InsertUser(SQL_User_Object obj_User)
            {
                string fullname = obj_User.FULLNAME;
                string email = obj_User.EMAIL;
                string password = obj_User.PASSWORD;
                string status = "Active";

                SQL_DataAccess SQLDataAccess = new SQL_DataAccess();

                string sSQL = "SELECT * FROM user_info where email = '" + email + "';";

                DataSet ds = SQLDataAccess.GetDataSet(sSQL);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    string sSQL2 = "INSERT INTO user_info (fullname,email,password,status) VALUES('" + fullname + "','" + email + "','" + password + "','" + status + "');";
                    SQLDataAccess.ExecuteSQL(sSQL2);
                    return true;
                }
                return true;
            }
        }
    }
}