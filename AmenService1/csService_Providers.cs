using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csService_Providers
    {
        csDAL objdal = new csDAL();

        //-------------Pics-------------------
        public Int32 Service_Provider_ID { set; get; }
        public Int32 Client_ID { set; get; }
        
        public string Service_Provider { set; get; }
        public string Service_Provider_Number { set; get; }
        public string Service_Provider_Description { set; get; }
        public string Experience { set; get; }
        public string Contact_Person { set; get; }
        public string Mobile_No { set; get; }
        public string Office_No { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public string Country { set; get; }
        public string City { set; get; }
        public string Province { set; get; }
        public string Address { set; get; }
        public string Code { set; get; }

        public string Reg_Date { set; get; }
        public string LastUpdate_Date { set; get; }

        public Int32 Service_ID { set; get; }
        public string Service { set; get; }

        public Int32 Service_Provided_ID { set; get; }
        public string Service_Date { set; get; }
        public string Service_Description { set; get; }
        public string Service_Amount { set; get; }
        public string Service_Rate { set; get; }

        public csService_Providers()
        { }

        #region Service_Providers

        public DataTable crudeServiceProvider(string crude
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
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, serviceProviderID));
            objlist.Add(new csParameterListType("@Service_Provider_Number", SqlDbType.VarChar, serviceProviderNumber));
            objlist.Add(new csParameterListType("@Service_Provider", SqlDbType.VarChar, serviceProvider));
            objlist.Add(new csParameterListType("@Service_Provider_Description", SqlDbType.VarChar, serviceProviderDescription));
            objlist.Add(new csParameterListType("@Experience", SqlDbType.VarChar, experience));
            objlist.Add(new csParameterListType("@Contact_Person", SqlDbType.VarChar, contactPerson));
            objlist.Add(new csParameterListType("@Mobile_No", SqlDbType.VarChar, mobile));
            objlist.Add(new csParameterListType("@Office_No", SqlDbType.VarChar, tel));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, email));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, website));
            objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, country));
            objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, city));
            objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, province));
            objlist.Add(new csParameterListType("@Address", SqlDbType.VarChar, address));
            objlist.Add(new csParameterListType("@Code", SqlDbType.VarChar, postalCode));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, regDate));
            objlist.Add(new csParameterListType("@Service_ID", SqlDbType.VarChar, serviceID));
            objlist.Add(new csParameterListType("@Service", SqlDbType.VarChar, service));
            dt = objdal.search("procService_Providers_Crude", objlist);
            return dt;
        }

        public void addService_Providers()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Service_Provider_Number", SqlDbType.VarChar, Service_Provider_Number.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objdal.executespreturnnd("procService_Providers_Insert", objlist);
        }

        public void updateService_Providers()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            objlist.Add(new csParameterListType("@Service_ID", SqlDbType.VarChar, Service_ID.ToString()));
            objlist.Add(new csParameterListType("@Service_Provider", SqlDbType.VarChar, Service_Provider.ToString()));
            objlist.Add(new csParameterListType("@Service_Provider_Description", SqlDbType.VarChar, Service_Provider_Description.ToString()));
            objlist.Add(new csParameterListType("@Experience", SqlDbType.VarChar, Experience.ToString()));
            objlist.Add(new csParameterListType("@Contact_Person", SqlDbType.VarChar, Contact_Person.ToString()));
            objlist.Add(new csParameterListType("@Mobile_No", SqlDbType.VarChar, Mobile_No.ToString()));
            objlist.Add(new csParameterListType("@Office_No", SqlDbType.VarChar, Office_No.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
            objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
            objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
            objlist.Add(new csParameterListType("@Address", SqlDbType.VarChar, Address.ToString()));
            objlist.Add(new csParameterListType("@Code", SqlDbType.VarChar, Code.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procService_Providers_Update", objlist);
        }

        public DataTable Service_Providers_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procService_Providers_By_Client_ID", objpar);
            return dt;
        }

        public DataTable Service_Providers_View_By_Service_Provider_ID(Int32 Service_Provider_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            dt = objdal.search("procService_Providers_By_Service_Provider_ID", objpar);
            return dt;
        }

        public DataTable Service_Providers_View_Pre_By_Service_Provider_ID(Int32 Service_Provider_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            dt = objdal.search("procService_Providers_Pre_By_Service_Provider_ID", objpar);
            return dt;
        }

        public DataTable Service_Providers_View_By_Service_Provider_Number(string Service_Provider_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provider_Number", SqlDbType.VarChar, Service_Provider_Number));
            dt = objdal.search("procService_Providers_By_Service_Provider_Number", objpar);
            return dt;
        }

        public DataTable Service_Providers_View_By_Client_ID_and_Service_Provider_Date(Int32 Client_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procService_Providers_By_Client_ID_Date", objpar);
            return dt;
        }

        public DataTable Service_Providers_View_By_Service_Provider_Date(string Service_Provider_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provider_Date", SqlDbType.VarChar, Service_Provider_Date));
            dt = objdal.search("procService_Providers_By_Service_Provider_Date", objpar);
            return dt;
        }

        public DataTable Service_Providers_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procService_Providers_View_All");
            return dt;
        }


        public DataTable Delete_Service_Providers()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            dt = objdal.search("procService_Providers_Delete", objpar);
            return dt;
        }

        public DataTable searchForService_ProvidersAnyField1(string sVariable, Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procService_Providers_SearchByAnyField1", objpar);
            return dt;
        }

        #endregion

        #region Services

        public void addServices()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Service", SqlDbType.VarChar, Service.ToString()));
            objdal.executespreturnnd("procServices_Insert", objlist);
        }

        public void updateServices()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Service_ID", SqlDbType.BigInt, Service_ID));
            objlist.Add(new csParameterListType("@Service", SqlDbType.VarChar, Service.ToString()));
            objdal.executespreturnnd("procServices_Update", objlist);
        }

        public DataTable Services_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procServices_By_Client_ID", objpar);
            return dt;
        }

        public DataTable Services_View_By_Service_ID(Int32 Service_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_ID", SqlDbType.BigInt, Service_ID));
            dt = objdal.search("procServices_By_Service_ID", objpar);
            return dt;
        }


        public DataTable Delete_Services()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_ID", SqlDbType.BigInt, Service_ID));
            dt = objdal.search("procServices_Delete", objpar);
            return dt;
        }


        #endregion

        #region Services_Provided

        public void addServices_Provided()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            objlist.Add(new csParameterListType("@Service_ID", SqlDbType.BigInt, Service_ID));
            objlist.Add(new csParameterListType("@Service_Date", SqlDbType.VarChar, Service_Date.ToString()));
            objlist.Add(new csParameterListType("@Service_Description", SqlDbType.VarChar, Service_Description.ToString()));
            objlist.Add(new csParameterListType("@Service_Amount", SqlDbType.VarChar, Service_Amount.ToString()));
            objlist.Add(new csParameterListType("@Service_Rate", SqlDbType.VarChar, Service_Rate.ToString()));
            objdal.executespreturnnd("procServices_Provided_Insert", objlist);
        }

        public void updateServices_Provided()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Service_Provided_ID", SqlDbType.BigInt, Service_Provided_ID));
            objlist.Add(new csParameterListType("@Service_ID", SqlDbType.BigInt, Service_ID));
            objlist.Add(new csParameterListType("@Service_Date", SqlDbType.VarChar, Service_Date.ToString()));
            objlist.Add(new csParameterListType("@Service_Description", SqlDbType.VarChar, Service_Description.ToString()));
            objlist.Add(new csParameterListType("@Service_Amount", SqlDbType.VarChar, Service_Amount.ToString()));
            objlist.Add(new csParameterListType("@Service_Rate", SqlDbType.VarChar, Service_Rate.ToString()));
            objdal.executespreturnnd("procServices_Provided_Update", objlist);
        }

        public DataTable Services_Provided_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procServices_Provided_By_Client_ID", objpar);
            return dt;
        }

        public DataTable Services_Provided_View_By_Service_ID(Int32 Service_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_ID", SqlDbType.BigInt, Service_ID));
            dt = objdal.search("procServices_Provided_By_Service_ID", objpar);
            return dt;
        }

        public DataTable Services_Provided_View_By_Service_Provided_ID(Int32 Service_Provided_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provided_ID", SqlDbType.BigInt, Service_Provided_ID));
            dt = objdal.search("procServices_Provided_By_Service_Provided_ID", objpar);
            return dt;
        }

        public DataTable Services_Provided_View_By_Service_Provider_ID(Int32 Service_Provider_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            dt = objdal.search("procServices_Provided_By_Service_Provider_ID", objpar);
            return dt;
        }


        public DataTable Delete_Services_Provided()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Provided_ID", SqlDbType.BigInt, Service_Provided_ID));
            dt = objdal.search("procServices_Provided_Delete", objpar);
            return dt;
        }


        #endregion

    }
}
