using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csContacts
    {
        csDAL objdal = new csDAL();

        //-------------Pics-------------------
        public Int32 Contact_ID { set; get; }
        public string Tel { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public string Email_To { set; get; }
        public string Email_CC { set; get; }
        public string SMTP_Host { set; get; }
        public string SMTP_Port { set; get; }
        public string SMTP_User_Email { set; get; }
        public string SMTP_User_Password { set; get; }
        public Int32 Update_By_ID { set; get; }
        public string Update_Date { set; get; }

        public csContacts()
        { }


        public void updateContacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, Tel.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@Email_To", SqlDbType.VarChar, Email_To.ToString()));
            objlist.Add(new csParameterListType("@Email_CC", SqlDbType.VarChar, Email_CC.ToString()));
            objlist.Add(new csParameterListType("@SMTP_Host", SqlDbType.VarChar, SMTP_Host.ToString()));
            objlist.Add(new csParameterListType("@SMTP_Port", SqlDbType.VarChar, SMTP_Port.ToString()));
            objlist.Add(new csParameterListType("@SMTP_User_Email", SqlDbType.VarChar, SMTP_User_Email.ToString()));
            objlist.Add(new csParameterListType("@SMTP_User_Password", SqlDbType.VarChar, SMTP_User_Password.ToString()));
            objlist.Add(new csParameterListType("@Update_By_ID", SqlDbType.BigInt, Update_By_ID));
            objlist.Add(new csParameterListType("@Update_Date", SqlDbType.VarChar, Update_Date.ToString()));
            objdal.executespreturnnd("procContacts_Update", objlist);
        }


        public DataTable Contacts_View_By_Contact_ID(Int32 Contact_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            dt = objdal.search("procContacts_By_Contact_ID", objpar);
            return dt;
        }

        public DataTable Contacts_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procContacts");
            return dt;
        }

    }
}
