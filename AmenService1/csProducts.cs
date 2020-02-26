using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csProducts
    {
        csDAL objdal = new csDAL();

        public int Product_ID { set; get; }
        public string Product_Number { set; get; }
        public string Product_Name { set; get; }
        public string Description { set; get; }
        public string SerialNo { set; get; }
        public string SoftwareVersion { set; get; }
        public string ProductSize { set; get; }
        public string ProductLength { set; get; }
        public string ProductDepth { set; get; }
        public string ProductHeight { set; get; }
        public string ProductWeight { set; get; }
        public string ProductPower { set; get; }
        public string ProductFrequency { set; get; }
        public string Product_Value { set; get; }
        public DateTime Reg_Date { set; get; }

        public csProducts()
        { }
        public csProducts(int cProduct_ID,
            string cProduct_Number,
            string cProduct_Name,
            string cDescription,
            string cSerialNo,
            string cSoftwareVersion,
            string cProductSize,
            string cProductLength,
            string cProductDepth,
            string cProductHeight,
            string cProductWeight,
            string cProductPower,
            string cProductFrequency,
            string cProduct_Value,
            DateTime cReg_Date

            )
        {
            Product_ID = cProduct_ID;
            Product_Number = cProduct_Number;
            Product_Name = cProduct_Name;
            Description = cDescription;
            SerialNo = cSerialNo;
            SoftwareVersion = cSoftwareVersion;
            ProductLength = cProductLength;
            ProductDepth = cProductDepth;
            ProductHeight = cProductHeight;
            ProductWeight = cProductWeight;
            ProductPower = cProductPower;
            ProductFrequency = cProductFrequency;
            Product_Value = cProduct_Value;
            Reg_Date = cReg_Date;

        }

        //--------------Products----------------------------------------

        public void addProduct()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Product_Number", SqlDbType.VarChar, Product_Number.ToString()));
            objlist.Add(new csParameterListType("@Product_Name", SqlDbType.VarChar, Product_Name.ToString()));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
            objlist.Add(new csParameterListType("@SerialNo", SqlDbType.VarChar, SerialNo.ToString()));
            objlist.Add(new csParameterListType("@SoftwareVersion", SqlDbType.VarChar, SoftwareVersion.ToString()));
            objlist.Add(new csParameterListType("@ProductSize", SqlDbType.VarChar, ProductSize.ToString()));
            objlist.Add(new csParameterListType("@ProductLength", SqlDbType.VarChar, ProductLength.ToString()));
            objlist.Add(new csParameterListType("@ProductDepth", SqlDbType.VarChar, ProductDepth.ToString()));
            objlist.Add(new csParameterListType("@ProductHeight", SqlDbType.VarChar, ProductHeight.ToString()));
            objlist.Add(new csParameterListType("@ProductWeight", SqlDbType.VarChar, ProductWeight.ToString()));
            objlist.Add(new csParameterListType("@ProductPower", SqlDbType.VarChar, ProductPower.ToString()));
            objlist.Add(new csParameterListType("@ProductFrequency", SqlDbType.VarChar, ProductFrequency.ToString()));
            objlist.Add(new csParameterListType("@Product_Value", SqlDbType.VarChar, Product_Value.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.DateTime, Reg_Date));
            objdal.executespreturnnd("procProduct_Insert", objlist);
        }

        public void updateProduct()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            objlist.Add(new csParameterListType("@Product_Name", SqlDbType.VarChar, Product_Name.ToString()));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
            objlist.Add(new csParameterListType("@SerialNo", SqlDbType.VarChar, SerialNo.ToString()));
            objlist.Add(new csParameterListType("@SoftwareVersion", SqlDbType.VarChar, SoftwareVersion.ToString()));
            objlist.Add(new csParameterListType("@ProductSize", SqlDbType.VarChar, ProductSize.ToString()));
            objlist.Add(new csParameterListType("@ProductLength", SqlDbType.VarChar, ProductLength.ToString()));
            objlist.Add(new csParameterListType("@ProductDepth", SqlDbType.VarChar, ProductDepth.ToString()));
            objlist.Add(new csParameterListType("@ProductHeight", SqlDbType.VarChar, ProductHeight.ToString()));
            objlist.Add(new csParameterListType("@ProductWeight", SqlDbType.VarChar, ProductWeight.ToString()));
            objlist.Add(new csParameterListType("@ProductPower", SqlDbType.VarChar, ProductPower.ToString()));
            objlist.Add(new csParameterListType("@ProductFrequency", SqlDbType.VarChar, ProductFrequency.ToString()));
            objlist.Add(new csParameterListType("@Product_Value", SqlDbType.VarChar, Product_Value.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.DateTime, Reg_Date));
            objdal.executespreturnnd("procProduct_Update", objlist);
        }

        public DataTable viewProductByProduct_ID(int Product_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            dt = objdal.search("procProductBy_ProductID", objpar);
            return dt;
        }

  

        public DataTable viewAllProducts()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procProducts_ViewALL");
            return dt;
        }

        public void deleteProduct(int Product_ID)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            objdal.executespreturndr("procProduct_Delete", objpar);
        }

        public DataTable searchForProductByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procProductSearch_ByAnyField", objpar);
            return dt;
        }

        public DataTable searchForProductByAnyField1(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procProducts_Search_ByAnyField1", objpar);
            return dt;
        }
    }
}
