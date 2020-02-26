using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csMinistries
    {
        csDAL objdal = new csDAL();

        public Int32 Profile_ID { set; get; }
        public Int32 Ministry_ID { set; get; }
        public Int32 Client_Ministry_ID { set; get; }
        public Int32 Title_ID { set; get; }
        public Int32 Report_To_ID { set; get; }
        public Int32 Ministry_Item_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Profile_Number { set; get; }
        public string Ministry { set; get; }
        public string Start_Date { set; get; }
        public string End_Date { set; get; }
        public string Status { set; get; }
        public string Category { set; get; }
        public string Responsibilities { set; get; }


        public csMinistries()
        {

        }

        //--------------Profile----------------------------------------

        public DataTable crudeMinistriesItems(string crude, Int32 clientID, int ministryID, string ministry)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, ministryID));
            objlist.Add(new csParameterListType("@Ministry", SqlDbType.VarChar, ministry));
            dt = objdal.search("procMinistries_Items_Crude", objlist);
            return dt;
        }

        
        public void addMinistry_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry", SqlDbType.VarChar, Ministry.ToString()));
            objdal.executespreturnnd("procMinistries_Items_Insert", objlist);
        }

        public void addMinistries_Itemz()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Ministry", SqlDbType.VarChar, Ministry.ToString()));
            objdal.executespreturnnd("procMinistries_Itemz_Insert", objlist);
        }

        public void UpdateMinistries_Itemz()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objlist.Add(new csParameterListType("@Ministry", SqlDbType.VarChar, Ministry.ToString()));
            objdal.executespreturnnd("procMinistries_Itemz_Update", objlist);
        }

        public void DeleteMinistries_Itemz()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objdal.executespreturnnd("procMinistries_Itemz_Delete", objlist);
        }


        public DataTable viewAllMinistries_Itemz_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procMinistries_Itemz_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewAllMinistries_Itemz_By_Ministry_ID(int Ministry_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            dt = objdal.search("procMinistries_Itemz_By_Ministry_ID", objlist);
            return dt;
        }

        public DataTable viewAllMinistry_Items()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            dt = objdal.search("procMinistres_Items");
            return dt;
        }

        //------------------Client_Ministries-------------------------------

        public void addClient_MinistriesPre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procClient_Ministries_Insert_Pre", objlist);
        }

        public void addClient_Ministries()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objlist.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, Title_ID));
            objlist.Add(new csParameterListType("@Responsibilities", SqlDbType.VarChar, Responsibilities.ToString()));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objlist.Add(new csParameterListType("@Report_To_ID", SqlDbType.BigInt, Report_To_ID));
            objdal.executespreturnnd("procClient_Ministries_Insert", objlist);
        }

        public void updateClient_Ministries()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_Ministry_ID", SqlDbType.BigInt, Client_Ministry_ID));
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objlist.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, Title_ID));
            objlist.Add(new csParameterListType("@Responsibilities", SqlDbType.VarChar, Responsibilities.ToString()));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objlist.Add(new csParameterListType("@Report_To_ID", SqlDbType.BigInt, Report_To_ID));
            objdal.executespreturnnd("procClient_Ministries_Update", objlist);
        }

        public DataTable viewClient_Ministries_By_Profile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procClient_Ministries_By_ProfileID", objlist);
            return dt;
        }

        public void deleteClient_Ministries()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_Ministry_ID", SqlDbType.BigInt, Client_Ministry_ID));
            objdal.executespreturnnd("procClient_Ministries_Delete", objlist);
        }


        //---------------Ministry--------------------------------------------


        public void addMinistry()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Ministry", SqlDbType.VarChar, Ministry));
            objlist.Add(new csParameterListType("@Responsibilities", SqlDbType.VarChar, Responsibilities.ToString()));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objdal.executespreturnnd("procMinistries_Insert", objlist);
        }

        public void updateMinistry()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objlist.Add(new csParameterListType("@Ministry", SqlDbType.BigInt, Ministry));
            objlist.Add(new csParameterListType("@Responsibilities", SqlDbType.VarChar, Responsibilities.ToString()));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objdal.executespreturnnd("procMinistries_Update", objlist);
        }

        public void addMinistry2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Ministry_Item_ID", SqlDbType.BigInt, Ministry_Item_ID));
            objlist.Add(new csParameterListType("@Responsibilities", SqlDbType.VarChar, Responsibilities.ToString()));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objdal.executespreturnnd("procMinistries_Insert2", objlist);
        }

        public void updateMinistry2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objlist.Add(new csParameterListType("@Ministry_Item_ID", SqlDbType.BigInt, Ministry_Item_ID));
            objlist.Add(new csParameterListType("@Responsibilities", SqlDbType.VarChar, Responsibilities.ToString()));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objdal.executespreturnnd("procMinistries_Update2", objlist);
        }

        public DataTable viewMinistry_By_Profile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procMinistries_By_ProfileID", objlist);
            return dt;
        }

        public DataTable viewMinistry_By_Profile_ID2(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procMinistries_By_ProfileID2", objlist);
            return dt;
        }

        public DataTable viewMinistries_By_Ministry_ID(int Ministry_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            dt = objdal.search("procMinistries_By_MinistryID", objlist);
            return dt;
        }

        public DataTable viewMinistries_By_Ministry_ID2(int Ministry_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            dt = objdal.search("procMinistries_By_MinistryID2", objlist);
            return dt;
        }

        #region MinistryWorkers
        //procClient_Workers_By_Client_ID

        public DataTable viewClient_Ministry_Workers_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Ministry_Workers_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Ministry_Workers_InActive_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Ministry_Workers_InActive_By_Client_ID", objpar);
            return dt;
        }

        #endregion

    }
}
