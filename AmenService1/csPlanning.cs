using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace AmenService1
{
    public class csPlanning
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 User_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Use_Name { set; get; }
        public string Planning1 { set; get; }
        public string Planning2 { set; get; }
        public string Planning3 { set; get; }
        public string Planning4 { set; get; }
        public string Planning5 { set; get; }
        public string Planning6 { set; get; }
        public string Planning7 { set; get; }
        public string Planning8 { set; get; }


        public csPlanning()
        { }

        public DataTable viewPlanning_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPersonal_Planning_By_Profile_ID", objlist);
            return dt;
        }

        public void addPlanning()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Planning1", SqlDbType.VarChar, Planning1.ToString()));
            objlist.Add(new csParameterListType("@Planning2", SqlDbType.VarChar, Planning2.ToString()));
            objlist.Add(new csParameterListType("@Planning3", SqlDbType.VarChar, Planning3.ToString()));
            objlist.Add(new csParameterListType("@Planning4", SqlDbType.VarChar, Planning4.ToString()));
            objlist.Add(new csParameterListType("@Planning5", SqlDbType.VarChar, Planning5.ToString()));
            objlist.Add(new csParameterListType("@Planning6", SqlDbType.VarChar, Planning6.ToString()));
            objlist.Add(new csParameterListType("@Planning7", SqlDbType.VarChar, Planning7.ToString()));
            objlist.Add(new csParameterListType("@Planning8", SqlDbType.VarChar, Planning8.ToString()));
            objdal.executespreturnnd("procPersonal_Planning_Insert", objlist);
        }

        public void updatePlanning()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Planning1", SqlDbType.VarChar, Planning1.ToString()));
            objlist.Add(new csParameterListType("@Planning2", SqlDbType.VarChar, Planning2.ToString()));
            objlist.Add(new csParameterListType("@Planning3", SqlDbType.VarChar, Planning3.ToString()));
            objlist.Add(new csParameterListType("@Planning4", SqlDbType.VarChar, Planning4.ToString()));
            objlist.Add(new csParameterListType("@Planning5", SqlDbType.VarChar, Planning5.ToString()));
            objlist.Add(new csParameterListType("@Planning6", SqlDbType.VarChar, Planning6.ToString()));
            objlist.Add(new csParameterListType("@Planning7", SqlDbType.VarChar, Planning7.ToString()));
            objlist.Add(new csParameterListType("@Planning8", SqlDbType.VarChar, Planning8.ToString()));
            objdal.executespreturnnd("procPersonal_Planning_Update", objlist);
        }
    }
}
