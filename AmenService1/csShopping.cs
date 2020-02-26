using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csShopping
    {


        public int Shopping_ID { set; get; }
        public int Profile_ID { set; get; }
        public string Item_Date { set; get; }
        public string Item_Number { set; get; }
        public string Item_Category { set; get; }
        public string Item_Name { set; get; }
        public string Item_Description { set; get; }
        public string Item_Source { set; get; }
        public string Item_HowMuch { set; get; }
        public string Item_HaveIt { set; get; }


        public csShopping()
        { }
        public csShopping(
            int cShopping_ID,
            int cProfile_ID,
            string cItem_Number,
            string cItem_Date,
            string cItem_Category,
            string cItem_Name,
            string cItem_Description,
            string cItem_Source,
            string cItem_Duration,
            string cItem_HowMuch,
            string cItem_HaveIt
            )
        {
            Shopping_ID = cShopping_ID;
            Profile_ID = cProfile_ID;
            Item_Number = cItem_Number;
            Item_Date = cItem_Date;
            Item_Category = cItem_Category;
            Item_Name = cItem_Name;
            Item_Description = cItem_Description;
            Item_Source = cItem_Source;
            Item_HowMuch = cItem_HowMuch;
            Item_HaveIt = cItem_HaveIt;
        }

        public void add_Shopping()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Item_Date", SqlDbType.VarChar, Item_Date));
            objlist.Add(new csParameterListType("@Item_Category", SqlDbType.VarChar, Item_Category.ToString()));
            objlist.Add(new csParameterListType("@Item_Name", SqlDbType.VarChar, Item_Name.ToString()));
            objlist.Add(new csParameterListType("@Item_Description", SqlDbType.VarChar, Item_Description.ToString()));
            objlist.Add(new csParameterListType("@Item_Source", SqlDbType.VarChar, Item_Source.ToString()));
            objlist.Add(new csParameterListType("@Item_HowMuch", SqlDbType.VarChar, Item_HowMuch.ToString()));
            objlist.Add(new csParameterListType("@Item_HaveIt", SqlDbType.VarChar, Item_HaveIt.ToString()));
            objdal.executespreturnnd("procShopping_Insert", objlist);
        }

        public void update_Shopping()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopping_ID", SqlDbType.BigInt, Shopping_ID));
            objlist.Add(new csParameterListType("@Item_Date", SqlDbType.Date, Item_Date));
            objlist.Add(new csParameterListType("@Item_Category", SqlDbType.VarChar, Item_Category.ToString()));
            objlist.Add(new csParameterListType("@Item_Name", SqlDbType.VarChar, Item_Name.ToString()));
            objlist.Add(new csParameterListType("@Item_Description", SqlDbType.VarChar, Item_Description.ToString()));
            objlist.Add(new csParameterListType("@Item_Source", SqlDbType.VarChar, Item_Source.ToString()));
            objlist.Add(new csParameterListType("@Item_HowMuch", SqlDbType.VarChar, Item_HowMuch.ToString()));
            objlist.Add(new csParameterListType("@Item_HaveIt", SqlDbType.VarChar, Item_HaveIt.ToString()));
            objdal.executespreturnnd("procShopping_Update", objlist);
        }

        public DataTable viewShopping_By_Profile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procShopping_By_ProfileID", objpar);
            return dt;
        }

        public DataTable viewShopping_By_Profile_ID0(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procShopping_By_Profile_ID0", objpar);
            return dt;
        }

        public DataTable viewShopping_By_Shopping_ID(int Shopping_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Shopping_ID", SqlDbType.BigInt, Shopping_ID));
            dt = objdal.search("procShopping_By_ShoppingID", objpar);
            return dt;
        }

        public void addShopping_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_Number", SqlDbType.VarChar, Item_Number.ToString()));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procShoppingPre_Insert", objlist);
        }

        public DataTable viewShoppingID_ByItem_Number(string Item_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_Number", SqlDbType.VarChar, Item_Number.ToString()));
            dt = objdal.search("procShoppingID_By_ItemNumber", objpar);
            return dt;
        }

        public DataTable searchForShoppingByAnyField1(string sVariable, int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchShoppingByAnyField1", objpar);
            return dt;
        }

    

    }

}
