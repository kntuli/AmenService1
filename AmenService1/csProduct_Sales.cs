using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csProduct_Sales
    {
        csDAL objdal = new csDAL();

        public int Sale_ID { set; get; }
        public string Sale_No { set; get; }
        public string Sold_Items { set; get; }
        public string Total_Sale_Value { set; get; }
        public string VAT_Value { set; get; }
        public DateTime Sale_Date { set; get; }
        public string Sold_To { set; get; }
        public string Sold_By { set; get; }
        public string Buyer_Category { set; get; }

        public csProduct_Sales()
        { }
        public csProduct_Sales(int cSale_ID,
            string cSale_No,
            string cSold_Items,
            string cTotal_Sale_Value,
            string cVAT_Value,
            DateTime cSale_Date,
            string cSold_To,
            string cSold_By,
            string cBuyer_Category 

            )
        {
            Sale_ID = cSale_ID;
            Sale_No = cSale_No;
            Sold_Items = cSold_Items;
            Total_Sale_Value = cTotal_Sale_Value;
            VAT_Value = cVAT_Value;
            Sale_Date = cSale_Date;
            Sold_To = cSold_To;
            Sold_By = cSold_By;
            Buyer_Category = cBuyer_Category;
 

        }

        //--------------Products----------------------------------------

        public void addProductSales()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Sale_No", SqlDbType.VarChar, Sale_No.ToString()));
            objlist.Add(new csParameterListType("@Sold_Items", SqlDbType.VarChar, Sold_Items.ToString()));
            objlist.Add(new csParameterListType("@Total_Sale_Value", SqlDbType.VarChar, Total_Sale_Value.ToString()));
            objlist.Add(new csParameterListType("@VAT_Value", SqlDbType.VarChar, VAT_Value.ToString()));
            objlist.Add(new csParameterListType("@Sale_Date", SqlDbType.DateTime, Sale_Date));            
            objlist.Add(new csParameterListType("@Sold_To", SqlDbType.VarChar, Sold_To.ToString()));
            objlist.Add(new csParameterListType("@Sold_By", SqlDbType.VarChar, Sold_By.ToString()));
            objdal.executespreturnnd("procProductSales_Insert", objlist);
        }

        public void addProductSales_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Sale_No", SqlDbType.VarChar, Sale_No.ToString()));
            objdal.executespreturnnd("procProductSalesPre_Insert", objlist);
        }

        public void updateProductSales()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Sale_ID", SqlDbType.BigInt, Sale_ID));
            objlist.Add(new csParameterListType("@Sale_No", SqlDbType.VarChar, Sale_No.ToString()));
            objlist.Add(new csParameterListType("@Sold_Items", SqlDbType.VarChar, Sold_Items.ToString()));
            objlist.Add(new csParameterListType("@Total_Sale_Value", SqlDbType.VarChar, Total_Sale_Value.ToString()));
            objlist.Add(new csParameterListType("@VAT_Value", SqlDbType.VarChar, VAT_Value.ToString()));
            objlist.Add(new csParameterListType("@Sale_Date", SqlDbType.DateTime, Sale_Date));
            objlist.Add(new csParameterListType("@Sold_To", SqlDbType.VarChar, Sold_To.ToString()));
            objlist.Add(new csParameterListType("@Sold_By", SqlDbType.VarChar, Sold_By.ToString()));
            objdal.executespreturnnd("procProductSales_Update", objlist);
        }

        public DataTable viewProductSalesBySale_ID(int Sale_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Sale_ID", SqlDbType.BigInt, Sale_ID));
            dt = objdal.search("procProductSalesBy_SaleID", objpar);
            return dt;
        }

        public DataTable GetSale_IDBySale_No(String Sale_No)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Sale_No", SqlDbType.VarChar, Sale_No.ToString()));
            dt = objdal.search("procSaleID_By_SaleNo", objpar);
            return dt;
        }

        public DataTable viewAllProductSales()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procProductSales_ViewALL");
            return dt;
        }

        public void deleteProductSales(int Sale_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Sale_ID", SqlDbType.BigInt, Sale_ID));
            objdal.executespreturndr("procProductSales_Delete", objpar);
        }

        public DataTable searchForProductSalesByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procProductSalesSearch_ByAnyField", objpar);
            return dt;
        }

        public DataTable searchForProductSalesByAnyField1(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procProductSales_Search_ByAnyField1", objpar);
            return dt;
        }

 
    }
}
