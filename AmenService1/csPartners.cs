using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csPartners
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Partner_ID { set; get; }
        public string Partner_No { set; get; }
        public string Full_Name { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }
        public string Gender { set; get; }
        public string Age_Bracket { set; get; }

        public string Birth_Date { set; get; }
        public string Birth_Year { set; get; }
        public string Birth_Month { set; get; }
        public string Birth_Day { set; get; }
        public string Marital { set; get; }
        public string Wedding_Date { set; get; }
        public string Wedding_Year { set; get; }
        public string Wedding_Month { set; get; }
        public string Wedding_Day { set; get; }

        public string Reg_Date { set; get; }
        public string IsChurch_Member { set; get; }
        public string Church_Attending { set; get; }
        public string PersonYouKnowInOurChurch { set; get; }
        public string Referred_By { set; get; }
        public string IsActive { set; get; }

        public string LastUpdate_Date { set; get; }


        //--------------Contacts--------------
        public Int32 Contact_ID { set; get; }
        public string Cellphone { set; get; }
        public string Telephone { set; get; }
        public string PhoneH { set; get; }
        public string PhoneW { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public string SocialMedia { set; get; }
        public string SocialMedia1 { set; get; }
        public string SocialMedia2 { set; get; }
        public string SocialMedia3 { set; get; }

        //-------------Location---------------
        public Int32 Location_ID { set; get; }
        public string Continent { set; get; }
        public string City { set; get; }
        public string Province { set; get; }
        public string Country { set; get; }
        public string Area_Category { set; get; }
        public string Area_Name { set; get; }
        public string Directions { set; get; }
        public string GPSCoordinates { set; get; }

        //-------------Address---------------
        public Int32 Address_ID { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
        public string AddressCode { set; get; }


        //-------------Partnership---------------
        public Int32 Partnership_ID { set; get; }
        public string Partnership_Date { set; get; }
        public Int32 Partnership_Item_ID { set; get; }
        public Int32 Partnership_Category_ID { set; get; }
        public string Partnership_Category_Notes { set; get; }
        public string Partnership_Amount { set; get; }
        public string Partnership_Amount_Day { set; get; }
        public string HowDidYouHereAboutPartnership { set; get; }
        public string Name_Your_Seed { set; get; }

        //----------Partners Followups----------
        public Int32 Followup_ID { set; get; }
        public string Followup_Date { set; get; }
        public Int32 Follower_ID { set; get; }
        public string Followup_Notes { set; get; }
        public string Followup_Recommendations { set; get; }
        public string Followup_Description { set; get; }


        //----------Partners Categories----------
        public Int32 Category_ID { set; get; }
        public string Category { set; get; }

        //----------Partners Items----------
        public Int32 Item_ID { set; get; }
        public string Item { set; get; }

        public csPartners()
        { }

        #region Partners
        public void addPartners_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Partner_No", SqlDbType.VarChar, Partner_No.ToString()));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objdal.executespreturnnd("procClient_Partners_Pre_Insert", objlist);
        }

        public void updatePartners()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
            objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
            objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
            objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
            objlist.Add(new csParameterListType("@Age_Bracket", SqlDbType.VarChar, Age_Bracket.ToString()));
            objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
            objlist.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
            objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
            objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
            objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
            objlist.Add(new csParameterListType("@Wedding_Date", SqlDbType.VarChar, Wedding_Date.ToString()));
            objlist.Add(new csParameterListType("@Wedding_Year", SqlDbType.VarChar, Wedding_Year.ToString()));
            objlist.Add(new csParameterListType("@Wedding_Month", SqlDbType.VarChar, Wedding_Month.ToString()));
            objlist.Add(new csParameterListType("@Wedding_Day", SqlDbType.VarChar, Wedding_Day.ToString()));
            objlist.Add(new csParameterListType("@IsChurch_Member", SqlDbType.VarChar, IsChurch_Member.ToString()));
            objlist.Add(new csParameterListType("@Church_Attending", SqlDbType.VarChar, Church_Attending.ToString()));
            objlist.Add(new csParameterListType("@PersonYouKnowInOurChurch", SqlDbType.VarChar, PersonYouKnowInOurChurch.ToString()));
            objlist.Add(new csParameterListType("@Referred_By", SqlDbType.VarChar, Referred_By.ToString()));
            objlist.Add(new csParameterListType("@IsActive ", SqlDbType.VarChar, IsActive.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procClient_Partners_Update", objlist);
        }

        public DataTable viewClient_Partners_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Partners_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partners_By_Partner_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partners_By_Partner_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partners_PreAllByPartner_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partners_Pre_All", objpar);
            return dt;
        }


        public DataTable viewPartner_ID_ByPartner_No(string Partner_No)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_No", SqlDbType.VarChar, Partner_No.ToString()));
            dt = objdal.search("procClient_Partner_ID_By_Partner_No", objpar);
            return dt;
        }


        public DataTable viewClient_Partners_By_Client_ID_Date(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From.ToString()));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To.ToString()));
            dt = objdal.search("procClient_Partners_By_Client_ID_Date", objpar);
            return dt;
        }
        
        public DataTable searchForClient_Partners_ByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procClient_Partners_Search_ByAnyField1", objpar);
            return dt;
        }

        #endregion

        #region Contacts
        //-------------------------Contacts-----------------------------------

        public void updateContacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@PhoneW", SqlDbType.VarChar, PhoneW.ToString()));
            objlist.Add(new csParameterListType("@SocialMedia1", SqlDbType.VarChar, SocialMedia1.ToString()));
            objlist.Add(new csParameterListType("@SocialMedia2", SqlDbType.VarChar, SocialMedia2.ToString()));
            objlist.Add(new csParameterListType("@SocialMedia3", SqlDbType.VarChar, SocialMedia3.ToString()));
            objdal.executespreturnnd("procClient_Partners_Contacts_Update", objlist);
        }


        public DataTable viewContactsByPartner_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partners_Contacts_By_Partner_ID", objpar);
            return dt;
        }

        #endregion

        #region Location
        //-------------------Location----------------------------------
        public void updateLocation()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
            objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
            objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
            objlist.Add(new csParameterListType("@Area_Category", SqlDbType.VarChar, Area_Category.ToString()));
            objlist.Add(new csParameterListType("@Area_Name", SqlDbType.VarChar, Area_Name.ToString()));
            objlist.Add(new csParameterListType("@Directions", SqlDbType.VarChar, Directions.ToString()));
            objlist.Add(new csParameterListType("@GPSCoordinates", SqlDbType.VarChar, GPSCoordinates.ToString()));
            objdal.executespreturnnd("procClient_Partners_Location_Update", objlist);
        }

        public DataTable viewLocationByPartner_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partners_Location_By_Partner_ID", objpar);
            return dt;
        }
        #endregion

        #region address
        //-----------------------Address----------------------------------------------
        public void updateAddress()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            objlist.Add(new csParameterListType("@AddressLine1", SqlDbType.VarChar, AddressLine1.ToString()));
            objlist.Add(new csParameterListType("@AddressLine2", SqlDbType.VarChar, AddressLine2.ToString()));
            objlist.Add(new csParameterListType("@AddressCode", SqlDbType.VarChar, AddressCode.ToString()));
            objdal.executespreturnnd("procClient_Partners_Address_Update", objlist);
        }

        public DataTable viewAddressByPartner_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partners_Address_By_Partner_ID", objpar);
            return dt;
        }

        #endregion

        #region Partnership
     

        //-----------------------Guests------------------------
        public void AddNewPartnership()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objdal.executespreturnnd("procClient_Partnership_Insert", objlist);
        }

        public void updatePartnership()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Partnership_ID", SqlDbType.BigInt, Partnership_ID));
            objlist.Add(new csParameterListType("@Partnership_Item_ID", SqlDbType.BigInt, Partnership_Item_ID));
            objlist.Add(new csParameterListType("@Partnership_Category_ID", SqlDbType.BigInt, Partnership_Category_ID.ToString()));
            objlist.Add(new csParameterListType("@Partnership_Date", SqlDbType.VarChar, Partnership_Date.ToString()));
            objlist.Add(new csParameterListType("@Partnership_Category_Notes", SqlDbType.VarChar, Partnership_Category_Notes.ToString()));
            objlist.Add(new csParameterListType("@Partnership_Amount", SqlDbType.VarChar, Partnership_Amount.ToString()));
            objlist.Add(new csParameterListType("@Partnership_Amount_Day", SqlDbType.VarChar, Partnership_Amount_Day.ToString()));
            objlist.Add(new csParameterListType("@HowDidYouHereAboutPartnership", SqlDbType.VarChar, HowDidYouHereAboutPartnership.ToString()));
            objlist.Add(new csParameterListType("@Name_Your_Seed", SqlDbType.VarChar, Name_Your_Seed.ToString()));
            objlist.Add(new csParameterListType("@IsActive ", SqlDbType.VarChar, IsActive.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procClient_Partnership_Update", objlist);
        }

        public DataTable viewClient_Partnership_By_Client_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Partnership_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partnership_By_Client_ID_Date(Int32 Client_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procClient_Partnership_By_Client_ID_Date", objpar);
            return dt;
        }

        public DataTable viewClient_PartnershipByClient_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Partnership_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partnership_By_Partner_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partnership_By_Partner_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partnership_By_Partnership_ID(Int32 Partnership_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partnership_ID", SqlDbType.BigInt, Partnership_ID));
            dt = objdal.search("procClient_Partnership_By_Partnership_ID", objpar);
            return dt;
        }

        public DataTable searchForClient_PartnershipByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchClient_PartnershipByAnyField1", objpar);
            return dt;
        }
        
        #endregion

        #region Client_Partners_Followups

        //-----------------------Client_Followups------------------------
        public void AddClient_Partners_Followups()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            objlist.Add(new csParameterListType("@Follower_ID", SqlDbType.BigInt, Follower_ID));
            objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
            objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
            objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
            objdal.executespreturnnd("procClient_Partners_Followup_Insert", objlist);
        }

        public void updateClient_Partners_Followups()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
            objlist.Add(new csParameterListType("@Follower_ID", SqlDbType.BigInt, Follower_ID));
            objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date.ToString()));
            objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
            objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
            objdal.executespreturnnd("procClient_Partners_Followup_Update", objlist);
        }

        public DataTable viewPartner_Followups_By_Client_ID_and_Category_ID(Int32 Client_ID, Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procClient_Followups_By_Client_ID_and_Category_ID", objpar);
            return dt;
        }

        public DataTable viewPartner_Followups_By_Profile_ID_and_Category_ID(Int32 Category_ID, Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procClient_Followups_By_Profile_ID_and_Category_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partner_Followups_By_Partner_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partners_Followup_By_Partner_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partner_Followups_By_NewConvert_ID(Int32 Partner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Partner_ID", SqlDbType.BigInt, Partner_ID));
            dt = objdal.search("procClient_Partners_Followup_By_Partner_ID", objpar);
            return dt;
        }

        public DataTable viewClient_Partner_Followups_By_Followup_ID(Int32 Followup_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
            dt = objdal.search("procClient_Partners_Followup_By_Followup_ID", objpar);
            return dt;
        }


        public DataTable searchForPartners_Followup_ByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchPartnersByAnyField1", objpar);
            return dt;
        }

        #endregion


        #region Client_Partners_Categories

        public void addClient_Partners_Categories()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objdal.executespreturnnd("procClient_Partners_Categories_Insert", objlist);
        }

        public void UpdateClient_Partners_Categories()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objdal.executespreturnnd("procClient_Partners_Categories_Update", objlist);
        }

        public void DeleteClient_Partners_Categories()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objdal.executespreturnnd("procClient_Partners_Categories_Delete", objlist);
        }

        public DataTable viewAllClient_Partners_Categories()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            dt = objdal.search("procClient_Partners_Categories");
            return dt;
        }

        public DataTable viewAllClient_Partners_Categories_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Partners_Categories_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewAllClient_Partners_Categories_By_Category_ID(Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procClient_Partners_Categories_By_Category_ID", objpar);
            return dt;
        }

        #endregion

        #region Client_Partners_Items

        public void addClient_Partners_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item.ToString()));
            objdal.executespreturnnd("procClient_Partners_Items_Insert", objlist);
        }

        public void UpdateClient_Partners_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item.ToString()));
            objdal.executespreturnnd("procClient_Partners_Items_Update", objlist);
        }

        public void DeleteClient_Partners_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procClient_Partners_Items_Delete", objlist);
        }

        public DataTable viewAllClient_Partners_Items()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            dt = objdal.search("procClient_Partners_Items");
            return dt;
        }

        public DataTable viewAllClient_Partners_Items_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_Partners_Items_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewAllClient_Partners_Items_By_Item_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procClient_Partners_Items_By_Item_ID", objpar);
            return dt;
        }

        #endregion

    }
}
