using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csSaveFile
    {

        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public string fileName { set; get; }
        public string fileExtension { set; get; }
        public byte[] data { set; get; }
        public string Doc_Title { set; get; }
        public string Doc_Description { set; get; }
        public string Date_Uploaded { set; get; }

        public csSaveFile()
        {

        }

        public void addData_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt,  Client_ID));
            objlist.Add(new csParameterListType("@Data", SqlDbType.VarBinary, data));
            objlist.Add(new csParameterListType("@FileName", SqlDbType.VarChar, fileName.ToString()));
            objlist.Add(new csParameterListType("@FileExtension", SqlDbType.VarChar, fileExtension.ToString()));
            objlist.Add(new csParameterListType("@Doc_Title", SqlDbType.VarChar, Doc_Title.ToString()));
            objlist.Add(new csParameterListType("@Doc_Description", SqlDbType.VarChar, Doc_Description.ToString()));
            objlist.Add(new csParameterListType("@Date_Uploaded", SqlDbType.VarChar, Date_Uploaded.ToString()));
            objdal.executespreturnnd("procData_File_Insert", objlist);
        }

        public DataTable viewDatafilesByClient_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procDataFilesBy_ClientID", objpar);
            return dt;
        }

        public DataTable viewDatafilesByDoc_ID(Int32 Client_Doc_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_Doc_ID", SqlDbType.BigInt, Client_Doc_ID));
            dt = objdal.search("procDataFilesBy_DocID", objpar);
            return dt;
        }
    }
}