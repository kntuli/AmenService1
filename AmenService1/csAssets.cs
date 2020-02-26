using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AmenService1
{
    public class csAssets
    {
        csDAL objdal = new csDAL();
        //-------------Pics-------------------
        public Int32 Asset_ID { set; get; }
        public Int32 Client_ID { set; get; }
        public string Asset_Name { set; get; }
        public string Asset_Number { set; get; }
        public string Asset_Description { set; get; }
        public string Reg_Date { set; get; }

        public Int32 Category_ID { set; get; }
        public string Model_No { set; get; }
        public string Serial_No { set; get; }
        public string Manufacturer { set; get; }

        public string Last_Update_Date { set; get; }
        public string ShowOrHide { set; get; }


        public string Category { set; get; }


        public string Condition { set; get; }
        public string Unit_Value { set; get; }
        public string Qty { set; get; }
        public string Total_Value { set; get; }

        public Int32 Assigned_To_ID { set; get; }
        public Int32 Department_ID { set; get; }
        public string Room { set; get; }
        public string Assigned_Date { set; get; }
        public string LastUpdate_Date { set; get; }

        public string Purchase_Date { set; get; }
        public string Purchase_Price { set; get; }
        public string Supplier { set; get; }
        public string Warranty_Expiration { set; get; }
        public string Insurance_Details { set; get; }
        public string Insurance_Renewal_Date { set; get; }

        public string Leasing_Firm { set; get; }
        public string Lease_Amount { set; get; }
        public string Lease_Type { set; get; }
        public string Lease_Start_Date { set; get; }
        public string Lease_End_Date { set; get; }

        public Int32 Service_Repair_ID { set; get; }
        //public string Category { set; get; }
        public Int32 Service_ID { set; get; }
        public Int32 Service_Provider_ID { set; get; }
        public string Date { set; get; }
        public string Description { set; get; }
        public string Amount { set; get; }
        public string Parts_Replaced { set; get; }
        public string Next_Service_Date { set; get; }


        public Int32 Lending_ID { set; get; }
        public string Lending_Date { set; get; }
        public string Lending_Description { set; get; }
        public string Lending_To { set; get; }
        public string Lending_Period { set; get; }
        public string Lending_Bring_Back_Date { set; get; }
        public string Lending_Condition_OnBringBack { set; get; }
        public string Lending_Condition_Description_OnBringBack { set; get; }
        public string Lending_IsBroughtBack { set; get; }


        public csAssets()
        { }


        #region Assets
        public void addAssets()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Asset_Number", SqlDbType.VarChar, Asset_Number.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objdal.executespreturnnd("procAssets_Insert", objlist);
        }

        public void updateAssets()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.VarChar, Category_ID.ToString()));
            objlist.Add(new csParameterListType("@Asset_Name", SqlDbType.VarChar, Asset_Name.ToString()));
            objlist.Add(new csParameterListType("@Asset_Description", SqlDbType.VarChar, Asset_Description.ToString()));
            objlist.Add(new csParameterListType("@Model_No", SqlDbType.VarChar, Model_No.ToString()));
            objlist.Add(new csParameterListType("@Serial_No", SqlDbType.VarChar, Serial_No.ToString()));
            objlist.Add(new csParameterListType("@Manufacturer", SqlDbType.VarChar, Manufacturer.ToString()));
            objlist.Add(new csParameterListType("@Last_Update_Date", SqlDbType.VarChar, Last_Update_Date.ToString()));
            objdal.executespreturnnd("procAssets_Update", objlist);
        }

        public DataTable Assets_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procAssets_By_Client_ID", objpar);
            return dt;
        }

        public DataTable Assets_View_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_By_Asset_ID", objpar);
            return dt;
        }

        public DataTable Assets_View_Pre_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Pre_By_Asset_ID", objpar);
            return dt;
        }

        public DataTable Assets_View_By_Asset_Number(string Asset_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_Number", SqlDbType.VarChar, Asset_Number));
            dt = objdal.search("procAssets_By_Asset_Number", objpar);
            return dt;
        }

        public DataTable Assets_View_By_Client_ID_and_Asset_Date(Int32 Client_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procAssets_By_Client_ID_Date", objpar);
            return dt;
        }

        public DataTable Assets_View_By_Asset_Date(string Asset_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_Date", SqlDbType.VarChar, Asset_Date));
            dt = objdal.search("procAssets_By_Asset_Date", objpar);
            return dt;
        }

        public DataTable Assets_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAssets_View_All");
            return dt;
        }


        public DataTable Delete_Assets()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Delete", objpar);
            return dt;
        }

        public DataTable searchForAssetsAnyField1(string sVariable, Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procAssets_SearchByAnyField1", objpar);
            return dt;
        }

        #endregion

        #region Assets_Categories
        public void addAssets_Categories()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objdal.executespreturnnd("procAssets_Categories_Insert", objlist);
        }

        public void updateAssets_Categories()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objdal.executespreturnnd("procAssets_Categories_Update", objlist);
        }

        public DataTable Assets_Categories_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procAssets_Categories_By_Client_ID", objpar);
            return dt;
        }

        public DataTable Assets_Categories_View_By_Category_ID(Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procAssets_Categories_By_Category_ID", objpar);
            return dt;
        }

        public DataTable Delete_Assets_Categories()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procAssets_Categories_Delete", objpar);
            return dt;
        }

        #endregion

        #region Assets_Quantity_Value

        public void updateAssets_Quantity_Value()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            objlist.Add(new csParameterListType("@Condition", SqlDbType.VarChar, Condition.ToString()));
            objlist.Add(new csParameterListType("@Unit_Value", SqlDbType.VarChar, Unit_Value.ToString()));
            objlist.Add(new csParameterListType("@Qty", SqlDbType.VarChar, Qty.ToString()));
            objlist.Add(new csParameterListType("@Total_Value", SqlDbType.VarChar, Total_Value.ToString()));
            objdal.executespreturnnd("procAssets_Quantity_Value_Update", objlist);
        }

        public DataTable Assets_Quantity_Value_View_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Quantity_Value_By_Asset_ID", objpar);
            return dt;
        }

        #endregion

        #region Assets_Location

        public void updateAssets_Location()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            objlist.Add(new csParameterListType("@Assigned_To_ID", SqlDbType.BigInt, Assigned_To_ID));
            objlist.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
            objlist.Add(new csParameterListType("@Room", SqlDbType.VarChar, Room.ToString()));
            objlist.Add(new csParameterListType("@Assigned_Date", SqlDbType.VarChar, Assigned_Date.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procAssets_Location_Update", objlist);
        }

        public DataTable Assets_Location_View_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Location_By_Asset_ID", objpar);
            return dt;
        }

        #endregion

        #region Assets_Purchase_Info

        public void updateAssets_Purchase_Info()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            objlist.Add(new csParameterListType("@Purchase_Date", SqlDbType.VarChar, Purchase_Date));
            objlist.Add(new csParameterListType("@Purchase_Price", SqlDbType.VarChar, Purchase_Price));
            objlist.Add(new csParameterListType("@Supplier", SqlDbType.VarChar, Supplier.ToString()));
            objlist.Add(new csParameterListType("@Warranty_Expiration", SqlDbType.VarChar, Warranty_Expiration.ToString()));
            objlist.Add(new csParameterListType("@Insurance_Details", SqlDbType.VarChar, Insurance_Details.ToString()));
            objlist.Add(new csParameterListType("@Insurance_Renewal_Date", SqlDbType.VarChar, Insurance_Renewal_Date.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procAssets_Purchase_Info_Update", objlist);
        }

        public DataTable Assets_Purchase_Info_View_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Purchase_Info_By_Asset_ID", objpar);
            return dt;
        }

        #endregion

        #region Assets_Lease_Info

        public void updateAssets_Lease_Info()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            objlist.Add(new csParameterListType("@Leasing_Firm", SqlDbType.VarChar, Leasing_Firm));
            objlist.Add(new csParameterListType("@Lease_Amount", SqlDbType.VarChar, Lease_Amount));
            objlist.Add(new csParameterListType("@Lease_Type", SqlDbType.VarChar, Lease_Type.ToString()));
            objlist.Add(new csParameterListType("@Lease_Start_Date", SqlDbType.VarChar, Lease_Start_Date.ToString()));
            objlist.Add(new csParameterListType("@Lease_End_Date", SqlDbType.VarChar, Lease_End_Date.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procAssets_Lease_Info_Update", objlist);
        }

        public DataTable Assets_Lease_Info_View_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Lease_Info_By_Asset_ID", objpar);
            return dt;
        }

        #endregion

        #region Services_Repairs

        public void addServices_Repairs()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            objlist.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
            objlist.Add(new csParameterListType("@Amount", SqlDbType.VarChar, Amount.ToString()));
            objlist.Add(new csParameterListType("@Parts_Replaced", SqlDbType.VarChar, Parts_Replaced.ToString()));
            objlist.Add(new csParameterListType("@Next_Service_Date", SqlDbType.VarChar, Next_Service_Date.ToString()));
            objdal.executespreturnnd("procAssets_Services_Repairs_Insert", objlist);
        }

        public void updateServices_Repairs()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Service_Repair_ID", SqlDbType.BigInt, Service_Repair_ID));
            objlist.Add(new csParameterListType("@Service_Provider_ID", SqlDbType.BigInt, Service_Provider_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
            objlist.Add(new csParameterListType("@Amount", SqlDbType.VarChar, Amount.ToString()));
            objlist.Add(new csParameterListType("@Parts_Replaced", SqlDbType.VarChar, Parts_Replaced.ToString()));
            objlist.Add(new csParameterListType("@Next_Service_Date", SqlDbType.VarChar, Next_Service_Date.ToString()));
            objdal.executespreturnnd("procAssets_Services_Repairs_Update", objlist);
        }

        public DataTable Services_Repairs_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procAssets_Services_RepairsBy_Client_ID", objpar);
            return dt;
        }

        public DataTable Services_Repairs_View_By_Service_ID(Int32 Service_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_ID", SqlDbType.BigInt, Service_ID));
            dt = objdal.search("procAssets_Services_Repairs_By_Service_ID", objpar);
            return dt;
        }

        public DataTable Services_Repairs_View_By_Service_Repair_ID(Int32 Service_Repair_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Repair_ID", SqlDbType.BigInt, Service_Repair_ID));
            dt = objdal.search("procAssets_Services_Repairs_By_Service_Repair_ID", objpar);
            return dt;
        }

        public DataTable Services_Repairs_View_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Services_Repairs_By_Asset_ID", objpar);
            return dt;
        }


        public DataTable Delete_Services_Repairs()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Service_Repair_ID", SqlDbType.BigInt, Service_Repair_ID));
            dt = objdal.search("procAssets_Services_Repairs_Delete", objpar);
            return dt;
        }


        #endregion

        #region Assets_Lending

        public void addAssets_Lending()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            objlist.Add(new csParameterListType("@Lending_Date", SqlDbType.VarChar, Lending_Date.ToString()));
            objlist.Add(new csParameterListType("@Lending_Description", SqlDbType.VarChar, Lending_Description.ToString()));
            objlist.Add(new csParameterListType("@Lending_To", SqlDbType.VarChar, Lending_To.ToString()));
            objlist.Add(new csParameterListType("@Lending_Period", SqlDbType.VarChar, Lending_Period.ToString()));
            objlist.Add(new csParameterListType("@Lending_Bring_Back_Date", SqlDbType.VarChar, Lending_Bring_Back_Date.ToString()));
            objlist.Add(new csParameterListType("@Lending_Condition_OnBringBack", SqlDbType.VarChar, Lending_Condition_OnBringBack.ToString()));
            objlist.Add(new csParameterListType("@Lending_Condition_Description_OnBringBack", SqlDbType.VarChar, Lending_Condition_Description_OnBringBack.ToString()));
            objlist.Add(new csParameterListType("@Lending_IsBroughtBack", SqlDbType.VarChar, Lending_IsBroughtBack.ToString()));
            objdal.executespreturnnd("procAssets_Lending_Insert", objlist);
        }

        public void updateAssets_Lending()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Lending_ID", SqlDbType.BigInt, Lending_ID));
            objlist.Add(new csParameterListType("@Lending_Date", SqlDbType.VarChar, Lending_Date.ToString()));
            objlist.Add(new csParameterListType("@Lending_Description", SqlDbType.VarChar, Lending_Description.ToString()));
            objlist.Add(new csParameterListType("@Lending_To", SqlDbType.VarChar, Lending_To.ToString()));
            objlist.Add(new csParameterListType("@Lending_Bring_Back_Date", SqlDbType.VarChar, Lending_Bring_Back_Date.ToString()));
            objlist.Add(new csParameterListType("@Lending_Condition_OnBringBack", SqlDbType.VarChar, Lending_Condition_OnBringBack.ToString()));
            objlist.Add(new csParameterListType("@Lending_Condition_Description_OnBringBack", SqlDbType.VarChar, Lending_Condition_Description_OnBringBack.ToString()));
            objlist.Add(new csParameterListType("@Lending_IsBroughtBack", SqlDbType.VarChar, Lending_IsBroughtBack.ToString()));
            objdal.executespreturnnd("procAssets_Lending_Update", objlist);
        }

        public DataTable Assets_Lending_View_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procAssets_Lending_By_Client_ID", objpar);
            return dt;
        }

        public DataTable Assets_Lending_View_By_Client_ID_and_Lending_Date(Int32 Client_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procAssets_Lending_By_Client_ID_Date", objpar);
            return dt;
        }

        public DataTable Assets_Lending_View_By_Lending_ID(Int32 Lending_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Lending_ID", SqlDbType.BigInt, Lending_ID));
            dt = objdal.search("procAssets_Lending_By_Lending_ID", objpar);
            return dt;
        }

        public DataTable Assets_Lending_View_By_Asset_ID(Int32 Asset_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Asset_ID", SqlDbType.BigInt, Asset_ID));
            dt = objdal.search("procAssets_Lending_By_Asset_ID", objpar);
            return dt;
        }

        public DataTable Delete_Assets_Lending()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Lending_ID", SqlDbType.BigInt, Lending_ID));
            dt = objdal.search("procAssets_Lending_Delete", objpar);
            return dt;
        }


        #endregion
    }
}