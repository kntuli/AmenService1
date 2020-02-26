using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csMembers_Pages
    {
        csDAL objdal = new csDAL();

       public int Page_ID { set; get; }
       public int Profile_ID { set; get; }
        public string PageUser_Name { set; get; }
        public string Page_Ready { set; get; }

        public csMembers_Pages()
        { }
         
        public csMembers_Pages(
            int cPage_ID,
            int cProfile_ID, 
            string cPageUser_Name, 
            string cPage_Ready)
        {
            
            Page_ID = cPage_ID;
            Profile_ID = cProfile_ID;
            PageUser_Name = cPageUser_Name;
            Page_Ready = cPage_Ready;
           
        }

         public void addPage()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@PageUser_Name", SqlDbType.VarChar, PageUser_Name.ToString()));
             objlist.Add(new csParameterListType("@Page_Ready", SqlDbType.VarChar, Page_Ready.ToString()));
             objdal.executespreturnnd("procMembers_Page_Insert", objlist);
         }

         public void updatePage()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@PageUser_Name", SqlDbType.VarChar, PageUser_Name.ToString()));
             objlist.Add(new csParameterListType("@Page_Ready", SqlDbType.VarChar, Page_Ready.ToString()));
             objdal.executespreturnnd("procMembers_Page_Update", objlist);
         }

         public DataTable viewPageByPageUserName(string PageUser_Name)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@PageUser_Name", SqlDbType.VarChar, PageUser_Name.ToString()));
             dt = objdal.search("procMembers_Page_By_PageUserName", objpar);
             return dt;
         }

         public DataTable viewPageByProfileID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMembers_Page_By_Profile_ID", objpar);
             return dt;
         }
 
         public void deletePage(int Page_ID)
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, Page_ID));
             objdal.executespreturndr("procMembers_Page_Delete", objpar);
         }

         public DataTable searchForPagesByAnyField(string sVariable)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchPagesByAnyField", objpar);
             return dt;
         }


    }

}
