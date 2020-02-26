using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AmenService1
{
    public class csPages
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Page_ID { set; get; }
        public Int32 Page_Custom_ID { set; get; }
        public string Custom_Page { set; get; }

        public csPages()
        { }

        public DataTable viewCustomPage_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPages_Custom_View_By_Client_ID2", objlist);
            return dt;
        }

        public DataTable viewCustomPage_By_Page_ID(Int32 Page_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, Page_ID));
            dt = objdal.search("procPages_Custom_View_By_Page_ID", objlist);
            return dt;
        }

        public DataTable viewCustomizePage_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPages_Custom_View_By_Client_ID", objlist);
            return dt;
        }

        public void updateCustomPage()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Custom_ID", SqlDbType.BigInt, Page_Custom_ID));
            objlist.Add(new csParameterListType("@Custom_Page", SqlDbType.VarChar, Custom_Page.ToString()));
            objdal.executespreturnnd("procPage_Custom_Update", objlist);
        }


        //------------------Update Custom----------------------------

        public void updateClient_Use_Custom_Pages()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Custom_Page", SqlDbType.VarChar, Custom_Page.ToString()));
            objdal.executespreturnnd("procClient_Custom_Page_Update", objlist);
        }

        public DataTable viewPage_Totals_By_Client_ID(Int32 Client_ID, Int32 Page_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, Page_ID));
            dt = objdal.search("procPages_Totals_By_Client_ID", objlist);
            return dt;
        }
    }
}