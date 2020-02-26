using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csEvents
    {
        csDAL objdal = new csDAL();
        //-------------Pics-------------------
        public Int32 Event_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Event_Name { set; get; }
        public string Event_Number { set; get; }
        public string Event_Start_Date { set; get; }
        public string Event_End_Date { set; get; }
        public string Event_Time { set; get; }
        public string Event_Venue { set; get; }
        public Int32 Event_Coordinator_ID { set; get; }
        public string Event_Target_Audience { set; get; }
        public string Event_Message_Theme { set; get; }
        public string Event_Objectives { set; get; }
        public string Event_Description { set; get; }
        public string Event_Risk_Assessment { set; get; }
        public string Event_Evaluation_Criteria { set; get; }
        public string Reg_Date { set; get; }
        public string Last_Update_Date { set; get; }
        public string ShowOrHide { set; get; }

        public string Check1 { set; get; }
        public string Check2 { set; get; }
        public string Check3 { set; get; }
        public string Check4 { set; get; }
        public string Check5 { set; get; }
        public string Check6 { set; get; }
        public string Check7 { set; get; }
        public string Check8 { set; get; }
        public string Check9 { set; get; }
        public string Check10 { set; get; }

        public string Start_Date { set; get; }
        public string Finish_Date { set; get; }
        public string Duration { set; get; }
        public string Current_Stage { set; get; }
        public string Project_Status { set; get; }
        public string Project_Objectives { set; get; }
        public string Deliverables { set; get; }
        public string Milestones { set; get; }
        public string Specification { set; get; }
        public string Limits { set; get; }
        public string LastUpdate_Date { set; get; }

        public Int32 Schedule_ID { set; get; }
        public Int32 Person_Responsible_ID { set; get; }
        public string Action_Name { set; get; }

        public Int32 Budget_ID { set; get; }
        public string Cost1 { set; get; }
        public string Cost2 { set; get; }
        public string Cost3 { set; get; }
        public string Cost4 { set; get; }
        public string Cost5 { set; get; }
        public string Cost6 { set; get; }
        public string Cost7 { set; get; }
        public string Cost8 { set; get; }
        public string Cost9 { set; get; }
        public string Cost10 { set; get; }
        public string Cost11 { set; get; }
        public string Cost12 { set; get; }
        public string Cost13 { set; get; }
        public string Cost14 { set; get; }
        public string Cost15 { set; get; }
        public string Cost16 { set; get; }
        public string Cost17 { set; get; }
        public string Cost18 { set; get; }
        public string Cost19 { set; get; }
        public string Cost20 { set; get; }
        public string GrandTotal { set; get; }
        public string Available_Budget { set; get; }
        public string Projected_Budget { set; get; }
        public string Other_Fundraising { set; get; }
        

        public csEvents()
        { }

        //------------------------Photos----------------------------------

  

        #region Events

        public void addEvents()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Event_Number", SqlDbType.VarChar, Event_Number.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objdal.executespreturnnd("procEvents_Insert", objlist);
        }

        public void updateEvents()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            objlist.Add(new csParameterListType("@Event_Start_Date", SqlDbType.VarChar, Event_Start_Date.ToString()));
            objlist.Add(new csParameterListType("@Event_End_Date", SqlDbType.VarChar, Event_End_Date.ToString()));
            objlist.Add(new csParameterListType("@Event_Time", SqlDbType.VarChar, Event_Time.ToString()));
            objlist.Add(new csParameterListType("@Event_Name", SqlDbType.VarChar, Event_Name.ToString()));
            objlist.Add(new csParameterListType("@Event_Venue", SqlDbType.VarChar, Event_Venue.ToString()));
            objlist.Add(new csParameterListType("@Event_Coordinator_ID", SqlDbType.BigInt, Event_Coordinator_ID));
            objlist.Add(new csParameterListType("@Event_Target_Audience", SqlDbType.VarChar, Event_Target_Audience.ToString()));
            objlist.Add(new csParameterListType("@Event_Message_Theme", SqlDbType.VarChar, Event_Message_Theme.ToString()));
            objlist.Add(new csParameterListType("@Event_Objectives", SqlDbType.VarChar, Event_Objectives.ToString()));
            objlist.Add(new csParameterListType("@Event_Description", SqlDbType.VarChar, Event_Description.ToString()));
            objlist.Add(new csParameterListType("@Event_Risk_Assessment", SqlDbType.VarChar, Event_Risk_Assessment.ToString()));
            objlist.Add(new csParameterListType("@Event_Evaluation_Criteria", SqlDbType.VarChar, Event_Evaluation_Criteria.ToString()));
            objlist.Add(new csParameterListType("@Last_Update_Date", SqlDbType.VarChar, Last_Update_Date.ToString()));
            objdal.executespreturnnd("procEvents_Update", objlist);
        }

        public DataTable Events_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procEvents_By_Client_ID", objpar);
            return dt;
        }

        public DataTable Events_View_By_Event_ID(Int32 Event_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            dt = objdal.search("procEvents_By_Event_ID", objpar);
            return dt;
        }

        public DataTable Events_View_By_Event_Number(string Event_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_Number", SqlDbType.VarChar, Event_Number));
            dt = objdal.search("procEvents_By_Event_Number", objpar);
            return dt;
        }

        public DataTable Events_View_By_Client_ID_and_Event_Date(Int32 Client_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procEvents_By_Client_ID_Date", objpar);
            return dt;
        }

        public DataTable Events_View_By_Event_Date(string Event_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_Date", SqlDbType.VarChar, Event_Date));
            dt = objdal.search("procEvents_By_Event_Date", objpar);
            return dt;
        }

        public DataTable Events_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procEvents_View_All");
            return dt;
        }

        public DataTable Events_View_Date_Today()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procEvents_By_Event_Date_Today");
            return dt;
        }

        public DataTable Events_View_Date_Week()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procEvents_By_Event_Date_Week");
            return dt;
        }

        public DataTable Events_View_Date_Month()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procEvents_By_Event_Date_Month");
            return dt;
        }

        public DataTable Events_View_Date_Year()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procEvents_By_Event_Date_Year");
            return dt;
        }

        public DataTable Delete_Events()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            dt = objdal.search("procEvents_Delete", objpar);
            return dt;
        }

        public DataTable searchForEventsAnyField1(string sVariable, Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procEvents_SearchByAnyField1", objpar);
            return dt;
        }

        #endregion

        #region Events_Checklist

        public void updateEvents_CheckList()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            objlist.Add(new csParameterListType("@Check1", SqlDbType.VarChar, Check1.ToString()));
            objlist.Add(new csParameterListType("@Check2", SqlDbType.VarChar, Check2.ToString()));
            objlist.Add(new csParameterListType("@Check3", SqlDbType.VarChar, Check3.ToString()));
            objlist.Add(new csParameterListType("@Check4", SqlDbType.VarChar, Check4.ToString()));
            objlist.Add(new csParameterListType("@Check5", SqlDbType.VarChar, Check5.ToString()));
            objlist.Add(new csParameterListType("@Check6", SqlDbType.VarChar, Check6.ToString()));
            objlist.Add(new csParameterListType("@Check7", SqlDbType.VarChar, Check7.ToString()));
            objlist.Add(new csParameterListType("@Check8", SqlDbType.VarChar, Check8.ToString()));
            objlist.Add(new csParameterListType("@Check9", SqlDbType.VarChar, Check9.ToString()));
            //objlist.Add(new csParameterListType("@Check10", SqlDbType.VarChar, Check10.ToString()));
            objdal.executespreturnnd("procEvents_CheckList_Update", objlist);
        }

        public DataTable Events_CheckList_View_By_Event_ID(Int32 Event_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            dt = objdal.search("procEvents_CheckList_By_Event_ID", objpar);
            return dt;
        }
        #endregion

        #region Events_Schedule

        public void addEvents_Schedule()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            objlist.Add(new csParameterListType("@Person_Responsible_ID", SqlDbType.BigInt, Person_Responsible_ID));
            objlist.Add(new csParameterListType("@Action_Name", SqlDbType.VarChar, Action_Name));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
            objlist.Add(new csParameterListType("@Finish_Date", SqlDbType.VarChar, Finish_Date.ToString()));
            objlist.Add(new csParameterListType("@Duration", SqlDbType.VarChar, Duration.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procEvents_Schedule_Insert", objlist);
        }

        public void updateEvents_Schedule()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Schedule_ID", SqlDbType.BigInt, Schedule_ID));
            objlist.Add(new csParameterListType("@Person_Responsible_ID", SqlDbType.BigInt, Person_Responsible_ID));
            objlist.Add(new csParameterListType("@Action_Name", SqlDbType.VarChar, Action_Name));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
            objlist.Add(new csParameterListType("@Finish_Date", SqlDbType.VarChar, Finish_Date.ToString()));
            objlist.Add(new csParameterListType("@Duration", SqlDbType.VarChar, Duration.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procEvents_Schedule_Update", objlist);
        }

        public DataTable viewEvents_Schedule_By_Event_ID(Int32 Event_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            dt = objdal.search("procEvents_Schedule_By_Event_ID", objpar);
            return dt;
        }

        public DataTable viewEvents_Schedule_By_Schedule_ID(Int32 Schedule_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Schedule_ID", SqlDbType.BigInt, Schedule_ID));
            dt = objdal.search("procEvents_Schedule_By_Schedule_ID", objpar);
            return dt;
        }


        #endregion

        #region Events_Budget

        public void updateEvents_Budget()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            objlist.Add(new csParameterListType("@Cost1", SqlDbType.VarChar, Cost1));
            objlist.Add(new csParameterListType("@Cost2", SqlDbType.VarChar, Cost2));
            objlist.Add(new csParameterListType("@Cost3", SqlDbType.VarChar, Cost3));
            objlist.Add(new csParameterListType("@Cost4", SqlDbType.VarChar, Cost4));
            objlist.Add(new csParameterListType("@Cost5", SqlDbType.VarChar, Cost5));
            objlist.Add(new csParameterListType("@Cost6", SqlDbType.VarChar, Cost6));
            objlist.Add(new csParameterListType("@Cost7", SqlDbType.VarChar, Cost7));
            objlist.Add(new csParameterListType("@Cost8", SqlDbType.VarChar, Cost8));
            objlist.Add(new csParameterListType("@Cost9", SqlDbType.VarChar, Cost9));
            objlist.Add(new csParameterListType("@Cost10", SqlDbType.VarChar, Cost10));
            objlist.Add(new csParameterListType("@Cost11", SqlDbType.VarChar, Cost11));
            objlist.Add(new csParameterListType("@Cost12", SqlDbType.VarChar, Cost12));
            objlist.Add(new csParameterListType("@Cost13", SqlDbType.VarChar, Cost13));
            objlist.Add(new csParameterListType("@Cost14", SqlDbType.VarChar, Cost14));
            objlist.Add(new csParameterListType("@Cost15", SqlDbType.VarChar, Cost15));
            objlist.Add(new csParameterListType("@Cost16", SqlDbType.VarChar, Cost16));
            objlist.Add(new csParameterListType("@Cost17", SqlDbType.VarChar, Cost17));
            objlist.Add(new csParameterListType("@Cost18", SqlDbType.VarChar, Cost18));
            objlist.Add(new csParameterListType("@Cost19", SqlDbType.VarChar, Cost19));
            objlist.Add(new csParameterListType("@Cost20", SqlDbType.VarChar, Cost20));
            objlist.Add(new csParameterListType("@GrandTotal", SqlDbType.VarChar, GrandTotal));
            objlist.Add(new csParameterListType("@Available_Budget", SqlDbType.VarChar, Available_Budget));
            objlist.Add(new csParameterListType("@Projected_Budget", SqlDbType.VarChar, Projected_Budget));
            objlist.Add(new csParameterListType("@Other_Fundraising", SqlDbType.VarChar, Other_Fundraising));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procEvents_Budget_Update", objlist);
        }

        public DataTable viewEvents_Budget_By_Event_ID(Int32 Event_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            dt = objdal.search("procEvents_Budget_By_Event_ID", objpar);
            return dt;
        }

        public DataTable viewEvents_Budget_By_Budget_ID(Int32 Budget_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Budget_ID", SqlDbType.BigInt, Budget_ID));
            dt = objdal.search("procEvents_Budget_By_Budget_ID", objpar);
            return dt;
        }


        public void updateEvents_Budget_Labels()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            objlist.Add(new csParameterListType("@Cost1", SqlDbType.VarChar, Cost1));
            objlist.Add(new csParameterListType("@Cost2", SqlDbType.VarChar, Cost2));
            objlist.Add(new csParameterListType("@Cost3", SqlDbType.VarChar, Cost3));
            objlist.Add(new csParameterListType("@Cost4", SqlDbType.VarChar, Cost4));
            objlist.Add(new csParameterListType("@Cost5", SqlDbType.VarChar, Cost5));
            objlist.Add(new csParameterListType("@Cost6", SqlDbType.VarChar, Cost6));
            objlist.Add(new csParameterListType("@Cost7", SqlDbType.VarChar, Cost7));
            objlist.Add(new csParameterListType("@Cost8", SqlDbType.VarChar, Cost8));
            objlist.Add(new csParameterListType("@Cost9", SqlDbType.VarChar, Cost9));
            objlist.Add(new csParameterListType("@Cost10", SqlDbType.VarChar, Cost10));
            objlist.Add(new csParameterListType("@Cost11", SqlDbType.VarChar, Cost11));
            objlist.Add(new csParameterListType("@Cost12", SqlDbType.VarChar, Cost12));
            objlist.Add(new csParameterListType("@Cost13", SqlDbType.VarChar, Cost13));
            objlist.Add(new csParameterListType("@Cost14", SqlDbType.VarChar, Cost14));
            objlist.Add(new csParameterListType("@Cost15", SqlDbType.VarChar, Cost15));
            objlist.Add(new csParameterListType("@Cost16", SqlDbType.VarChar, Cost16));
            objlist.Add(new csParameterListType("@Cost17", SqlDbType.VarChar, Cost17));
            objlist.Add(new csParameterListType("@Cost18", SqlDbType.VarChar, Cost18));
            objlist.Add(new csParameterListType("@Cost19", SqlDbType.VarChar, Cost19));
            objlist.Add(new csParameterListType("@Cost20", SqlDbType.VarChar, Cost20));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procEvents_Budget_Labels_Update", objlist);
        }

        public DataTable viewEvents_Budget_Labels_By_Event_ID(Int32 Event_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
            dt = objdal.search("procEvents_Budget_Labels_By_Event_ID", objpar);
            return dt;
        }

        public DataTable viewEvents_Budget_Labels_By_Budget_ID(Int32 Budget_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Budget_ID", SqlDbType.BigInt, Budget_ID));
            dt = objdal.search("procEvents_Budget_Labels_By_Budget_ID", objpar);
            return dt;
        }

        #endregion

    }
}