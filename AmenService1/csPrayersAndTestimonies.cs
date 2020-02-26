using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csPrayersAndTestimonies
    {
        csDAL objdal = new csDAL();

        public Int32 PrayersAndTestimonies_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Category { set; get; }
        public string Collection_Methood { set; get; }
        public string MemberOr { set; get; }
        public Int32 Member_ID { set; get; }
        public string Sender_Name { set; get; }
        public string Date { set; get; }
        public string Sender { set; get; }
        public string Message { set; get; }
        public Int32 Modified_By_ID { set; get; }
        public string Last_Modified_Date { set; get; }

        public string Attended { set; get; }
        public string Attend_Date { set; get; }
        public Int32 Attended_By_ID { set; get; }
        public string Attend_Notes { set; get; }

        public Int32 Profile_ID { set; get; }
        public string Send_To { set; get; }

        public csPrayersAndTestimonies()
        { }

        #region CMS



        public void add_PrayersAndTestimonies()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objlist.Add(new csParameterListType("@Collection_Methood", SqlDbType.VarChar, Collection_Methood.ToString()));
            objlist.Add(new csParameterListType("@MemberOr", SqlDbType.VarChar, MemberOr.ToString()));
            objlist.Add(new csParameterListType("@Sender_Name", SqlDbType.VarChar, Sender_Name.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Sender", SqlDbType.VarChar, Sender.ToString()));
            objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, Message.ToString()));
            objdal.executespreturnnd("procPrayersAndTestimonies_Insert", objlist);
        }

        public void update_PrayersAndTestimonies()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objlist.Add(new csParameterListType("@Collection_Methood", SqlDbType.VarChar, Collection_Methood.ToString()));
            objlist.Add(new csParameterListType("@MemberOr", SqlDbType.VarChar, MemberOr.ToString()));
            objlist.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
            objlist.Add(new csParameterListType("@Sender_Name", SqlDbType.VarChar, Sender_Name.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Sender", SqlDbType.VarChar, Sender.ToString()));
            objlist.Add(new csParameterListType("@Modified_By_ID", SqlDbType.BigInt, Modified_By_ID));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procPrayersAndTestimonies_Update", objlist);
        }


        public DataTable viewPrayersAndTestimonies_By_Client_ID(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPrayersAndTestimonies_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_By_Client_ID_Prayer(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPrayersAndTestimonies_By_Client_ID_Prayer", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_By_Client_ID_Testimony(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPrayersAndTestimonies_By_Client_ID_Testimony", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_By_Client_ID_and_Category(Int32 Client_ID, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procPrayersAndTestimonies_By_Client_ID_and_Category", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_By_PrayersAndTestimonies_ID(Int32 PrayersAndTestimonies_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@PrayersAndTestimonies_ID", SqlDbType.BigInt, PrayersAndTestimonies_ID));
            dt = objdal.search("procPrayersAndTestimonies_By_PrayersAndTestimonies_ID", objpar);
            return dt;
        }



        public void Update_PrayersAndTestimonies_Attend()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@PrayersAndTestimonies_ID", SqlDbType.BigInt, PrayersAndTestimonies_ID));
            objlist.Add(new csParameterListType("@Attended_By_ID", SqlDbType.BigInt, Attended_By_ID));
            objlist.Add(new csParameterListType("@Attend_Date", SqlDbType.VarChar, Attend_Date.ToString()));
            objdal.executespreturnnd("procPrayersAndTestimonies_Attend_Update", objlist);
        }

        public DataTable viewPrayersAndTestimonies_Attend_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPrayersAndTestimonies_Attend_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_Attend_By_Attend_ID(Int32 Attend_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Attend_ID", SqlDbType.BigInt, Attend_ID));
            dt = objdal.search("procPrayersAndTestimonies_Attend_By_Attend_ID", objpar);
            return dt;
        }

        #endregion
        #region Partakers

        public void add_PrayersAndTestimonies_Partakers()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Send_To", SqlDbType.VarChar, Send_To.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Sender", SqlDbType.VarChar, Sender.ToString()));
            objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, Message.ToString()));
            objdal.executespreturnnd("procPrayersAndTestimonies_Partakers_Insert", objlist);
        }

        public void update_PrayersAndTestimonies_Partakers()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@PrayersAndTestimonies_ID", SqlDbType.BigInt, PrayersAndTestimonies_ID));
            objlist.Add(new csParameterListType("@Send_To", SqlDbType.VarChar, Send_To.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Sender", SqlDbType.VarChar, Sender.ToString()));
            objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, Message.ToString()));
            objdal.executespreturnnd("procPrayersAndTestimonies_Partakers_Update", objlist);
        }


        public DataTable viewPrayersAndTestimonies_By_Profile_ID(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPrayersAndTestimonies_Partakers_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_By_Profile_ID_Prayer(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPrayersAndTestimonies_Partakers_By_Profile_ID_Prayer", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_By_Profile_ID_Testimony(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPrayersAndTestimonies_Partakers_By_Profile_ID_Testimony", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_By_Profile_ID_and_Category(Int32 Profile_ID, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procPrayersAndTestimonies_Partakers_By_Profile_ID_and_Category", objpar);
            return dt;
        }

        public DataTable viewPrayersAndTestimonies_Partakers_By_PrayersAndTestimonies_ID(Int32 PrayersAndTestimonies_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@PrayersAndTestimonies_ID", SqlDbType.BigInt, PrayersAndTestimonies_ID));
            dt = objdal.search("procPrayersAndTestimonies_Partakers_By_PrayersAndTestimonies_ID", objpar);
            return dt;
        }


        #endregion

        #region PrayersAndTestimonies

        public DataTable crudePrayers(string crude, Int32 profileID, Int32 prayersAndTestimoniesID, string category, string date, string message)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
            objlist.Add(new csParameterListType("@PrayersAndTestimonies_ID", SqlDbType.BigInt, prayersAndTestimoniesID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, category));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, date));
            objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, message));
            dt = objdal.search("procPrayerCrude", objlist);
            return dt;
        }

        public void addPrayersAndTestimoniesPre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procPrayersAndTestimonies_InsertPre", objlist);
        }

        public void updatePrayersAndTestimonies()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@PrayersAndTestimonies_ID", SqlDbType.BigInt, PrayersAndTestimonies_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, Message.ToString()));
            objdal.executespreturnnd("procPrayersAndTestimonies_Update", objlist);
        }


        public DataTable viewPrayersAndTestimonies_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPrayersAndTestimonies_By_ProfileID", objpar);
            return dt;
        }

        public void deletePrayersAndTestimonies()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@PrayersAndTestimonies_ID", SqlDbType.BigInt, PrayersAndTestimonies_ID));
            objdal.executespreturnnd("procPrayersAndTestimonies_Delete", objlist);
        }

        #endregion
    }
}
