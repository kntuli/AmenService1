using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csClientSMS
    {
        csDAL objdal = new csDAL();

        //-------------Company-------------------
        public Int32 Message_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Message_To { set; get; }
        public string Message_Date { set; get; }
        public string Message { set; get; }
        public string Recipient_Count { set; get; }

        public string SendTime { set; get; }
        public string SMSMessage { set; get; }
        public string Active { set; get; }
        public string LastSendDate { set; get; }

        public csClientSMS()
        { }
        
        //--------------Client----------------------------------------
        public void addClientSMS()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Message_To", SqlDbType.VarChar, Message_To.ToString()));
            objlist.Add(new csParameterListType("@Message_Date", SqlDbType.VarChar, Message_Date.ToString()));
            objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, Message.ToString()));
            objlist.Add(new csParameterListType("@Recipient_Count", SqlDbType.VarChar, Recipient_Count.ToString()));
            objdal.executespreturnnd("procClient_SMS_Outbox_Insert", objlist);
        }

        public DataTable viewClientSMS_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_SMS_Outbox_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewClientSMS_By_Message_ID(Int32 Message_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, Message_ID));
            dt = objdal.search("procClient_SMS_Outbox_By_Message_ID", objpar);
            return dt;
        }


        public DataTable viewClient_SMS_Accounts_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_SMS_Accounts_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewSMS_Line_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procSMS_Line_By_ClientID", objpar);
            return dt;
        }

        public DataTable Delete_SMS_Line_By_Msg_ID(Int32 Msg_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Msg_ID", SqlDbType.BigInt, Msg_ID));
            dt = objdal.search("procSMS_Line_Delete", objpar);
            return dt;
        }

        #region AutoBirthdays

        public DataTable viewClient_Auto_Birthdays_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Auto_Birthdays_By_Client_ID", objpar);
            return dt;
        }

        public void update_Client_Auto_Birthdays_Options()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@SendTime", SqlDbType.VarChar, SendTime.ToString()));
            objlist.Add(new csParameterListType("@SMSMessage", SqlDbType.VarChar, SMSMessage.ToString()));
            objlist.Add(new csParameterListType("@Active", SqlDbType.VarChar, Active.ToString()));
            objdal.executespreturnnd("procClient_Auto_Birthdays_Options_Update", objlist);
        }

        public void update_Client_Auto_Birthdays_SendDate()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@LastSendDate", SqlDbType.VarChar, LastSendDate.ToString()));
            objdal.executespreturnnd("procClient_Auto_Birthdays_SendDate_Update", objlist);
        }

        #endregion

        #region AutoWeddings

        public DataTable viewClient_Auto_Wedding_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Auto_Wedding_By_Client_ID", objpar);
            return dt;
        }

        public void update_Client_Auto_Wedding_Options()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@SendTime", SqlDbType.VarChar, SendTime.ToString()));
            objlist.Add(new csParameterListType("@SMSMessage", SqlDbType.VarChar, SMSMessage.ToString()));
            objlist.Add(new csParameterListType("@Active", SqlDbType.VarChar, Active.ToString()));
            objdal.executespreturnnd("procClient_Auto_Wedding_Options_Update", objlist);
        }

        public void update_Client_Auto_Wedding_SendDate()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@LastSendDate", SqlDbType.VarChar, LastSendDate.ToString()));
            objdal.executespreturnnd("procClient_Auto_Wedding_SendDate_Update", objlist);
        }

        #endregion

    }
}
