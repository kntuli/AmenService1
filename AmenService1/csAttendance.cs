using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csAttendance
    {
        csDAL objdal = new csDAL();

        public Int32 Attendance_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Service { set; get; }
        public string Category { set; get; }
        public string Service_Date { set; get; }
        public string Service_Time { set; get; }
        public string Service_Venue { set; get; }

        public Int32 Members { set; get; }
        public Int32 Members_Males { set; get; }
        public Int32 Members_Females { set; get; }

        public Int32 Children { set; get; }
        public Int32 Children_Males { set; get; }
        public Int32 Children_Females { set; get; }

        public Int32 Guests { set; get; }
        public Int32 Guests_Males { set; get; }
        public Int32 Guests_Females { set; get; }

        public Int32 Altar_Call { set; get; }
        public Int32 Altar_Call_Males { set; get; }
        public Int32 Altar_Call_Females { set; get; }

        public Int32 Bus_Taxi1 { set; get; }
        public Int32 Bus_Taxi1Adults { set; get; }
        public Int32 Bus_Taxi1Children { set; get; }
        public string Bus_Taxi_Area_Name1 { set; get; }
        public string Bus_Taxi_Arrival_Time1 { set; get; }

        public Int32 Bus_Taxi2 { set; get; }
        public Int32 Bus_Taxi2Adults { set; get; }
        public Int32 Bus_Taxi2Children { set; get; }
        public string Bus_Taxi_Area_Name2 { set; get; }
        public string Bus_Taxi_Arrival_Time2 { set; get; }

        public Int32 Bus_Taxi3 { set; get; }
        public Int32 Bus_Taxi3Adults { set; get; }
        public Int32 Bus_Taxi3Children { set; get; }
        public string Bus_Taxi_Area_Name3 { set; get; }
        public string Bus_Taxi_Arrival_Time3 { set; get; }

        public Int32 Bus_Taxi4 { set; get; }
        public Int32 Bus_Taxi4Adults { set; get; }
        public Int32 Bus_Taxi4Children { set; get; }
        public string Bus_Taxi_Area_Name4 { set; get; }
        public string Bus_Taxi_Arrival_Time4 { set; get; }

        public Int32 Bus_Taxi5 { set; get; }
        public Int32 Bus_Taxi5Adults { set; get; }
        public Int32 Bus_Taxi5Children { set; get; }
        public string Bus_Taxi_Area_Name5 { set; get; }
        public string Bus_Taxi_Arrival_Time5 { set; get; }

        public Int32 Bus_Taxi6 { set; get; }
        public Int32 Bus_Taxi6Adults { set; get; }
        public Int32 Bus_Taxi6Children { set; get; }
        public string Bus_Taxi_Area_Name6 { set; get; }
        public string Bus_Taxi_Arrival_Time6 { set; get; }

        public Int32 Bus_Taxi7 { set; get; }
        public Int32 Bus_Taxi7Adults { set; get; }
        public Int32 Bus_Taxi7Children { set; get; }
        public string Bus_Taxi_Area_Name7 { set; get; }
        public string Bus_Taxi_Arrival_Time7 { set; get; }

        public Int32 Bus_Taxi8 { set; get; }
        public Int32 Bus_Taxi8Adults { set; get; }
        public Int32 Bus_Taxi8Children { set; get; }
        public string Bus_Taxi_Area_Name8 { set; get; }
        public string Bus_Taxi_Arrival_Time8 { set; get; }

        public Int32 Bus_Taxi9 { set; get; }
        public Int32 Bus_Taxi9Adults { set; get; }
        public Int32 Bus_Taxi9Children { set; get; }
        public string Bus_Taxi_Area_Name9 { set; get; }
        public string Bus_Taxi_Arrival_Time9 { set; get; }

        public Int32 Bus_Taxi10 { set; get; }
        public Int32 Bus_Taxi10Adults { set; get; }
        public Int32 Bus_Taxi10Children { set; get; }
        public string Bus_Taxi_Area_Name10 { set; get; }
        public string Bus_Taxi_Arrival_Time10 { set; get; }


        public Int32 Cars_Parked { set; get; }
        public Int32 Other { set; get; }
        public string SummaryNotes { set; get; }
        public string LastUpdate_Date { set; get; }


        public csAttendance()
        { }


        public DataTable attendanceCrude(string crude, Int32 attendanceID, Int32 clientID, Int32 profileID, string attendanceDate, string description, string category, Int32 homeCellID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, attendanceID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
            objlist.Add(new csParameterListType("@Attendance_Date", SqlDbType.VarChar, attendanceDate));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, description));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, category));
            objlist.Add(new csParameterListType("@HomeCell_ID", SqlDbType.BigInt, homeCellID));
            dt = objdal.search("procAttendanceRegisterCrude", objlist);
            return dt;
        }

        public DataTable viewAttendance_By_Client_ID_And_Category(Int32 Client_ID, string Category, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procService_Attendance_By_Client_ID_By_Date2", objpar);
            return dt;
        }


        public void addAttendance()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            
            objlist.Add(new csParameterListType("@Service", SqlDbType.VarChar, Service.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Service_Date", SqlDbType.VarChar, Service_Date));
            objlist.Add(new csParameterListType("@Service_Time", SqlDbType.VarChar, Service_Time));
            objlist.Add(new csParameterListType("@Service_Venue", SqlDbType.VarChar, Service_Venue));
           
            objlist.Add(new csParameterListType("@Members", SqlDbType.BigInt, Members));
            objlist.Add(new csParameterListType("@Members_Males", SqlDbType.BigInt, Members_Males));
            objlist.Add(new csParameterListType("@Members_Females", SqlDbType.BigInt, Members_Females));
            
            objlist.Add(new csParameterListType("@Children", SqlDbType.BigInt, Children));
            objlist.Add(new csParameterListType("@Children_Males", SqlDbType.BigInt, Children_Males));
            objlist.Add(new csParameterListType("@Children_Females", SqlDbType.BigInt, Children_Females));
            
            objlist.Add(new csParameterListType("@Guests", SqlDbType.BigInt, Guests));
            objlist.Add(new csParameterListType("@Guests_Males", SqlDbType.BigInt, Guests_Males));
            objlist.Add(new csParameterListType("@Guests_Females", SqlDbType.BigInt, Guests_Females));
            
            objlist.Add(new csParameterListType("@Altar_Call", SqlDbType.BigInt, Altar_Call));
            objlist.Add(new csParameterListType("@Altar_Call_Males", SqlDbType.BigInt, Altar_Call_Males));
            objlist.Add(new csParameterListType("@Altar_Call_Females", SqlDbType.BigInt, Altar_Call_Females));

            objlist.Add(new csParameterListType("@Bus_Taxi1", SqlDbType.BigInt, Bus_Taxi1));
            objlist.Add(new csParameterListType("@Bus_Taxi1Adults", SqlDbType.BigInt, Bus_Taxi1Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi1Children", SqlDbType.BigInt, Bus_Taxi1Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name1", SqlDbType.VarChar, Bus_Taxi_Area_Name1));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time1", SqlDbType.VarChar, Bus_Taxi_Arrival_Time1));

            objlist.Add(new csParameterListType("@Bus_Taxi2", SqlDbType.BigInt, Bus_Taxi2));
            objlist.Add(new csParameterListType("@Bus_Taxi2Adults", SqlDbType.BigInt, Bus_Taxi2Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi2Children", SqlDbType.BigInt, Bus_Taxi2Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name2", SqlDbType.VarChar, Bus_Taxi_Area_Name2));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time2", SqlDbType.VarChar, Bus_Taxi_Arrival_Time2));

            objlist.Add(new csParameterListType("@Bus_Taxi3", SqlDbType.BigInt, Bus_Taxi3));
            objlist.Add(new csParameterListType("@Bus_Taxi3Adults", SqlDbType.BigInt, Bus_Taxi3Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi3Children", SqlDbType.BigInt, Bus_Taxi3Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name3", SqlDbType.VarChar, Bus_Taxi_Area_Name3));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time3", SqlDbType.VarChar, Bus_Taxi_Arrival_Time3));

            objlist.Add(new csParameterListType("@Bus_Taxi4", SqlDbType.BigInt, Bus_Taxi4));
            objlist.Add(new csParameterListType("@Bus_Taxi4Adults", SqlDbType.BigInt, Bus_Taxi4Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi4Children", SqlDbType.BigInt, Bus_Taxi4Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name4", SqlDbType.VarChar, Bus_Taxi_Area_Name4));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time4", SqlDbType.VarChar, Bus_Taxi_Arrival_Time4));

            objlist.Add(new csParameterListType("@Bus_Taxi5", SqlDbType.BigInt, Bus_Taxi5));
            objlist.Add(new csParameterListType("@Bus_Taxi5Adults", SqlDbType.BigInt, Bus_Taxi5Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi5Children", SqlDbType.BigInt, Bus_Taxi5Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name5", SqlDbType.VarChar, Bus_Taxi_Area_Name5));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time5", SqlDbType.VarChar, Bus_Taxi_Arrival_Time5));

            objlist.Add(new csParameterListType("@Bus_Taxi6", SqlDbType.BigInt, Bus_Taxi6));
            objlist.Add(new csParameterListType("@Bus_Taxi6Adults", SqlDbType.BigInt, Bus_Taxi6Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi6Children", SqlDbType.BigInt, Bus_Taxi6Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name6", SqlDbType.VarChar, Bus_Taxi_Area_Name6));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time6", SqlDbType.VarChar, Bus_Taxi_Arrival_Time6));

            objlist.Add(new csParameterListType("@Bus_Taxi7", SqlDbType.BigInt, Bus_Taxi7));
            objlist.Add(new csParameterListType("@Bus_Taxi7Adults", SqlDbType.BigInt, Bus_Taxi7Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi7Children", SqlDbType.BigInt, Bus_Taxi7Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name7", SqlDbType.VarChar, Bus_Taxi_Area_Name7));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time7", SqlDbType.VarChar, Bus_Taxi_Arrival_Time7));

            objlist.Add(new csParameterListType("@Bus_Taxi8", SqlDbType.BigInt, Bus_Taxi8));
            objlist.Add(new csParameterListType("@Bus_Taxi8Adults", SqlDbType.BigInt, Bus_Taxi8Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi8Children", SqlDbType.BigInt, Bus_Taxi8Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name8", SqlDbType.VarChar, Bus_Taxi_Area_Name8));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time8", SqlDbType.VarChar, Bus_Taxi_Arrival_Time8));

            objlist.Add(new csParameterListType("@Bus_Taxi9", SqlDbType.BigInt, Bus_Taxi9));
            objlist.Add(new csParameterListType("@Bus_Taxi9Adults", SqlDbType.BigInt, Bus_Taxi9Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi9Children", SqlDbType.BigInt, Bus_Taxi9Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name9", SqlDbType.VarChar, Bus_Taxi_Area_Name9));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time9", SqlDbType.VarChar, Bus_Taxi_Arrival_Time9));

            objlist.Add(new csParameterListType("@Bus_Taxi10", SqlDbType.BigInt, Bus_Taxi10));
            objlist.Add(new csParameterListType("@Bus_Taxi10Adults", SqlDbType.BigInt, Bus_Taxi10Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi10Children", SqlDbType.BigInt, Bus_Taxi10Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name10", SqlDbType.VarChar, Bus_Taxi_Area_Name10));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time10", SqlDbType.VarChar, Bus_Taxi_Arrival_Time10));

            objlist.Add(new csParameterListType("@Cars_Parked", SqlDbType.BigInt, Cars_Parked));
            objlist.Add(new csParameterListType("@Other", SqlDbType.BigInt, Other));
            objlist.Add(new csParameterListType("@SummaryNotes", SqlDbType.VarChar, SummaryNotes));

            objdal.executespreturnnd("procService_Attendance_Insert1", objlist);

        }

        public void updateAttendance()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, Attendance_ID));

            objlist.Add(new csParameterListType("@Service", SqlDbType.VarChar, Service.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Service_Date", SqlDbType.VarChar, Service_Date));
            objlist.Add(new csParameterListType("@Service_Time", SqlDbType.VarChar, Service_Time));
            objlist.Add(new csParameterListType("@Service_Venue", SqlDbType.VarChar, Service_Venue));

            objlist.Add(new csParameterListType("@Members", SqlDbType.BigInt, Members));
            objlist.Add(new csParameterListType("@Members_Males", SqlDbType.BigInt, Members_Males));
            objlist.Add(new csParameterListType("@Members_Females", SqlDbType.BigInt, Members_Females));

            objlist.Add(new csParameterListType("@Children", SqlDbType.BigInt, Children));
            objlist.Add(new csParameterListType("@Children_Males", SqlDbType.BigInt, Children_Males));
            objlist.Add(new csParameterListType("@Children_Females", SqlDbType.BigInt, Children_Females));

            objlist.Add(new csParameterListType("@Guests", SqlDbType.BigInt, Guests));
            objlist.Add(new csParameterListType("@Guests_Males", SqlDbType.BigInt, Guests_Males));
            objlist.Add(new csParameterListType("@Guests_Females", SqlDbType.BigInt, Guests_Females));

            objlist.Add(new csParameterListType("@Altar_Call", SqlDbType.BigInt, Altar_Call));
            objlist.Add(new csParameterListType("@Altar_Call_Males", SqlDbType.BigInt, Altar_Call_Males));
            objlist.Add(new csParameterListType("@Altar_Call_Females", SqlDbType.BigInt, Altar_Call_Females));

            objlist.Add(new csParameterListType("@Bus_Taxi1", SqlDbType.BigInt, Bus_Taxi1));
            objlist.Add(new csParameterListType("@Bus_Taxi1Adults", SqlDbType.BigInt, Bus_Taxi1Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi1Children", SqlDbType.BigInt, Bus_Taxi1Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name1", SqlDbType.VarChar, Bus_Taxi_Area_Name1));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time1", SqlDbType.VarChar, Bus_Taxi_Arrival_Time1));

            objlist.Add(new csParameterListType("@Bus_Taxi2", SqlDbType.BigInt, Bus_Taxi2));
            objlist.Add(new csParameterListType("@Bus_Taxi2Adults", SqlDbType.BigInt, Bus_Taxi2Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi2Children", SqlDbType.BigInt, Bus_Taxi2Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name2", SqlDbType.VarChar, Bus_Taxi_Area_Name2));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time2", SqlDbType.VarChar, Bus_Taxi_Arrival_Time2));

            objlist.Add(new csParameterListType("@Bus_Taxi3", SqlDbType.BigInt, Bus_Taxi3));
            objlist.Add(new csParameterListType("@Bus_Taxi3Adults", SqlDbType.BigInt, Bus_Taxi3Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi3Children", SqlDbType.BigInt, Bus_Taxi3Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name3", SqlDbType.VarChar, Bus_Taxi_Area_Name3));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time3", SqlDbType.VarChar, Bus_Taxi_Arrival_Time3));

            objlist.Add(new csParameterListType("@Bus_Taxi4", SqlDbType.BigInt, Bus_Taxi4));
            objlist.Add(new csParameterListType("@Bus_Taxi4Adults", SqlDbType.BigInt, Bus_Taxi4Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi4Children", SqlDbType.BigInt, Bus_Taxi4Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name4", SqlDbType.VarChar, Bus_Taxi_Area_Name4));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time4", SqlDbType.VarChar, Bus_Taxi_Arrival_Time4));

            objlist.Add(new csParameterListType("@Bus_Taxi5", SqlDbType.BigInt, Bus_Taxi5));
            objlist.Add(new csParameterListType("@Bus_Taxi5Adults", SqlDbType.BigInt, Bus_Taxi5Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi5Children", SqlDbType.BigInt, Bus_Taxi5Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name5", SqlDbType.VarChar, Bus_Taxi_Area_Name5));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time5", SqlDbType.VarChar, Bus_Taxi_Arrival_Time5));

            objlist.Add(new csParameterListType("@Bus_Taxi6", SqlDbType.BigInt, Bus_Taxi6));
            objlist.Add(new csParameterListType("@Bus_Taxi6Adults", SqlDbType.BigInt, Bus_Taxi6Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi6Children", SqlDbType.BigInt, Bus_Taxi6Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name6", SqlDbType.VarChar, Bus_Taxi_Area_Name6));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time6", SqlDbType.VarChar, Bus_Taxi_Arrival_Time6));

            objlist.Add(new csParameterListType("@Bus_Taxi7", SqlDbType.BigInt, Bus_Taxi7));
            objlist.Add(new csParameterListType("@Bus_Taxi7Adults", SqlDbType.BigInt, Bus_Taxi7Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi7Children", SqlDbType.BigInt, Bus_Taxi7Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name7", SqlDbType.VarChar, Bus_Taxi_Area_Name7));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time7", SqlDbType.VarChar, Bus_Taxi_Arrival_Time7));

            objlist.Add(new csParameterListType("@Bus_Taxi8", SqlDbType.BigInt, Bus_Taxi8));
            objlist.Add(new csParameterListType("@Bus_Taxi8Adults", SqlDbType.BigInt, Bus_Taxi8Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi8Children", SqlDbType.BigInt, Bus_Taxi8Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name8", SqlDbType.VarChar, Bus_Taxi_Area_Name8));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time8", SqlDbType.VarChar, Bus_Taxi_Arrival_Time8));

            objlist.Add(new csParameterListType("@Bus_Taxi9", SqlDbType.BigInt, Bus_Taxi9));
            objlist.Add(new csParameterListType("@Bus_Taxi9Adults", SqlDbType.BigInt, Bus_Taxi9Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi9Children", SqlDbType.BigInt, Bus_Taxi9Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name9", SqlDbType.VarChar, Bus_Taxi_Area_Name9));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time9", SqlDbType.VarChar, Bus_Taxi_Arrival_Time9));

            objlist.Add(new csParameterListType("@Bus_Taxi10", SqlDbType.BigInt, Bus_Taxi10));
            objlist.Add(new csParameterListType("@Bus_Taxi10Adults", SqlDbType.BigInt, Bus_Taxi10Adults));
            objlist.Add(new csParameterListType("@Bus_Taxi10Children", SqlDbType.BigInt, Bus_Taxi10Children));
            objlist.Add(new csParameterListType("@Bus_Taxi_Area_Name10", SqlDbType.VarChar, Bus_Taxi_Area_Name10));
            objlist.Add(new csParameterListType("@Bus_Taxi_Arrival_Time10", SqlDbType.VarChar, Bus_Taxi_Arrival_Time10));

            objlist.Add(new csParameterListType("@Cars_Parked", SqlDbType.BigInt, Cars_Parked));
            objlist.Add(new csParameterListType("@Other", SqlDbType.BigInt, Other));
            objlist.Add(new csParameterListType("@SummaryNotes", SqlDbType.VarChar, SummaryNotes));

            objdal.executespreturnnd("procService_Attendance_Update", objlist);
        }


        public void deleteAttendance()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, Attendance_ID));
            objdal.executespreturnnd("procService_Attendance_Delete", objlist);
        }




        public DataTable viewAttendance_By_Client_ID(Int32 Client_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procService_Attendance_By_Client_ID_By_Date", objpar);
            return dt;
        }

        public DataTable viewAttendance_By_Attendance_ID(Int32 Attendance_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, Attendance_ID));
            dt = objdal.search("procService_Attendance_By_Attendance_ID", objpar);
            return dt;
        }


    }
}
