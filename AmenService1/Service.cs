using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Data;
using System.Web.Script.Serialization;
using System.Configuration;
using System.EnterpriseServices;
using System.Net;
using System.IO;


namespace AmenService1
{

    [ServiceContract(Name = "AmenService1Contract")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service
    {
        csShop objShop = new csShop();
        csFiles objFile = new csFiles();
        csPages objPage = new csPages();
        csUser_Accounts objUser = new csUser_Accounts();

        csClients objClient = new csClients();
        csProfiles objProfiles = new csProfiles();
        csMinistries objMinistries = new csMinistries();
        csFinancials objFinace = new csFinancials();
        csNetworks objNetworks = new csNetworks();
        csEvents objEvents = new csEvents();
        csLeadership objLeadership = new csLeadership();
        csAttendance objAttendance = new csAttendance();

        csPrayersAndTestimonies objPrayersAndTestimonies = new csPrayersAndTestimonies();

        csCommunication objComm = new csCommunication();
        csService_Providers sp = new csService_Providers();

        #region Attrition

        [OperationContract]
        [Description("Returns members Family by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string attritionCrude(string secToken, string crude, Int32 clientID, Int32 profileID, int attritionID, string attritionDate, string category, string attritionDescription)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.crudeAttrition(crude, clientID, profileID, attritionID, attritionDate, category, attritionDescription);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns All members Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllAttritionsSmallOrLarge({secToken},{ClientID},{smallOrLarge})")]
        public string GetAllAttritionsSmallOrLarge(string secToken, string ClientID, string smallOrLarge)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Attritions_SmallOrLarge_By_Client_ID(Convert.ToInt32(ClientID), smallOrLarge);
            }


            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns All members Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllAttritions({secToken},{ClientID})")]
        public string GetAllAttritions(string secToken, string ClientID)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Attritions_By_Client_ID(Convert.ToInt32(ClientID));
            }


            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }



        #endregion

        #region Profiles

        [OperationContract]
        [Description("Returns All members only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllProfilesMembersSmallOrLarge({secToken},{ClientID},{smallOrLarge})")]
        public string GetAllProfilesMembersSmallOrLarge(string secToken, string ClientID, string smallOrLarge)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Members_SmallOrLarge_By_Client_ID(Convert.ToInt32(ClientID), smallOrLarge);
            }


            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);


        }

        [OperationContract]
        [Description("Returns members Profile by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ProfileDetailsById({secToken},{ProfileID})")]
        public string GetProfileDetailsById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfileDetailsByProfile_ID(Convert.ToInt32(ProfileID));
            }



            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns members Profile by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ProfileById({secToken},{ProfileID})")]
        public string GetProfileById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfileByProfile_ID(Convert.ToInt32(ProfileID));
            }

            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns All members only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllProfilesMembersOnly({secToken},{ClientID})")]
        public string GetAllProfilesMembersOnly(string secToken, string ClientID)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_MembersOny_By_Client_ID2(Convert.ToInt32(ClientID));
            }
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);


        }

        [OperationContract]
        [Description("Returns All members Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllProfiles({secToken},{ClientID})")]
        public string GetAllProfiles(string secToken, string ClientID)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfileByClient_ID(Convert.ToInt32(ClientID));
            }
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);


        }


        [OperationContract]
        [Description("Add Member by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "AddMember({secToken},{ClientID})")]
        public string addMember(string secToken, string ClientID)
        {
            int clientID = Convert.ToInt32(ClientID);

            DataTable dt2 = new DataTable();
            dt2 = objProfiles.viewProfileByClient_ID(clientID);

            Int32 Profile_Count = dt2.Rows.Count + 1;
            string Member_Number = Profile_Count.ToString("00") + clientID.ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString();

            objProfiles.Client_ID = clientID;
            objProfiles.Profile_Number = Member_Number;
            objProfiles.MainDepartment_ID = 3;
            objProfiles.Category_ID = 1;
            objProfiles.Reg_Date = DateTime.Now.ToString();
            objProfiles.addProfile_Pre();


            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfileID_ByProfile_Number(Member_Number);
            }

            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Add New Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string addNewProfile(string secToken, Int32 ClientID, string firstname, string lastname, string mobile, string gender, string agebracket, string birthyear, string birthmonth, string birthday)
        {
            objProfiles.Client_ID = ClientID;
            objProfiles.First_Name = firstname;
            objProfiles.Last_Name = lastname;
            objProfiles.Cellphone = mobile;
            objProfiles.Gender = gender;
            objProfiles.Age_Bracket = agebracket;
            objProfiles.Birth_Year = birthyear;
            objProfiles.Birth_Month = birthmonth;
            objProfiles.Birth_Day = birthday;
            //objProfiles.addNewProfile();

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.addNewProfile();
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add New Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string addNewProfile2(string secToken, Int32 ClientID, string regDate, string firstname, string lastname, string mobile, string gender, Int32 ageBracketID, string birthyear, string birthmonth, string birthday)
        {
            objProfiles.Client_ID = ClientID;
            objProfiles.Reg_Date = regDate;
            objProfiles.First_Name = firstname;
            objProfiles.Last_Name = lastname;
            objProfiles.Cellphone = mobile;
            objProfiles.Gender = gender;
            objProfiles.ageBracket_ID = ageBracketID;
            objProfiles.Birth_Year = birthyear;
            objProfiles.Birth_Month = birthmonth;
            objProfiles.Birth_Day = birthday;
            //objProfiles.addNewProfile();

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.addNewProfile2();
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Update member Profile by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateProfile(string secToken, int ProfileID, string firstname, string lastname, string gender, string idno, string birthdate, string agebracket, string marital, string weddingdate, int homeCellID, int networkID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.First_Name = firstname;
                objProfiles.Last_Name = lastname;
                objProfiles.Full_Name = lastname + " " + firstname;
                objProfiles.Gender = gender;
                objProfiles.ID_No = idno;
                objProfiles.Birth_Date = birthdate;
                objProfiles.Birth_Year = birthdate.Substring(0, 4);
                objProfiles.Birth_Month = birthdate.Substring(5, 2);
                objProfiles.Birth_Day = birthdate.Substring(8, 2);
                objProfiles.Age_Bracket = agebracket;
                objProfiles.Marital = marital;
                objProfiles.Wedding_Date = weddingdate;
                objProfiles.Wedding_Year = weddingdate.Substring(0, 4);
                objProfiles.Wedding_Month = weddingdate.Substring(5, 2);
                objProfiles.Wedding_Day = weddingdate.Substring(8, 2);
                objProfiles.HomeCell_ID = homeCellID;
                objProfiles.Network_ID = networkID;
                objProfiles.LastUpdate_Date = DateTime.Now.ToString();
                objProfiles.updateProfile_CMember2();
            }


        }

        [OperationContract]
        [Description("Update member Profile by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateProfile2(string secToken, int ProfileID, string regDate, string firstname, string lastname, string gender, string idno, string birthdate, Int32 ageBracketID, string marital, string weddingdate, int homeCellID, int networkID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.Reg_Date = regDate;
                objProfiles.First_Name = firstname;
                objProfiles.Last_Name = lastname;
                objProfiles.Full_Name = lastname + " " + firstname;
                objProfiles.Gender = gender;
                objProfiles.ID_No = idno;
                objProfiles.Birth_Date = birthdate;
                objProfiles.Birth_Year = birthdate.Substring(0, 4);
                objProfiles.Birth_Month = birthdate.Substring(5, 2);
                objProfiles.Birth_Day = birthdate.Substring(8, 2);
                objProfiles.ageBracket_ID = ageBracketID;
                objProfiles.Marital = marital;
                objProfiles.Wedding_Date = weddingdate;
                objProfiles.Wedding_Year = weddingdate.Substring(0, 4);
                objProfiles.Wedding_Month = weddingdate.Substring(5, 2);
                objProfiles.Wedding_Day = weddingdate.Substring(8, 2);
                objProfiles.HomeCell_ID = homeCellID;
                objProfiles.Network_ID = networkID;
                objProfiles.LastUpdate_Date = DateTime.Now.ToString();
                objProfiles.updateProfile_CMember3();
            }


        }

        [OperationContract]
        [Description("Search member Profile by any field")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "searchProfile({secToken},{sVariable})")]
        public string searchProfile(string secToken, string sVariable)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.searchForProfileByAnyField2(sVariable, 1);
            }
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Delete member Profile by Profile ID")]
        //[WebGet(ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(Method = "DELETE", 
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json)]//,UriTemplate = "DeleteEmployee({ID})"
        public void DeleteProfile(Int32 ProfileID)
        {
            //csEmployees objEmployees = new csEmployees();
            //objProfiles.Profile_ID = ID;
            //objProfiles.deleteProfile();
        }

        #endregion

        #region Contacts

        [OperationContract]
        [Description("Returns members Contact by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ContactById({secToken},{ProfileID})")]
        public string GetContactById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewContactsByProfile_ID(Convert.ToInt32(ProfileID));
            }

            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Update member Contact by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateContact(string secToken, int ProfileID, string mobile, string phone, string phonew, string email, string socialmedia1, string socialmedia2, string socialmedia3)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.Cellphone = mobile;
                objProfiles.Telephone = phone;
                objProfiles.PhoneW = phonew;
                objProfiles.Email = email;
                objProfiles.SocialMedia1 = socialmedia1;
                objProfiles.SocialMedia2 = socialmedia2;
                objProfiles.SocialMedia3 = socialmedia3;
                objProfiles.updateContacts();
            }


        }

        #endregion

        #region Location

        [OperationContract]
        [Description("Returns members Location by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "LocationById({secToken},{ProfileID})")]
        public string GetLocationById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewLocation_and_AddressByProfile_ID(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Update member Location by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateLocation(string secToken, int ProfileID, string city, string province, string country, string areaCategory, string areaName, string directions, string GPSCoordinates, string addressLine1, string addressLine2, string addressCode)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.City = city;
                objProfiles.Province = province;
                objProfiles.Country = country;
                objProfiles.Area_Category = areaCategory;
                objProfiles.Area_Name = areaName;
                objProfiles.Directions = directions;
                objProfiles.GPSCoordinates = GPSCoordinates;
                objProfiles.AddressLine1 = addressLine1;
                objProfiles.AddressLine2 = addressLine2;
                objProfiles.AddressCode = addressCode;
                objProfiles.updateLocation_and_Address();
            }



        }

        #endregion

        #region HomeCells

        [OperationContract]
        [Description("Returns homecell by ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string homeCellCrude(string secToken, string crude, Int32 clientID, Int32 cellID, string cellName, string cellVenue, string cellDay, string cellTime, Int32 leaderID, Int32 intern1ID, Int32 intern2ID, string startDate, string cellActive)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.crudeHomeCell(crude, clientID, cellID, cellName, cellVenue, cellDay, cellTime, leaderID, intern1ID, intern2ID, startDate, cellActive);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns HomeCells by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "HomeCellsById({secToken},{ClientID})")]
        public string GetHomeCellsById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewHome_Cell_By_Client_ID(Convert.ToInt32(ClientID));
            }

            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns HomeCells by CellID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "HomeCellsByCellId({secToken},{CellID})")]
        public string GetHomeCellsByCellId(string secToken, string CellID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewHome_Cell_By_Cell_ID(Convert.ToInt32(CellID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns HomeCells by Client ID and No Dates")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "HomeCellsByIdandNoDates({secToken},{ClientID})")]
        public string GetHomeCellsByIdandNoDates(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewHome_Cell_By_Client_ID_and_NoDates(Convert.ToInt32(ClientID));
            }

            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns All HomeCells by Client ID with Dates")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "HomeCellsByIdandwithDates({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetAllHomeCellsByIdandwithDates(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewHome_Cell_By_Client_ID_and_Dates(Convert.ToInt32(ClientID), From_Date, To_Date);
            }
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        [OperationContract]
        [Description("Update HomeCells by Cell_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateHomeCell(string secToken, int Cell_ID, string Start_Date, string Cell_Name, string Cell_Venue, string Cell_Day, string Cell_Time, Int32 Leader_ID, Int32 Intern1_ID, Int32 Intern2_ID, string Cell_Active)
        {

            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Cell_ID = Cell_ID;
                objProfiles.Start_Date = Start_Date;
                objProfiles.Cell_Name = Cell_Name;
                objProfiles.Cell_Venue = Cell_Venue;
                objProfiles.Cell_Day = Cell_Day;
                objProfiles.Cell_Time = Cell_Time;
                objProfiles.Leader_ID = Leader_ID;
                objProfiles.Intern1_ID = Intern1_ID;
                objProfiles.Intern2_ID = Intern2_ID;
                objProfiles.Cell_Active = Cell_Active;
                objProfiles.LastUpdate_Date = DateTime.Now.ToString();
                objProfiles.updateCell();
            }


        }

        [OperationContract]
        [Description("Add HomeCell by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addHomeCell(string secToken, int ClientID)
        {
            
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                DataTable dtCellIDGet = new DataTable();
                dtCellIDGet = objProfiles.viewHome_Cell_GroupID_By_Client_ID(ClientID);

                DataTable dt = new DataTable();
                dt = objProfiles.viewHome_Cell_By_Client_ID(ClientID);

                Int32 Cell_ID = Convert.ToInt32(dtCellIDGet.Rows[0]["Cell_ID"].ToString());

                int Cell_Count = dt.Rows.Count + 1;
                string Profile_Number_Prefix = string.Empty;

                string Cell_Number = "HC" + Cell_Count.ToString("00") + ClientID.ToString("00") + DateTime.Now.Year.ToString();

                objProfiles.Cell_Number = Cell_Number;
                objProfiles.Client_ID = ClientID;
                objProfiles.Group_ID = Cell_ID;
                objProfiles.LastUpdate_Date = DateTime.Now.ToString();
                objProfiles.addHome_Cell_Pre();
            }

        }

        [OperationContract]
        [Description("Returns HomeCellMembers by Cell ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "HomeCellMembers({secToken},{CellID})")]
        public string GetHomeCellMembers(string secToken, string CellID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewHome_Cell_Members_By_Cell_ID(Convert.ToInt32(CellID));
            }
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns homecellGuests by ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string homeCellGuestCrude(string secToken, string crude, Int32 clientID, int visitorID, int cellID, string guestName, string guestMobile, string guestAddress, string guestBirthDate, string gender, string marital, string status, string attendChurch, string visitRegular, Int32 invitedByID, string regDate)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.crudeHomeGuestCell(crude, clientID, visitorID, cellID, guestName, guestMobile, guestAddress, guestBirthDate, gender, marital, status, attendChurch, visitRegular, invitedByID, regDate);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        #endregion

        #region Networks

        [OperationContract]
        [Description("Returns Networks by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NetworksById({secToken},{ClientID})")]
        public string GetNetworksById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objNetworks.viewNetworks_By_Client_ID(Convert.ToInt32(ClientID));
            }
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        #endregion
        
        #region Spiritual_Activities

        [OperationContract]
        [Description("Returns members Activity by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string activityCrude(string secToken, string crude, Int32 profileID, Int32 activityID, string activity, string description, string date, string status)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.crudeActivity(crude, profileID, activityID, activity, description, date, status);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns members Spiritual_Activities by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ActivityById({secToken},{ProfileID})")]
        public string GetActivityById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewSpiritual_ActivitiesByProfile_ID(Convert.ToInt32(ProfileID));
            }
           

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member Spiritual_Activities Activity by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addActivity(string secToken, int ProfileID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.addSpiritual_ActivitiesPre();
            }

        }

        [OperationContract]
        [Description("Add member Spiritual_Activities Activity")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addActivity2(string secToken, int ProfileID, string Activity, string Description, string Date, string Status)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.Activity = Activity;
                objProfiles.Description = Description;
                objProfiles.Date = Date;
                objProfiles.Status = Status;
                objProfiles.addSpiritual_Activities();
            }

        }

        [OperationContract]
        [Description("Update member Spiritual_Activities by Activity ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateActivity(string secToken, int ActivityID, string Activity, string Description, string Date, string Status)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Activity_ID = ActivityID;
                objProfiles.Activity = Activity;
                objProfiles.Description = Description;
                objProfiles.Date = Date;
                objProfiles.Status = Status;
                objProfiles.updateSpiritual_Activities();
            }


        }


        [OperationContract]
        [Description("Remove member Spiritual_Activities by Activity ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeActivity(string secToken, int ActivityID)
        {
             DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Activity_ID = ActivityID;
                objProfiles.removeSpiritual_Activities();
            }

        }

        #endregion

        #region ClientRegistration

        [OperationContract]
        [Description("Returns New Client Reg")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string registerNewClient(string secToken, string churchName, string pastorName, string mobile, string email, string tel, string city, string province, string country, string physicalAddress, string physicalAddressCode, string package)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objClient.registerNewClient(churchName, pastorName, mobile, email, tel, city, province, country, physicalAddress, physicalAddressCode, package);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region Client Details

        [OperationContract]
        [Description("Returns ClientDetails")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientDetails({secToken},{ClientID})")]
        public string GetClientDetails(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objClient.viewClientByClient_ID(Convert.ToInt32(ClientID));
            }


            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region ClientMinistries


        [OperationContract]
        [Description("Returns members ClientMinistries by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientMinistriesById({secToken},{ProfileID})")]
        public string GetClientMinistriesById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objMinistries.viewClient_Ministries_By_Profile_ID(Convert.ToInt32(ProfileID));
            }
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member Ministries by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addClientMinistries(string secToken, int ProfileID, int Client_ID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objMinistries.Client_ID = Client_ID;
                objMinistries.Profile_ID = ProfileID;
                objMinistries.addClient_MinistriesPre();
            }


        }

        [OperationContract]
        [Description("Add member Ministries by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addClientMinistries2(string secToken, int ProfileID, int Client_ID, int Ministry_ID, int Title_ID, string Responsibilities, string Start_Date, string End_Date, string Status, int Report_To_ID, string Category)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objMinistries.Client_ID = Client_ID;
                objMinistries.Profile_ID = ProfileID;
                objMinistries.Ministry_ID = Ministry_ID;
                objMinistries.Title_ID = Title_ID;
                objMinistries.Responsibilities = Responsibilities;
                objMinistries.Start_Date = Start_Date;
                objMinistries.End_Date = End_Date;
                objMinistries.Status = Status;
                objMinistries.Report_To_ID = Report_To_ID;
                objMinistries.Category = Category;
                objMinistries.addClient_Ministries();
            }


        }

        [OperationContract]
        [Description("Update member ClientMinistries by Activity ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateClientMinistries(string secToken, int Client_Ministry_ID, int Ministry_ID, int Title_ID, string Responsibilities, string Start_Date, string End_Date, string Status, int Report_To_ID, string Category)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objMinistries.Client_Ministry_ID = Client_Ministry_ID;
                objMinistries.Ministry_ID = Ministry_ID;
                objMinistries.Title_ID = Title_ID;
                objMinistries.Responsibilities = Responsibilities;
                objMinistries.Start_Date = Start_Date;
                objMinistries.End_Date = End_Date;
                objMinistries.Status = Status;
                objMinistries.Report_To_ID = Report_To_ID;
                objMinistries.Category = Category;
                objMinistries.updateClient_Ministries();
            }

        }


        [OperationContract]
        [Description("Remove member ClientMinistries by Client_Ministry_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeClientMinistries(string secToken, int Client_Ministry_ID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objMinistries.Client_Ministry_ID = Client_Ministry_ID;
                objMinistries.deleteClient_Ministries();
            }

        }

        #endregion

        #region ClientMinistriesItems


        [OperationContract]
        [Description("Returns members ClientMinistriesItems byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientMinistriesItemsById({secToken},{ClientID})")]
        public string GetClientMinistriesItemsById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objMinistries.viewAllMinistries_Itemz_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member MinistriesItems by ClientID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addClientMinistriesItems(string secToken, int Client_ID, string Ministry)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {

                objMinistries.Client_ID = Client_ID;
                objMinistries.Ministry = Ministry;
                objMinistries.addMinistries_Itemz();
            }

        }

        [OperationContract]
        [Description("Update member ClientMinistriesItem by Ministry_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateClientMinistriesItems(string secToken, int Ministry_ID, string Ministry)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objMinistries.Ministry_ID = Ministry_ID;
                objMinistries.Ministry = Ministry;
                objMinistries.UpdateMinistries_Itemz();
            }

        }

        [OperationContract]
        [Description("Returns Ministries Items by ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string ministriesItemsCrude(string secToken, string crude, Int32 clientID, int ministryID, string ministry)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objMinistries.crudeMinistriesItems(crude, clientID, ministryID, ministry);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Remove member ClientMinistriesItem by Ministry_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeClientMinistriesItems(string secToken, int Ministry_ID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objMinistries.Ministry_ID = Ministry_ID;
                objMinistries.DeleteMinistries_Itemz();
            }

        }

        #endregion

        #region ClientMinistryWorkers
        [OperationContract]
        [Description("Returns ClientMinistriesWorkers byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientMinistryWorkers({secToken},{ClientID})")]
        public string GetClientMinistryWorkers(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objMinistries.viewClient_Ministry_Workers_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns ClientMinistriesWorkers byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientMinistryWorkersInActive({secToken},{ClientID})")]
        public string GetClientMinistryWorkersInActive(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objMinistries.viewClient_Ministry_Workers_InActive_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region ClientMinistryLeadership
        [OperationContract]
        [Description("Returns members ClientMinistriesItems byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientMinistryLeaders({secToken},{ClientID})")]
        public string GetClientMinistryLeaders(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objLeadership.viewClient_Leadership_New_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns members ClientMinistriesItems byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientMinistryLeadersInActive({secToken},{ClientID})")]
        public string GetClientMinistryLeadersInActive(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objLeadership.viewClient_Leadership_InActive_New_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region ClientShared

        [OperationContract]
        [Description("Returns members ClientMinistriesTitles byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "UserTypes({secToken},{ClientID})")]
        public string GetUserTypes(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {

                dt = objClient.viewAgeBracket_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns members ClientMinistriesTitles byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientAgeBracketById({secToken},{ClientID})")]
        public string GetClientAgeBracketById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {

                dt = objClient.viewAgeBracket_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns titles by ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string titlesCrude(string secToken, string crude, Int32 clientID, int titleID, string title)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objLeadership.crudeTitles(crude, clientID, titleID, title);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns members ClientMinistriesTitles byClient ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientMinistriesTitlesById({secToken},{ClientID})")]
        public string GetClientMinistriesTitlesById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {

                dt = objLeadership.viewAllLeadership_Titlez_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member MinistriesTitles by ClientID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addClientMinistriesTitles(string secToken, int Client_ID, string Title)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objLeadership.Client_ID = Client_ID;
                objLeadership.Title = Title;
                objLeadership.addLeadership_Titlez();
            }

        }

        [OperationContract]
        [Description("Update member ClientMinistriesTitles by Ministry_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateClientMinistriesTitles(string secToken, int Title_ID, string Title)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objLeadership.Title_ID = Title_ID;
                objLeadership.Title = Title;
                objLeadership.UpdateLeadership_Titlez();
            }

        }


        [OperationContract]
        [Description("Remove member ClientMinistriesTitles by Title_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeClientMinistriesTitles(string secToken, int Title_ID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objLeadership.Title_ID = Title_ID;
                objLeadership.DeleteLeadership_Titlez();
            }

        }

        #endregion

        #region ServiceProviders

        [OperationContract]
        [Description("Returns serviceProvider")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string serviceProviderCrude(string secToken
            , string crude
            , Int32 clientID
            , Int32 serviceProviderID
            , string serviceProviderNumber
            , string serviceProvider
            , string serviceProviderDescription
            , string experience
            , string contactPerson
            , string mobile
            , string tel
            , string email
            , string website
            , string country
            , string province
            , string city
            , string address
            , string postalCode
            , string regDate
            , Int32 serviceID
            , string service)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = sp.crudeServiceProvider(crude, clientID, serviceProviderID, serviceProviderNumber, serviceProvider, serviceProviderDescription, experience, contactPerson, mobile, tel, email, website, country, province, city, address, postalCode, regDate, serviceID, service);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        #endregion

        #region Family

        [OperationContract]
        [Description("Returns members Family by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string familyCrude(string secToken, string crude, Int32 profileID, int familyID, string relationship, string fullName, string mobile, string churchAttending, string isSaved, string isBaptised)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.crudeFamily(crude, profileID, familyID, relationship, fullName, mobile, churchAttending, isSaved, isBaptised);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }



        [OperationContract]
        [Description("Returns members Family by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "FamilyById({secToken},{ProfileID})")]
        public string GetFamilyById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewFamilyByProfile_ID(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member Family Member by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addFamily(string secToken, int ProfileID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.addFamilyPre();
            }

        }

        [OperationContract]
        [Description("Update member Family Member by Family ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateFamily(string secToken, int FamilyID, string relationship, string fullName, string contactNumber, string churchAttending, string isSaved, string isBaptised)
        {

            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Family_ID = FamilyID;
                objProfiles.Relationship = relationship;
                objProfiles.FullNames = fullName;
                objProfiles.Cellphone = contactNumber;
                objProfiles.ChurchAttending = churchAttending;
                objProfiles.Saved = isSaved;
                objProfiles.Baptised = isBaptised;
                objProfiles.updateFamilyApp();
            }

        }


        [OperationContract]
        [Description("Remove member Family Member by Family ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeFamily(string secToken, int FamilyID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Family_ID = FamilyID;
                objProfiles.removeFamilyApp();
            }

        }

        #endregion

        #region Education

        [OperationContract]
        [Description("Returns education by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string educationCrude(string secToken, string crude, Int32 profileID, Int32 educationID, string institution, string qualification, string qualificationLevel, string intendedCareer, string studyPeriod, string studyYears, string studyStatus)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {
                //return "nothing";
            }
            else
            {
                dt = objProfiles.crudeEducation(crude, profileID, educationID, institution, qualification, qualificationLevel, intendedCareer, studyPeriod, studyYears, studyStatus);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns members Education by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "EducationById({secToken},{ProfileID})")]
        public string GetEducationById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewEducationByProfile_ID(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member Education Member by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addEducation(string secToken, int ProfileID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.AddEducationPre();
            }

        }

        [OperationContract]
        [Description("Update member Education Member by Education ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateEducation(string secToken, int EducationID, string institution, string qualification, string studyLevel, string studyStatus, string intendedCareer, string studyPeriod, string studyYears)
        {

                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Education_ID = EducationID;
                objProfiles.Institution = institution;
                objProfiles.Qualification = qualification;
                objProfiles.Qualification_Level = studyLevel;
                objProfiles.Study_Status = studyStatus;
                objProfiles.Intended_Career = intendedCareer;
                objProfiles.Study_Period = studyPeriod;
                objProfiles.Study_Years = studyYears;
                objProfiles.updateEducation();
            }

        }


        [OperationContract]
        [Description("Remove member Education Member by Education ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeEducation(string secToken, int EducationID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Education_ID = EducationID;
                objProfiles.removeEducation();
            }

        }


        #endregion

        #region Career

        [OperationContract]
        [Description("Returns career by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string careerCrude(string secToken, string crude, Int32 profileID, Int32 careerID, string workStatus, string workFor, string workForName, string departmentName, string workPosition, string workPeriod, string workYears)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.crudeCareer(crude, profileID, careerID, workStatus, workFor, workForName, departmentName, workPosition, workPeriod, workYears);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }



        [OperationContract]
        [Description("Returns members Career by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CareerById({secToken},{ProfileID})")]
        public string GetCareerById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewCareerByProfile_ID(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member Career by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addCareer(string secToken, int ProfileID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.AddCareerPre();
            }

        }

        [OperationContract]
        [Description("Update member Career by Career ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateCareer(string secToken, int CareerID, string workStatus, string workFor, string workForName, string departmentName, string workPosition, string workPeriod, string workYears)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Career_ID = CareerID;
                objProfiles.Work_Status = workStatus;
                objProfiles.Work_For = workFor;
                objProfiles.Work_For_Name = workForName;
                objProfiles.Department_Name = departmentName;
                objProfiles.Work_Position = workPosition;
                objProfiles.Work_Period = workPeriod;
                objProfiles.Work_Years = workYears;
                objProfiles.updateCareer();
            }

        }


        [OperationContract]
        [Description("Remove member Career by Career ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeCareer(string secToken, int CareerID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Career_ID = CareerID;
                objProfiles.removeCareer();
            }

        }

        #endregion

        #region PrayersAndTestimonies

        [OperationContract]
        [Description("Returns career by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string prayerCrude(string secToken, string crude, Int32 profileID, Int32 prayersAndTestimoniesID, string category, string date, string message)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPrayersAndTestimonies.crudePrayers(crude, profileID, prayersAndTestimoniesID, category, date, message);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns members PrayersAndTestimonies by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "PrayersAndTestimoniesById({secToken},{ProfileID})")]
        public string GetPrayersAndTestimoniesById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPrayersAndTestimonies.viewPrayersAndTestimonies_By_Profile_ID(Convert.ToInt32(ProfileID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add member PrayersAndTestimonies by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addPrayersAndTestimonies(string secToken, int ProfileID, int Client_ID)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objPrayersAndTestimonies.Client_ID = Client_ID;
                objPrayersAndTestimonies.Profile_ID = ProfileID;
                objPrayersAndTestimonies.addPrayersAndTestimoniesPre();
            }
        }

        [OperationContract]
        [Description("Update member PrayersAndTestimonies by  ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updatePrayersAndTestimonies(string secToken, int PrayersAndTestimonies_ID, string Category, string Date, string Message)
        {
                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objPrayersAndTestimonies.PrayersAndTestimonies_ID = PrayersAndTestimonies_ID;
                objPrayersAndTestimonies.Category = Category;
                objPrayersAndTestimonies.Date = Date;
                objPrayersAndTestimonies.Message = Message;
                objPrayersAndTestimonies.updatePrayersAndTestimonies();
            }
        }


        [OperationContract]
        [Description("Remove member PrayersAndTestimonies by PrayersAndTestimonies_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removePrayersAndTestimonies(string secToken, int PrayersAndTestimonies_ID)
        {

                        DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objPrayersAndTestimonies.PrayersAndTestimonies_ID = PrayersAndTestimonies_ID;
                objPrayersAndTestimonies.deletePrayersAndTestimonies();
            }
        }




        #endregion

        #region Attendance


        [OperationContract]
        [Description("Returns Attendance")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string attendanceCrude(string secToken, string crude, Int32 attendanceID, Int32 clientID, Int32 profileID, string attendanceDate, string description, string category, Int32 homeCellID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objAttendance.attendanceCrude(crude, attendanceID, clientID, profileID, attendanceDate, description, category, homeCellID);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns AttendanceByClientIDAndCategory")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "AttendanceByClientIDAndCategory({secToken},{ClientID},{Category},{fromDate},{toDate})")]
        public string GetAttendanceByClientIDAndCategory(string secToken, string ClientID, string Category, string fromDate, string toDate)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objAttendance.viewAttendance_By_Client_ID_And_Category(Convert.ToInt32(ClientID), Category, fromDate, toDate);
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("AddServiceAttendance")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void AddServiceAttendance(
            string secToken, 
            Int32 clientID, 
            string name, 
            string category,
            string date, 
            string time, 
            string venue, 
            Int32 totalMembers, 
            Int32 totalMembersMales, 
            Int32 totalMembersFemales,
            Int32 totalChildren, 
            Int32 totalChildrenMales, 
            Int32 totalChildrenFemales,
            Int32 totalGuests, 
            Int32 totalGuestsMales, 
            Int32 totalGuestsFemales,
            Int32 totalAltarCall, 
            Int32 totalAltarCallMales, 
            Int32 totalAltarCallFemales,
            Int32 busTaxiTotal1,
            Int32 busTaxiTotal1Adults,
            Int32 busTaxiTotal1Children, 
            string busTaxiAreaName1, 
            string busTaxiArrivalTime1,
            Int32 busTaxiTotal2,
            Int32 busTaxiTotal2Adults,
            Int32 busTaxiTotal2Children, 
            string busTaxiAreaName2, 
            string busTaxiArrivalTime2,
            Int32 busTaxiTotal3,
            Int32 busTaxiTotal3Adults,
            Int32 busTaxiTotal3Children, 
            string busTaxiAreaName3, 
            string busTaxiArrivalTime3,
            Int32 busTaxiTotal4,
            Int32 busTaxiTotal4Adults,
            Int32 busTaxiTotal4Children, 
            string busTaxiAreaName4, 
            string busTaxiArrivalTime4,
            Int32 busTaxiTotal5,
            Int32 busTaxiTotal5Adults,
            Int32 busTaxiTotal5Children, 
            string busTaxiAreaName5, 
            string busTaxiArrivalTime5,
            Int32 busTaxiTotal6,
            Int32 busTaxiTotal6Adults,
            Int32 busTaxiTotal6Children, 
            string busTaxiAreaName6, 
            string busTaxiArrivalTime6,
            Int32 busTaxiTotal7,
            Int32 busTaxiTotal7Adults,
            Int32 busTaxiTotal7Children, 
            string busTaxiAreaName7, 
            string busTaxiArrivalTime7,
            Int32 busTaxiTotal8,
            Int32 busTaxiTotal8Adults,
            Int32 busTaxiTotal8Children, 
            string busTaxiAreaName8, 
            string busTaxiArrivalTime8,
            Int32 busTaxiTotal9,
            Int32 busTaxiTotal9Adults,
            Int32 busTaxiTotal9Children, 
            string busTaxiAreaName9, 
            string busTaxiArrivalTime9,
            Int32 busTaxiTotal10,
            Int32 busTaxiTotal10Adults,
            Int32 busTaxiTotal10Children, 
            string busTaxiAreaName10, 
            string busTaxiArrivalTime10,
            Int32 totalCars, 
            Int32 totalOther,
            string summaryNotes
            )
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {

                objAttendance.Client_ID = clientID;
                objAttendance.Service = name;
                objAttendance.Category = category;
                objAttendance.Service_Date = date;
                objAttendance.Service_Time = time;
                objAttendance.Service_Venue = venue;

                objAttendance.Members = totalMembers;
                objAttendance.Members_Males = totalMembersMales;
                objAttendance.Members_Females = totalMembersFemales;

                objAttendance.Children = totalChildren;
                objAttendance.Children_Males = totalChildrenMales;
                objAttendance.Children_Females = totalChildrenFemales;

                objAttendance.Guests = totalGuests;
                objAttendance.Guests_Males = totalGuestsMales;
                objAttendance.Guests_Females = totalGuestsFemales;

                objAttendance.Altar_Call = totalAltarCall;
                objAttendance.Altar_Call_Males = totalAltarCallMales;
                objAttendance.Altar_Call_Females = totalAltarCallFemales;

                objAttendance.Bus_Taxi1 = busTaxiTotal1;
                objAttendance.Bus_Taxi1Adults = busTaxiTotal1Adults;
                objAttendance.Bus_Taxi1Children = busTaxiTotal1Children;
                objAttendance.Bus_Taxi_Area_Name1 = busTaxiAreaName1;
                objAttendance.Bus_Taxi_Arrival_Time1 = busTaxiArrivalTime1;

                objAttendance.Bus_Taxi2 = busTaxiTotal2;
                objAttendance.Bus_Taxi2Adults = busTaxiTotal2Adults;
                objAttendance.Bus_Taxi2Children = busTaxiTotal2Children;
                objAttendance.Bus_Taxi_Area_Name2 = busTaxiAreaName2;
                objAttendance.Bus_Taxi_Arrival_Time2 = busTaxiArrivalTime2;

                objAttendance.Bus_Taxi3 = busTaxiTotal3;
                objAttendance.Bus_Taxi3Adults = busTaxiTotal3Adults;
                objAttendance.Bus_Taxi3Children = busTaxiTotal3Children;
                objAttendance.Bus_Taxi_Area_Name3 = busTaxiAreaName3;
                objAttendance.Bus_Taxi_Arrival_Time3 = busTaxiArrivalTime3;

                objAttendance.Bus_Taxi4 = busTaxiTotal4;
                objAttendance.Bus_Taxi4Adults = busTaxiTotal4Adults;
                objAttendance.Bus_Taxi4Children = busTaxiTotal4Children;
                objAttendance.Bus_Taxi_Area_Name4 = busTaxiAreaName4;
                objAttendance.Bus_Taxi_Arrival_Time4 = busTaxiArrivalTime4;

                objAttendance.Bus_Taxi5 = busTaxiTotal5;
                objAttendance.Bus_Taxi5Adults = busTaxiTotal5Adults;
                objAttendance.Bus_Taxi5Children = busTaxiTotal5Children;
                objAttendance.Bus_Taxi_Area_Name5 = busTaxiAreaName5;
                objAttendance.Bus_Taxi_Arrival_Time5 = busTaxiArrivalTime5;

                objAttendance.Bus_Taxi6 = busTaxiTotal6;
                objAttendance.Bus_Taxi6Adults = busTaxiTotal6Adults;
                objAttendance.Bus_Taxi6Children = busTaxiTotal6Children;
                objAttendance.Bus_Taxi_Area_Name6 = busTaxiAreaName6;
                objAttendance.Bus_Taxi_Arrival_Time6 = busTaxiArrivalTime6;

                objAttendance.Bus_Taxi7 = busTaxiTotal7;
                objAttendance.Bus_Taxi7Adults = busTaxiTotal7Adults;
                objAttendance.Bus_Taxi7Children = busTaxiTotal7Children;
                objAttendance.Bus_Taxi_Area_Name7 = busTaxiAreaName7;
                objAttendance.Bus_Taxi_Arrival_Time7 = busTaxiArrivalTime7;

                objAttendance.Bus_Taxi8 = busTaxiTotal8;
                objAttendance.Bus_Taxi8Adults = busTaxiTotal8Adults;
                objAttendance.Bus_Taxi8Children = busTaxiTotal8Children;
                objAttendance.Bus_Taxi_Area_Name8 = busTaxiAreaName8;
                objAttendance.Bus_Taxi_Arrival_Time8 = busTaxiArrivalTime8;

                objAttendance.Bus_Taxi9 = busTaxiTotal9;
                objAttendance.Bus_Taxi9Adults = busTaxiTotal9Adults;
                objAttendance.Bus_Taxi9Children = busTaxiTotal9Children;
                objAttendance.Bus_Taxi_Area_Name9 = busTaxiAreaName9;
                objAttendance.Bus_Taxi_Arrival_Time9 = busTaxiArrivalTime9;

                objAttendance.Bus_Taxi10 = busTaxiTotal10;
                objAttendance.Bus_Taxi10Adults = busTaxiTotal10Adults;
                objAttendance.Bus_Taxi10Children = busTaxiTotal10Children;
                objAttendance.Bus_Taxi_Area_Name10 = busTaxiAreaName10;
                objAttendance.Bus_Taxi_Arrival_Time10 = busTaxiArrivalTime10;

                objAttendance.Cars_Parked = totalCars;
                objAttendance.Other = totalOther;
                objAttendance.SummaryNotes = summaryNotes;
                objAttendance.addAttendance();
            }

        }


        [OperationContract]
        [Description("UpdateServiceAttendance")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void UpdateServiceAttendance(
            string secToken,
            Int32 attendanceID,
            string name,
            string category,
            string date,
            string time,
            string venue,
            Int32 totalMembers,
            Int32 totalMembersMales,
            Int32 totalMembersFemales,
            Int32 totalChildren,
            Int32 totalChildrenMales,
            Int32 totalChildrenFemales,
            Int32 totalGuests,
            Int32 totalGuestsMales,
            Int32 totalGuestsFemales,
            Int32 totalAltarCall,
            Int32 totalAltarCallMales,
            Int32 totalAltarCallFemales,
            Int32 busTaxiTotal1,
            Int32 busTaxiTotal1Adults,
            Int32 busTaxiTotal1Children,
            string busTaxiAreaName1,
            string busTaxiArrivalTime1,
            Int32 busTaxiTotal2,
            Int32 busTaxiTotal2Adults,
            Int32 busTaxiTotal2Children,
            string busTaxiAreaName2,
            string busTaxiArrivalTime2,
            Int32 busTaxiTotal3,
            Int32 busTaxiTotal3Adults,
            Int32 busTaxiTotal3Children,
            string busTaxiAreaName3,
            string busTaxiArrivalTime3,
            Int32 busTaxiTotal4,
            Int32 busTaxiTotal4Adults,
            Int32 busTaxiTotal4Children,
            string busTaxiAreaName4,
            string busTaxiArrivalTime4,
            Int32 busTaxiTotal5,
            Int32 busTaxiTotal5Adults,
            Int32 busTaxiTotal5Children,
            string busTaxiAreaName5,
            string busTaxiArrivalTime5,
            Int32 busTaxiTotal6,
            Int32 busTaxiTotal6Adults,
            Int32 busTaxiTotal6Children,
            string busTaxiAreaName6,
            string busTaxiArrivalTime6,
            Int32 busTaxiTotal7,
            Int32 busTaxiTotal7Adults,
            Int32 busTaxiTotal7Children,
            string busTaxiAreaName7,
            string busTaxiArrivalTime7,
            Int32 busTaxiTotal8,
            Int32 busTaxiTotal8Adults,
            Int32 busTaxiTotal8Children,
            string busTaxiAreaName8,
            string busTaxiArrivalTime8,
            Int32 busTaxiTotal9,
            Int32 busTaxiTotal9Adults,
            Int32 busTaxiTotal9Children,
            string busTaxiAreaName9,
            string busTaxiArrivalTime9,
            Int32 busTaxiTotal10,
            Int32 busTaxiTotal10Adults,
            Int32 busTaxiTotal10Children,
            string busTaxiAreaName10,
            string busTaxiArrivalTime10,
            Int32 totalCars,
            Int32 totalOther,
            string summaryNotes
            )
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objAttendance.Attendance_ID = attendanceID;
                objAttendance.Service = name;
                objAttendance.Category = category;
                objAttendance.Service_Date = date;
                objAttendance.Service_Time = time;
                objAttendance.Service_Venue = venue;

                objAttendance.Members = totalMembers;
                objAttendance.Members_Males = totalMembersMales;
                objAttendance.Members_Females = totalMembersFemales;

                objAttendance.Children = totalChildren;
                objAttendance.Children_Males = totalChildrenMales;
                objAttendance.Children_Females = totalChildrenFemales;

                objAttendance.Guests = totalGuests;
                objAttendance.Guests_Males = totalGuestsMales;
                objAttendance.Guests_Females = totalGuestsFemales;

                objAttendance.Altar_Call = totalAltarCall;
                objAttendance.Altar_Call_Males = totalAltarCallMales;
                objAttendance.Altar_Call_Females = totalAltarCallFemales;

                objAttendance.Bus_Taxi1 = busTaxiTotal1;
                objAttendance.Bus_Taxi1Adults = busTaxiTotal1Adults;
                objAttendance.Bus_Taxi1Children = busTaxiTotal1Children;
                objAttendance.Bus_Taxi_Area_Name1 = busTaxiAreaName1;
                objAttendance.Bus_Taxi_Arrival_Time1 = busTaxiArrivalTime1;

                objAttendance.Bus_Taxi2 = busTaxiTotal2;
                objAttendance.Bus_Taxi2Adults = busTaxiTotal2Adults;
                objAttendance.Bus_Taxi2Children = busTaxiTotal2Children;
                objAttendance.Bus_Taxi_Area_Name2 = busTaxiAreaName2;
                objAttendance.Bus_Taxi_Arrival_Time2 = busTaxiArrivalTime2;

                objAttendance.Bus_Taxi3 = busTaxiTotal3;
                objAttendance.Bus_Taxi3Adults = busTaxiTotal3Adults;
                objAttendance.Bus_Taxi3Children = busTaxiTotal3Children;
                objAttendance.Bus_Taxi_Area_Name3 = busTaxiAreaName3;
                objAttendance.Bus_Taxi_Arrival_Time3 = busTaxiArrivalTime3;

                objAttendance.Bus_Taxi4 = busTaxiTotal4;
                objAttendance.Bus_Taxi4Adults = busTaxiTotal4Adults;
                objAttendance.Bus_Taxi4Children = busTaxiTotal4Children;
                objAttendance.Bus_Taxi_Area_Name4 = busTaxiAreaName4;
                objAttendance.Bus_Taxi_Arrival_Time4 = busTaxiArrivalTime4;

                objAttendance.Bus_Taxi5 = busTaxiTotal5;
                objAttendance.Bus_Taxi5Adults = busTaxiTotal5Adults;
                objAttendance.Bus_Taxi5Children = busTaxiTotal5Children;
                objAttendance.Bus_Taxi_Area_Name5 = busTaxiAreaName5;
                objAttendance.Bus_Taxi_Arrival_Time5 = busTaxiArrivalTime5;

                objAttendance.Bus_Taxi6 = busTaxiTotal6;
                objAttendance.Bus_Taxi6Adults = busTaxiTotal6Adults;
                objAttendance.Bus_Taxi6Children = busTaxiTotal6Children;
                objAttendance.Bus_Taxi_Area_Name6 = busTaxiAreaName6;
                objAttendance.Bus_Taxi_Arrival_Time6 = busTaxiArrivalTime6;

                objAttendance.Bus_Taxi7 = busTaxiTotal7;
                objAttendance.Bus_Taxi7Adults = busTaxiTotal7Adults;
                objAttendance.Bus_Taxi7Children = busTaxiTotal7Children;
                objAttendance.Bus_Taxi_Area_Name7 = busTaxiAreaName7;
                objAttendance.Bus_Taxi_Arrival_Time7 = busTaxiArrivalTime7;

                objAttendance.Bus_Taxi8 = busTaxiTotal8;
                objAttendance.Bus_Taxi8Adults = busTaxiTotal8Adults;
                objAttendance.Bus_Taxi8Children = busTaxiTotal8Children;
                objAttendance.Bus_Taxi_Area_Name8 = busTaxiAreaName8;
                objAttendance.Bus_Taxi_Arrival_Time8 = busTaxiArrivalTime8;

                objAttendance.Bus_Taxi9 = busTaxiTotal9;
                objAttendance.Bus_Taxi9Adults = busTaxiTotal9Adults;
                objAttendance.Bus_Taxi9Children = busTaxiTotal9Children;
                objAttendance.Bus_Taxi_Area_Name9 = busTaxiAreaName9;
                objAttendance.Bus_Taxi_Arrival_Time9 = busTaxiArrivalTime9;

                objAttendance.Bus_Taxi10 = busTaxiTotal10;
                objAttendance.Bus_Taxi10Adults = busTaxiTotal10Adults;
                objAttendance.Bus_Taxi10Children = busTaxiTotal10Children;
                objAttendance.Bus_Taxi_Area_Name10 = busTaxiAreaName10;
                objAttendance.Bus_Taxi_Arrival_Time10 = busTaxiArrivalTime10;

                objAttendance.Cars_Parked = totalCars;
                objAttendance.Other = totalOther;
                objAttendance.SummaryNotes = summaryNotes;
                objAttendance.updateAttendance();
            }

        }

        [OperationContract]
        [Description("DeleteServiceAttendance")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void DeleteServiceAttendance(string secToken, Int32 attendanceID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objAttendance.Attendance_ID = attendanceID;
                objAttendance.deleteAttendance();
            }

        }
        #endregion

        #region Photos

        csPhoto objPhoto = new csPhoto();


        [OperationContract]
        [Description("Returns members Photo by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "PhotoById({secToken},{ProfileID})")]
        public string GetPhotoById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPhoto.viewPhoto_Profile_By_Profile_ID(Convert.ToInt32(ProfileID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns members AllPhoto by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "PhotoAllById({secToken},{ProfileID})")]
        public string GetPhotoAllById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {
                return "no image";
            }
            else
            {
                dt = objPhoto.viewPhotoByProfile_ID(Convert.ToInt32(ProfileID));
                if (dtUser.Rows.Count > 0)
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    Dictionary<string, object> row;
                    foreach (DataRow dr in dt.Rows)
                    {
                        row = new Dictionary<string, object>();
                        foreach (DataColumn col in dt.Columns)
                        {
                            row.Add(col.ColumnName, dr[col]);
                        }
                        rows.Add(row);
                    }
                    return serializer.Serialize(rows);
                }
                else
                {
                    return "no image";
                }
            }

        }

        [OperationContract]
        [Description("Returns members PhotoURL by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "PhotoURLById({secToken},{ProfileID})")]
        public string GetPhotoURLById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);
            string ImageUrl = "NoImage";

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPhoto.viewPhoto_Profile_By_Profile_ID(Convert.ToInt32(ProfileID));
                if (dt.Rows.Count > 0)
                {
                    Byte[] bytes = (Byte[])dt.Rows[0]["blobdata"];
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    ImageUrl = "data:image/png;base64," + base64String;
                }
            }


            return ImageUrl;
        }


        [OperationContract]
        [Description("Add Member Photo by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addPhotoz(string secToken, int ProfileID, string fName, string base64String)
        {

            //objPhoto.Profile_ID = ProfileID;
            //objPhoto.filename = fName;
            //objPhoto.base64blobdata = base64String;
            //objPhoto.base64thumbdata = base64String;
            //objPhoto.Photo_Date = DateTime.Now.ToString();
            //objPhoto.addPhoto2a();

            //string base64String = "data:image/png;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/4QBaRXhpZgAATU0AKgAAAAgABQMBAAUAAAABAAAASgMDAAEAAAABAAAAAFEQAAEAAAABAQAAAFERAAQAAAABAAAOw1ESAAQAAAABAAAOwwAAAAAAAYagAACxj//bAEMAAgEBAgEBAgICAgICAgIDBQMDAwMDBgQEAwUHBgcHBwYHBwgJCwkICAoIBwcKDQoKCwwMDAwHCQ4PDQwOCwwMDP/bAEMBAgICAwMDBgMDBgwIBwgMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDP/AABEIAHkAewMBIgACEQEDEQH/xAAfAAABBQEBAQEBAQAAAAAAAAAAAQIDBAUGBwgJCgv/xAC1EAACAQMDAgQDBQUEBAAAAX0BAgMABBEFEiExQQYTUWEHInEUMoGRoQgjQrHBFVLR8CQzYnKCCQoWFxgZGiUmJygpKjQ1Njc4OTpDREVGR0hJSlNUVVZXWFlaY2RlZmdoaWpzdHV2d3h5eoOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4eLj5OXm5+jp6vHy8/T19vf4+fr/xAAfAQADAQEBAQEBAQEBAAAAAAAAAQIDBAUGBwgJCgv/xAC1EQACAQIEBAMEBwUEBAABAncAAQIDEQQFITEGEkFRB2FxEyIygQgUQpGhscEJIzNS8BVictEKFiQ04SXxFxgZGiYnKCkqNTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqCg4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1tre4ubrCw8TFxsfIycrS09TV1tfY2dri4+Tl5ufo6ery8/T19vf4+fr/2gAMAwEAAhEDEQA/AP36jA8teB0p2B6Ckj/1a/SloAMD0FGB6CiigAwPQUYHoKK8d/aW/bk8CfswQtBrF8b7WiuU0yzw859C/ZB9fyoA9iwPQUYHoK/Mr4o/8Fl/HPiK5kj8MaRpWgWmSEaZTczEe+cAH6V5jqX/AAUv+M2okkeLprfP/PG3jXH6GgD9g8D0FGB6Cvxmj/4KB/GRLxZ/+E+1lnUY5EeCPptxX0d+y1/wWDurCRNL+JtubqA8R6rZxYkT/ronf6igD9C8D0FGB6CuK+F37Rngf40Qo3hnxPpOqSOMiBJgs4/7Zthv0rtaADA9BRgegoooAMD0FUrn/XtV2qdz/r2oAtx/6tfpS0kf+rX6UtABRRVHxR4ht/CPhnUdVvG2WmmWst3O391I0LsfyBoA8k/bv/aVH7NPwE1LU7O5t08QXoFrpkbsN/mNwZAvcIMn8K/HjX/EF74q1m51HUrqe9vryQyzTzOWeRickkmuu/aJ+P8Arn7R/wATr/xFrVxK4nkYWlsWJjsoc/LGo6cDGT3PNcLQAUUUUAFFFFAFjTNVudFvY7mzuJ7W4iYMkkTlHUjoQRzX6r/8EvP2pNT/AGhfg9d6f4guTea74ZlWB7hzmS6hYZR29WGCCe/FflBX0V/wTJ+Py/BH9pKyt7uXy9J8TqNOuSThVcn923/fXH40AfrlRQDkZHINFABVO5/17Vcqnc/69qALcf8Aq1+lLSR/6tfpS0AFcR+01ps2sfs3/EG0t8me68N6jFGB1LNayAfqa7eo7y1S9tJYZVV45kKOpGQwIwQaAPwHord+KHhBvh/8SvEOgtnOi6lcWPPU+XKyZ/SsKgAooooAKKKKACn21xJZ3Ec0TtHLEwdHU4KkHII980ygDJwOSaAP3H/Zv8bS/Ej4B+D9dn/1+q6RbXEn+80YJ/Wu1ri/2c/CZ8CfAXwfo7Da2naRbQMPcRqK7SgAqnc/69quVTuf9e1AFuP/AFa/SlpI/wDVr9KWgAoor5q/4Kb/ALTHij9mn4VaDe+FLiCz1DVNT8iSaSES7Y1jZioB45OOfQGgD8+v+CgOhr4e/bJ8fWygANqAn49ZYkkP6vXjtdF8V/ijq/xo+IGo+Jtemin1bVCjXEkcYjVikaxjCjgfKgrnaACiiigAooooAK1fAunnVvG+jWoXebm+giC/3t0ijH61lU6KVoZFdGZHQhlZTgqR3FAH746LF9n0i0j6eXCi49MKBVmvjH/gizaat/wpPxReXk1zJptzq4WzSRyVDLGvmsufUsoPupr7OoAKp3P+varlU7n/AF7UAW4/9Wv0paSP/Vr9KWgArwb/AIKO/AC4/aB/Zj1S002Fp9a0KRdWsY1GWmaMMHjHqWjZ8DuwWveaCMigD8AyMHB4Ior7k/4KIf8ABN3VrHxleeNPh9pUl/puqO0+oaZarmS0mJy0kajqjHkgfdOe3T4furWSyuZIZkeKWJijowwykcEEetAEdFFFABRRRQAU6GF7iZI41Z3kIVVAyWJ6AUiqXYAAkk4AHevtD/gnt/wTn1/xH8QNN8X+N9Km0vQdLZLu0tbpdsl/IOUO3qEHDZPXAoA+5v2TvhJD8EP2e/C/h2JFWS1skkuSP45n+eRvxZjXotAAUAAYAooAKp3P+varlU7n/XtQBbj/ANWv0paSP/Vr9KWgAooooAK/KT/gq18AIvhB+0KdYsIRFpfi2M3qqowsc4OJV/PDf8Cr9W6+Jv8Agtpp1vN8JfB104X7TBqcscZ77WjBb/0FaAPzcooooAKKKKAPVv2IPh7B8UP2rPBOj3SLLayagtxNGwyJEiBlZT7EIRX7TABQAAAB0FfkF/wS/wBRtNM/bb8HSXciRI/2uKMscAyPayqg+pJAHuRX6+0AFFFFABVO5/17Vcqnc/69qALcf+rX6UtRSXMdna+ZNIkUaLlmdgoH4mvCfjX/AMFJ/hT8FWlt5dcOv6nFkGy0dBcuCOzPkRqfUFs+1AHvdIzBVJJAA5JPavza+K//AAWo8W65JJD4P8N6VoFuchbi+c3twfcAbUU+xDfWvnL4pftffEr4yh08QeMNYu7eT71tHL5Fv/37j2r+lAH6k/tCft8/Dr9nuxmS81mDVtXVT5enae4mlLejEfKnPqc+1fmR+1j+2F4l/ay8WJd6sy2mlWTN9g06I/u7cHqSf4mIAya8lkkaVyzsWZuSSck0lABRRRQAUUUUAWdG1i68PatbX9lPLa3lnKs0M0bbXjdTkMD2INfp9+xN/wAFMvD/AMW/DlpofjbULXRfFUCiL7RcMI7fUMcBgx4Vz3Bx7V+XFAODkcEUAfvzb3Md3AksUiSxSDcrowZWHqCOtPr8Pfhr+0z4/wDhA6f8I54t1zTIkO7yI7lmgY+8bZU/iK+pfgd/wWh8Q6JLBaePtBtdbtchXv8ATsW10o7sYz+7c+w2UAfo7VO5/wBe1cd8EP2mvBP7RGjC88K67a37AAy2rHy7m3Po8Z+YfXoexNdjc/69qAPyC/bF/aw8efFT4n+JNF1PX7pNF0zU7myhsbZjDAY45WRdwH3jgDO7NeGV1vx8/wCS6eNP+w9ff+lElclQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQBoeFvFep+CNdt9T0e/u9N1C1bdFcW0pjkQ/Udvboa/Yj9iX4k6v8Xv2W/CPiLXrkXmr6hBN9on2BfNKXEsYJA4ztQZ96/Gev16/4Js/8mS+Bf+uN1/6WT0Af/9k=";
            //BinaryReader b = new BinaryReader(file.InputStream);
             
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                string newbase64String = base64String.Replace("data:image/png;base64,", "");
                byte[] byte_original = Convert.FromBase64String(newbase64String);

                csCreateThumb objCreateThumb = new csCreateThumb();
                byte[] byte_thumb = objCreateThumb.CreateThumbnail(byte_original, 100, 50, 50);

                csPhoto objPhoto = new csPhoto();
                objPhoto.Profile_ID = ProfileID;
                objPhoto.filename = fName;
                objPhoto.blobdata = byte_original;
                objPhoto.thumbdata = byte_thumb;
                objPhoto.Photo_Date = DateTime.Now.ToString();
                objPhoto.addPhoto2();
            }

        }

        [OperationContract]
        [Description("remove Member Photo by Photo ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "removePhoto({secToken},{PhotoID})")]
        public void removePhoto(string secToken, string PhotoID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int photoID = Convert.ToInt32(PhotoID);

                objPhoto.Photo_ID = photoID;
                objPhoto.Delete_Photo();
            }
        }

        [OperationContract]
        [Description("set As Profile Photo by Photo ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "setAsProfilePhoto({secToken},{PhotoID},{ProfileID})")]
        public void SetAsProfilePhoto(string secToken, string PhotoID, string ProfileID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int photoID = Convert.ToInt32(PhotoID);
                int profileID = Convert.ToInt32(ProfileID);

                objPhoto.Photo_ID = photoID;
                objPhoto.Profile_ID = profileID;
                objPhoto.setAsProfilePhoto();
            }
        }

        #endregion

        #region UserAccounts

        #region User

        [OperationContract]
        [Description("User Authentication")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
            //UriTemplate = "UserAuthentication({secToken},{clientID},{userName},{password})")]
        public string UserAuthentication(string secToken, string churchCode, string userName, string password)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {
                
            }
            else
            {
                dt = objUser.viewUserAuthentication(churchCode, userName, password);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("User Authentication Member")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        //UriTemplate = "UserAuthentication({secToken},{clientID},{userName},{password})")]
        public string UserAuthenticationMember(string secToken, string userName, string password)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.viewUserAuthenticationMember(userName, password);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("User Authentication Member")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        //UriTemplate = "UserAuthentication({secToken},{clientID},{userName},{password})")]
        public string UserMemberByUsername(string secToken, string userName)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.viewUserMemberByUsername(userName);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        [OperationContract]
        [Description("User member Profile by UserName")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getUserName({secToken}/{UserName}/{Password})")]
        public bool getUserName(string secToken, string UserName, string Password)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                //dt = objUser.viewUserByUser_Name_and_Password(1, UserName, Password);
            }
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            //Dictionary<string, object> row;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    row = new Dictionary<string, object>();
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        row.Add(col.ColumnName, dr[col]);
            //    }
            //    rows.Add(row);
            //}
            //return serializer.Serialize(rows);

        }
        #endregion

        #region UserAccount

        [OperationContract]
        [Description("Returns Users by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string userAccountCrude(string secToken, string crude, Int32 userID, Int32 clientID, Int32 profileID, string userEmail, Int32 userTypeID, string userStatus, string userPassword)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.userAccountCrude(crude, userID, clientID, profileID, userEmail, userTypeID, userStatus, userPassword);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Member User Account")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string userAccountCreateMember(string secToken, string membershipNumber, string fullName, string mobile, string userName, string userPassword)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.userAccountMemberCreate(membershipNumber, fullName, mobile, userName, userPassword);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns UserTypes")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "UserTypes({secToken})")]
        public string GetUserAccountTypes(string secToken)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {

                dt = objUser.viewAllUser_Types();
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns Users Show Hide ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string updateUserAccountShowHideIDNumber(string secToken, Int32 userID, Int32 showHideID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.updateUuserAccountShowHideIDNumber(userID, showHideID);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Users Void Finance")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string updateUserAccountVoidFinance(string secToken, Int32 userID, Int32 voidFinance)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.updateUuserAccountVoidFinance(userID, voidFinance);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        #endregion

        #region UserAccess

        [OperationContract]
        [Description("Returns Users by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string userAccessCrude(string secToken, string crude, Int32 clientID, Int32 accessID, Int32 userID, Int32 pageID, string userAccess)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.userAccessCrude(crude, clientID, accessID, userID, pageID, userAccess);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Users by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string userAccessSubCrude(string secToken, string crude, Int32 accessSubID, Int32 userID, Int32 pageID, Int32 pageSubID, string userAccess)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.userAccessSubCrude(crude, accessSubID, userID, pageID, pageSubID, userAccess);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }



        [OperationContract]
        [Description("ShopperUserAccess")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string ShopperUserAccess(string secToken, string username, string password)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewShopperUserAccess(username, password);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns UserAccessByUserID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "UserAccessByUserID({secToken},{userID})")]
        public string GetUserAccessByUserID2(string secToken, string userID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.viewUserAccess_By_User_ID2(Convert.ToInt32(userID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns UserAccessByUserIDandPageID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "UserAccessByUserIDandPageID({secToken},{userID},{pageID})")]
        public string GetUserAccessByUserIDandPageID(string secToken, string userID, string pageID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.viewUserAccess_By_User_IDandPage_ID(Convert.ToInt32(userID), Convert.ToInt32(pageID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        #endregion

        #region ChangePassword

        [OperationContract]
        [Description("ChangeUserPassword")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void ChangeUserPassword(string secToken, Int32 Profile_ID, string Pasword)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objUser.Profile_ID = Profile_ID;
                objUser.Pasword = Pasword;
                objUser.UpdatePassword_ByProfileID();
            }

        }


        [OperationContract]
        [Description("Returns UserAccountByProfileID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "UserAccountByProfileID({secToken},{profileID})")]
        public string GetUserAccountByProfileID(string secToken, string profileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objUser.viewUserByProfile_ID(Convert.ToInt32(profileID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        #endregion

        #endregion

        #region Messages

        csMessages objMessages = new csMessages();

        [OperationContract]
        [Description("Returns members Messages by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "MessagesByProfileId({secToken},{ProfileID})")]
        public string GetMessagesByProfileId(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objMessages.viewMessages_Inbox_Distinct_By_Profile_ID(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns members Messages by Group ID and Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "MessagesByGroupIdandProfileId({secToken},{GroupID},{ProfileID})")]
        public string GetMessagesByGroupIdandProfileId2a(string secToken, string GroupID, string ProfileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objMessages.viewMessages_Inbox_By_Group_ID_and_Profile_ID(Convert.ToInt32(GroupID), Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }



        [OperationContract]
        [Description("Add Message by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addMessage(string secToken, int Client_ID, int Group_ID, int From_Profile_ID, string MessageContent, string Message_Date, string Message_Number)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objMessages.Client_ID = Client_ID;
                objMessages.Group_ID = Group_ID;
                objMessages.From_Profile_ID = From_Profile_ID;
                objMessages.MessageContent = MessageContent;
                objMessages.Message_Date1 = Message_Date;
                objMessages.Message_Number = Message_Number;
                objMessages.addNew_Message();
            }
        }

        #endregion

        #region Finance

        [OperationContract]
        [Description("Returns Finacial by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string financialCrude(string secToken, string crude, Int32 financialID, Int32 profileID, Int32 clientID, string financialDate, string financialAmount, Int32 moneyInItemID, string financialFor, string description, string collectionMethod, string confirmed, string confirmDate, string dateFrom, string dateTo)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.financialCrude(crude, financialID, profileID, clientID, financialDate, financialAmount, moneyInItemID, financialFor, description, collectionMethod, confirmed, confirmDate, dateFrom, dateTo);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns Finacial by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string financialCrude2(string secToken, string crude, Int32 financialID, Int32 profileID, Int32 clientID, string financialDate, string financialAmount, Int32 moneyInItemID, string financialFor, string description, string collectionMethod, string confirmed, string confirmDate, string dateFrom, string dateTo, Int32 moneyInSpecialGroupID, string personOrGroup)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.financialCrude2(crude, financialID, profileID, clientID, financialDate, financialAmount, moneyInItemID, financialFor, description, collectionMethod, confirmed, confirmDate, dateFrom, dateTo, moneyInSpecialGroupID, personOrGroup);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns members Family by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string financeItemsCrude(string secToken, string crude, Int32 clientID, int moneyInItemID, string itemName, string SMSMessage, string AppMessage)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.financeItemsCrude(crude, clientID, moneyInItemID, itemName, SMSMessage, AppMessage);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns SpecialGroup by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string financeSpecialGroupCrude(string secToken, string crude, Int32 clientID, int moneyInSpecialGroupID, string itemName, string SMSMessage, string AppMessage)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.financeSpecialGroupCrude(crude, clientID, moneyInSpecialGroupID, itemName, SMSMessage, AppMessage);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns FinanceItems by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "FinacialItemsById({secToken},{ClientID})")]
        public string GetFinaceItemsById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewMoneyIn_Item_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add FinaceItems by client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addFinaceItems(string secToken, int ClientID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Client_ID = ClientID;
                objFinace.add_MoneyIn_Items_Pre();
            }

        }

        [OperationContract]
        [Description("Update FinaceItems by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateFinaceItems(string secToken, int itemId, string Item, string Item_SMS, string App_Message)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.MoneyInItem_ID = itemId;
                objFinace.Item = Item;
                objFinace.Item_SMS = Item_SMS;
                objFinace.App_Message = App_Message;
                objFinace.update_MoneyIn_Items2();
            }

        }


        [OperationContract]
        [Description("Remove FinaceItems by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeFinaceItems(string secToken, int itemId)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.MoneyInItem_ID = itemId;
                objFinace.remove_MoneyIn_Item();
            }

        }


        #region FinanceCollection


        //------------------Finance Collection--------------------------------------

        [OperationContract]
        [Description("Returns Financial Collection by Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "FinancialCollectionById/{secToken}/{ClientID}/{Date_From}/{Date_To}")]
        public string GetFinancialCollectionById(string secToken, string ClientID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_By_Client_ID1(Convert.ToInt32(ClientID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add Finacial Collection by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addFinacialCollection(string secToken, int ProfileID, string Financial_Date, string Financial_Amount, string Financial_For, string Financial_Description, string Payment_Type, string Confirmed, string Confirm_Date)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Profile_ID = ProfileID;
                objFinace.Financial_Date = Financial_Date;
                objFinace.Financial_Amount = Financial_Amount;
                objFinace.Financial_For = Financial_For;
                objFinace.Financial_Description = Financial_Description;
                objFinace.Payment_Type = Payment_Type;
                objFinace.Confirmed = Confirmed;
                objFinace.Confirm_Date = Confirm_Date;
                objFinace.add_Financials();
            }

        }

        [OperationContract]
        [Description("Void Finacials by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void voidFinacial(string secToken, int Finacial_ID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Financial_ID = Finacial_ID;
                objFinace.update_FinancialsVoid();
            }

        }
        #endregion

        #region Statements

        [OperationContract]
        [Description("Returns Statements by Profile Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "StatementsById({secToken},{ProfileID},{Date_From},{Date_To})")]
        public string GetStatementsById(string secToken, string ProfileID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_Statements_By_Profile_ID(Convert.ToInt32(ProfileID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Statements Totals by Profile Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "StatementsTotalsById({secToken},{ProfileID},{Date_From},{Date_To})")]
        public string GetStatementsTotalsById(string secToken, string ProfileID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_Statements_Totals_By_Profile_ID(Convert.ToInt32(ProfileID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Statements Totals by Profile Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "StatementsGroupTotalsById({secToken},{specialGroupID},{Date_From},{Date_To})")]
        public string GetStatementsGroupTotalsById(string secToken, string specialGroupID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_Statements_Totals_By_SpecialGroup_ID(Convert.ToInt32(specialGroupID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        #endregion

        #region CollectionHistory

        [OperationContract]
        [Description("Returns CollectionHistory by Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CollectionHistoryById({secToken},{ClientID},{Date_From},{Date_To})")]
        public string GetCollectionHistoryById(string secToken, string ClientID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_CollectionHistory_By_Client_ID(Convert.ToInt32(ClientID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns CollectionHistory and FinanceItem by Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CollectionHistoryByIdandFinanceItem({secToken},{ClientID},{Date_From},{Date_To},{FinanceItem})")]
        public string GetCollectionHistoryByIdandFinanceItem(string secToken, string ClientID, string Date_From, string Date_To, string FinanceItem)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_CollectionHistory_By_Client_ID_and_FinanceItem(Convert.ToInt32(ClientID), Date_From, Date_To, FinanceItem);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns CollectionHistory Totals by Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CollectionHistoryTotalsById({secToken},{ClientID},{Date_From},{Date_To})")]
        public string GetCollectionHistoryTotalsById(string secToken, string ClientID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();

            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_CollectionHistory_Totals_By_Client_ID(Convert.ToInt32(ClientID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns CollectionHistory Totals by ClientID, FinanceItemID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CollectionHistoryTotalsByFinanceItemId({secToken},{ClientID},{FinanceItemID},{Date_From},{Date_To})")]
        public string GetCollectionHistoryTotalsByFinanceItemId(string secToken, string ClientID, string FinanceItemID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();

            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_CollectionHistory_Totals_By_Client_ID_and_FinanceItem_ID(Convert.ToInt32(ClientID), Convert.ToInt32(FinanceItemID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        #endregion

        #region Counting

        [OperationContract]
        [Description("Returns Counting by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CountingById({secToken},{ClientID},{ServiceDate},{ServiceName})")]
        public string GetCountingById(string secToken, string ClientID, string ServiceDate, string ServiceName)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_Counting_By_Client_ID(Convert.ToInt32(ClientID), ServiceDate, ServiceName);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Counting GrandTotal by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CountingGrandTotalById({secToken},{ClientID},{ServiceDate},{ServiceName})")]
        public string GetCountingGrandTotalById(string secToken, string ClientID, string ServiceDate, string ServiceName)
        {
            DataTable dt = new DataTable();

                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_Counting_GrandTotal_By_Client_ID(Convert.ToInt32(ClientID), ServiceDate, ServiceName);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add FinanceCounting by client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addFinanceCounting(string secToken, int ClientID, string ServiceDate, string ServiceName, string ItemName, int ItemTotal, int ItemValue1, int ItemValue2, int ItemValue3, int ItemValue4, int ItemValue5, int ItemValue6, int ItemValue7, int ItemValue8)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Client_ID = ClientID;
                objFinace.ServiceDate = ServiceDate;
                objFinace.ServiceName = ServiceName;
                objFinace.ItemName = ItemName;
                objFinace.ItemTotal = ItemTotal;
                objFinace.ItemValue1 = ItemValue1;
                objFinace.ItemValue2 = ItemValue2;
                objFinace.ItemValue3 = ItemValue3;
                objFinace.ItemValue4 = ItemValue4;
                objFinace.ItemValue5 = ItemValue5;
                objFinace.ItemValue6 = ItemValue6;
                objFinace.ItemValue7 = ItemValue7;
                objFinace.ItemValue8 = ItemValue8;
                objFinace.add_Financials_Counting();
            }

        }


        [OperationContract]
        [Description("Remove FinanceCounting by Counting ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeFinanceCounting(string secToken, int CountingId)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Counting_ID = CountingId;
                objFinace.remove_Financials_Counting();
            }

        }


        #endregion

        #region FinanceExpenses

        [OperationContract]
        [Description("Returns Expenses by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string ExpenseItemCrude(string secToken, string crude, int clientID, int expenseItemID, string item)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewExpenseItemCrude(crude, clientID, expenseItemID, item);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns ExpenseItems by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ExpenseItemsById({secToken},{ClientID})")]
        public string GetExpenseItemsById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewExpenses_Item_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add ExpenseItems by client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addExpenseItems(string secToken, int ClientID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Client_ID = ClientID;
                objFinace.Expense_Items = "";
                objFinace.add_Expense_Items();
            }

        }

        [OperationContract]
        [Description("Update ExpenseItems by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateExpenseItems(string secToken, int itemId, string Item)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.ExpenseItem_ID = itemId;
                objFinace.Expense_Items = Item;
                objFinace.update_Expense_Items();
            }

        }


        [OperationContract]
        [Description("Remove ExpenseItems by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeExpenseItems(string secToken, int itemId)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.ExpenseItem_ID = itemId;
                objFinace.remove_Expense_Items();
            }

        }

        //-------------Expenses------------------------------

        [OperationContract]
        [Description("Returns Expenses by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string ExpensesCrude(string secToken, string crude, int clientID, int expenseID, int expenseItemID, string expenseDate, string expenseAmount, string expenseDescription, int serviceProviderID, string paymentDate, string paymentMethod, int costAreaItemID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewExpensesCrude(crude, clientID, expenseID, expenseItemID, expenseDate, expenseAmount, expenseDescription, serviceProviderID, paymentDate, paymentMethod, costAreaItemID);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns Expenses by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ExpensesById({secToken},{ClientID},{Date_From},{Date_To})")]
        public string GetExpensesById(string secToken, string ClientID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewExpenses_By_Client_ID2(Convert.ToInt32(ClientID), Date_From, Date_To);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add Expenses by client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addExpenses(string secToken, int ClientID, int ExpenseItem_ID, string Expense_Date, string Expense_Amount, string Expense_Description)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Client_ID = ClientID;
                objFinace.ExpenseItem_ID = ExpenseItem_ID;
                objFinace.Expense_Date = Expense_Date;
                objFinace.Expense_Amount = Expense_Amount;
                objFinace.Expense_Description = Expense_Description;
                objFinace.add_Expenses2();
            }

        }

        [OperationContract]
        [Description("Update Expenses by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateExpenses(string secToken, int Expense_ID, string Expense_Date, string Expense_Amount, string Expense_Description)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Expense_ID = Expense_ID;
                objFinace.Expense_Date = Expense_Date;
                objFinace.Expense_Amount = Expense_Amount;
                objFinace.Expense_Description = Expense_Description;
                objFinace.update_Expenses2();
            }
        }


        [OperationContract]
        [Description("Remove Expense by Expense ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeExpenses(string secToken, int Expense_ID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objFinace.Expense_ID = Expense_ID;
                objFinace.remove_Expenses2();
            }

        }

        [OperationContract]
        [Description("Returns ExpenseHistory Totals by Client ID and Period")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ExpenseHistoryTotalsById({secToken},{ClientID},{Date_From},{Date_To})")]
        public string GetExpenseHistoryTotalsById(string secToken, string ClientID, string Date_From, string Date_To)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFinace.viewFinancials_ExpenseHistory_Totals_By_Client_ID(Convert.ToInt32(ClientID), Date_From, Date_To);
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        #endregion

        #endregion
 
        #region Communication

        #region SMS

        [OperationContract]
        [Description("Returns SMS Out Bos by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string smsOutBoxCrude(string secToken, string crude, Int32 clientID, Int32 messageID, Int32 sentByProfileID, string sentToMobile, string message, string recipientCount)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.smsOutBoxCrude(crude, clientID, messageID, sentByProfileID, sentToMobile, message, recipientCount);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns ClientSMS by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "SMSInBoxByClientID({secToken},{ClientID})")]
        public string GetSMSInBoxByClientID(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewSMS_Line_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns ClientSMS by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "AddClientSMSById({secToken},{ClientID})")]
        public string AddClientSMSById2(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewClient_SMS_Accounts_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns ClientSMS by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientSMSById({secToken},{ClientID})")]
        public string GetClientSMSById2(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewClient_SMS_Accounts_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        public static string Mid(string s, int a, int b)
        {
            string temp = s.Substring(a - 1, b);
            return temp;
        }

        [OperationContract]
        [Description("Returns sendSMS by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public String sendSMS2(string secToken, string ClientID, string TxNumber, string TxMessage)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewClient_SMS_Accounts_By_Client_ID(Convert.ToInt32(ClientID));
            }

            string url;

            string TxUserName = dt.Rows[0]["SMSUsername"].ToString();
            string TxPassword = dt.Rows[0]["SMSPassword"].ToString();
            string TxApi = dt.Rows[0]["SMSAPI"].ToString();

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
                    case "[": c = "";
                        break;
                    case "]": c = "";
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
                //objRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
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



        [OperationContract]
        [Description("Returns sendSMS by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "sendSMS({secToken},{ClientID},{TxNumber},{TxMessage})")]
        public String readHtmlPage(string secToken, string ClientID, string TxNumber, string TxMessage)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewClient_SMS_Accounts_By_Client_ID(Convert.ToInt32(ClientID));
            }

            string url;

            string TxUserName = dt.Rows[0]["SMSUsername"].ToString();
            string TxPassword = dt.Rows[0]["SMSPassword"].ToString();
            string TxApi = dt.Rows[0]["SMSAPI"].ToString();

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
                    case " crlf ": c = "%0A";
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

            //http://api.clickatell.com/http/sendmsg?user=BIS247&password=4wBbv8ry&api_id=3393003&to=27837534922&text=Hi

            url = "http://api.clickatell.com/http/sendmsg?user=";
            url = url + TxUserName + "&password=" + TxPassword + "&api_id=" + TxApi + "&to=" + TxNumber + "&text=" + useMsg;

            WebResponse objResponse;
            WebRequest objRequest;
            string result;

            //try
            //{
                //objRequest.ContentType.ToString("application/X-www-form-urlencoded; charset='utf-8'");
                objRequest = System.Net.HttpWebRequest.Create(url);
                objResponse = objRequest.GetResponse();

                StreamReader sr = new StreamReader(objResponse.GetResponseStream());
                result = sr.ReadToEnd();
                sr.Close();
                return result;
            //}
            //catch (Exception ex)
            //{
            //    string s = ex.ToString();
            //    if (s.Contains("(404)"))
            //    {
            //        return "URL: " + url + " not found.";
            //    }
            //    else
            //    {
            //        return s;
            //    }
            //}

        }


        [OperationContract]
        [Description("Returns SMSBalance by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "SMSBalance({secToken},{ClientID})")]
        public string GetSMSBalance(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewClient_SMS_Accounts_By_Client_ID(Convert.ToInt32(ClientID));
            }

            string url;

            string TxUserName = dt.Rows[0]["SMSUsername"].ToString();
            string TxPassword = dt.Rows[0]["SMSPassword"].ToString();
            string TxApi = dt.Rows[0]["SMSAPI"].ToString();

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
                string bal = "";
                bal = result.Replace("Credit:", "");
                return bal;
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
                    string bal = "";
                    bal = s.Replace("Credit:", "");
                    return bal;
                }
            }

        }

        #endregion

        #region Email
        [OperationContract]
        [Description("Add sendEmail")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void SendEmail2(string secToken, string strTo, string strSubject, string strMessage)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objUser.Emailz("support@amen247.co.za",strTo, strSubject, strMessage);
            }


        }


        [OperationContract]
        [Description("Add sendEmail")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void SendEmail(string secToken, string strFrom, string strTo, string strSubject, string strMessage)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                //objPost.SendEmail2(strFrom, strTo, strSubject, strMessage);
            }


        }
        #endregion

        #region Filters

        [OperationContract]
        [Description("Returns CommunicationFilter1")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CommunicationFilter1({secToken})")]
        public string GetCommunicationFilter1(string secToken)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.ViewCommunication_Filter1();
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns CommunicationFilter2")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CommunicationFilter2({secToken},{parentID})")]
        public string GetCommunicationFilter2(string secToken, string parentID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewCommunication_Filter2_By_Filter1(Convert.ToInt32(parentID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns CommunicationFilter3")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CommunicationFilter3({secToken},{parentID})")]
        public string GetCommunicationFilter3(string secToken, string parentID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewCommunication_Filter3_By_Filter2(Convert.ToInt32(parentID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns CommunicationFilterResults")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CommunicationFilterResults({secToken},{clientID},{cfId},{specificID})")]
        public string GetCommunicationFilterResults(string secToken, string clientID, string cfId, string specificID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.viewCommunication_Result(Convert.ToInt32(clientID), Convert.ToInt32(cfId), Convert.ToInt32(specificID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        #endregion

        #region AppMobile

        [OperationContract]
        [Description("Returns App User and Device")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string appUserDeviceCrude(string secToken, string crude, Int32 User_ID, Int32 Client_ID, string Name, string Surname, string Mobile, string Email, string ChurchName, Int32 Profile_ID, string MembershipNumber, string Password, string token, string uuid, string manufacture, string model, string os, string osVersion, string language)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.appUserDeviceCrude(crude, User_ID, Client_ID, Name, Surname, Mobile, Email, ChurchName, Profile_ID, MembershipNumber, Password, token, uuid, manufacture, model, os, osVersion, language);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion


        #endregion

        #region Birthdays
        [OperationContract]
        [Description("Returns BirthDays by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string birthDaysCrude(string secToken, string crude, string category, Int32 clientID, Int32 birthdayID, Int32 weddingID, string sendTime, string message, string active)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objComm.birthDaysCrude(crude, category, clientID, birthdayID, weddingID, sendTime, message, active);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns sendSMS by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void scheduleSMS()
        {
            Int32 Client_ID;
            DataTable dt = new DataTable();

                dt = objClient.ViewAllClients();

                Int32 Tot_Count = 0;

                Tot_Count = dt.Rows.Count;

                for (Int32 r = 0; r <= Tot_Count; r++)
                {

                    try
                    {

                        #region Birthddays
                        Client_ID = Convert.ToInt32(dt.Rows[r]["ID"].ToString());
                        dt = objComm.viewClient_Auto_Birthdays_By_Client_ID(Client_ID);


                        string SendTime = dt.Rows[0]["SendTime"].ToString();
                        string SMS_Message = dt.Rows[0]["SMSMessage"].ToString();
                        string Active = dt.Rows[0]["Active"].ToString();

                        string LastSendDate = "";
                        try
                        {
                            LastSendDate = Convert.ToDateTime(dt.Rows[0]["LastSendDate"]).ToString("yyyy/MM/dd");
                        }
                        catch
                        {
                            LastSendDate = "";
                        }
                        DateTime TNow = DateTime.Now;
                        DateTime T1_6am = Convert.ToDateTime("06:00:00");
                        DateTime T2_6am = Convert.ToDateTime("06:59:00");

                        DateTime T1_7am = Convert.ToDateTime("07:00:00");
                        DateTime T2_7am = Convert.ToDateTime("07:59:00");

                        DateTime T1_8am = Convert.ToDateTime("08:00:00");
                        DateTime T2_8am = Convert.ToDateTime("08:59:00");


                        string WhatT = "";
                        if (TNow >= T1_6am && TNow <= T2_6am)
                        {
                            WhatT = "Is 6am";
                        }

                        if (TNow >= T1_7am && TNow <= T2_7am)
                        {
                            WhatT = "Is 7am";
                        }

                        if (TNow >= T1_8am && TNow <= T2_8am)
                        {
                            WhatT = "Is 8am";
                        }

                        if (Active == "Yes")
                        {

                            if (SendTime == "opt1" && WhatT == "Is 6am" && LastSendDate != DateTime.Now.ToString("yyyy/MM/dd"))
                            {
                                Auto_Send(Client_ID, SMS_Message);
                            }

                            if (SendTime == "opt2" && WhatT == "Is 7am" && LastSendDate != DateTime.Now.ToString("yyyy/MM/dd"))
                            {
                                Auto_Send(Client_ID, SMS_Message);
                            }

                            if (SendTime == "opt3" && WhatT == "Is 8am" && LastSendDate != DateTime.Now.ToString("yyyy/MM/dd"))
                            {
                                Auto_Send(Client_ID, SMS_Message);
                            }
                        }
                        #endregion

                        #region Weddings
                        DataTable dt2 = new DataTable();
                        dt2 = objComm.viewClient_Auto_Wedding_By_Client_ID(Client_ID);


                        string SendTime_Wedding = dt2.Rows[0]["SendTime"].ToString();
                        string SMS_Message_Wedding = dt2.Rows[0]["SMSMessage"].ToString();
                        string Active_Wedding = dt2.Rows[0]["Active"].ToString();

                        string LastSendDate_Wedding = "";
                        try
                        {
                            LastSendDate_Wedding = Convert.ToDateTime(dt2.Rows[0]["LastSendDate"]).ToString("yyyy/MM/dd");
                        }
                        catch
                        {
                            LastSendDate_Wedding = "";
                        }
                        DateTime TNow_Wedding = DateTime.Now;
                        DateTime T1_6am_Wedding = Convert.ToDateTime("06:00:00");
                        DateTime T2_6am_Wedding = Convert.ToDateTime("06:59:00");

                        DateTime T1_7am_Wedding = Convert.ToDateTime("07:00:00");
                        DateTime T2_7am_Wedding = Convert.ToDateTime("07:59:00");

                        DateTime T1_8am_Wedding = Convert.ToDateTime("08:00:00");
                        DateTime T2_8am_Wedding = Convert.ToDateTime("08:59:00");

                        string WhatT_Wedding = "";
                        if (TNow_Wedding >= T1_6am_Wedding && TNow_Wedding <= T2_6am_Wedding)
                        {
                            WhatT_Wedding = "Is 6am";
                        }

                        if (TNow_Wedding >= T1_7am_Wedding && TNow_Wedding <= T2_7am_Wedding)
                        {
                            WhatT_Wedding = "Is 7am";
                        }

                        if (TNow_Wedding >= T1_8am_Wedding && TNow_Wedding <= T2_8am_Wedding)
                        {
                            WhatT_Wedding = "Is 8am";
                        }

                        if (Active_Wedding == "Yes")
                        {
                            if (SendTime_Wedding == "opt1" && WhatT_Wedding == "Is 6am" && LastSendDate_Wedding != DateTime.Now.ToString("yyyy/MM/dd"))
                            {
                                Auto_Send_Wedding(Client_ID, SMS_Message_Wedding);
                            }

                            if (SendTime_Wedding == "opt2" && WhatT_Wedding == "Is 7am" && LastSendDate_Wedding != DateTime.Now.ToString("yyyy/MM/dd"))
                            {

                                Auto_Send_Wedding(Client_ID, SMS_Message_Wedding);

                            }

                            if (SendTime_Wedding == "opt3" && WhatT_Wedding == "Is 8am" && LastSendDate_Wedding != DateTime.Now.ToString("yyyy/MM/dd"))
                            {

                                Auto_Send_Wedding(Client_ID, SMS_Message_Wedding);

                            }
                        }
                        #endregion

                    }
                    catch { }
                }


        }


        #region Birthdays Auto Send




        public void Auto_Send(Int32 Client_ID, string SMS_Message)
        {

            DataTable dt = new DataTable();
            dt = objComm.viewClient_SMS_Accounts_By_Client_ID(Client_ID);

            string SMSUsername = dt.Rows[0]["SMSUsername"].ToString();
            string SMSClientID = dt.Rows[0]["SMSClientID"].ToString();
            string SMSPassword = dt.Rows[0]["SMSPassword"].ToString();
            string API = dt.Rows[0]["SMSAPI"].ToString();


            if (SMS_Message != String.Empty)
            {
                try
                {

                    string SMS_Credit;
                    SMS_Credit = objUser.GetSMSBalance(SMSUsername, SMSPassword, API);

                    if (SMS_Credit != "Credit: 0.000")
                    {
                        DataTable dtB = new DataTable();

                        dtB = objProfiles.viewAllBirthdaysByClient_ID(Client_ID);


                        Int32 r;
                        Int32 rTot = dt.Rows.Count;
                        for (r = 0; r < rTot; r++)
                        {
                            objUser.readHtmlPage(SMSUsername, SMSPassword, API, dtB.Rows[r]["Mobile"].ToString(), SMS_Message);
                        }

                        objComm.Client_ID = Client_ID;
                        objComm.LastSendDate = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt");
                        objComm.update_Client_Auto_Birthdays_SendDate();

                       
                    }
                    else
                    {
                        //lblMany_Message.Text = "Message NOT Sent, Please Check SMS Credits";
                        //lblMany_Message.ForeColor = Color.Red;
                    }

                }
                catch
                {
                    //lblMany_Message.Text = "Message NOT Sent, Please Check SMS Credits";
                    //lblMany_Message.ForeColor = Color.Red;
                }
            }
            else
            {
                //lblMany_Message.Text = "Message is required";
                //lblMany_Message.ForeColor = Color.Red;
            }

        }

       #endregion

        #region Wedding Auto Send



        public void Auto_Send_Wedding(Int32 Client_ID, string SMS_Message_Wedding)
        {

            DataTable dt = new DataTable();
            dt = objComm.viewClient_SMS_Accounts_By_Client_ID(Client_ID);

            string SMSUsername = dt.Rows[0]["SMSUsername"].ToString();
            string SMSClientID = dt.Rows[0]["SMSClientID"].ToString();
            string SMSPassword = dt.Rows[0]["SMSPassword"].ToString();
            string API = dt.Rows[0]["SMSAPI"].ToString();

            if (SMS_Message_Wedding != String.Empty)
            {
                try
                {

                    string SMS_Credit = objUser.GetSMSBalance(SMSUsername, SMSPassword, API);
                    //lblSMS_Credit1.Text = objSMS.GetSMSBalance(lblSMSUsername.Text, lblSMSPassword.Text, lblAPI.Text);

                    if (SMS_Credit != "Credit: 0.000")
                    {
                        DataTable dtW = new DataTable();
                        dtW = objProfiles.viewAllWeddingByClient_ID(Client_ID);

                        Int32 r;
                        Int32 rTot = dtW.Rows.Count;
                        for (r = 0; r < rTot; r++)
                        {
                            objUser.readHtmlPage(SMSUsername, SMSPassword, API, dtW.Rows[r]["Mobile"].ToString(), SMS_Message_Wedding);

                            //lblMany_Message.Text = "Message Sent (" + rTot + ")";
                        }

                        objComm.Client_ID = Client_ID;
                        objComm.LastSendDate = DateTime.Now.ToString();
                        objComm.update_Client_Auto_Wedding_SendDate();

                    }
                    else
                    {
                        //lblMany_Message.Text = "Message NOT Sent, Please Check SMS Credits";
                        //lblMany_Message.ForeColor = Color.Red;
                    }

                }
                catch
                {
                    //lblMany_Message.Text = "Message NOT Sent, Please Check SMS Credits";
                    //lblMany_Message.ForeColor = Color.Red;
                }
            }
            else
            {
                //lblMany_Message.Text = "Message is required";
                //lblMany_Message.ForeColor = Color.Red;
            }

        }



        #endregion


        #endregion

        #region Guests

        [OperationContract]
        [Description("Returns NewConvertCard Crude")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string addGuest(string secToken, Int32 clientID, string guestDate, string guestType, string firstName, string lastName, string mobile, string gender, Int32 ageBracketID, string birthyear, string birthmonth, string birthday)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.addGuestNew(clientID, guestDate, guestType, firstName, lastName, mobile, gender, ageBracketID, birthyear, birthmonth, birthday);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        //[OperationContract]
        //[Description("Add Guest")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json)]
        //public void addGuest(string secToken, Int32 clientID, string guestDate, string guestType, string firstName, string lastName, string mobile, string gender, Int32 ageBracketID, string birthyear, string birthmonth, string birthday)
        //{
        //    DataTable dtUser = new DataTable();
        //    dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

        //    if (dtUser.Rows.Count == 0)
        //    {

        //    }
        //    else
        //    {
        //        objProfiles.Client_ID = clientID;
        //        objProfiles.Guest_Date = guestDate;
        //        objProfiles.Guest_Type = guestType;
        //        objProfiles.First_Name = firstName;
        //        objProfiles.Last_Name = lastName;
        //        objProfiles.Cellphone = mobile;
        //        objProfiles.Gender = gender;
        //        objProfiles.ageBracket_ID = ageBracketID;
        //        objProfiles.Birth_Year = birthyear;
        //        objProfiles.Birth_Month = birthmonth;
        //        objProfiles.Birth_Day = birthday;
        //        objProfiles.addGuest();

        //        //DataTable dt = new DataTable();

        //        //dt = objProfiles.viewProfileID_ByProfile_Number(Member_Number);

        //        //objProfiles.Profile_ID = Convert.ToInt32(dt.Rows[0]["Profile_ID"].ToString());
        //        //objProfiles.Client_ID = clientID;
        //        //objProfiles.Category = "New Guest";
        //        //objProfiles.Guest_Date = DateTime.Now.ToString("yyyy/MM/dd");
        //        //objProfiles.AddNewGuests2();
        //    }

        //}

        #region Summary

        [OperationContract]
        [Description("Returns NewConvertsSummary by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsSummary({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GuestsSummary(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewGuests_By_Client_ID_Date_Summary(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns GuestsByGenderById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsByGenderById({secToken},{ClientID},{gender},{From_Date},{To_Date})")]
        public string GetGuestsByGenderById(string secToken, string ClientID, string gender, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_Gender(Convert.ToInt32(ClientID), gender, From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns withFollowups by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsWithFollowupsById({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetGuestsWithFollowupsById(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_withFollowups(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns withNoFollowups by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsWithNoFollowupsById({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetGuestsWithNoFollowupsById(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_withNoFollowups(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns ChurchAttending by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsChurchAttendingById({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetGuestsChurchAttendingById(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_ChurchAttending(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns NoChurchAttending by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsNoChurchAttendingById({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetGuestsNoChurchAttendingById(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_NoChurchAttending(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns GuestsSavedById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsSavedById({secToken},{ClientID},{Saved},{From_Date},{To_Date})")]
        public string GetGuestsSavedById(string secToken, string ClientID, string Saved, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_Saved(Convert.ToInt32(ClientID), Saved, From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns GuestsBaptisedById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsBaptisedById({secToken},{ClientID},{Baptised},{From_Date},{To_Date})")]
        public string GetGuestsBaptisedById(string secToken, string ClientID, string Baptised, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_Baptised(Convert.ToInt32(ClientID), Baptised, From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns GuestsPromotedById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestsPromotedById({secToken},{ClientID},{CategoryID},{From_Date},{To_Date})")]
        public string GetGuestsPromotedById(string secToken, string ClientID, string CategoryID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date_Promoted(Convert.ToInt32(ClientID), Convert.ToInt32(CategoryID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        #endregion

        #region AllGuests

        [OperationContract]
        [Description("Returns All Guests only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllGuestsOnlySmallOrLarge({secToken},{ClientID},{smallOrLarge})")]
        public string GetAllGuestsOnlyNoDatesSmallOrLarge(string secToken, string ClientID, string smallOrLarge)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_NoDate2_Small_and_Large(Convert.ToInt32(ClientID), smallOrLarge);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        [OperationContract]
        [Description("Returns All Guests only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllGuestsOnlyNoDates({secToken},{ClientID})")]
        public string GetAllGuestsOnlyNoDates(string secToken, string ClientID)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_NoDate2(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        [OperationContract]
        [Description("Returns All Guests only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllGuestsRegularsSmallOrLarge({secToken},{ClientID},{smallOrLarge})")]
        public string GetAllGuestsRegularsSmallOrLarge(string secToken, string ClientID, string smallOrLarge)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Regulars_Small_and_Large(Convert.ToInt32(ClientID), smallOrLarge);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        [OperationContract]
        [Description("Returns All Guests by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllGuestsOnlyNoDatesRegulars({secToken},{ClientID})")]
        public string GetAllGuestsOnlyNoDatesRegulars(string secToken, string ClientID)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_NoDate2_Regulars(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }




        [OperationContract]
        [Description("Returns All Guests only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllGuestsOnly({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetAllGuestsOnly(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_Guests_By_Client_ID_Date2(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }
        #endregion

        #region AllGuestsBySpiritualActivity
        //[OperationContract]
        //[Description("Returns All GuestsSpiritualActivity only Profile by Client ID")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "GetAllGuestsBySpiritualActivityOnlyNoDates({ClientID},{Activity})")]
        //public string GetAllGuestsSpiritualActivityOnlyNoDates(string ClientID, string Activity)
        //{

        //    DataTable dt = new DataTable();
        //    dt = objProfiles.viewProfile_Guests_By_SpiritualActivity_Client_ID_NoDate2(Convert.ToInt32(ClientID), Activity);

        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //    Dictionary<string, object> row;
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        row = new Dictionary<string, object>();
        //        foreach (DataColumn col in dt.Columns)
        //        {
        //            row.Add(col.ColumnName, dr[col]);
        //        }
        //        rows.Add(row);
        //    }
        //    return serializer.Serialize(rows);

        //}



        //[OperationContract]
        //[Description("Returns All GuestsSpiritualActivity only Profile by Client ID")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "GetAllGuestsBySpiritualActivityOnly({ClientID},{From_Date},{To_Date},{Activity})")]
        //public string GetAllGuestsBySpiritualActivityOnly(string ClientID, string From_Date, string To_Date, string Activity)
        //{

        //    DataTable dt = new DataTable();
        //    dt = objProfiles.viewProfile_Guests_By_SpiritualActivity_Client_ID_Date2(Convert.ToInt32(ClientID), From_Date, To_Date, Activity);

        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //    Dictionary<string, object> row;
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        row = new Dictionary<string, object>();
        //        foreach (DataColumn col in dt.Columns)
        //        {
        //            row.Add(col.ColumnName, dr[col]);
        //        }
        //        rows.Add(row);
        //    }
        //    return serializer.Serialize(rows);

        //}
        #endregion

        #region General



        [OperationContract]
        [Description("Add Guest by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "addNewGuest({secToken},{ClientID})")]
        public void addNewGuest(string secToken, string ClientID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int clientID = Convert.ToInt32(ClientID);

                DataTable dt2 = new DataTable();
                dt2 = objProfiles.viewProfileByClient_ID(clientID);

                Int32 Profile_Count = dt2.Rows.Count + 1;
                string Member_Number = Profile_Count.ToString("00") + clientID.ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString();

                objProfiles.Client_ID = clientID;
                objProfiles.Profile_Number = Member_Number;
                objProfiles.MainDepartment_ID = 3;
                objProfiles.Category_ID = 4;
                objProfiles.Reg_Date = DateTime.Now.ToString();
                objProfiles.addProfile_Pre();

                DataTable dt = new DataTable();

                dt = objProfiles.viewProfileID_ByProfile_Number(Member_Number);

                objProfiles.Profile_ID = Convert.ToInt32(dt.Rows[0]["Profile_ID"].ToString());
                objProfiles.Client_ID = clientID;
                objProfiles.Category = "New Guest";
                objProfiles.Guest_Date = DateTime.Now.ToString("yyyy/MM/dd");
                objProfiles.AddNewGuests2();
            }

        }


  


        #endregion

        #region GuestCard

        [OperationContract]
        [Description("Returns members Family by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string guestCardCrude(string secToken, string crude, Int32 profileID, Int32 guestID, string category, string guestType, string guestDate, string howDidYouHereAboutChurch, string churchAttending, string personYouKnowInOurChurch, string anyPrayerNeeds, string isSaved, string isBaptised, string lifeStatus)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.guestCardCrude(crude, profileID, guestID, category, guestType, guestDate, howDidYouHereAboutChurch, churchAttending, personYouKnowInOurChurch, anyPrayerNeeds, isSaved, isBaptised, lifeStatus);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns GuestCard by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuestCardById({secToken},{ProfileID})")]
        public string GetGuestCardById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewGuestCard_By_Profile_ID(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Update GuestCard by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateGuestCard(string secToken, int ProfileID, string Guest_Type, string Category, string isSaved, string isBaptised, string Guest_Date, string HowDidYouHereAboutChurch, string ChurchAttending, string PersonYouKnowInOurChurch, string LifeStatus, string AnyPrayerNeeds)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.Guest_Type = Guest_Type;
                objProfiles.Category = Category;
                objProfiles.isSaved = isSaved;
                objProfiles.isBaptised = isBaptised;
                objProfiles.Guest_Date = Guest_Date;
                objProfiles.HowDidYouHereAboutChurch = HowDidYouHereAboutChurch;
                objProfiles.ChurchAttending = ChurchAttending;
                objProfiles.PersonYouKnowInOurChurch = PersonYouKnowInOurChurch;
                objProfiles.LifeStatus = LifeStatus;
                objProfiles.AnyPrayerNeeds = AnyPrayerNeeds;
                objProfiles.updateGuestCard();
            }

        }

        #endregion

        #region Followups

        [OperationContract]
        [Description("Returns followups by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string followupsCrude(string secToken, string crude, Int32 clientID, Int32 categoryID, Int32 profileID, Int32 followupID, int followupByID, string followupDate, string followupNotes, string followupRecommendations)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.followupsCrude(crude, clientID, categoryID, profileID, followupID, followupByID, followupDate, followupNotes, followupRecommendations);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Followups by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "FollowupsById({secToken},{ProfileID})")]
        public string GetFollowupsById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewClient_Followups_By_Profile_ID2(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Add Followups by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addFollowups(string secToken, int ClientID, int ProfileID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Client_ID = ClientID;
                objProfiles.Profile_ID = ProfileID;
                objProfiles.AddClient_FollowupsPre();
            }

        }

        [OperationContract]
        [Description("Update Followups by Followup ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateFollowups(string secToken, int Followup_ID, int Followup_By_ID, string Followup_Date, string Followup_Notes, string Followup_Recommendations)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Followup_ID = Followup_ID;
                objProfiles.Followup_By_ID = Followup_By_ID;
                objProfiles.Followup_Date = Followup_Date;
                objProfiles.Followup_Notes = Followup_Notes;
                objProfiles.Followup_Recommendations = Followup_Recommendations;
                objProfiles.updateClient_Guest_Followups();
            }

        }


        [OperationContract]
        [Description("Remove Followups by Followup ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void removeFollowups(string secToken, int Followup_ID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Followup_ID = Followup_ID;
                objProfiles.deleteClient_Guest_Followups();
            }

        }

        #endregion

        #endregion

        #region NewConverts

        #region Summary

        [OperationContract]
        [Description("Returns NewConvertsSummary by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NewConvertsSummary({secToken},{ClientID},{From_Date},{To_Date})")]
        public string NewConvertsSummary(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewPromoted_NewConverts_By_Client_ID_Date_Summary(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns NewConvertsByGenderById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NewConvertsByGenderById({secToken},{ClientID},{gender},{From_Date},{To_Date})")]
        public string GetNewConvertsByGenderById(string secToken, string ClientID, string gender, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_Date_Gender(Convert.ToInt32(ClientID), gender, From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns withFollowups by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NewConvertsWithFollowupsById({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetNewConvertsWithFollowupsById(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_Date_withFollowups(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns NewConverts withNoFollowups by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NewConvertsWithNoFollowupsById({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetNewConvertsWithNoFollowupsById(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_Date_withNoFollowups(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        [OperationContract]
        [Description("Returns NewConvertsBaptisedById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NewConvertsBaptisedById({secToken},{ClientID},{Baptised},{From_Date},{To_Date})")]
        public string GetNewConvertsBaptisedById(string secToken, string ClientID, string Baptised, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_Date_Baptised(Convert.ToInt32(ClientID), Baptised, From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns NewConvertsPromotedById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NewConvertsPromotedById({secToken},{ClientID},{CategoryID},{From_Date},{To_Date})")]
        public string GetNewConvertsPromotedById(string secToken, string ClientID, string CategoryID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_Date_Promoted(Convert.ToInt32(ClientID), Convert.ToInt32(CategoryID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        #endregion

        #region AllNewConverts

        [OperationContract]
        [Description("Add NewConvert by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "addNewConvert({secToken},{ClientID})")]
        public void addNewConvert(string secToken, string ClientID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int clientID = Convert.ToInt32(ClientID);

                DataTable dt2 = new DataTable();
                dt2 = objProfiles.viewProfileByClient_ID(clientID);

                Int32 Profile_Count = dt2.Rows.Count + 1;
                string Member_Number = Profile_Count.ToString("00") + clientID.ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString();

                objProfiles.Client_ID = clientID;
                objProfiles.Profile_Number = Member_Number;
                objProfiles.MainDepartment_ID = 3;
                objProfiles.Category_ID = 2;
                objProfiles.Reg_Date = DateTime.Now.ToString();
                objProfiles.addProfile_Pre();

                DataTable dt = new DataTable();

                dt = objProfiles.viewProfileID_ByProfile_Number(Member_Number);

                objProfiles.Profile_ID = Convert.ToInt32(dt.Rows[0]["Profile_ID"].ToString());
                objProfiles.Client_ID = clientID;
                objProfiles.Category = "New Born";
                objProfiles.Convertion_Date = DateTime.Now.ToString("yyyy/MM/dd");
                objProfiles.AddNewConvert2();
            }

        }


        [OperationContract]
        [Description("Returns All Promoted NewConverts by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllPromotedNewConverts({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetAllPromotedNewConverts(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewPromoted_NewConverts_By_Client_ID_Date(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("promote NewConverts To Member by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "promoteNewConvertsToMember({secToken},{ClientID},{ProfileID})")]
        public void promoteNewConvertsToMember(string secToken, string ClientID, string ProfileID)
        {
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int clientID = Convert.ToInt32(ClientID);
                int profileID = Convert.ToInt32(ProfileID);

                objProfiles.Client_ID = clientID;
                objProfiles.Profile_ID = profileID;
                objProfiles.Category_ID = 1;
                objProfiles.Promoted_Date = DateTime.Now.ToString();
                objProfiles.updateProfile_Promote();
            }

        }


        [OperationContract]
        [Description("Returns All NewConverts only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllNewConvertsSmallOrLarge({secToken},{ClientID},{smallOrLarge})")]
        public string GetAllNewConvertsSmallOrLarge(string secToken, string ClientID, string smallOrLarge)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_SmallOrLarge(Convert.ToInt32(ClientID), smallOrLarge);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns All NewConverts only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllNewConvertsPromotedSmallOrLarge({secToken},{ClientID},{smallOrLarge})")]
        public string GetAllNewConvertsPromotedSmallOrLarge(string secToken, string ClientID, string smallOrLarge)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_Promoted_By_Client_ID_SmallOrLarge(Convert.ToInt32(ClientID), smallOrLarge);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }




        [OperationContract]
        [Description("Returns All NewConverts only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllNewConvertsOnlyNoDates({secToken},{ClientID})")]
        public string GetAllNewConvertsOnlyNoDates(string secToken, string ClientID)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_NoDate2(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }



        [OperationContract]
        [Description("Returns All NewConverts only Profile by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllNewConvertsOnly({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetAllNewConvertsOnly(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewProfile_NewConverts_By_Client_ID_Date2(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }
        #endregion

        #region NewConvertCard

        [OperationContract]
        [Description("Returns NewConvertCard Crude")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string NewConvertCardCrude(string secToken, string crude, Int32 profileID, Int32 newconvertID, string category, string convertionDate, string howDidYouHereAboutChurch, string churchAttending, string personYouKnowInOurChurch, string anyPrayerNeeds, string isBaptised, string lifeStatus)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.newconvertCardCrude(crude, profileID, newconvertID, category, convertionDate, howDidYouHereAboutChurch, churchAttending, personYouKnowInOurChurch, anyPrayerNeeds, isBaptised, lifeStatus);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns NewConvertCard by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "NewConvertCardById({secToken},{ProfileID})")]
        public string GetNewConvertCardById(string secToken, string ProfileID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewNewConvertCard_By_Profile_ID(Convert.ToInt32(ProfileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Update NewConvertCard by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateNewConvertCard(string secToken, int ProfileID, string Category, string Convertion_Date, string WhoLedToChrist_By, string isBaptised, string HowDidYouHereAboutChurch, string WhereDidItHappen, string PersonYouKnowInOurChurch, string PreviousChurch, string LifeStatus, string AnyPrayerNeeds)
        {

                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objProfiles.Profile_ID = ProfileID;
                objProfiles.Category = Category;
                objProfiles.Convertion_Date = Convertion_Date;
                objProfiles.WhoLedToChrist_By = WhoLedToChrist_By;
                objProfiles.WhereDidItHappen = WhereDidItHappen;
                objProfiles.HowDidYouHereAboutChurch = HowDidYouHereAboutChurch;
                objProfiles.PersonYouKnowInOurChurch = PersonYouKnowInOurChurch;
                objProfiles.PreviousChurch = PreviousChurch;
                objProfiles.isBaptised = isBaptised;
                objProfiles.LifeStatus = LifeStatus;
                objProfiles.AnyPrayerNeeds = AnyPrayerNeeds;
                objProfiles.updateConverts2();
            }

        }

        #endregion


        #endregion

        #region PromotedToFrom

        [OperationContract]
        [Description("Returns AllGuestsPromotedSmallOrLarge")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllGuestsPromotedSmallOrLarge({secToken},{ClientID},{smallOrLarge})")]
        public string GetAllGuestsPromotedSmallOrLarge(string secToken, string ClientID, string smallOrLarge)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewPromoted_Guests_By_Client_IDsmallOrLarge(Convert.ToInt32(ClientID), smallOrLarge);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("Returns All Promoted Guests by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetAllPromotedGuests({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetAllPromotedGuests(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewPromoted_Guests_By_Client_ID_Date(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("promote Guest To Member by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "promoteGuestToMember({secToken},{ClientID},{ProfileID})")]
        public void promoteGuestToMember(string secToken, string ClientID, string ProfileID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int clientID = Convert.ToInt32(ClientID);
                int profileID = Convert.ToInt32(ProfileID);

                objProfiles.Client_ID = clientID;
                objProfiles.Profile_ID = profileID;
                objProfiles.Category_ID = 1;
                objProfiles.Promoted_Date = DateTime.Now.ToString();
                objProfiles.updateProfile_Promote();
            }

        }

        [OperationContract]
        [Description("promote Guest To Newconvert by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "promoteGuestToNewconvert({secToken},{ClientID},{ProfileID})")]
        public void promoteGuestToNewconvert(string secToken, string ClientID, string ProfileID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int clientID = Convert.ToInt32(ClientID);
                int profileID = Convert.ToInt32(ProfileID);

                objProfiles.Client_ID = clientID;
                objProfiles.Profile_ID = profileID;
                objProfiles.Category_ID = 2;
                objProfiles.Promoted_Date = DateTime.Now.ToString();
                objProfiles.updateProfile_Promote();
            }

        }

        [OperationContract]
        [Description("Returns PromotedToFromCountById by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "PromotedToFromCountById({secToken},{ClientID},{CategoryIDTo},{CategoryIDFrom},{From_Date},{To_Date})")]
        public string GetPromotedToFromCountById(string secToken, string ClientID, string CategoryIDTo, string CategoryIDFrom, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objProfiles.viewPromoted_ToFrom_Count_By_Client_ID_Date(Convert.ToInt32(ClientID), Convert.ToInt32(CategoryIDTo), Convert.ToInt32(CategoryIDFrom), From_Date, To_Date);
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("promote promoteToFrom To From by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "promoteToFrom({secToken},{ClientID},{ProfileID},{ToID},{FromID})")]
        public void promoteToFrom(string secToken, string ClientID, string ProfileID, string ToID, string FromID)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                int clientID = Convert.ToInt32(ClientID);
                int profileID = Convert.ToInt32(ProfileID);
                int toID = Convert.ToInt32(ToID);
                int fromID = Convert.ToInt32(FromID);

                objProfiles.Client_ID = clientID;
                objProfiles.Profile_ID = profileID;
                objProfiles.Category_ID = toID;
                objProfiles.Category_ID_From = fromID;
                objProfiles.Promoted_Date = DateTime.Now.ToString();
                objProfiles.updateProfile_PromoteToFrom();
            }

        }



        #endregion

        #region Events


        [OperationContract]
        [Description("Returns Events by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "EventsById({secToken},{ClientID})")]
        public string GetEventsById(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objEvents.Events_View_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Events by EventID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "EventsByEventId({secToken},{EventID})")]
        public string GetEventsByEventId(string secToken, string EventID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objEvents.Events_View_By_Event_ID(Convert.ToInt32(EventID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns Events by Client ID and No Dates")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "EventsByClientIdandNoDates({secToken},{ClientID})")]
        public string GetEventsByIdandNoDates(string secToken, string ClientID)
        {
            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objEvents.Events_View_By_Client_ID(Convert.ToInt32(ClientID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns All Events by Client ID with Dates")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "EventsByClientIdandwithDates({secToken},{ClientID},{From_Date},{To_Date})")]
        public string GetAllEventsByIdandwithDates(string secToken, string ClientID, string From_Date, string To_Date)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objEvents.Events_View_By_Client_ID_and_Event_Date(Convert.ToInt32(ClientID), From_Date, To_Date);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        [OperationContract]
        [Description("Update Events by Event_ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void updateEvent(string secToken, int Event_ID, string Event_Name, string Event_Start_Date, string Event_End_Date, string Event_Time, string Event_Venue, Int32 Event_Coordinator_ID, string Event_Target_Audience, string Event_Message_Theme, string Event_Objectives, string Event_Description, string Event_Risk_Assessment, string Event_Evaluation_Criteria)
        {

                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objEvents.Event_ID = Event_ID;
                objEvents.Event_Name = Event_Name;
                objEvents.Event_Start_Date = Event_Start_Date;
                objEvents.Event_End_Date = Event_End_Date;
                objEvents.Event_Time = Event_Time;
                objEvents.Event_Coordinator_ID = Event_Coordinator_ID;
                objEvents.Event_Target_Audience = Event_Target_Audience;
                objEvents.Event_Message_Theme = Event_Message_Theme;
                objEvents.Event_Objectives = Event_Objectives;
                objEvents.Event_Description = Event_Description;
                objEvents.Event_Risk_Assessment = Event_Risk_Assessment;
                objEvents.Event_Evaluation_Criteria = Event_Evaluation_Criteria;
                objEvents.Last_Update_Date = DateTime.Now.ToString();
                objEvents.updateEvents();
            }

        }

        [OperationContract]
        [Description("Add Event by Client ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void addEvent(string secToken, int ClientID)
        {

            DataTable dt = new DataTable();
                                    DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objEvents.Events_View_By_Client_ID(ClientID);


                int Event_Count = dt.Rows.Count + 1;
                string Profile_Number_Prefix = string.Empty;

                string Event_Number = Event_Count.ToString("00") + ClientID.ToString("00") + DateTime.Now.Year.ToString();

                objEvents.Event_Number = Event_Number;
                objEvents.Client_ID = ClientID;
                objEvents.Reg_Date = DateTime.Now.ToString();
                objEvents.addEvents();
            }

        }



        #endregion

        #region Shop

        #region Books

        [OperationContract]
        [Description("Returns BooksAll")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "BooksAll({secToken})")]
        public string GetAllBooks(string secToken)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewAllBooks();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region Sermons

        [OperationContract]
        [Description("Returns SermonsAll")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "SermonsAll({secToken})")]
        public string GetAllSermons(string secToken)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewAllSermons();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region Music

        [OperationContract]
        [Description("Returns MusicAll")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "MusicAll({secToken})")]
        public string GetAllMusic(string secToken)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewAllMusic();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region Variety

        [OperationContract]
        [Description("Returns VarietyAll")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "VarietyAll({secToken})")]
        public string GetAllVariety(string secToken)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewAllVariety();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
        #endregion

        #region Orders
        [OperationContract]
        [Description("Add Orders")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void NewOrderCreate(string secToken, string fullName, string mobile, string tel, string email, string shippingAddress, string country, string province, string city, string zipcode, string orderDescription, string orderAmount, string qtytotal, string userPassword)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            DataTable dt = new DataTable();
            dt = objShop.viewAllAmen_Shop_Shoppers();
            string Number = (dt.Rows.Count + 1).ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("00");

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objShop.Shopper_Number = Number;
                objShop.Shopper_Name = fullName;
                objShop.Shopper_Category = "Shopper";
                objShop.Shopper_RegDate = DateTime.Now.ToString();
                objShop.Shopper_Mobile = mobile;
                objShop.Shopper_Tel = tel;
                objShop.Shopper_Email = email;
                objShop.Shopper_Address = shippingAddress;
                objShop.Shopper_Country = country;
                objShop.Shopper_Province = province;
                objShop.Shopper_City = city;
                objShop.Shopper_PostalCode = zipcode;
                objShop.User_Password = userPassword;
                objShop.addAmen_Shop_Shopper2();


                DataTable dt2 = new DataTable();
                dt2 = objShop.viewAmen_Shop_Shopper_ByShopper_Number(Number);
                Int32 Shopper_Id = Convert.ToInt32(dt2.Rows[0]["Shopper_ID"]);

                Shop_Orders_insert(secToken, Shopper_Id, orderDescription, orderAmount, qtytotal);
            }

        }

        [OperationContract]
        [Description("Shop_Orders_insert")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void Shop_Orders_insert(string secToken, Int32 Shopper_ID, string Order_Description, string Order_Amount, string Order_Qty)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            DataTable dt = new DataTable();
            dt = objShop.viewAllAmen_Shop_Shoppers();
            string strOrderNumber = (dt.Rows.Count + 1).ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("00");

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objShop.Order_Number = strOrderNumber;
                objShop.Shopper_ID = Shopper_ID;
                objShop.Order_Name = "Order#" + Shopper_ID;
                objShop.Order_Description = Order_Description;
                objShop.Order_Amount = Order_Amount;
                objShop.Order_Qty = Order_Qty;
                objShop.Order_Status = "Pending";
                objShop.Order_Date = DateTime.Now.ToString();
                objShop.AddAmen_Shop_Orders();
            }

        }



        [OperationContract]
        [Description("OrdersByShopperID")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string OrdersByShopperID(string secToken, Int32 ShopperID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewAmen_Shop_Orders_By_Shopper_ID(ShopperID);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }


        #endregion

        #region Shopper
        [OperationContract]
        [Description("ShopperUser Authentication")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        //UriTemplate = "UserAuthentication({secToken},{clientID},{userName},{password})")]
        public string ShopperUser(string secToken, string userName, string password)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewShopperUserAccess(userName, password);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("ShopperByShopperID")]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public string ShopperByShopperID(string secToken, Int32 ShopperID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objShop.viewAmen_Shop_Shopper_By_Shopper_ID(ShopperID);
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);

        }

        [OperationContract]
        [Description("UpdateShopperDetails")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void UpdateShopperDetails(string secToken, Int32 shopperID, string fullName, string mobile, string tel, string email, string shippingAddress, string country, string province, string city, string zipcode)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objShop.Shopper_ID = shopperID;
                objShop.Shopper_Name = fullName;
                objShop.Shopper_Mobile = mobile;
                objShop.Shopper_Tel = tel;
                objShop.Shopper_Email = email;
                objShop.Shopper_Address = shippingAddress;
                objShop.Shopper_Country = country;
                objShop.Shopper_Province = province;
                objShop.Shopper_City = city;
                objShop.Shopper_PostalCode = zipcode;
                objShop.UpdateAmen_Shop_Shopper();


            }

        }

        [OperationContract]
        [Description("UpdateShopperLogins")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void UpdateShopperLogins(string secToken, string userName,  string userPassword)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objShop.User_Name = userName;
                objShop.User_Password = userPassword;
                objShop.UpdateAmen_Shop_Shopper_Logins();


            }

        }

        [OperationContract]
        [Description("New Shopper Create")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void NewShopperCreate(string secToken, string fullName, string mobile, string tel, string email, string shippingAddress, string country, string province, string city, string zipcode, string userPassword)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            DataTable dt = new DataTable();
            dt = objShop.viewAllAmen_Shop_Shoppers();
            string Number = (dt.Rows.Count + 1).ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("00");

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objShop.Shopper_Number = Number;
                objShop.Shopper_Name = fullName;
                objShop.Shopper_Category = "Shopper";
                objShop.Shopper_RegDate = DateTime.Now.ToString();
                objShop.Shopper_Mobile = mobile;
                objShop.Shopper_Tel = tel;
                objShop.Shopper_Email = email;
                objShop.Shopper_Address = shippingAddress;
                objShop.Shopper_Country = country;
                objShop.Shopper_Province = province;
                objShop.Shopper_City = city;
                objShop.Shopper_PostalCode = zipcode;
                objShop.User_Password = userPassword;
                objShop.addAmen_Shop_Shopper2();

            }

        }


        #endregion

        #endregion

        #region FilesHandler

        #region Shop

        #region Books
        [OperationContract]
        [Description("Returns Shop Books Image by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "BookShopItemImageByItemID({secToken},{itemID})")]
        public string GetBooksShopItemImageByItemID(string secToken, string itemID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFile.viewBooksShopItemImageByItemID(Convert.ToInt32(itemID));
            }
            string ftype = null;
            string fname = null;
            if (dt.Rows.Count > 0)
            {
                fname = dt.Rows[0]["Img_Front_Filename"].ToString();//
                ftype = Path.GetExtension(fname);
                //ftype = dt.Rows[0]["fileType"].ToString();//Img_Front_Filename

                try
                {
                    if (ftype != null)
                    {

                        Byte[] bytes = (Byte[])dt.Rows[0]["Img_Front_Cover"];
                        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        string FileUrl = "data:" + ftype + ";base64," + base64String;

                        return FileUrl;

                    }
                    else
                    {
                        return "No Image";
                    }
                }
                catch
                { return "No Image"; }
            }
            else
            {
                return "No Image";
            }
        }

        #endregion

        #region Sermons
        [OperationContract]
        [Description("Returns SermonShop Image by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "SermonShopItemImageByItemID({secToken},{itemID})")]
        public string GetSermonShopItemImageByItemID(string secToken, string itemID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFile.viewSermonsShopItemImageByItemID(Convert.ToInt32(itemID));
            }
            string ftype = null;
            string fname = null;
            if (dt.Rows.Count > 0)
            {
                fname = dt.Rows[0]["Img_Front_Filename"].ToString();//
                ftype = Path.GetExtension(fname);
                //ftype = dt.Rows[0]["fileType"].ToString();//Img_Front_Filename

                try
                {
                    if (ftype != null)
                    {

                        Byte[] bytes = (Byte[])dt.Rows[0]["Img_Front_Cover"];
                        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        string FileUrl = "data:" + ftype + ";base64," + base64String;

                        return FileUrl;

                    }
                    else
                    {
                        return "No Image";
                    }
                }
                catch
                { return "No Image"; }
            }
            else
            {
                return "No Image";
            }
        }

        #endregion

        #region Music
        [OperationContract]
        [Description("Returns MusicShop Image by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "MusicShopItemImageByItemID({secToken},{itemID})")]
        public string GetMusicShopItemImageByItemID(string secToken, string itemID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFile.viewMusicShopItemImageByItemID(Convert.ToInt32(itemID));
            }
            string ftype = null;
            string fname = null;
            if (dt.Rows.Count > 0)
            {
                fname = dt.Rows[0]["Img_Front_Filename"].ToString();//
                ftype = Path.GetExtension(fname);
                //ftype = dt.Rows[0]["fileType"].ToString();//Img_Front_Filename

                try
                {
                    if (ftype != null)
                    {

                        Byte[] bytes = (Byte[])dt.Rows[0]["Img_Front_Cover"];
                        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        string FileUrl = "data:" + ftype + ";base64," + base64String;

                        return FileUrl;

                    }
                    else
                    {
                        return "No Image";
                    }
                }
                catch
                { return "No Image"; }
            }
            else
            {
                return "No Image";
            }
        }

        #endregion

        #region Variety
        [OperationContract]
        [Description("Returns Variety Shop Image by Item ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "VarietyShopItemImageByItemID({secToken},{itemID})")]
        public string GetVarietyShopItemImageByItemID(string secToken, string itemID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFile.viewVarietyShopItemImageByItemID(Convert.ToInt32(itemID));
            }
            string ftype = null;
            string fname = null;
            if (dt.Rows.Count > 0)
            {
                fname = dt.Rows[0]["Img_Front_Filename"].ToString();//
                ftype = Path.GetExtension(fname);
                //ftype = dt.Rows[0]["fileType"].ToString();//Img_Front_Filename

                try
                {
                    if (ftype != null)
                    {

                        Byte[] bytes = (Byte[])dt.Rows[0]["Img_Front_Cover"];
                        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        string FileUrl = "data:" + ftype + ";base64," + base64String;

                        return FileUrl;

                    }
                    else
                    {
                        return "No Image";
                    }
                }
                catch
                { return "No Image"; }
            }
            else
            {
                return "No Image";
            }
        }

        #endregion



        //[OperationContract]
        //[Description("Returns Files Profile by Profile ID and Category")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "ProfileFileByProfileIDandCategoryNoFileData({secToken},{ProfileID},{Category})")]
        //public string GetProfileFileByProfileIDandCategoryNoFileData(string secToken, string ProfileID, string Category)
        //{
        //    DataTable dt = new DataTable();
        //    DataTable dtUser = new DataTable();
        //    dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

        //    if (dtUser.Rows.Count == 0)
        //    {

        //    }
        //    else
        //    {
        //        dt = objFile.viewProfileFilesByProfileIDandCategoryNoFileData(Convert.ToInt32(ProfileID), Category);
        //    }
        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //    Dictionary<string, object> row;
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        row = new Dictionary<string, object>();
        //        foreach (DataColumn col in dt.Columns)
        //        {
        //            row.Add(col.ColumnName, dr[col]);
        //        }
        //        rows.Add(row);
        //    }
        //    return serializer.Serialize(rows);
        //}

        
        //[OperationContract]
        //[Description("Returns Files Profile by Profile ID and Category")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "ProfileFileByProfileIDandCategory({secToken},{ProfileID},{Category})")]
        //public string GetProfileFilesByProfileIDandCategory(string secToken, string ProfileID, string Category)
        //{
        //    DataTable dt = new DataTable();
        //    DataTable dtUser = new DataTable();
        //    dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

        //    if (dtUser.Rows.Count == 0)
        //    {

        //    }
        //    else
        //    {
        //        dt = objFile.viewProfileFilesByProfileIDandCategory(Convert.ToInt32(ProfileID), Category);
        //    }
        //    string ftype = null;
        //    if (dt.Rows.Count > 0)
        //    {
        //        ftype = dt.Rows[0]["fileType"].ToString();
        //        try
        //        {
        //            if (ftype != null)
        //            {

        //                Byte[] bytes = (Byte[])dt.Rows[0]["fileData"];
        //                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
        //                string FileUrl = "data:" + ftype + ";base64," + base64String;

        //                return FileUrl;

        //            }
        //            else
        //            {
        //                return "No Image";
        //            }
        //        }
        //        catch 
        //        { return "No Image"; }
        //    }
        //    else
        //    {
        //        return "No Image";
        //    }
        //}


        //[OperationContract]
        //[Description("Returns File Profile by File ID")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "ProfileFileByFileID({secToken},{FileID})")]
        //public string GetProfileFileByFileID(string secToken, string FileID)
        //{
        //    DataTable dt = new DataTable();
        //    DataTable dtUser = new DataTable();
        //    dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

        //    if (dtUser.Rows.Count == 0)
        //    {

        //    }
        //    else
        //    {
        //        dt = objFile.viewProfileFileByfileID(Convert.ToInt32(FileID));
        //    }
        //    string ftype = null;
        //    if (dt.Rows.Count > 0)
        //    {
        //        ftype = dt.Rows[0]["fileType"].ToString();
        //        try
        //        {
        //            if (ftype != null)
        //            {

        //                Byte[] bytes = (Byte[])dt.Rows[0]["fileData"];
        //                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
        //                string FileUrl = "data:" + ftype + ";base64," + base64String;

        //                return FileUrl;

        //            }
        //            else
        //            {
        //                return "No Image";
        //            }
        //        }
        //        catch
        //        { return "No Image"; }
        //    }
        //    else
        //    {
        //        return "No Image";
        //    }
        //}


        //[OperationContract]
        //[Description("Returns File Profile by File ID")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "ProfileFileByFileID2({secToken},{FileID})")]
        //public string GetProfileFileByFileID2(string secToken, string FileID)
        //{
        //    DataTable dt = new DataTable();
        //    DataTable dtUser = new DataTable();
        //    dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

        //    if (dtUser.Rows.Count == 0)
        //    {

        //    }
        //    else
        //    {
        //        dt = objFile.viewProfileFileByfileID(Convert.ToInt32(FileID));
        //    }
        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //    Dictionary<string, object> row;
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        row = new Dictionary<string, object>();
        //        foreach (DataColumn col in dt.Columns)
        //        {
        //            row.Add(col.ColumnName, dr[col]);
        //        }
        //        rows.Add(row);
        //    }
        //    return serializer.Serialize(rows);
        //}

        //[OperationContract]
        //[Description("Remove ProfileFile")]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest,
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json)]
        //public void ProfileFileRemove(string secToken, Int32 fileID)
        //{
        //    DataTable dtUser = new DataTable();
        //    dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

        //    if (dtUser.Rows.Count == 0)
        //    {

        //    }
        //    else
        //    {
        //        objFile.fileID = fileID;
        //        objFile.removeProfileFile();
        //    }

        //}

        #endregion

        #region ClientFiles

        [OperationContract]
        [Description("Returns members PhotoURL by Profile ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ClientFileURLByClientId({secToken},{ClientID},{Category})")]
        public string GetClientFileURLByClientId(string secToken, string ClientID, string Category)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);
            string ImageUrl = "NoImage";

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFile.viewClient_Files_By_Client_ID_And_Category(Convert.ToInt32(ClientID), Category);
                if (dt.Rows.Count > 0)
                {
                    Byte[] bytes = (Byte[])dt.Rows[0]["blobdata"];
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    ImageUrl = "data:image/png;base64," + base64String;
                }
            }


            return ImageUrl;
        }

        #endregion

        #region ExpenseFile

        [OperationContract]
        [Description("Returns File by File ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ExpenseFileByFileID({secToken},{FileID})")]
        public string GetExpenseFileByFileID(string secToken, string FileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFile.viewExpenseFileByFileID(Convert.ToInt32(FileID));
            }
            string ftype = null;
            if (dt.Rows.Count > 0)
            {
                ftype = dt.Rows[0]["fileType"].ToString();
                try
                {
                    if (ftype != null)
                    {

                        Byte[] bytes = (Byte[])dt.Rows[0]["fileData"];
                        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        string FileUrl = "data:" + ftype + ";base64," + base64String;

                        return FileUrl;

                    }
                    else
                    {
                        return "NoFile";
                    }
                }
                catch
                { return "NoFile"; }
            }
            else
            {
                return "NoFile";
            }
        }


        [OperationContract]
        [Description("Returns File by File ID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "ExpenseFileRemoveByFileID({secToken},{FileID})")]
        public string GetExpenseFileRemoveByFileID(string secToken, string FileID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objFile.viewExpenseFileRemoveByFileID(Convert.ToInt32(FileID));
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
 
        }


        #endregion

        #endregion

        #region Pages

        [OperationContract]
        [Description("Returns CustomPageByClientID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CustomPageByClientID({secToken},{clientID})")]
        public string GetCustomPageByClientID(string secToken, string clientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPage.viewCustomPage_By_Client_ID(Convert.ToInt32(clientID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        [OperationContract]
        [Description("Returns CustomPageByPageID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CustomPageByPageID({secToken},{pageID})")]
        public string GetCustomPageByPageID(string secToken, string pageID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPage.viewCustomPage_By_Page_ID(Convert.ToInt32(pageID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }


        [OperationContract]
        [Description("Returns CustomizerPageByClientID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "CustomizerPageByClientID({secToken},{clientID})")]
        public string GetCustomizerPageByClientID(string secToken, string clientID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPage.viewCustomizePage_By_Client_ID(Convert.ToInt32(clientID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }




        [OperationContract]
        [Description("CustomPageUpdate")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void CustomPageUpdate(string secToken, Int32 Page_Custom_ID, string Custom_Page)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objPage.Page_Custom_ID = Page_Custom_ID;
                objPage.Custom_Page = Custom_Page;
                objPage.updateCustomPage();
            }

        }


        [OperationContract]
        [Description("ClientUseCustomPagesUpdate")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public void ClientUseCustomPagesUpdate(string secToken, Int32 Client_ID, string Custom_Page)
        {
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                objPage.Client_ID = Client_ID;
                objPage.Custom_Page = Custom_Page;
                objPage.updateClient_Use_Custom_Pages();
            }

        }

        [OperationContract]
        [Description("Returns PageTotalsByClientID")]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "PageTotalsByClientID({secToken},{clientID},{pageID})")]
        public string GetPageTotalsByClientID(string secToken, string clientID, string pageID)
        {
            DataTable dt = new DataTable();
            DataTable dtUser = new DataTable();
            dtUser = objUser.viewServiceSecTokenSelectBySecToken1(secToken);

            if (dtUser.Rows.Count == 0)
            {

            }
            else
            {
                dt = objPage.viewPage_Totals_By_Client_ID(Convert.ToInt32(clientID), Convert.ToInt32(pageID));
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }



        #endregion

    }
}