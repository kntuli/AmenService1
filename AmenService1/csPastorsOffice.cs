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
    public class csPastorsOffice
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 User_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Use_Name { set; get; }

        public csPastorsOffice()
        { }

        public DataTable viewPastors_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPastors_View_By_Client_ID", objlist);
            return dt;
        }

     
    }
}
