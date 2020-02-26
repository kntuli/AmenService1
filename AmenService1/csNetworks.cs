using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csNetworks
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Network_ID { set; get; }
        public string Category { set; get; }
        public string Network_Name { set; get; }
        public string Network_Number { set; get; }
        public string Network_Description { set; get; }
        public string Age_Focus { set; get; }
        public string Gender_Focus { set; get; }
        public string Network_Day { set; get; }
        public string Network_Time { set; get; }
        public string IsActive { set; get; }
        public string Reg_Date { set; get; }
        public string LastUpdate_Date { set; get; }

        public string HowDidYouHereAboutChurch { set; get; }
        public string PreviousChurch { set; get; }
        public string PersonYouKnowInOurChurch { set; get; }
        
        public string Church_Worker { set; get; }

        public csNetworks()
        { }


        public void AddNetworks()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Network_Number", SqlDbType.VarChar, Network_Number));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procClient_Networks_Insert", objlist);
        }

        public void updateNetworks()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Network_ID", SqlDbType.BigInt, Network_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Network_Name", SqlDbType.VarChar, Network_Name.ToString()));
            objlist.Add(new csParameterListType("@Network_Description", SqlDbType.VarChar, Network_Description.ToString()));
            objlist.Add(new csParameterListType("@Age_Focus", SqlDbType.VarChar, Age_Focus.ToString()));
            objlist.Add(new csParameterListType("@Gender_Focus", SqlDbType.VarChar, Gender_Focus.ToString()));
            objlist.Add(new csParameterListType("@Network_Day", SqlDbType.VarChar, Network_Day.ToString()));
            objlist.Add(new csParameterListType("@Network_Time", SqlDbType.VarChar, Network_Time.ToString()));
            objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procClient_Networks_Update", objlist);
        }

        public DataTable viewNetwork_ID_By_Network_Number(string Network_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Network_Number", SqlDbType.VarChar, Network_Number));
            dt = objdal.search("procClient_Networks_By_Network_Number", objpar);
            return dt;
        }

        public DataTable viewNetworks_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Networks_By_Client_ID", objlist);
            return dt;
        }



        public DataTable viewNetworks_By_Network_ID(Int32 Network_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Network_ID", SqlDbType.BigInt, Network_ID));
            dt = objdal.search("procClient_Networks_By_Network_ID", objlist);
            return dt;
        }

    }
}
