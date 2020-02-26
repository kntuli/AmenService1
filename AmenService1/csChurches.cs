using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csChurches
    {
        csDAL objdal = new csDAL();

        public Int32 HQs_ID { set; get; }
        public Int32 Church_ID { set; get; }
        public string Church { set; get; }

        public csChurches()
        { }

        public void addChurches()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            objlist.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            objlist.Add(new csParameterListType("@Church", SqlDbType.VarChar, Church.ToString()));
            objdal.executespreturnnd("procChurches_Insert", objlist);
        }

        public void UpdateChurches()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            objlist.Add(new csParameterListType("@Church", SqlDbType.VarChar, Church.ToString()));
            objdal.executespreturnnd("procChurches_Update", objlist);
        }

        public void DeleteChurches()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            objdal.executespreturnnd("procChurches_Delete", objlist);
        }

        public DataTable viewAllChurches_By_HQs_ID(Int32 HQs_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@HQs_ID", SqlDbType.BigInt, HQs_ID));
            dt = objdal.search("procChurches_By_HQs_ID", objpar);
            return dt;
        }

        public DataTable viewAllChurches_By_Church_ID(Int32 Church_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Church_ID", SqlDbType.BigInt, Church_ID));
            dt = objdal.search("procChurches_By_Church_ID", objpar);
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
            dt = objdal.search("procSearchChurchesByAnyField1", objpar);
            return dt;
        }

    }
}
