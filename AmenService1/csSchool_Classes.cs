using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csSchool_Classes
    {
        csDAL objdal = new csDAL();

        public Int32 Profile_ID { set; get; }
        public Int32 Class_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Class_Number { set; get; }
        public string Class_Name { set; get; }
        public string Class_Inteded_Outcomes { set; get; }
        public string Class_Duration { set; get; }
        public string Class_Time { set; get; }
        public string Class_Capacity { set; get; }
        public string Class_Active { set; get; }
        public string Reg_Date { set; get; }
        public string LastUpdate_Date { set; get; }

        public Int32 Teacher_ID { set; get; }
        public string Is_Active { set; get; }

        public Int32 Learner_ID { set; get; }

        public Int32 TimeTable_ID { set; get; }
        public string TimeTable_Date { set; get; }
        public string TimeTable_Time { set; get; }

        public Int32 Attendance_ID { set; get; }
        public string Date { set; get; }
        public string Time { set; get; }
        public string Present { set; get; } 

        public csSchool_Classes()
        { }


        public void addSchool_Class_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Class_Number", SqlDbType.VarChar, Class_Number.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_ClassesPre_Insert", objlist);
        }

        public void updateSchool_Class()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Class_Name", SqlDbType.VarChar, Class_Name.ToString()));
            objlist.Add(new csParameterListType("@Class_Inteded_Outcomes", SqlDbType.VarChar, Class_Inteded_Outcomes.ToString()));
            objlist.Add(new csParameterListType("@Class_Duration", SqlDbType.VarChar, Class_Duration.ToString()));
            objlist.Add(new csParameterListType("@Class_Time", SqlDbType.VarChar, Class_Time));
            objlist.Add(new csParameterListType("@Class_Capacity", SqlDbType.VarChar, Class_Capacity));
            objlist.Add(new csParameterListType("@Class_Active", SqlDbType.VarChar, Class_Active));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_Classes_Update", objlist);
        }


        public DataTable viewSchool_Class_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procSchool_Classes_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_By_Class_ID(Int32 Class_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            dt = objdal.search("procSchool_Classes_By_Class_ID", objpar);
            return dt;
        }

        public DataTable viewClass_ID_ByClass_Number(string Class_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_Number", SqlDbType.VarChar, Class_Number.ToString()));
            dt = objdal.search("procClass_ID_By_Class_Number", objpar);
            return dt;
        }

        //---------------Teachers------------------------------

        public void addSchool_Class_Teacher()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Is_Active", SqlDbType.VarChar, Is_Active));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_Class_Teachers_Insert", objlist);
        }

        public void updateSchool_Class_Teacher()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Teacher_ID", SqlDbType.BigInt, Teacher_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Is_Active", SqlDbType.VarChar, Is_Active));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_Class_Teachers_Update", objlist);
        }


        public DataTable viewSchool_Class_Teacher_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procSchool_Class_Teachers_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Teacher_By_Class_ID(Int32 Class_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            dt = objdal.search("procSchool_Class_Teachers_By_Class_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Teacher_By_Teacher_ID(Int32 Teacher_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Teacher_ID", SqlDbType.BigInt, Teacher_ID));
            dt = objdal.search("procSchool_Class_Teachers_By_Teacher_ID", objpar);
            return dt;
        }



        //---------------Learners------------------------------

        public void addSchool_Class_Learner()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Is_Active", SqlDbType.VarChar, Is_Active));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_Class_Learners_Insert", objlist);
        }

        public void updateSchool_Class_Learner()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Learner_ID", SqlDbType.BigInt, Learner_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Is_Active", SqlDbType.VarChar, Is_Active));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_Class_Learners_Update", objlist);
        }


        public DataTable viewSchool_Class_Learner_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procSchool_Class_Learners_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Learner_By_Class_ID(Int32 Class_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            dt = objdal.search("procSchool_Class_Learners_By_Class_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Learner_By_Learner_ID(Int32 Learner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Learner_ID", SqlDbType.BigInt, Learner_ID));
            dt = objdal.search("procSchool_Class_Learners_By_Learner_ID", objpar);
            return dt;
        }


        //---------------TimeTable------------------------------

        public void addSchool_Class_TimeTable()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@TimeTable_Time", SqlDbType.VarChar, TimeTable_Time));
            objlist.Add(new csParameterListType("@TimeTable_Date", SqlDbType.VarChar, TimeTable_Date));
            objlist.Add(new csParameterListType("@Is_Active", SqlDbType.VarChar, Is_Active));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_Class_TimeTables_Insert", objlist);
        }

        public void updateSchool_Class_TimeTable()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@TimeTable_ID", SqlDbType.BigInt, TimeTable_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@TimeTable_Time", SqlDbType.VarChar, TimeTable_Time));
            objlist.Add(new csParameterListType("@TimeTable_Date", SqlDbType.VarChar, TimeTable_Date));
            objlist.Add(new csParameterListType("@Is_Active", SqlDbType.VarChar, Is_Active));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procSchool_Class_TimeTables_Update", objlist);
        }


        public DataTable viewSchool_Class_TimeTable_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procSchool_Class_TimeTables_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_TimeTable_By_Class_ID(Int32 Class_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            dt = objdal.search("procSchool_Class_TimeTables_By_Class_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_TimeTable_By_TimeTable_ID(Int32 TimeTable_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@TimeTable_ID", SqlDbType.BigInt, TimeTable_ID));
            dt = objdal.search("procSchool_Class_TimeTables_By_TimeTable_ID", objpar);
            return dt;
        }


        //---------------Attendance------------------------------

        public void addSchool_Class_Attendance()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Time", SqlDbType.VarChar, Time.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Present", SqlDbType.VarChar, Present.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procSchool_Class_Attendances_Insert", objlist);
        }

        public void updateSchool_Class_Attendance()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, Attendance_ID));
            objlist.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Time", SqlDbType.VarChar, Time.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Present", SqlDbType.VarChar, Present.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procSchool_Class_Attendances_Update", objlist);
        }


        public DataTable viewSchool_Class_Attendance_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procSchool_Class_Attendances_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Attendance_By_Class_ID(Int32 Class_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            dt = objdal.search("procSchool_Class_Attendances_By_Class_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Attendance_By_Attendance_ID(Int32 TimeTable_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, Attendance_ID));
            dt = objdal.search("procSchool_Class_Attendances_By_Attendance_ID", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Attendance_Learner_By_Class_ID(Int32 Class_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            dt = objdal.search("procSchool_Class_Attendance_Learners_By_Class_ID", objpar);
            return dt;
        }

        public void updateSchool_Class_Attendance_Present()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, Attendance_ID));
            objlist.Add(new csParameterListType("@Present", SqlDbType.VarChar, Present.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procSchool_Class_Attendances_Present_Update", objlist);
        }


        public DataTable viewSchool_Class_Attendance_By_Client_ID_Date(Int32 Client_ID, string Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date));
            dt = objdal.search("procSchool_Class_Attendances_By_Client_ID_Date", objpar);
            return dt;
        }

        public DataTable viewSchool_Class_Attendance_By_Class_ID_Date(Int32 Class_ID, string Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Class_ID", SqlDbType.BigInt, Class_ID));
            objpar.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date));
            dt = objdal.search("procSchool_Class_Attendances_By_Class_ID_Date", objpar);
            return dt;
        }

    }
}
