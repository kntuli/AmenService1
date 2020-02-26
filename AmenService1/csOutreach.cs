using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csOutreach
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public Int32 Outreach_ID { set; get; }
        public string Outreach_Number { set; get; }
        public string Place { set; get; }
        public string Date { set; get; }
        public string Time { set; get; }
        public string Purpose { set; get; }
        public string Outcome { set; get; }

        public Int32 Team_ID { set; get; }

        public csOutreach()
        { }

        #region Outreach

        //-----------------------Outreach-----------------------
        public void AddNewOutreach()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Outreach_Number", SqlDbType.VarChar, Outreach_Number.ToString()));
            objdal.executespreturnnd("procClient_Outreach_Insert", objlist);
        }

        public void updateOutreach()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Outreach_ID", SqlDbType.BigInt, Outreach_ID));
            objlist.Add(new csParameterListType("@Place", SqlDbType.VarChar, Place.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Time", SqlDbType.VarChar, Time.ToString()));
            objlist.Add(new csParameterListType("@Purpose", SqlDbType.VarChar, Purpose.ToString()));
            objlist.Add(new csParameterListType("@Outcome", SqlDbType.VarChar, Outcome.ToString()));
            objdal.executespreturnnd("procClient_Outreach_Update", objlist);
        }

        public DataTable viewOutreachID_ByOutreach_Number(string Outreach_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Outreach_Number", SqlDbType.VarChar, Outreach_Number.ToString()));
            dt = objdal.search("procClient_Outreach_ID_By_Outreach_Number", objpar);
            return dt;
        }

        public DataTable viewOutreach_By_Client_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Outreach_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewOutreach_By_Client_ID_Date(Int32 Client_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procClient_Outreach_By_Client_ID_Date", objpar);
            return dt;
        }

        public DataTable viewOutreachByOutreach_ID(Int32 Outreach_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Outreach_ID", SqlDbType.BigInt, Outreach_ID));
            dt = objdal.search("procClient_Outreach_By_Outreach_ID", objpar);
            return dt;
        }

        public DataTable searchForOutreachByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchOutreachByAnyField1", objpar);
            return dt;
        }
        #endregion

        //-----------------------Outreach Team-----------------------
        public void AddNewOutreach_Team()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Outreach_ID", SqlDbType.BigInt, Outreach_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procClient_Outreach_Team_Insert", objlist);
        }

        public void UpdateOutreach_Team()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Team_ID", SqlDbType.BigInt, Team_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procClient_Outreach_Team_Update", objlist);
        }

        public void DeleteOutreach_Team()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Team_ID", SqlDbType.BigInt, Team_ID));
            objdal.executespreturnnd("procClient_Outreach_Team_Delete", objlist);
        }

        public DataTable viewOutreach_Team_By_Outreach_ID(int Outreach_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Outreach_ID", SqlDbType.BigInt, Outreach_ID));
            dt = objdal.search("procClient_Outreach_Team_By_Outreach_ID", objpar);
            return dt;
        }

        public DataTable viewOutreach_Team_By_Team_ID(int Team_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Team_ID", SqlDbType.BigInt, Team_ID));
            dt = objdal.search("procClient_Outreach_Team_By_Team_ID", objpar);
            return dt;
        }

    }
}
