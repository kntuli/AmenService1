using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Data.SqlClient;

namespace AmenService1
{
    public class csYearPlanner
    {

        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Profile_ID { set; get; }


        public Int32 YearPlanner_ID { set; get; }
        public string Date { set; get; }
        public string DayOfWeek { set; get; }
        public string StartEnd { set; get; }
        public string Happenings { set; get; }
        public string Time { set; get; }

        public Int32 Diary_ID { set; get; }
        public string Diary_Date { set; get; }
        public string Diary_Times { set; get; }
        public string Appointment { set; get; }
        public string ToDo { set; get; }
        public string Status { set; get; }
        public string Year { set; get; }
        public string Month { set; get; }
        public string Day { set; get; }

        public csYearPlanner()
        { }


        #region YearPlanner

        public void addYearPlanner()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@DayOfWeek", SqlDbType.VarChar, DayOfWeek.ToString()));
            objlist.Add(new csParameterListType("@StartEnd", SqlDbType.VarChar, StartEnd.ToString()));
            objlist.Add(new csParameterListType("@Happenings", SqlDbType.VarChar, Happenings.ToString()));
            objlist.Add(new csParameterListType("@Time", SqlDbType.VarChar, Time.ToString()));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objdal.executespreturnnd("procClient_YearPlanner_Insert", objlist);
        }

        public void updateYearPlanner()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@YearPlanner_ID", SqlDbType.BigInt, YearPlanner_ID));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar,Date.ToString()));
            objlist.Add(new csParameterListType("@DayOfWeek", SqlDbType.VarChar, DayOfWeek.ToString()));
            objlist.Add(new csParameterListType("@StartEnd", SqlDbType.VarChar, StartEnd.ToString()));
            objlist.Add(new csParameterListType("@Happenings", SqlDbType.VarChar, Happenings.ToString()));
            objlist.Add(new csParameterListType("@Time", SqlDbType.VarChar, Time.ToString()));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objdal.executespreturnnd("procClient_YearPlanner_Update", objlist);

        }

        public DataTable viewYearPlanner_By_Client_ID_and_Date(Int32 Client_ID, string Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            dt = objdal.search("procClient_YearPlanner_By_Client_ID_and_Date", objlist);
            return dt;
        }

        public DataTable viewYearPlanner_By_Client_ID_and_Year(Int32 Client_ID, string Year)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Year", SqlDbType.VarChar, Year.ToString()));
            dt = objdal.search("procClient_YearPlanner_By_Client_ID_and_Year", objlist);
            return dt;
        }

        public DataTable viewYearPlanner_By_Client_ID_and_Year_Few(Int32 Client_ID, string Year, Int32 SelTop)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Year", SqlDbType.VarChar, Year.ToString()));
            objlist.Add(new csParameterListType("@SelTop", SqlDbType.BigInt, SelTop));
            dt = objdal.search("procClient_YearPlanner_By_Client_ID_and_Year_Few", objlist);
            return dt;
        }

        public DataTable viewYearPlanner_By_YearPlanner_ID(Int32 YearPlanner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@YearPlanner_ID", SqlDbType.BigInt, YearPlanner_ID));
            dt = objdal.search("procClient_YearPlanner_By_YearPlanner_ID", objlist);
            return dt;
        }


        public DataTable viewYearPlanner_Empty()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procClient_YearPlanner_Empty");
            return dt;
        }

        public void addYearPlanner_Empty()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Year", SqlDbType.VarChar, Year.ToString()));
            objdal.executespreturnnd("procClient_YearPlanner_Insert_Empty", objlist);
        }

        #endregion

        #region MyDiary

        public void addMyDiary()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date.ToString()));
            objlist.Add(new csParameterListType("@Diary_Times", SqlDbType.VarChar, Diary_Times.ToString()));
            objlist.Add(new csParameterListType("@Appointment", SqlDbType.VarChar, Appointment.ToString()));
            objlist.Add(new csParameterListType("@ToDo", SqlDbType.VarChar, ToDo.ToString()));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objdal.executespreturnnd("procMyDiary_Insert", objlist);
        }

        public void updateMyDiary()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date.ToString()));
            objlist.Add(new csParameterListType("@Diary_Times", SqlDbType.VarChar, Diary_Times.ToString()));
            objlist.Add(new csParameterListType("@Appointment", SqlDbType.VarChar, Appointment.ToString()));
            objlist.Add(new csParameterListType("@ToDo", SqlDbType.VarChar, ToDo.ToString()));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objdal.executespreturnnd("procMyDiary_Update", objlist);
        }

        public DataTable viewMyDiary_By_Profile_ID_and_Diary_Date_and_Diary_Times(Int32 Profile_ID, string Diary_Date, string Diary_Times)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date));
            objlist.Add(new csParameterListType("@Diary_Times", SqlDbType.VarChar, Diary_Times));
            dt = objdal.search("procMyDiary_View_By_Profile_ID_and_Diary_Date_and_Diary_Times", objlist);
            return dt;
        }

        public DataTable viewMyDiary_By_Profile_ID_and_Diary_Date(Int32 Profile_ID, string Diary_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date.ToString()));
            dt = objdal.search("procMyDiary_View_By_Profile_ID_and_Diary_Date", objlist);
            return dt;
        }

        public DataTable viewAll_MyDiary()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procMyDiary_Times_View_All");
            return dt;
        }

        #endregion

    }
}
