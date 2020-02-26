using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csLeadership
    {
        csDAL objdal = new csDAL();

        //-------------Location---------------
        public Int32 Leadership_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Leadership_Title { set; get; }
        public Int32 Profile_ID { set; get; }
        public Int32 Report_To_ID { set; get; }
        public Int32 Ministry_ID { set; get; }
        public string Leadership_Year { set; get; }
        public string Category { set; get; }
        public string Mandate { set; get; }
        public string Leadership_Period { set; get; }
        public string IsActive { set; get; }
        public string Reg_Date { set; get; }
        public string LastUpdate_Date { set; get; }
        public string Deactivation_Date { set; get; }
        public string Migration_Date { set; get; }

        public string Leadership_Year_From { set; get; }
        public string Leadership_Year_To { set; get; }

        public Int32 Title_ID { set; get; }
        public string Title { set; get; }



        public csLeadership()
        { }


        #region Leadership

        public DataTable viewClient_Leadership_New_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Leadership_New_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Leadership_InActive_New_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Leadership_InActive_New_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewLeadershipByClient_ID(Int32 Client_ID, string LeadershipYear)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
            dt = objdal.search("procClient_Leadership_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewLeadershipByClient_ID2(Int32 Client_ID, string LeadershipYear)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
            dt = objdal.search("procClient_Leadership_By_Client_ID2", objpar);
            return dt;
        }

        public DataTable viewLeadership_By_Client_ID_and_Category(Int32 Client_ID, string LeadershipYear, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procClient_Leadership_By_Client_ID_and_Category", objpar);
            return dt;
        }

        public DataTable viewLeadership_By_Client_ID_and_Category2(Int32 Client_ID, string LeadershipYear, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procClient_Leadership_By_Client_ID_and_Category2", objpar);
            return dt;
        }


        public DataTable viewLeadershipByLeadership_ID(Int32 Leadership_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Leadership_ID", SqlDbType.BigInt, Leadership_ID));
            dt = objdal.search("procClient_Leadership_By_Leadership_ID", objpar);
            return dt;
        }

        public void addLeadership()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Report_To_ID", SqlDbType.BigInt, Report_To_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, Title_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, Leadership_Year.ToString()));
            objlist.Add(new csParameterListType("@Mandate", SqlDbType.VarChar, Mandate.ToString()));
            objlist.Add(new csParameterListType("@Leadership_Period", SqlDbType.VarChar, Leadership_Period.ToString()));
            objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objdal.executespreturnnd("procClient_Leadership_Insert2", objlist);
        }

        public void updateLeadership()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Leadership_ID", SqlDbType.BigInt, Leadership_ID));
            objlist.Add(new csParameterListType("@Report_To_ID", SqlDbType.BigInt, Report_To_ID));
            objlist.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, Title_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Mandate", SqlDbType.VarChar, Mandate.ToString()));
            objlist.Add(new csParameterListType("@Leadership_Period", SqlDbType.VarChar, Leadership_Period.ToString()));
            objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procClient_Leadership_Update2", objlist);
        }


        public void addLeadership_Migrate()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Leadership_Year_From", SqlDbType.VarChar, Leadership_Year_From.ToString()));
            objlist.Add(new csParameterListType("@Leadership_Year_To", SqlDbType.VarChar, Leadership_Year_To.ToString()));
            objlist.Add(new csParameterListType("@Migration_Date", SqlDbType.VarChar, Migration_Date.ToString()));
            objdal.executespreturnnd("procClient_Leadership_Insert_Migrate", objlist);
        }

        #endregion

        #region Titles

        public DataTable crudeTitles(string crude, Int32 clientID, int titleID, string title)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, titleID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, title));
            dt = objdal.search("procClient_Leadership_Title_Crude", objlist);
            return dt;
        }


        public void addLeadership_Titlez()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objdal.executespreturnnd("procClient_Leadership_Titlez_Insert", objlist);
        }

        public void UpdateLeadership_Titlez()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, Title_ID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objdal.executespreturnnd("procClient_Leadership_Titlez_Update", objlist);
        }

        public void DeleteLeadership_Titlez()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, Title_ID));
            objdal.executespreturnnd("procClient_Leadership_Titlez_Delete", objlist);
        }

        public DataTable viewAllLeadership_Titles()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            dt = objdal.search("procClient_Leadership_Titles");
            return dt;
        }

        public DataTable viewAllLeadership_Titlez_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Leadership_Titlez_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewAllLeadership_Titlez_By_Title_ID(Int32 Title_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Title_ID", SqlDbType.BigInt, Title_ID));
            dt = objdal.search("procClient_Leadership_Titlez_By_Title_ID", objpar);
            return dt;
        }

        #endregion

        #region Leaders with AmenApp-

        //---------Leaders with AmenApp----------------
        public DataTable viewLeaders_with_AmenApp_By_Client_ID(Int32 Client_ID, string LeadershipYear)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
            dt = objdal.search("procReport_All_Leaders_with_AmenApp_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewLeaders_with_AmenApp_By_Client_ID_and_Category(Int32 Client_ID, string LeadershipYear, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procReport_All_Leaders_with_AmenApp_By_Client_ID_and_Category", objpar);
            return dt;
        }

        public DataTable viewHome_Cell_Leaders_with_AmenApp_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procReport_Home_Cell_Leaders_with_AmenApp_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewHome_Cell_Leaders_and_Interns_with_AmenApp_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procReport_Home_Cell_Leader_and_Interns_with_AmenApp_By_Client_ID", objpar);
            return dt;
        }
        #endregion

    }

}

