using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace AmenService1
{
    public class csReferrals
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Referral_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Referral_Email { set; get; }
        public string Pay_Status { set; get; }
        public string Pay_Date { set; get; }
        public string Date_Reg { set; get; }

        public csReferrals()
        { }

        public void addReferrals()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Referral_Email", SqlDbType.VarChar, Referral_Email.ToString()));
            objlist.Add(new csParameterListType("@Pay_Status", SqlDbType.VarChar, Pay_Status.ToString()));
            objlist.Add(new csParameterListType("@Pay_Date", SqlDbType.VarChar, Pay_Date.ToString()));
            objlist.Add(new csParameterListType("@Date_Reg", SqlDbType.DateTime, Date_Reg));
            objdal.executespreturnnd("procReferrals_Insert", objlist);
        }

        public void UpdateReferrals()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Referral_ID", SqlDbType.BigInt, Referral_ID));
            objlist.Add(new csParameterListType("@Pay_Status", SqlDbType.VarChar, Pay_Status.ToString()));
            objlist.Add(new csParameterListType("@Pay_Date", SqlDbType.VarChar, Pay_Date.ToString()));
            objdal.executespreturnnd("procReferrals_Update", objlist);
        }

        public DataTable viewReferrals_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procReferrals_View_By_Profile_ID", objlist);
            return dt;
        }

        public DataTable viewReferrals_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procReferrals_View_By_Client_ID", objlist);
            return dt;
        }

        public DataTable getAllReferrals()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procReferrals_ViewALL");
            return dt;
        }

        public DataTable viewReferrals_By_Email(string Email)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Referral_Email", SqlDbType.BigInt, Referral_Email));
            dt = objdal.search("procReferrals_View_By_Client_ID", objlist);
            return dt;
        }

    }
}
