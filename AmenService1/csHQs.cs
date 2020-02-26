using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csHQs
    {

        csDAL objdal = new csDAL();

        public Int32 HQs_ID { set; get; }
        public Int32 Church_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string HQs_Number { set; get; }
        public string HQs_Name { set; get; }
        public string HQs_Description { set; get; }
        public string Movement { set; get; }
        public string Membership { set; get; }
        public string Reg_Date { set; get; }
        public string Remove_Date { set; get; }
        public string Date_Established { set; get; }

        //--------------Contacts--------------
        public Int32 Contact_ID { set; get; }
        public string Category { set; get; }
        public string Contact_Person { set; get; }
        public string Cellphone { set; get; }
        public string Telephone { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }

        //-------------Location---------------
        public Int32 Location_ID { set; get; }
        public string Continent { set; get; }
        public string City { set; get; }
        public string Province { set; get; }
        public string Country { set; get; }
        public string Area_Category { set; get; }
        public string Area_Name { set; get; }
        public string PhysicalAddressLine1 { set; get; }
        public string PhysicalAddressLine2 { set; get; }
        public string PhysicalAddressCode { set; get; }
        public string PostalAddressLine1 { set; get; }
        public string PostalAddressLine2 { set; get; }
        public string PostalAddressCode { set; get; }
        public string Directions { set; get; }
        public string GPSCoordinates { set; get; }


        public Int32 User_ID { set; get; }
        public string FullName { set; get; }
        public string Mobile { set; get; }
        public string User_Email { set; get; }
        public string Pasword { set; get; }
        public string User_Active_Status { set; get; }
        public string Date_Reg { set; get; }

        public csHQs()
        { }


        #region HQs

        public void addHQs_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_Number", SqlDbType.VarChar, HQs_Number.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objdal.executespreturnnd("procHQs_Pre_Insert", objlist);
        }

        public void updateHQs_Reg()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@HQs_Name", SqlDbType.VarChar, HQs_Name.ToString()));
            objlist.Add(new csParameterListType("@Movement", SqlDbType.VarChar, Movement.ToString()));
            objdal.executespreturnnd("procHQs_Update_Reg", objlist);
        }

        public void updateHQs()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@HQs_Name", SqlDbType.VarChar, HQs_Name.ToString()));
            objlist.Add(new csParameterListType("@HQs_Description", SqlDbType.VarChar, HQs_Description.ToString()));
            objlist.Add(new csParameterListType("@Movement", SqlDbType.VarChar, Movement.ToString()));
            objlist.Add(new csParameterListType("@Membership", SqlDbType.VarChar, Membership.ToString()));
            objlist.Add(new csParameterListType("@Date_Established", SqlDbType.VarChar, Date_Established));
            objdal.executespreturnnd("procHQs_Update", objlist);
        }

        public DataTable ViewAllHQs()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procHQs_ViewALL");
            return dt;
        }

        public DataTable viewHQs_Profile_By_HQs_ID(Int32 HQs_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            dt = objdal.search("procHQs_Profiles_By_HQs_ID", objpar);
            return dt;
        }

        public DataTable GetHQs_ID_By_HQs_Number(String HQs_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_Number", SqlDbType.VarChar, HQs_Number.ToString()));
            dt = objdal.search("procHQs_ID_By_HQs_Number", objpar);
            return dt;
        }

        public DataTable GetHQs_By_HQs_Name(String HQs_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_Name", SqlDbType.VarChar, HQs_Name.ToString()));
            dt = objdal.search("procHQs_By_HQs_Name", objpar);
            return dt;
        }

        public void deleteHQs(int HQs_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objdal.executespreturndr("procHQs_Delete", objpar);
        }


        #region HQs_Contacts
        //-------------------------Contacts-----------------------------------

        public void AddHQs_Contacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Contact_Person", SqlDbType.VarChar, Contact_Person.ToString()));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procHQs_Contacts_Insert_Reg", objlist);
        }

        public void updateHQs_Contacts_Reg()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Contact_Person", SqlDbType.VarChar, Contact_Person.ToString()));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procHQs_Contacts_Update_Reg", objlist);
        }


       public void updateHQs_Contacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Contact_Person", SqlDbType.VarChar, Contact_Person.ToString()));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procHQs_Contacts_Update", objlist);
        }

       public DataTable viewHQs_Contacts_By_HQs_ID(Int32 HQs_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            dt = objdal.search("procHQs_Contacts_By_HQs_ID", objpar);
            return dt;
        }

       public DataTable viewHQs_Contacts_By_Contact_ID(Int32 Contact_ID)
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           List<csParameterListType> objpar = new List<csParameterListType>();
           objpar.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
           dt = objdal.search("procHQs_Contacts_By_Contact_ID", objpar);
           return dt;
       }

       public DataTable DeleteHQs_Contacts()
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           List<csParameterListType> objpar = new List<csParameterListType>();
           objpar.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
           dt = objdal.search("procHQs_Contacts_Delete", objpar);
           return dt;
       }

        #endregion

       #region HQs_Location
       //-------------------Location----------------------------------
       public void AddHQs_Location()
       {
           csDAL objdal = new csDAL();
           List<csParameterListType> objlist = new List<csParameterListType>();
           objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
           objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
           objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
           objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
           objlist.Add(new csParameterListType("@Area_Category", SqlDbType.VarChar, Area_Category.ToString()));
           objlist.Add(new csParameterListType("@Area_Name", SqlDbType.VarChar, Area_Name.ToString()));
           objlist.Add(new csParameterListType("@PhysicalAddressLine1", SqlDbType.VarChar, PhysicalAddressLine1.ToString()));
           objlist.Add(new csParameterListType("@PhysicalAddressLine2", SqlDbType.VarChar, PhysicalAddressLine2.ToString()));
           objlist.Add(new csParameterListType("@PhysicalAddressCode", SqlDbType.VarChar, PhysicalAddressCode.ToString()));
           objlist.Add(new csParameterListType("@PostalAddressLine1", SqlDbType.VarChar, PostalAddressLine1.ToString()));
           objlist.Add(new csParameterListType("@PostalAddressLine2", SqlDbType.VarChar, PostalAddressLine2.ToString()));
           objlist.Add(new csParameterListType("@PostalAddressCode", SqlDbType.VarChar, PostalAddressCode.ToString()));
           objlist.Add(new csParameterListType("@Directions", SqlDbType.VarChar, Directions.ToString()));
           objlist.Add(new csParameterListType("@GPSCoordinates", SqlDbType.VarChar, GPSCoordinates.ToString()));
           objdal.executespreturnnd("procHQs_Location_Insert_Reg", objlist);
       }

       public void updateHQs_Location()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
            objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
            objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
            objlist.Add(new csParameterListType("@Area_Category", SqlDbType.VarChar, Area_Category.ToString()));
            objlist.Add(new csParameterListType("@Area_Name", SqlDbType.VarChar, Area_Name.ToString()));
            objlist.Add(new csParameterListType("@PhysicalAddressLine1", SqlDbType.VarChar, PhysicalAddressLine1.ToString()));
            objlist.Add(new csParameterListType("@PhysicalAddressLine2", SqlDbType.VarChar, PhysicalAddressLine2.ToString()));
            objlist.Add(new csParameterListType("@PhysicalAddressCode", SqlDbType.VarChar, PhysicalAddressCode.ToString()));
            objlist.Add(new csParameterListType("@PostalAddressLine1", SqlDbType.VarChar, PostalAddressLine1.ToString()));
            objlist.Add(new csParameterListType("@PostalAddressLine2", SqlDbType.VarChar, PostalAddressLine2.ToString()));
            objlist.Add(new csParameterListType("@PostalAddressCode", SqlDbType.VarChar, PostalAddressCode.ToString()));
            objlist.Add(new csParameterListType("@Directions", SqlDbType.VarChar, Directions.ToString()));
            objlist.Add(new csParameterListType("@GPSCoordinates", SqlDbType.VarChar, GPSCoordinates.ToString()));
            objdal.executespreturnnd("procHQs_Location_Update", objlist);
        }

       public DataTable viewHQs_Location_By_HQs_ID(Int32 HQs_ID)
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           List<csParameterListType> objpar = new List<csParameterListType>();
           objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
           dt = objdal.search("procHQs_Location_By_HQs_ID", objpar);
           return dt;
       }

       public DataTable viewHQs_Location_By_Location_ID(Int32 Location_ID)
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           List<csParameterListType> objpar = new List<csParameterListType>();
           objpar.Add(new csParameterListType("@Location_ID", SqlDbType.BigInt, Location_ID));
           dt = objdal.search("procHQs_Location_By_Location_ID", objpar);
           return dt;
       }

        #endregion

        #endregion

        #region Churches
        public void addChurches()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objdal.executespreturnnd("procHQs_Churches_Insert", objlist);
        }

        public void UpdateChurches()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            objlist.Add(new csParameterListType("@Remove_Date", SqlDbType.VarChar, Remove_Date.ToString()));
            objdal.executespreturnnd("procChurches_Update", objlist);
        }

        public void DeleteChurches()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            objdal.executespreturnnd("procHQs_Churches_Delete", objlist);
        }

        public DataTable viewAllChurches_By_HQs_ID(Int32 HQs_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            dt = objdal.search("procHQs_Churches_By_HQs_ID", objpar);
            return dt;
        }

        public DataTable viewAllChurches_By_HQs_ID2(Int32 HQs_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            dt = objdal.search("procHQs_Churches_By_HQs_ID2", objpar);
            return dt;
        }

        public DataTable viewAllChurches_By_Church_ID(Int32 Church_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            dt = objdal.search("procHQs_Churches_By_Church_ID", objpar);
            return dt;
        }

        public DataTable searchForChurchesByAnyField1(string sVariable, int Church_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchChurchesByAnyField1", objpar);
            return dt;
        }

        public DataTable searchForChurchesByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procHQs_SearchChurchesByAnyField1", objpar);
            return dt;
        }

        public DataTable viewAllChurches_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procHQs_Churches_By_Client_ID", objpar);
            return dt;
        }

        #endregion


        #region User Accounts
        public DataTable searchForHQs_UsersByAnyField_User_Login(string sVariable, Int32 HQs_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchHQs_UsersByAnyField", objpar);
            return dt;
        }

        public DataTable searchForHQs_UsersByAny_User_Email(string User_Email)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email));
            dt = objdal.search("procHQs_UserAccount_By_User_Email", objpar);
            return dt;
        }

        public DataTable viewHQs_User_By_User_ID(Int32 User_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            dt = objdal.search("procHQs_UserAccount_View_By_User_ID", objpar);
            return dt;
        }

        public DataTable viewHQs_UserAccount_By_HQs_ID(Int32 HQs_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            dt = objdal.search("procHQs_UserAccount_View_By_HQs_ID", objpar);
            return dt;
        }

        public void addUser()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@FullName", SqlDbType.VarChar, FullName.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, User_Active_Status.ToString()));
            objlist.Add(new csParameterListType("@Date_Reg", SqlDbType.VarChar, Date_Reg));
            objdal.executespreturnnd("procHQs_User_Insert_SignUp", objlist);
        }

        public void updateUsers1()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            objlist.Add(new csParameterListType("@FullName", SqlDbType.VarChar, FullName.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@User_Email", SqlDbType.VarChar, User_Email.ToString()));
            objlist.Add(new csParameterListType("@Pasword", SqlDbType.VarChar, Pasword.ToString()));
            objlist.Add(new csParameterListType("@User_Active_Status", SqlDbType.VarChar, User_Active_Status.ToString()));
            objdal.executespreturnnd("procHQs_User_Accounts_Update", objlist);
        }

        #endregion

    }
}
