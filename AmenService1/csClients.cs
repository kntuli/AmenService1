using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csClients
    {

        csDAL objdal = new csDAL();

        //-------------Company-------------------
        public Int32 Client_ID { set; get; }
        public Int32 Category_ID { set; get; }
        public string Client_Number { set; get; }
        public string Client_Slogan { set; get; }
        public string Client_Description { set; get; }
        public string Client_Name { set; get; }
        public string Movement { set; get; }
        public string Membership { set; get; }
        public string Reg_Date { set; get; }
        public string Legal_Docs { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Vision { set; get; }
        public string Mission { set; get; }
        public string Payment_Method { set; get; }
        public string Date_Established { set; get; }

        //-----------Search Engine
        public Int32 Search_Engine_ID { set; get; }
        public string Search_Key_Words { set; get; }

        //-------------Pics-------------------
        public Int32 Pic_ID { set; get; }
        public string Pic_Image { set; get; }
        public string Profile_Pic { set; get; }

        //--------------Contacts--------------
        public Int32 Contact_ID { set; get; }
        public string Contact_Name { set; get; }
        public string Department { set; get; }
        public string Category { set; get; }
        public string Cellphone { set; get; }
        public string Telephone { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public Int32 Contact_Profile_ID { set; get; }
        public string Show_To { set; get; }

        //-------------Location---------------
        public Int32 Location_ID { set; get; }
        public string Continent { set; get; }
        public string City { set; get; }
        public string Province { set; get; }
        public string Country { set; get; }
        public string Area_Category { set; get; }
        public string Directions { set; get; }
        public string GPSCoordinates { set; get; }

        //-------------Address---------------
        public Int32 Address_ID { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
        public string AddressCode { set; get; }

        //----------------Custom pages----------
        public string Custom_Page { set; get; }

       public csClients()
        { }
        
        //--------------Client----------------------------------------

       public DataTable registerNewClient(string churchName, string pastorName, string mobile, string email, string tel, string city, string province, string country, string physicalAddress, string physicalAddressCode, string package)
       {
           csDAL objdal = new csDAL();
           DataTable dt = new DataTable();
           List<csParameterListType> objlist = new List<csParameterListType>();
           objlist.Add(new csParameterListType("@Church_Name", SqlDbType.VarChar, churchName));
           objlist.Add(new csParameterListType("@Pastor_Name", SqlDbType.VarChar, pastorName));
           objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, mobile));
           objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, email));
           objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, tel));
           objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, city));
           objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, province));
           objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, country));
           objlist.Add(new csParameterListType("@PhysicalAddress", SqlDbType.VarChar, physicalAddress));
           objlist.Add(new csParameterListType("@PhysicalAddressCode", SqlDbType.VarChar, physicalAddressCode));
           objlist.Add(new csParameterListType("@Package", SqlDbType.VarChar, package));
           dt = objdal.search("procRegister_New_Church", objlist);
           return dt;
       }


        public void addClient()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_Number", SqlDbType.VarChar, Client_Number.ToString()));
            objlist.Add(new csParameterListType("@Client_Name", SqlDbType.VarChar, Client_Name.ToString()));
            objlist.Add(new csParameterListType("@Legal_Docs", SqlDbType.VarChar, Legal_Docs.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objdal.executespreturnnd("procClient_Insert", objlist);
        }

        public void addClient_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_Number", SqlDbType.VarChar, Client_Number.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objdal.executespreturnnd("procClientPre_Insert", objlist);
        }

        public void addClient_Pre2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_Number", SqlDbType.VarChar, Client_Number.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objdal.executespreturnnd("procClientPre_Insert2", objlist);
        }

        public void updateClient()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Client_Name", SqlDbType.VarChar, Client_Name.ToString()));
            objlist.Add(new csParameterListType("@Movement", SqlDbType.VarChar, Movement.ToString()));
            objlist.Add(new csParameterListType("@Membership", SqlDbType.VarChar, Membership.ToString()));
            objlist.Add(new csParameterListType("@Payment_Method", SqlDbType.VarChar, Payment_Method.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@Legal_Docs", SqlDbType.VarChar, Legal_Docs.ToString()));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procClient_Update", objlist);
        }

        public void updateClient2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Client_Name", SqlDbType.VarChar, Client_Name.ToString()));
            objlist.Add(new csParameterListType("@Movement", SqlDbType.VarChar, Movement.ToString()));
            objlist.Add(new csParameterListType("@Membership", SqlDbType.VarChar, Membership.ToString()));
            objlist.Add(new csParameterListType("@Payment_Method", SqlDbType.VarChar, Payment_Method.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@Legal_Docs", SqlDbType.VarChar, Legal_Docs.ToString()));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procClient_Update2", objlist);
        }

        public void updateClient_Church()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Client_Slogan", SqlDbType.VarChar, Client_Slogan.ToString()));
            objlist.Add(new csParameterListType("@Church_Description", SqlDbType.VarChar, Client_Description.ToString()));
            objlist.Add(new csParameterListType("@Movement", SqlDbType.VarChar, Movement.ToString()));
            objlist.Add(new csParameterListType("@Payment_Method", SqlDbType.VarChar, Payment_Method.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objdal.executespreturnnd("procClient_Church_Update", objlist);
        }

        public void updateClient_Church2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Client_Slogan", SqlDbType.VarChar, Client_Slogan.ToString()));
            objlist.Add(new csParameterListType("@Church_Description", SqlDbType.VarChar, Client_Description.ToString()));
            objlist.Add(new csParameterListType("@Movement", SqlDbType.VarChar, Movement.ToString()));
            objlist.Add(new csParameterListType("@Membership", SqlDbType.VarChar, Membership.ToString()));
            objlist.Add(new csParameterListType("@Payment_Method", SqlDbType.VarChar, Payment_Method.ToString()));
            objlist.Add(new csParameterListType("@Date_Established", SqlDbType.VarChar, Date_Established.ToString()));
            objdal.executespreturnnd("procClient_Church_Update2", objlist);
        }


        public void updateClient0()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Client_Name", SqlDbType.VarChar, Client_Name.ToString()));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procClient_Update0", objlist);
        }

        public void updateClient_Profile_ID()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procClient_Profile_ID_Update", objlist);
        }

        public DataTable viewClientByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClientBy_ClientID", objpar);
            return dt;
        }



        public DataTable GetClient_IDByClient_Number(String Client_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_Number", SqlDbType.VarChar, Client_Number.ToString()));
            dt = objdal.search("procClientID_By_ClientNumber", objpar);
            return dt;
        }

        public DataTable GetChurch_IDByChurch_Name(String Client_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_Name", SqlDbType.VarChar, Client_Name.ToString()));
            dt = objdal.search("procClient_By_ClientName", objpar);
            return dt;
        }

        public DataTable viewClientByUser_ID(int User_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@User_ID", SqlDbType.BigInt, User_ID));
            dt = objdal.search("procClientBy_UserID", objpar);
            return dt;
        }


        public DataTable ViewAllClients()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procClient_ViewALL");
            return dt;
        }

        public DataTable ViewAllClients_Academics()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procClient_ViewAll_Academic");
            return dt;
        }

        public DataTable ViewAllClients_Admin()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procClients_ViewAll_Admin");
            return dt;
        }

        public void deleteClient(int Client_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objdal.executespreturndr("procClient_Delete", objpar);
        }

        public DataTable searchForClientByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procClientsSearch_ByAnyField", objpar);
            return dt;
        }

        public DataTable searchForClientByAnyField1(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procClients_Search_ByAnyField1", objpar);
            return dt;
        }

        public DataTable searchForClientByAnyField_Admin(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procClients_Search_ByAnyField_Admin", objpar);
            return dt;
        }

        public DataTable searchForChurchByAnyField2(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procChurch_Search_ByAnyField2", objpar);
            return dt;
        }

        public DataTable searchForChurch_Search_EngineByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procChurch_Search_Engine_ByAnyField", objpar);
            return dt;
        }

        public DataTable searchForChurchByAnyField2a(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procChurch_Search_ByAnyField2", objpar);
            return dt;
        }

        public void updateClient_Company()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Client_Name", SqlDbType.VarChar, Client_Name.ToString()));
            objlist.Add(new csParameterListType("@Legal_Docs", SqlDbType.VarChar, Legal_Docs.ToString()));
            objdal.executespreturnnd("procClientCompany_Update", objlist);
        }

        public DataTable getClientIDByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClientBy_ClientID", objpar);
            return dt;
        }

        //------------Vision----------------

        public DataTable viewVisionByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procVision_By_ClientID", objpar);
            return dt;
        }

        public void updateVision()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Vision", SqlDbType.VarChar, Vision.ToString()));
            objlist.Add(new csParameterListType("@Mission", SqlDbType.VarChar, Mission.ToString()));
            objdal.executespreturnnd("procVision_Update", objlist);
        }

        //------------------------Photos----------------------------------

        public void addPics()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
            objdal.executespreturnnd("procPics_Client_Insert", objlist);
        }

        public void updatePics()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
            objdal.executespreturnnd("procPics_Client_Update", objlist);
        }

        public void updatePics1()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
            objdal.executespreturnnd("procPics_ByName_Update", objlist);
        }

        public void updatePicsAll()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
            objdal.executespreturnnd("procPics_All_Update", objlist);
        }

        public DataTable viewPicByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPics_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewPicAllByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPics_AllBy_Client_ID", objpar);
            return dt;
        }

        public DataTable viewAllPicByPClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPics_All_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewPicByClient_ID_and_PicName()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            dt = objdal.search("procPic_By_Client_IDandPicName", objpar);
            return dt;
        }

        public DataTable DeletePicByClient_ID_and_PicName()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            dt = objdal.search("procPics_Client_ByName_Delete", objpar);
            return dt;
        }



        //-------------------------Contacts-----------------------------------

        public void updateContacts_Church()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procContacts_Clients_Update_Church", objlist);
        }

        public DataTable viewContactsByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procContacts_By_Client_ID", objpar);
            return dt;
        }


        //-------------------------Church Contacts-----------------------------------

        public void addChurch_Contacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contact_Name", SqlDbType.VarChar, Contact_Name.ToString()));
            objlist.Add(new csParameterListType("@Department", SqlDbType.VarChar, Department.ToString()));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@Show_To", SqlDbType.VarChar, Show_To.ToString()));
            objdal.executespreturnnd("procInsert_Church_Contacts", objlist);
        }

        public void updateChurch_Contacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Contact_Name", SqlDbType.VarChar, Contact_Name.ToString()));
            objlist.Add(new csParameterListType("@Department", SqlDbType.VarChar, Department.ToString()));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@Show_To", SqlDbType.VarChar, Show_To.ToString()));
            objdal.executespreturnnd("procUpdate_Church_Contacts", objlist);
        }



        public void addContacts_Client()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Contact_Profile_ID", SqlDbType.BigInt, Contact_Profile_ID));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procContacts_Clients_Insert_Church", objlist);
        }
        public void updateContacts_Client()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Contact_Profile_ID", SqlDbType.BigInt, Contact_Profile_ID));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procContacts_Clients_Update_Church", objlist);
        }

        public void updateClients_Contacts_ByClient_ID_and_Profile_ID()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Contact_Profile_ID", SqlDbType.BigInt, Contact_Profile_ID));
            objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procClients_Contacts_Update_ByClient_ID_and_Profile_ID", objlist);
        }

        public void deleteContacts_Client()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            objdal.executespreturnnd("procContacts_Clients_Delete_Church", objlist);
        }

        public DataTable viewChurch_ContactsByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procContacts_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewContact_Client_View_ChurchByClient_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procContacts_By_Client_ID2", objpar);
            return dt;
        }

        public DataTable viewContact_Client_View_ChurchByContact_ID(Int32 Contact_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            dt = objdal.search("procContact_Clients_View_Church_By_Contact_ID", objpar);
            return dt;
        }

        public DataTable viewContact_Client_View_ChurchByProfile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contact_Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procContact_Clients_View_Church_By_Profile_ID", objpar);
            return dt;
        }

        //---------------Search Engine--------------------
        public void updateChurch_Search_Engine()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Search_Key_Words", SqlDbType.VarChar, Search_Key_Words.ToString()));
            objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objdal.executespreturnnd("procClients_Search_Engine_Update", objlist);
        }

        public DataTable viewChurch_Search_EngineByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClients_Search_Engine_By_Client_ID", objpar);
            return dt;
        }

       
        //-------------------Location----------------------------------
        public void updateClients_Location()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
            objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
            objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
            objlist.Add(new csParameterListType("@Area_Category", SqlDbType.VarChar, Area_Category.ToString()));
            objlist.Add(new csParameterListType("@Directions", SqlDbType.VarChar, Directions.ToString()));
            objlist.Add(new csParameterListType("@GPSCoordinates", SqlDbType.VarChar, GPSCoordinates.ToString()));
            objdal.executespreturnnd("procClients_Location_Update", objlist);
        }

        public DataTable viewClients_LocationByClient_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClients_Location_By_ClientID", objpar);
            return dt;
        }

        //-----------------------Address----------------------------------------------
        public void updateClients_Address()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@AddressLine1", SqlDbType.VarChar, AddressLine1.ToString()));
            objlist.Add(new csParameterListType("@AddressLine2", SqlDbType.VarChar, AddressLine2.ToString()));
            objlist.Add(new csParameterListType("@AddressCode", SqlDbType.VarChar, AddressCode.ToString()));
            objdal.executespreturnnd("procClients_Address_Update", objlist);
        }

        public DataTable viewClients_AddressByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClients_Address_By_ClientID", objpar);
            return dt;
        }

        #region ClientShared

        public DataTable viewAgeBracket_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procClient_AgeBracket_By_Client_ID", objpar);
            return dt;
        }
        #endregion


    }
}
