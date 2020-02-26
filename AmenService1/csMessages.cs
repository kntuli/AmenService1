using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csMessages
    {
        csDAL objdal = new csDAL();

        public int Message_ID { set; get; }
        public int Profile_ID { set; get; }

        public int Client_ID { set; get; }
        public int From_Profile_ID { set; get; }
        public int To_Profile_ID { set; get; }
        public int Group_ID { set; get; }

        public int Msg_ID { set; get; }
        public int Num { set; get; }
       
        public string Category { set; get; }
        public string fromfullName { set; get; }
        public string fromPhone { set; get; }
        public string tofullName { set; get; }
        public string subject { set; get; }
        public string Message { set; get; }
        
        public string MessageContent { set; get; }
        public string Message_Date1 { set; get; }
        public string Message_Number { set; get; }

        public int Inbox_ID { set; get; }
        public string Read { set; get; }
        public string Read_Date { set; get; }


        public DateTime Message_Date { set; get; }
        public string Message_Mark { set; get; }
        public int Message_No { set; get; }

        public int Comment_ID { set; get; }
        public string Comment { set; get; }
        public DateTime Comment_Date { set; get; }
        public string Comment_Mark { set; get; }

        public int Contact_Person_ID { set; get; }
        public string Reg_Date { set; get; }

         public csMessages()
        { }


        //-------------New-------------------------------
         public void addNew_Message()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objlist.Add(new csParameterListType("@From_Profile_ID", SqlDbType.BigInt, From_Profile_ID));
             objlist.Add(new csParameterListType("@MessageContent", SqlDbType.VarChar, MessageContent.ToString()));
             objlist.Add(new csParameterListType("@Message_Date", SqlDbType.VarChar, Message_Date1));
             objlist.Add(new csParameterListType("@Message_Number", SqlDbType.VarChar, Message_Number));
             objdal.executespreturnnd("procMessages_App_Insert", objlist);
         }

         public void addNew_Message_Inbox()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, Message_ID));
             objlist.Add(new csParameterListType("@Read", SqlDbType.VarChar, Read.ToString()));
             //objlist.Add(new csParameterListType("@Read_Date", SqlDbType.VarChar, Read_Date));
             objdal.executespreturnnd("procMessages_Inbox_App_Insert", objlist);
         }

         public void updateNew_Message_Inbox()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Inbox_ID", SqlDbType.BigInt, Inbox_ID));
             objlist.Add(new csParameterListType("@Read", SqlDbType.VarChar, Read.ToString()));
             objlist.Add(new csParameterListType("@Read_Date", SqlDbType.VarChar, Read_Date));
             objdal.executespreturnnd("procMessages_Inbox_App_Update", objlist);
         }

         public DataTable viewMessages_Inbox_By_Profile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMessages_Inbox_By_Profile_ID2", objpar);
             return dt;
         }

         public DataTable viewMessages_Inbox_Distinct_By_Profile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMessages_Inbox_Distinct_By_Profile_ID2", objpar);
             return dt;
         }

         public DataTable viewMessages_Inbox_By_Group_ID_and_Profile_ID(int Group_ID, int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMessages_Inbox_By_Group_ID_and_Profile_ID", objpar);
             return dt;
         }


         public DataTable viewMessages_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procMessages_By_Client_ID", objpar);
             return dt;
         }


         public DataTable viewAllMessages()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procMessages_View_All");
             return dt;
         }

         public DataTable viewMessage_ID_By_Message_Number(string Message_Number)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Message_Number", SqlDbType.VarChar, Message_Number));
             dt = objdal.search("procMessages_View_By_Message_Number", objpar);
             return dt;
         }



        //--------------Old------------------------
         public csMessages(int cMessage_ID, int cProfile_ID, int cFrom_Profile_ID, int cTo_Profile_ID, int cGroup_ID, string cMessage, string cCategory, DateTime cMessage_Date, string cMessage_Mark,
         int cComment_ID, string cComment, DateTime cComment_Date, string cComment_Mark, int cMessage_No)
        {
            //--------User Accounts----------
            Message_ID = cMessage_ID;
            Profile_ID = cProfile_ID;
            From_Profile_ID = cFrom_Profile_ID;
            To_Profile_ID = cTo_Profile_ID;
            Group_ID = cGroup_ID;
            Message = cMessage;
            Category = cCategory;
            Message_Date = cMessage_Date;
            Message_Mark = cMessage_Mark;
            Message_No = cMessage_No;

            Comment_ID = cComment_ID;
            Comment = cComment;
            Comment_Date = cComment_Date;
            Comment_Mark = cComment_Mark;
        }

         public void addMessage()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@From_Profile_ID", SqlDbType.BigInt, From_Profile_ID));
             objlist.Add(new csParameterListType("@Message_No", SqlDbType.BigInt, Message_No));
             objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, Message.ToString()));
             objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objlist.Add(new csParameterListType("@Message_Date", SqlDbType.DateTime, Message_Date));
             objlist.Add(new csParameterListType("@Message_Mark", SqlDbType.VarChar, Message_Mark.ToString()));
             objdal.executespreturnnd("procMessage_Insert", objlist);
         }

         public void updateMessage()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@From_Profile_ID", SqlDbType.BigInt, From_Profile_ID));
             objlist.Add(new csParameterListType("@Message", SqlDbType.VarChar, Message.ToString()));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Message_Date", SqlDbType.DateTime, Message_Date));
             objlist.Add(new csParameterListType("@Message_Mark", SqlDbType.VarChar, Message_Mark.ToString()));
             objdal.executespreturnnd("procMessage_Update", objlist);
         }




         public DataTable viewMessagesByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMessage_SelectBy_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewMessage_NoByProfile_IDandMessage_ID(int Profile_ID, int Message_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMessageNo_SelectBy_Profile_IDandMessage_ID", objpar);
             return dt;
         }


         public DataTable viewMessage_NoByMessage_IDandFromProfile_ID(int From_Profile_ID, int Message_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@From_Profile_ID", SqlDbType.BigInt, From_Profile_ID));
             objpar.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMessageNo_SelectBy_Message_IDandFrom_Profile_ID", objpar);
             return dt;
         }

         public DataTable getMessage_No()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procMessage_No");
             return dt;
         }


         public DataTable getAllMessages()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procMessages_ViewALL");
             return dt;
         }

         public void deleteMessage(int User_ID)
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, User_ID));
             objdal.executespreturndr("procMessage_Delete", objpar);
         }

         public DataTable searchForMessagesByAnyField(string sVariable)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchMessagesByAnyField", objpar);
             return dt;
         }


        //----------Friends-------------------------

         public DataTable viewFriendsByProfile_ID(int Profile_ID, int Group_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             dt = objdal.search("procFriends_SelectBy_Profile_ID", objpar);
             return dt;
         }

        //-------------Comments----------------------------
         public void addComment()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, Message_ID));
             objlist.Add(new csParameterListType("@From_Profile_ID", SqlDbType.BigInt, From_Profile_ID));
             objlist.Add(new csParameterListType("@Message_No", SqlDbType.BigInt, Message_No));
             objlist.Add(new csParameterListType("@Comment", SqlDbType.VarChar, Comment.ToString()));
             objlist.Add(new csParameterListType("@Comment_Date", SqlDbType.DateTime, Comment_Date));
             objlist.Add(new csParameterListType("@Comment_Mark", SqlDbType.VarChar, Comment_Mark.ToString()));
             objdal.executespreturnnd("procComment_Insert", objlist);
         }

         public DataTable viewCommentsByMessage_ID(int Message_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Message_ID", SqlDbType.BigInt, Message_ID));
             dt = objdal.search("procComments_SelectBy_Message_ID", objpar);
             return dt;
         }

         public DataTable viewCommentsByTo_Profile_ID(int To_Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@To_Profile_ID", SqlDbType.BigInt, To_Profile_ID));
             dt = objdal.search("procComments_SelectBy_To_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewCommentsByMessage_No(int Message_No)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Message_No", SqlDbType.BigInt, Message_No));
             dt = objdal.search("procComments_SelectBy_Message_No", objpar);
             return dt;
         }

        //----------------Group------------------------------
         public DataTable viewAllMessages_Groups()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procMessages_Groups");
             return dt;
         }



         //-------------Contact Person----------------------------
         public void addCommunication_Contact_Person()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procCommunication_Contact_Person_Insert", objlist);
         }

         public DataTable viewCommunication_Contact_Person_By_Group_ID(int Group_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             dt = objdal.search("procCommunication_Contact_Person_By_Group_ID", objpar);
             return dt;
         }

         public DataTable viewCommunication_Contact_Person_By_Profile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procCommunication_Contact_Person_By_Profile_ID", objpar);
             return dt;
         }


         //-------------Msg-------------------------------

         public void addMsg_Admin()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@fromfullName", SqlDbType.VarChar, fromfullName));
             objlist.Add(new csParameterListType("@fromPhone", SqlDbType.VarChar, fromPhone));
             objlist.Add(new csParameterListType("@tofullName", SqlDbType.VarChar, tofullName));
             objlist.Add(new csParameterListType("@subject", SqlDbType.VarChar, subject));
             objlist.Add(new csParameterListType("@message", SqlDbType.VarChar, Message));
             objdal.executespreturnnd("procMsg_Admin_Insert", objlist);
         }


         public void updateMsg_Admin()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Msg_ID", SqlDbType.BigInt, Msg_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objlist.Add(new csParameterListType("@fromfullName", SqlDbType.VarChar, fromfullName));
             objlist.Add(new csParameterListType("@fromPhone", SqlDbType.VarChar, fromPhone));
             objlist.Add(new csParameterListType("@tofullName", SqlDbType.VarChar, tofullName));
             objlist.Add(new csParameterListType("@subject", SqlDbType.VarChar, subject));
             objlist.Add(new csParameterListType("@message", SqlDbType.VarChar, Message));
             objdal.executespreturnnd("procMsg_Admin_Update", objlist);
         }

         public DataTable viewMsg_Admin_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procMsg_Admin_By_Client_ID", objpar);
             return dt;
         }

         public void deleteMsg_Admin()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Msg_ID", SqlDbType.BigInt, Msg_ID));
             objdal.executespreturndr("procMsg_Admin_Delete", objpar);
         }



    }
}
