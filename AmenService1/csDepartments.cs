using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AmenService1
{
    public class csDepartments
    {
        csDAL objdal = new csDAL();

        public int Department_ID { set; get; }
        public string Department { set; get; }


        public csDepartments()
        { }

        public void updateDepartment()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Department_ID ", SqlDbType.BigInt, Department_ID));
            objlist.Add(new csParameterListType("@Department", SqlDbType.VarChar, Department.ToString()));
            objdal.executespreturnnd("procDepartment_Update", objlist);
        }

        public DataTable viewDepartmentsBy_MainID(Int32 Main_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Main_ID", SqlDbType.BigInt, Main_ID));
            dt = objdal.search("procDepartmentsSubBy_MainID", objpar);
            return dt;
        }
    }
}
