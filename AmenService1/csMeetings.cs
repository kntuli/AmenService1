using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csMeetings
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Meeting_ID { set; get; }
        public string Meeting_Number { set; get; }
        public string Meeting_Category { set; get; }
        public string Meeting_Specific_Category { set; get; }
        public string Meeting_Title { set; get; }
        public string Meeting_Date { set; get; }
        public string Start_Time { set; get; }
        public string Finish_Time { set; get; }
        public string Meeting_Venue { set; get; }
        public string MeetingStillOn { set; get; }
        public string Agenda { set; get; }
        public string Agenda_File { set; get; }
        public byte[] Agenda_Data { set; get; }
        public string Minutes { set; get; }
        public string Minutes_File { set; get; }
        public byte[] Minutes_Data { set; get; }
        public string Invited_Total { set; get; }
        public string Invited_Names { set; get; }
        public string Attended_Total { set; get; }
        public string Attended_Names { set; get; }
        public string Reg_Date { set; get; }
        public string LastUpdate_Date { set; get; }
        public Int32 Category_ID { set; get; }

        public csMeetings()
        { }

        public void addMeeting_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_Number", SqlDbType.VarChar, Meeting_Number.ToString()));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Pre_Insert", objlist);
        }

        public void updateMeeting()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Meeting_Category", SqlDbType.VarChar, Meeting_Category.ToString()));
            objlist.Add(new csParameterListType("@Meeting_Specific_Category", SqlDbType.VarChar, Meeting_Specific_Category.ToString()));
            objlist.Add(new csParameterListType("@Meeting_Title", SqlDbType.VarChar, Meeting_Title.ToString()));
            objlist.Add(new csParameterListType("@Meeting_Date", SqlDbType.VarChar, Meeting_Date.ToString()));
            objlist.Add(new csParameterListType("@Start_Time", SqlDbType.VarChar, Start_Time));
            objlist.Add(new csParameterListType("@Finish_Time", SqlDbType.VarChar, Finish_Time));
            objlist.Add(new csParameterListType("@Meeting_Venue", SqlDbType.VarChar, Meeting_Venue));
            objlist.Add(new csParameterListType("@MeetingStillOn", SqlDbType.VarChar, MeetingStillOn));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Update", objlist);
        }

        public void updateMeeting_For_Projects()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Update_For_Projects", objlist);
        }

        public DataTable viewMeeting_ID_ByMeeting_Number(string Meeting_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Meeting_Number", SqlDbType.VarChar, Meeting_Number.ToString()));
            dt = objdal.search("procMeeting_ID_By_Meeting_Number", objpar);
            return dt;
        }

        public DataTable viewMeetings_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procMeetings_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewMeetings_By_Client_ID_and_Category_ID(Int32 Client_ID, Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procMeetings_By_Client_ID_and_Category_ID", objpar);
            return dt;
        }

        public DataTable viewMeetings_By_Client_ID_and_Meeting_Category(Int32 Client_ID, string Meeting_Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Meeting_Category", SqlDbType.VarChar, Meeting_Category.ToString()));
            dt = objdal.search("procMeetings_By_Client_ID_and_Meeting_Category", objpar);
            return dt;
        }

        public DataTable viewMeetings_Category_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procMeetings_Category_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewMeetings_By_Meeting_ID(Int32 Meeting_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            dt = objdal.search("procMeetings_By_Meeting_ID", objpar);
            return dt;
        }

        public DataTable searchForMeetingsByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procMeetings_SearchByAnyField1", objpar);
            return dt;
        }


        public void updateMeeting_Agenda()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Agenda", SqlDbType.VarChar, Agenda.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Agenda_Update", objlist);
        }

        public void updateMeeting_Agenda_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Agenda_File", SqlDbType.VarChar, Agenda_File.ToString()));
            objlist.Add(new csParameterListType("@Agenda_Data", SqlDbType.VarBinary, Agenda_Data));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Agenda_File_Update", objlist);
        }

        public DataTable viewMeetings_Agenda_By_Meeting_ID(Int32 Meeting_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            dt = objdal.search("procMeetings_Agenda_By_Meeting_ID", objpar);
            return dt;
        }



        public void updateMeeting_Minutes()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Minutes", SqlDbType.VarChar, Minutes.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Minutes_Update", objlist);
        }

        public void updateMeeting_Minutes_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Minutes_File", SqlDbType.VarChar, Minutes_File.ToString()));
            objlist.Add(new csParameterListType("@Minutes_Data", SqlDbType.VarBinary, Minutes_Data));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Minutes_File_Update", objlist);
        }

        public DataTable viewMeetings_Minutes_By_Meeting_ID(Int32 Meeting_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            dt = objdal.search("procMeetings_Minutes_By_Meeting_ID", objpar);
            return dt;
        }


        public void updateMeeting_Invited()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Invited_Total", SqlDbType.VarChar, Invited_Total.ToString()));
            objlist.Add(new csParameterListType("@Invited_Names", SqlDbType.VarChar, Invited_Names.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Invited_Update", objlist);
        }

        public DataTable viewMeetings_Invited_By_Meeting_ID(Int32 Meeting_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            dt = objdal.search("procMeetings_Invited_By_Meeting_ID", objpar);
            return dt;
        }

        public void updateMeeting_Attended()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            objlist.Add(new csParameterListType("@Attended_Total", SqlDbType.VarChar, Attended_Total.ToString()));
            objlist.Add(new csParameterListType("@Attended_Names", SqlDbType.VarChar, Attended_Names.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procMeetings_Attended_Update", objlist);
        }

        public DataTable viewMeetings_Attended_By_Meeting_ID(Int32 Meeting_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Meeting_ID", SqlDbType.BigInt, Meeting_ID));
            dt = objdal.search("procMeetings_Attended_By_Meeting_ID", objpar);
            return dt;
        }




    }
}
