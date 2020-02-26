using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csProduct_Sales_Items
    {
        csDAL objdal = new csDAL();

        public int SalesItems_ID { set; get; }
        public int Sale_ID { set; get; }       
        public string Product_Count { set; get; }
        public string Product_No { set; get; }
        public string Product_Name { set; get; }
        public string Product_Description { set; get; }
        public string Product_Value { set; get; }
        public string Discount { set; get; }
        public string Sale_Value { set; get; }


        public csProduct_Sales_Items()
        { }
        public csProduct_Sales_Items(int cSalesItems_ID, 
            int cSale_ID,
            string cProduct_Count,
            string cProduct_No,
            string cProduct_Name,
            string cProduct_Description,
            string cProduct_Value,
            string cDiscount,
            string cSale_Value

            )
        {
            SalesItems_ID = cSalesItems_ID;
            Sale_ID = cSale_ID;
            Product_Count = cProduct_Count;
            Product_No = cProduct_No;
            Product_Name = cProduct_Name;
            Product_Description = cProduct_Description;
            Product_Value = cProduct_Value;
            Discount = cDiscount;
            Sale_Value = cSale_Value;
 

        }

        //--------------Products----------------------------------------

        public void addProductSalesItems()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Sale_ID", SqlDbType.BigInt, Sale_ID));
            objlist.Add(new csParameterListType("@Product_No", SqlDbType.VarChar, Product_No.ToString()));
            objlist.Add(new csParameterListType("@Product_Name", SqlDbType.VarChar, Product_Name.ToString()));
            objlist.Add(new csParameterListType("@Product_Description", SqlDbType.VarChar, Product_Description.ToString()));
            objlist.Add(new csParameterListType("@Product_Value", SqlDbType.VarChar, Product_Value.ToString()));
            objlist.Add(new csParameterListType("@Discount", SqlDbType.VarChar, Discount.ToString()));
            objlist.Add(new csParameterListType("@Sale_Value", SqlDbType.VarChar, Sale_Value.ToString()));
            objdal.executespreturnnd("procProductSalesItems_Insert", objlist);
        }

        public void updateProductSalesItems()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@SalesItems_ID", SqlDbType.BigInt, SalesItems_ID));
            objlist.Add(new csParameterListType("@Product_No", SqlDbType.VarChar, Product_No.ToString()));
            objlist.Add(new csParameterListType("@Product_Name", SqlDbType.VarChar, Product_Name.ToString()));
            objlist.Add(new csParameterListType("@Product_Description", SqlDbType.VarChar, Product_Description.ToString()));
            objlist.Add(new csParameterListType("@Product_Value", SqlDbType.VarChar, Product_Value.ToString()));
            objlist.Add(new csParameterListType("@Discount", SqlDbType.VarChar, Discount.ToString()));
            objlist.Add(new csParameterListType("@Sale_Value", SqlDbType.VarChar, Sale_Value.ToString()));
            objdal.executespreturnnd("procProductSalesItems_Update", objlist);
        }

        public DataTable viewProductSalesItemsBySale_ID(int Sale_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Sale_ID", SqlDbType.BigInt, Sale_ID));
            dt = objdal.search("procProductSalesItemsBy_SaleID", objpar);
            return dt;
        }


        public DataTable viewAllProductSalesItems()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procProductSalesItems_ViewALL");
            return dt;
        }

        public void deleteProductSalesItems(int SalesItems_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@SalesItems_ID", SqlDbType.BigInt, SalesItems_ID));
            objdal.executespreturndr("procProductSalesItems_Delete", objpar);
        }

        public DataTable searchForProductSalesItemsByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procProductSalesItemsSearch_ByAnyField", objpar);
            return dt;
        }

        public DataTable searchForProductSalesItemsByAnyField1(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procProductSalesItems_Search_ByAnyField1", objpar);
            return dt;
        }
    }
}
