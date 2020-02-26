using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csCommunication
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

        public csCommunication()
        { }


        #region Communication_Filter

        public DataTable ViewCommunication_Filter1()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procCommunication_Filter1");
            return dt;
        }

        public DataTable viewCommunication_Filter2_By_Filter1(Int32 parent_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@parentID", SqlDbType.BigInt, parent_ID));
            dt = objdal.search("procCommunication_Filter2", objpar);
            return dt;
        }

        public DataTable viewCommunication_Filter3_By_Filter2(Int32 parent_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@parentID", SqlDbType.BigInt, parent_ID));
            dt = objdal.search("procCommunication_Filter3", objpar);
            return dt;
        }

        public DataTable viewCommunication_Result(Int32 clientID, Int32 cfId, Int32 specificID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objpar.Add(new csParameterListType("@cfId", SqlDbType.BigInt, cfId));
            objpar.Add(new csParameterListType("@specific_ID", SqlDbType.BigInt, specificID));
            dt = objdal.search("procCommunication_FilterAll_BySP", objpar);
            return dt;
        }


        #endregion

        #region AppUserDevices
        public DataTable appUserDeviceCrude(string crude, Int32 User_ID, Int32 Client_ID, string Name, string Surname, string Mobile, string Email, string ChurchName, Int32 Profile_ID, string MembershipNumber, string Password, string token, string uuid, string manufacture, string model, string os, string osVersion, string language)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Name", SqlDbType.VarChar, Name));
            objlist.Add(new csParameterListType("@Surname", SqlDbType.VarChar, Surname));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email));
            objlist.Add(new csParameterListType("@ChurchName", SqlDbType.VarChar, ChurchName));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@MembershipNumber", SqlDbType.VarChar, MembershipNumber));
            objlist.Add(new csParameterListType("@Password", SqlDbType.VarChar, Password));
            objlist.Add(new csParameterListType("@token", SqlDbType.VarChar, token));
            objlist.Add(new csParameterListType("@uuid", SqlDbType.VarChar, uuid));
            objlist.Add(new csParameterListType("@manufacture", SqlDbType.VarChar, manufacture));
            objlist.Add(new csParameterListType("@model", SqlDbType.VarChar, model));
            objlist.Add(new csParameterListType("@os", SqlDbType.VarChar, os));
            objlist.Add(new csParameterListType("@osVersion", SqlDbType.VarChar, osVersion));
            objlist.Add(new csParameterListType("@language", SqlDbType.VarChar, language));
            dt = objdal.search("procAppUserAndDeviceCrude", objlist);
            return dt;
        }

        #endregion


        public DataTable smsOutBoxCrude(string crude, Int32 clientID, Int32 messageID, Int32 sentByProfileID, string sentToMobile, string message, string recipientCount)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, messageID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, sentByProfileID));
            objlist.Add(new csParameterListType("@Message_To", SqlDbType.VarChar, sentToMobile));
            objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, message));
            objlist.Add(new csParameterListType("@Recipient_Count", SqlDbType.VarChar, recipientCount));
            dt = objdal.search("procClient_SMS_Outbox_Crude", objlist);
            return dt;
        }

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
            dt = objdal.search("procClient_SMS_Line_ClientID2", objpar);
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

        public DataTable birthDaysCrude(string crude, string category, Int32 clientID, Int32 birthdayID, Int32 weddingID, string sendTime, string message, string active)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, category));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Birthday_ID", SqlDbType.BigInt, birthdayID));
            objlist.Add(new csParameterListType("@Wedding_ID", SqlDbType.BigInt, weddingID));
            objlist.Add(new csParameterListType("@SendTime", SqlDbType.VarChar, sendTime));
            objlist.Add(new csParameterListType("@SMSMessage", SqlDbType.VarChar, message));
            objlist.Add(new csParameterListType("@Active", SqlDbType.VarChar, active));
            dt = objdal.search("procBirthDaysCrude", objlist);
            return dt;
        }


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
