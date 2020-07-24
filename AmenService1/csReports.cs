using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csReports
    {
        csDAL objdal = new csDAL();

        public Int32 Attendance_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Date_From { set; get; }
        public string Date_To { set; get; }

        public csReports()
        { }


        public DataTable viewMembers_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procReport_All_Members_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewMembersReport_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procReport_All_Members_By_Client_ID", objpar);
            return dt;
        }

         public DataTable viewMembers_By_Client_ID02(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_By_Client_ID02", objpar);
             return dt;
         }



         public DataTable viewMembers_and_Guests_and_NewConverts_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_and_Guests_and_NewConverts_By_Client_ID", objpar);
             return dt;
         }



         public DataTable viewMembers_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Members_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewMembers_and_Guests_and_NewConverts_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Members_and_Guests_and_NewConverts_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewMembers_Females_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Females_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewMembers_Females_By_Client_ID02(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Females_By_Client_ID02", objpar);
             return dt;
         }

         public DataTable viewMembers_Females_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Members_Females_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewMembers_Males_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewMembers_Males_By_Client_ID02(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID02", objpar);
             return dt;
         }

         public DataTable viewMembers_Males_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID_with_Period", objpar);
             return dt;
         }


         public DataTable viewMembers_Married_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Married_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewMembers_Married_By_Client_ID02(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Married_By_Client_ID02", objpar);
             return dt;
         }

         public DataTable viewMembers_Married_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Members_Married_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewMembers_Singles_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Singles_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewMembers_Singles_By_Client_ID02(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Singles_By_Client_ID02", objpar);
             return dt;
         }

         public DataTable viewMembers_Singles_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Members_Singles_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewMembers_Divorced_By_Client_ID02(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Divorced_By_Client_ID02", objpar);
             return dt;
         }

         public DataTable viewMembers_Widow_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Widow_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewMembers_Widow_By_Client_ID02(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Widow_By_Client_ID02", objpar);
             return dt;
         }


         public DataTable viewNewConverts_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_NewConverts_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewNewConverts_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_NewConverts_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewGuests_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Guests_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewGuests_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Guests_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewAttritions_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Attritions_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewAttritions_By_Client_ID_with_Period(Int32 Client_ID, string Date_From, string Date_To)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
             objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
             dt = objdal.search("procReport_All_Attritions_By_Client_ID_with_Period", objpar);
             return dt;
         }

         public DataTable viewCell_Leaders_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_Home_Cells_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewCell_Interns_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_Home_Cell_Interns_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewCell_Leaders_and_Interns_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_Home_Cell_Leader_and_Interns_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewLeadership_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_Leadership_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewBirthdays_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_Birthdays_Today_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewWorkers_By_Client_ID(Int32 Client_ID, string Workers_Year)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Workers_Year", SqlDbType.VarChar, Workers_Year));
             dt = objdal.search("procReports_Workers_By_Client_ID", objpar);
             return dt;
         }

        //-------------Members with smartphone------------------
         public DataTable viewReport_Members_with_SmartPhone_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_with_SmartPhone_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewReport_Members_with_SmartPhone_By_Client_ID_and_Gender(Int32 Client_ID, string Gender)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender));
             dt = objdal.search("procReport_All_Members_with_SmartPhone_By_Client_ID_and_Gender", objpar);
             return dt;
         }


        //---------------------Networks-------------------------------------
         public DataTable viewNetworks_By_Client_ID_Mens(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID02_Mens", objlist);
             return dt;
         }

         public DataTable viewNetworks_By_Client_ID_Womens(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID02_Womens", objlist);
             return dt;
         }

         public DataTable viewNetworks_By_Client_ID_Youth(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID02_Youth", objlist);
             return dt;
         }

         public DataTable viewNetworks_By_Client_ID_Young_Adults(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID02_Young_Adults", objlist);
             return dt;
         }

         public DataTable viewNetworks_By_Client_ID_Childrens(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID02_Childrens", objlist);
             return dt;
         }

         public DataTable viewNetworks_By_Client_ID_Couples(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procReport_All_Members_Males_By_Client_ID02_Couples", objlist);
             return dt;
         }

        #region Report_Filter

        public DataTable ViewReport_Filter1()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procReport_Filter1");
            return dt;
        }

        public DataTable viewReport_Filter2_By_Filter1(Int32 parent_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@parentID", SqlDbType.BigInt, parent_ID));
            dt = objdal.search("procReport_Filter2", objpar);
            return dt;
        }

        public DataTable viewReport_Filter3_By_Filter2(Int32 parent_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@parentID", SqlDbType.BigInt, parent_ID));
            dt = objdal.search("procReport_Filter3", objpar);
            return dt;
        }

        public DataTable viewReport_Result(Int32 clientID, Int32 cfId, Int32 specificID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objpar.Add(new csParameterListType("@cfId", SqlDbType.BigInt, cfId));
            objpar.Add(new csParameterListType("@specific_ID", SqlDbType.BigInt, specificID));
            dt = objdal.search("procReport_FilterAll_BySP", objpar);
            return dt;
        }


        #endregion

    }
}
