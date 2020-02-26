using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace AmenService1
{
    public class csUser_Accounts
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 User_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Use_Name { set; get; }
        public string Pasword { set; get; }
        public string User_Email { set; get; }
        public string User_Security_Question { set; get; }
        public string User_Security_Answer { set; get; }
        public string User_Active_Status { set; get; }
        public string User_Account_Type { set; get; }
        public string User_Language { set; get; }
        public Int32 UserRole_ID { set; get; }
        public Int32 User_Type_ID { set; get; }
        public DateTime Date_Reg { set; get; }
        public string UserRole_Name { set; get; }
        public int Department_ID { set; get; }
        public string departmentName { set; get; }
        public string departmentNumber { set; get; }
        public string Access { set; get; }
        public string LogInOut { set; get; }
        public string InOrOut { set; get; }
        public string LogInOut_Date { set; get; }


        public Int32 Access_ID { set; get; }
        public Int32 Page_ID { set; get; }
        public string User_Access { set; get; }

        public Int32 Shopper_ID { set; get; }

        public csUser_Accounts()
        { }

        public DataTable viewServiceSecTokenSelectBySecToken1(string secToken)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@secToken", SqlDbType.VarChar, secToken));
            dt = objdal.search("procAmenAdminSettings_View_SecToken", objlist);
            return dt;
        }

        public DataTable userAccountCrude(string crude, Int32 userID, Int32 clientID, Int32 profileID, string userEmail, Int32 userTypeID, string userStatus, string userPassword)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, userID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, userEmail));
            objlist.Add(new csParameterListType("@User_Type_ID", SqlDbType.BigInt, userTypeID));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, userStatus));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, userPassword));
            dt = objdal.search("procUserAccountsCrude", objlist);
            return dt;
        }

        public DataTable updateUuserAccountShowHideIDNumber(Int32 userID, Int32 showHideID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, userID));
            objlist.Add(new csParameterListType("@ShowHideID", SqlDbType.BigInt, showHideID));
            dt = objdal.search("procUserAccountShowHideIDNumber_Update", objlist);
            return dt;
        }

        public DataTable updateUuserAccountVoidFinance(Int32 userID, Int32 voidFinance)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, userID));
            objlist.Add(new csParameterListType("@VoidFinance", SqlDbType.BigInt, voidFinance));
            dt = objdal.search("procUserAccountVoidFinance_Update", objlist);
            return dt;
        }

        public DataTable userAccountMemberCreate(string membershipNumber, string fullName, string mobile, string userName, string userPassword)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@membershipNumber", SqlDbType.VarChar, membershipNumber));
            objlist.Add(new csParameterListType("@fullName", SqlDbType.VarChar, fullName));
            objlist.Add(new csParameterListType("@mobile", SqlDbType.VarChar, mobile));
            objlist.Add(new csParameterListType("@userName", SqlDbType.VarChar, userName));
            objlist.Add(new csParameterListType("@userPassword", SqlDbType.VarChar, userPassword));
            dt = objdal.search("procUserAccountsMemberCreate", objlist);
            return dt;
        }


        public DataTable viewUserAuthentication(string churchCode, string username, string password)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@ChurchCode", SqlDbType.VarChar, churchCode));
            objlist.Add(new csParameterListType("@UserName", SqlDbType.VarChar, username));
            objlist.Add(new csParameterListType("@Password", SqlDbType.VarChar, password));
            dt = objdal.search("procUserAuthentication", objlist);
            return dt;
        }

        public DataTable viewUserAuthenticationMember(string username, string password)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@UserName", SqlDbType.VarChar, username));
            objlist.Add(new csParameterListType("@Password", SqlDbType.VarChar, password));
            dt = objdal.search("procUserAuthenticationMember", objlist);
            return dt;
        }

        public DataTable viewUserMemberByUsername(string username)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, username));
            dt = objdal.search("procUserAccount_By_Email", objlist);
            return dt;
        }

        public void addUser()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Use_Name", SqlDbType.VarChar, Use_Name.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, User_Active_Status.ToString()));
            objlist.Add(new csParameterListType("@User_Account_Type", SqlDbType.VarChar, User_Account_Type.ToString()));
            objlist.Add(new csParameterListType("@User_Language", SqlDbType.VarChar, User_Language.ToString()));
            objlist.Add(new csParameterListType("@Date_Reg", SqlDbType.DateTime, Date_Reg));
            objdal.executespreturnnd("procUser_Insert_SignUp", objlist);
        }


        public void addUser0()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Use_Name", SqlDbType.VarChar, Use_Name.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@Date_Reg", SqlDbType.DateTime, Date_Reg));
            objlist.Add(new csParameterListType("@User_Type_ID", SqlDbType.BigInt, User_Type_ID));
            objdal.executespreturnnd("procUser_Insert0", objlist);
        }

        public void addUser_Activate()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Use_Name", SqlDbType.VarChar, Use_Name.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@Date_Reg", SqlDbType.DateTime, Date_Reg));
            objlist.Add(new csParameterListType("@User_Type_ID", SqlDbType.BigInt, User_Type_ID));
            objdal.executespreturnnd("procUser_Insert_Activate", objlist);
        }


        public void addUser1()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Use_Name", SqlDbType.VarChar, Use_Name.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, User_Active_Status.ToString()));
            objlist.Add(new csParameterListType("@Date_Reg", SqlDbType.DateTime, Date_Reg));
            objlist.Add(new csParameterListType("@User_Type_ID", SqlDbType.BigInt, User_Type_ID));
            objdal.executespreturnnd("procUser_Insert1", objlist);
        }

        public void updateUsers()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, User_Active_Status.ToString()));
            objlist.Add(new csParameterListType("@User_Account_Type", SqlDbType.VarChar, User_Account_Type.ToString()));
            objlist.Add(new csParameterListType("@User_Language", SqlDbType.VarChar, User_Language.ToString()));
            objdal.executespreturnnd("procUser_Update", objlist);
        }

        public void updateUsers1()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@Use_Name", SqlDbType.VarChar, Use_Name.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, User_Active_Status.ToString()));
            objlist.Add(new csParameterListType("@User_Type_ID", SqlDbType.BigInt, User_Type_ID));
            objdal.executespreturnnd("procUser_Accounts_Update1", objlist);
        }

        public void updateUserName_ByID(int User_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@Use_Name", SqlDbType.VarChar, Use_Name.ToString()));
            objdal.executespreturnnd("procUpdate_User_UserName_ByID", objlist);
        }

        public void updateUserLanguage_ByProfileID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@User_Language", SqlDbType.VarChar, User_Language.ToString()));
            objdal.executespreturnnd("procUpdate_UserLanguage_ByProfileID", objlist);
        }

        public void updateUserStatus_ByID(int User_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, User_Active_Status.ToString()));
            objdal.executespreturnnd("procUpdate_UserStatus_ByID", objlist);
        }

        public void UpdatePassword_ByProfileID()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objdal.executespreturnnd("procUpdate_User_Password_ByProfileID", objlist);
        }

        public void updateUserRole_ByID(int User_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@UserRole_ID", SqlDbType.VarChar, UserRole_ID));
            objdal.executespreturnnd("procUpdate_User_UserRole_ByID", objlist);
        }


        public DataTable viewUserByProfile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procUser_View_ByProfileID", objlist);
            return dt;
        }

        public DataTable viewUserAccountsByProfile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procUserAccount_View_ByProfileID", objlist);
            return dt;
        }

        public DataTable viewUserAccountsByProfile_ID2(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procUserAccount_View2_ByProfileID", objlist);
            return dt;
        }

        //

        public DataTable viewUserAccounts_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procUserAccount_View_By_Client_ID", objlist);
            return dt;
        }

        public DataTable view2UserAccountsByProfile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procUserAccount_View2_ByProfileID", objlist);
            return dt;
        }

        public DataTable viewUserAccounts_By_User_ID(Int32 User_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            dt = objdal.search("procUserAccount_View_By_User_ID", objlist);
            return dt;
        }

        public DataTable viewUserByUser_ID(int User_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            dt = objdal.search("procUser_SelectBy_User_ID", objlist);
            return dt;
        }

        public DataTable viewUserByUser_Name(string Use_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Use_Name", SqlDbType.VarChar, Use_Name.ToString()));
            dt = objdal.search("procUser_SelectBy_Username", objlist);
            return dt;
        }

        public DataTable viewUserByEmail(string Email)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, Email.ToString()));
            dt = objdal.search("procUserAccount_By_Email", objlist);
            return dt;
        }


        public DataTable getAllUsers()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procUser_ViewALL");
            return dt;
        }

        public void deleteUser(int User_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objdal.executespreturndr("procUser_Delete", objpar);
        }

        public DataTable searchForUsersByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchUsersByAnyField_Church_Reg", objpar);
            return dt;
        }

        public DataTable searchForUsersByAnyField_User_Login(string sVariable, Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchUsersByAnyField", objpar);
            return dt;
        }


        public DataTable viewAllUser_Types()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procUser_Type_View_All");
            return dt;
        }

        #region User Access

        public DataTable userAccessCrude(string crude, Int32 clientID, Int32 accessID, Int32 userID, Int32 pageID, string userAccess)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Access_ID", SqlDbType.BigInt, accessID));
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, userID));
            objlist.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, pageID));
            objlist.Add(new csParameterListType("@User_Access", SqlDbType.VarChar, userAccess));
            dt = objdal.search("procUserAccessCrude", objlist);
            return dt;
        }


        public DataTable userAccessSubCrude(string crude, Int32 accessSubID, Int32 userID, Int32 pageID, Int32 pageSubID, string userAccess)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Access_Sub_ID", SqlDbType.BigInt, accessSubID));
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, userID));
            objlist.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, pageID));
            objlist.Add(new csParameterListType("@Page_Sub_ID", SqlDbType.BigInt, pageSubID));
            objlist.Add(new csParameterListType("@User_Access", SqlDbType.VarChar, userAccess));
            dt = objdal.search("procUserAccessSubCrude", objlist);
            return dt;
        }

        #endregion

        //---------------Shoppers---------------------------
        public DataTable viewUserByEmail_Shoppers(string Email)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, Email.ToString()));
            dt = objdal.search("procUserAccount_By_Email_Shoppers", objlist);
            return dt;
        }

        public void addUser_Shopper()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objdal.executespreturnnd("addAmen_Shop_Shopper", objlist);
        }

        public void Update_User_Shopper()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objdal.executespreturnnd("procUser_Accounts_Update_Shopper", objlist);
        }

        //------------Access_Rules: Roles vs Departments--------------------

        public void AddUserAccess()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, Page_ID));
            objlist.Add(new csParameterListType("@User_Access", SqlDbType.VarChar, User_Access.ToString()));
            objdal.executespreturnnd("procUserAccess_Insert", objlist);
        }

        public void UpdateUserAccess()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Access_ID", SqlDbType.BigInt, Access_ID));
            //objlist.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, Page_ID));
            objlist.Add(new csParameterListType("@User_Access", SqlDbType.VarChar, User_Access.ToString()));
            objdal.executespreturnnd("procUserAccess_Update", objlist);
        }

        public DataTable viewUserAccess_By_User_ID(Int32 User_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            dt = objdal.search("procUserAccess_By_User_ID", objpar);
            return dt;
        }

        public DataTable viewUserAccess_By_User_ID2(Int32 User_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            dt = objdal.search("procUserAccess_By_User_ID2", objpar);
            return dt;
        }

        public DataTable viewUserAccess_By_User_IDandPage(Int32 User_ID, string page)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objpar.Add(new csParameterListType("@Page", SqlDbType.VarChar, page.ToString()));
            dt = objdal.search("procUserAccess_By_User_IDandPage", objpar);
            return dt;
        }

        public DataTable viewUserAccess_By_User_IDandPage_ID(Int32 User_ID, Int32 Page_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objpar.Add(new csParameterListType("@Page_ID", SqlDbType.BigInt, Page_ID));
            dt = objdal.search("procUserAccess_By_User_IDandPage_ID", objpar);
            return dt;
        }

        public DataTable viewUserAccess_By_User_IDandCustomPage(Int32 Client_ID, Int32 User_ID, string page)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objpar.Add(new csParameterListType("@Page", SqlDbType.VarChar, page.ToString()));
            dt = objdal.search("procUserAccess_By_User_IDandCustomPage", objpar);
            return dt;
        }

        public DataTable viewUserAccess_By_Access_ID(Int32 Access_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Access_ID", SqlDbType.BigInt, Access_ID));
            dt = objdal.search("procUserAccess_By_Access_ID", objpar);
            return dt;
        }

        public void deleteUserAccess()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Access_ID", SqlDbType.BigInt, Access_ID));
            objdal.executespreturndr("procUserAccess_Delete", objpar);
        }

        public DataTable viewAllPages()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPages_View_All");
            return dt;
        }


        //------------User Roles--------------------

        public void addUser_Roles()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
            objlist.Add(new csParameterListType("@Access", SqlDbType.VarChar, Access.ToString()));
            objlist.Add(new csParameterListType("@User_Type_ID", SqlDbType.BigInt, User_Type_ID));
            objdal.executespreturnnd("procUser_Roles_Insert", objlist);
        }

        public void updateUser_Roles()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            objlist.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
            objlist.Add(new csParameterListType("@Access", SqlDbType.VarChar, Access.ToString()));
            objlist.Add(new csParameterListType("@User_Type_ID", SqlDbType.BigInt, User_Type_ID));
            objdal.executespreturnnd("procUser_Roles_Update", objlist);
        }

        public void updateUser_Roles_Access()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            objlist.Add(new csParameterListType("@Access", SqlDbType.VarChar, Access.ToString()));
            objdal.executespreturnnd("procUser_Roles_Access_Update", objlist);
        }

        public void updateUser_Roles1(int UserRole_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            objlist.Add(new csParameterListType("@UserRole_Name", SqlDbType.VarChar, UserRole_Name.ToString()));
            //objlist.Add(new csParameterListType("@Can_View", SqlDbType.VarChar, Can_View.ToString()));
            //objlist.Add(new csParameterListType("@Can_Add", SqlDbType.VarChar, Can_Add.ToString()));
            //objlist.Add(new csParameterListType("@Can_Edit", SqlDbType.VarChar, Can_Edit.ToString()));
            //objlist.Add(new csParameterListType("@Can_Delete", SqlDbType.VarChar, Can_Delete.ToString()));
            objdal.executespreturnnd("procAddUser_Roles1", objlist);
        }

        public DataTable viewUser_Roles_ByID(int UserRole_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            dt = objdal.search("procUser_Roles_ByUserRole_ID", objpar);
            return dt;
        }


        public DataTable viewUser_Roles_ByProfile_IDandDepartment_ID(int Profile_ID, int Department_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
            dt = objdal.search("procUser_Roles_ByProfile_IDandDepartmentID", objpar);
            return dt;
        }

        public DataTable viewUser_Roles_ByProfile_IDandDepartment_ID2(int Profile_ID, int Department_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
            dt = objdal.search("procUser_Roles_ByProfile_IDandDepartmentID2", objpar);
            return dt;
        }

        public DataTable viewUser_Roles_ByProfile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procUser_Roles_ByProfile_ID", objpar);
            return dt;
        }

        public DataTable viewUser_Roles_ByProfile_ID2(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procUser_Roles_ByProfile_ID2", objpar);
            return dt;
        }
        public DataTable viewAllUser_Roles()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procUser_Roles_SelectAll");
            return dt;
        }

        public void deleteUser_Roles()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            objdal.executespreturndr("procUser_Roles_Delete", objpar);
        }

        public DataTable searchForUser_RolesByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchUser_RolesByAnyField", objpar);
            return dt;
        }

        //------------Departments--------------------

        public void addDepartment()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@departmentName", SqlDbType.VarChar, UserRole_Name.ToString()));
            objdal.executespreturnnd("procAddDepartment", objlist);
        }

        public void updateDepartment(int Department_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
            objlist.Add(new csParameterListType("@departmentName", SqlDbType.VarChar, UserRole_Name.ToString()));
            objdal.executespreturnnd("procAddDepartment", objlist);
        }


        public DataTable viewDepartmentByClientID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procDepartmentsBy_Client_ID", objpar);
            return dt;
        }

        public DataTable viewDepartment_ByNumber(string DepartmentNumber)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@departmentNumber", SqlDbType.VarChar, DepartmentNumber.ToString()));
            dt = objdal.search("procGetDepartmentIDByDeptName", objpar);
            return dt;
        }

        public DataTable viewAllDepartments()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procViewAllDepartments");
            return dt;
        }

        public void deleteDepartments(int UserRole_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            objdal.executespreturndr("procUser_Roles_Delete", objpar);
        }

        public DataTable searchForDepartmentsByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchUser_RolesByAnyField", objpar);
            return dt;
        }

        //------------Access_Rules: Roles vs Departments--------------------

        public void addUserRolevsDepartment()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            objlist.Add(new csParameterListType("@departmentNumber", SqlDbType.VarChar, departmentNumber.ToString()));
            objdal.executespreturnnd("procAddUserRolevsDepartment", objlist);
        }

        public void updateUserRolevsDepartment(string departmentNumber)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            objlist.Add(new csParameterListType("@departmentNumber", SqlDbType.VarChar, departmentNumber.ToString()));
            objdal.executespreturnnd("procAddUserRolevsDepartment", objlist);
        }

        public DataTable viewDeptNameByDeptNumber_ByID(int UserRole_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@UserRole_ID", SqlDbType.BigInt, UserRole_ID));
            dt = objdal.search("procGetDeptNameByDeptNumber", objpar);
            return dt;
        }

        public DataTable viewDepartmentNameByDepartNumber(string departmentNumber)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@departmentNumber", SqlDbType.VarChar, departmentNumber.ToString()));
            dt = objdal.search("procGetDepartmentNameByDeptNumber", objpar);
            return dt;
        }

        //public DataTable viewAllUserRolevsDepartment()
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    dt = objdal.search("procViewAllUserRolevsDepartment");
        //    return dt;
        //}

        public void deleteUserRolevsDepartment(string departmentNumber)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@departmentNumber", SqlDbType.VarChar, departmentNumber.ToString()));
            objdal.executespreturndr("procDeleteUserRolevsDepartment", objpar);
        }

        public DataTable searchForAccess_RulesByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchUserRolevsDepartmentByAnyField", objpar);
            return dt;
        }

        //----------------LogInOut User Tape-----------------

        public void UpdateUser_InOrOut(Int32 User_ID, string InOrOut)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@InOrOut", SqlDbType.VarChar, InOrOut.ToString()));
            objdal.executespreturnnd("procUser_InOrOut_Update", objlist);
        }

        public void addLogInOut_User()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@LogInOut", SqlDbType.VarChar, LogInOut.ToString()));
            objlist.Add(new csParameterListType("@LogInOut_Date", SqlDbType.VarChar, LogInOut_Date));
            objdal.executespreturnnd("procUser_LogInOut_Insert", objlist);
        }


        public DataTable viewUserLogInOutByUser_ID(Int32 User_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            dt = objdal.search("procUser_LogInOut_By_User_ID", objpar);
            return dt;
        }

        public void Emailz(string strFrom, string strTo, string strSubject, string strMessage)
        {
            try
            {
                MailMessage objMailMessage = new MailMessage();
                SmtpClient clientsmtp = new SmtpClient();
                clientsmtp.Port = 25;
                //clientsmtp.Host = "41.76.208.51"; //"winnfield.aserv.co.za";
                clientsmtp.Host = "mail.amen247.co.za"; //"winnfield.aserv.co.za";
                //clientsmtp.EnableSsl = true;
                clientsmtp.Credentials = new NetworkCredential("support@amen247.co.za", "Support@01");
                objMailMessage.Subject = strSubject;
                objMailMessage.Body = strMessage;
                objMailMessage.From = new MailAddress(strFrom);
                objMailMessage.To.Add(new MailAddress(strTo));
                clientsmtp.Send(objMailMessage);
            }
            catch { }
        }

        public void Email2SMS(string strFrom, string strToMobile, string strSubject, string strMessage)
        {
            string strTo = "sms@messaging.clickatell.com";

            string strAPI = "api_id:3494009";
            string strUser = "user:BIS247";
            string strPassword = "password:gfaGdcAdNeIENC";
            string strToCell = "to:" + strToMobile;
            string strText = "text:" + strMessage;
            string strReplyTo = "reply:" + strFrom;
            string strBody = strAPI + Environment.NewLine +
                strUser + Environment.NewLine +
                strPassword + Environment.NewLine +
                strToCell + Environment.NewLine +
                strReplyTo + Environment.NewLine +
                strText;


            MailMessage objMailMessage = new MailMessage();
            SmtpClient clientsmtp = new SmtpClient();
            clientsmtp.Port = 25;

            //clientsmtp.Host = "41.76.208.51"; //"winnfield.aserv.co.za";
            clientsmtp.Host = "mail.amen247.co.za"; //"winnfield.aserv.co.za";
            //clientsmtp.EnableSsl = true;
            clientsmtp.Credentials = new NetworkCredential("support@amen247.co.za", "Support@01");

            objMailMessage.IsBodyHtml = false;
            //objMailMessage.Sender.Address();

            objMailMessage.Subject = strSubject;
            objMailMessage.Body = strBody;
            objMailMessage.From = new MailAddress(strFrom);
            objMailMessage.To.Add(new MailAddress(strTo));
            clientsmtp.Send(objMailMessage);
        }

        public static string Mid(string s, int a, int b)
        {
            string temp = s.Substring(a - 1, b);
            return temp;
        }


        public String readHtmlPage(string TxUserName, string TxPassword, string TxApi, string TxNumber, string TxMessage)
        {
            string url;
            //string TxUserName;
            //string TxPassword;
            //string TxApi;

            //TxUserName = "BIS247";
            //TxPassword = "gfaGdcAdNeIENC";
            //TxApi = "3493113";

            string useMsg;
            //int i;
            string c;

            useMsg = "";
            int Tot;
            Tot = TxMessage.Length;

            for (int i = 1; i <= Tot; i++)
            {
                c = Mid(TxMessage, i, 1);
                switch (c)
                {
                    case "crlf": c = "%0A";
                        break;
                    case " ": c = "%20";
                        break;
                    case "+": c = "%2B";
                        break;
                    //case """" : c = "%22";

                    case "#": c = "%23";
                        break;
                    case "%": c = "%25";
                        break;
                    case "&": c = "%26";
                        break;
                    case ",": c = "%2C";
                        break;
                    case ".": c = "%2E";
                        break;
                    case "/": c = "%2F";
                        break;
                    case ":": c = "%3A";
                        break;
                    case ";": c = "%3B";
                        break;
                    case "<": c = "%3C";
                        break;
                    case "=": c = "%3D";
                        break;
                    case ">": c = "%3E";
                        break;
                    case "?": c = "%3F";
                        break;
                    case "¡": c = "%A1";
                        break;
                    case "£": c = "%A3";
                        break;
                    //case "#" : c = "%A4";

                    case "¥": c = "%A5";
                        break;
                    case "§": c = "%A7";
                        break;
                    case "Ä": c = "%C4";
                        break;
                    case "Å": c = "%C5";
                        break;
                    case "à": c = "%E0";
                        break;
                    case "ä": c = "%E4";
                        break;
                    case "å": c = "%E5";
                        break;
                    case "Æ": c = "%C6";
                        break;
                    case "Ç": c = "%C7";
                        break;
                    case "É": c = "%C9";
                        break;
                    case "è": c = "%E8";
                        break;
                    case "é": c = "%E9";
                        break;
                    case "ì": c = "%EC";
                        break;
                    case "Ñ": c = "%D1";
                        break;
                    case "ñ": c = "%F1";
                        break;
                    case "ò": c = "%F2";
                        break;
                    case "ö": c = "%F6";
                        break;
                    case "Ø": c = "%D8";
                        break;
                    case "Ö": c = "%D6";
                        break;
                    case "Ü": c = "%DC";
                        break;
                    case "ù": c = "%F9";
                        break;
                    case "ü": c = "%FC";
                        break;
                    case "ß": c = "%DF";
                        break;

                }
                useMsg = useMsg + c;
            }

            //http://api.clickatell.com/http/sendmsg?user=raps2012&password=PASSWORD&api_id=3393003&to=27721803380&text=Message

            url = "http://api.clickatell.com/http/sendmsg?user=";
            url = url + TxUserName + "&password=" + TxPassword + "&api_id=" + TxApi + "&to=" + TxNumber + "&text=" + useMsg;

            WebResponse objResponse;
            WebRequest objRequest;
            string result;

            try
            {
                //objRequest.ContentType = "application/X-www-form-urlencoded; charset=""utf-8"""
                objRequest = System.Net.HttpWebRequest.Create(url);
                objResponse = objRequest.GetResponse();

                StreamReader sr = new StreamReader(objResponse.GetResponseStream());
                result = sr.ReadToEnd();
                sr.Close();
                return result;
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                if (s.Contains("(404)"))
                {
                    return "URL: " + url + " not found.";
                }
                else
                {
                    return s;
                }
            }

        }




        public String GetSMSBalance(string TxUserName, string TxPassword, string TxApi)
        {
            string url;
            //string TxUserName;
            //string TxPassword;
            //string TxApi;

            //TxUserName = "BIS247";
            //TxPassword = "gfaGdcAdNeIENC";
            //TxApi = "3493113";

            //string useMsg;
            ////int i;
            //string c;


            url = "http://api.clickatell.com/http/getbalance?api_id=";
            url = url + TxApi + "&user=" + TxUserName + "&password=" + TxPassword;

            WebResponse objResponse;
            WebRequest objRequest;
            string result;

            try
            {
                //objRequest.ContentType = "application/X-www-form-urlencoded; charset=""utf-8"""
                objRequest = System.Net.HttpWebRequest.Create(url);
                objResponse = objRequest.GetResponse();

                StreamReader sr = new StreamReader(objResponse.GetResponseStream());
                result = sr.ReadToEnd();
                sr.Close();
                return result;
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                if (s.Contains("(404)"))
                {
                    return "URL: " + url + " not found.";
                }
                else
                {
                    return s;
                }
            }

        }

    }
}