using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csSpiritual_Food
    {

        csDAL objdal = new csDAL();

        public int Spiritual_Food_ID { set; get; }
        public int Profile_ID { set; get; }
        public string Food_Date { set; get; }
        public string Food_Number { set; get; }
        public string Food_Type { set; get; }
        public string Food_Name { set; get; }
        public string Food_Description { set; get; }
        public string Title_By { set; get; }
        public string Food_Source { set; get; }
        public string Food_Duration { set; get; }
        public string Food_HowMuch { set; get; }
        public string Food_Impact { set; get; }
        public string Food_Share { set; get; }


        public csSpiritual_Food()
        { }
        public csSpiritual_Food(
            int cSpiritual_Food_ID,
            int cProfile_ID,
            string cFood_Number,
            string cFood_Date,
            string cFood_Type,
            string cFood_Name,
            string cFood_Description,
            string cTitle_By,
            string cFood_Source,
            string cFood_Duration,
            string cFood_HowMuch,
            string cFood_Impact,
            string cFood_Share
            )
        {
            Spiritual_Food_ID = cSpiritual_Food_ID;
            Profile_ID = cProfile_ID;
            Food_Number = cFood_Number;
            Food_Date = cFood_Date;
            Food_Type = cFood_Type;
            Food_Name = cFood_Name;
            Food_Description = cFood_Description;
            Title_By = cTitle_By;
            Food_Source = cFood_Source;
            Food_Duration = cFood_Duration;
            Food_HowMuch = cFood_HowMuch;
            Food_Impact = cFood_Impact;
            Food_Share = cFood_Share;

        }

        public void add_Spiritual_Food()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Food_Date", SqlDbType.VarChar, Food_Date));
            objlist.Add(new csParameterListType("@Food_Type", SqlDbType.VarChar, Food_Type.ToString()));
            objlist.Add(new csParameterListType("@Food_Name", SqlDbType.VarChar, Food_Name.ToString()));
            objlist.Add(new csParameterListType("@Title_By", SqlDbType.VarChar, Title_By.ToString()));
            objlist.Add(new csParameterListType("@Food_Description", SqlDbType.VarChar, Food_Description.ToString()));
            objlist.Add(new csParameterListType("@Food_Source", SqlDbType.VarChar, Food_Source.ToString()));
            objlist.Add(new csParameterListType("@Food_Duration", SqlDbType.VarChar, Food_Duration.ToString()));
            objlist.Add(new csParameterListType("@Food_HowMuch", SqlDbType.VarChar, Food_HowMuch.ToString()));
            objlist.Add(new csParameterListType("@Food_Impact", SqlDbType.VarChar, Food_Impact.ToString()));
            objlist.Add(new csParameterListType("@Food_Share", SqlDbType.VarChar, Food_Share.ToString()));
            objdal.executespreturnnd("procSpiritual_Food_Insert", objlist);
        }

        public void update_Spiritual_Food()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Spiritual_Food_ID", SqlDbType.BigInt, Spiritual_Food_ID));
            objlist.Add(new csParameterListType("@Food_Date", SqlDbType.Date, Food_Date));
            objlist.Add(new csParameterListType("@Food_Type", SqlDbType.VarChar, Food_Type.ToString()));
            objlist.Add(new csParameterListType("@Food_Name", SqlDbType.VarChar, Food_Name.ToString()));
            objlist.Add(new csParameterListType("@Food_Description", SqlDbType.VarChar, Food_Description.ToString()));
            objlist.Add(new csParameterListType("@Title_By", SqlDbType.VarChar, Title_By.ToString()));
            objlist.Add(new csParameterListType("@Food_Source", SqlDbType.VarChar, Food_Source.ToString()));
            objlist.Add(new csParameterListType("@Food_Duration", SqlDbType.VarChar, Food_Duration.ToString()));
            objlist.Add(new csParameterListType("@Food_HowMuch", SqlDbType.VarChar, Food_HowMuch.ToString()));
            objlist.Add(new csParameterListType("@Food_Impact", SqlDbType.VarChar, Food_Impact.ToString()));
            objlist.Add(new csParameterListType("@Food_Share", SqlDbType.VarChar, Food_Share.ToString()));
            objdal.executespreturnnd("procSpiritual_Food_Update", objlist);
        }

        public DataTable viewSpiritual_Food_By_Profile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procSpiritual_Food_By_ProfileID", objpar);
            return dt;
        }

        public DataTable viewSpiritual_Food_By_Profile_ID0(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procSpiritual_Food_By_Profile_ID0", objpar);
            return dt;
        }

        public DataTable viewSpiritual_Food_By_Food_ID(int Spiritual_Food_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Spiritual_Food_ID", SqlDbType.BigInt, Spiritual_Food_ID));
            dt = objdal.search("procSpiritual_Food_By_Spiritual_FoodID", objpar);
            return dt;
        }

        public void addSpiritual_Food_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Food_Number", SqlDbType.VarChar, Food_Number.ToString()));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objdal.executespreturnnd("procSpiritual_FoodPre_Insert", objlist);
        }

        public DataTable viewSpiritual_FoodID_BySpiritual_Food_Number(string Food_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Food_Number", SqlDbType.VarChar, Food_Number.ToString()));
            dt = objdal.search("procSpiritual_FoodID_By_FoodNumber", objpar);
            return dt;
        }

        public DataTable searchForSpiritual_FoodByAnyField1(string sVariable, int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchSpiritual_FoodByAnyField1", objpar);
            return dt;
        }

        //--------------------Financial Items---------------------------


        //public void add_Spiritual_Food_Items()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Financial_Items", SqlDbType.VarChar, Financial_Items.ToString()));
        //    objdal.executespreturnnd("procFinancial_Items_Insert", objlist);
        //}

        //public DataTable viewAllSpiritual_Food_Item()
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    dt = objdal.search("procFinancial_Items");
        //    return dt;
        //}

     
    }

}
