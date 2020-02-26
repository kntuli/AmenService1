using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Data.SqlClient;

namespace AmenService1
{
    public class csDocuments
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Num { set; get; }
        public Int32 Document_ID { set; get; }
        public string Category { set; get; }
        public string Document_Date { set; get; }
        public string Document_Name { set; get; }
        public string Document_Title { set; get; }
        public string Document_Description { set; get; }
        public Int32 Download_Count { set; get; }
        public string File_Name { set; get; }
        public string File_Size { set; get; }
        public string File_Type { set; get; }
        public string ShowOrHide { set; get; }
        public byte[] blobdata { set; get; }
        public string base64data { set; get; }
        public Int32 Category_ID { set; get; }

        public Int32 Profile_ID { set; get; }
        public string LastUpdate_Date { set; get; }
        
        public Int32 Sermon_ID { set; get; }
        public string Sermon_Category { set; get; }
        public string Sermon_Date { set; get; }
        public string Sermon_Title { set; get; }
        public string Series_Title { set; get; }
        public string Sermon_Content { set; get; }
        public string Sermon_Number { set; get; }
        
        public Int32 Counselling_ID { set; get; }
        public string Counselling_Category { set; get; }
        public string Counselling_Date { set; get; }
        public string Counselling_Title { set; get; }
        public Int32 Counselling_Profile_ID { set; get; }
        public string Counselling_Full_Name { set; get; }
        public string Counselling_Contacts { set; get; }
        public string Counselling_Content { set; get; }
        public string Counselling_Number { set; get; }

        public Int32 Note_ID { set; get; }
        public string Note_Date { set; get; }
        public string Note_Title { set; get; }
        public string Note_Content { set; get; }
        public string Note_Number { set; get; }

        public string From_Date { set; get; }
        public string To_Date { set; get; }

        public Int32 Vision_ID { set; get; }
        public string Vision_Date { set; get; }
        public string Vision_Title { set; get; }
        public string Vision_Content { set; get; }

        public Int32 Diary_ID { set; get; }
        public string Diary_Date { set; get; }
        public string Diary_Times { set; get; }
        public string Appointment { set; get; }
        public string ToDo { set; get; }
        public string Status { set; get; }

        public csDocuments()
        { }


        #region Documents


        public void addDocuments()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@Document_Description", SqlDbType.VarChar, Document_Description.ToString()));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objlist.Add(new csParameterListType("@ShowOrHide", SqlDbType.VarChar, ShowOrHide.ToString()));
            objdal.executespreturnnd("procDocuments_Insert", objlist);
        }

        public void addDocumentz2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@File_Name", SqlDbType.VarChar, File_Name.ToString()));
            objlist.Add(new csParameterListType("@File_Size", SqlDbType.VarChar, File_Size.ToString()));
            objlist.Add(new csParameterListType("@File_Type", SqlDbType.VarChar, File_Type.ToString()));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objlist.Add(new csParameterListType("@base64data", SqlDbType.VarChar, base64data));
            objdal.executespreturnnd("procDocuments_Insert2", objlist);
        }

        public void addDocumentz3()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@File_Name", SqlDbType.VarChar, File_Name.ToString()));
            objlist.Add(new csParameterListType("@File_Size", SqlDbType.VarChar, File_Size.ToString()));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objlist.Add(new csParameterListType("@Document_Description", SqlDbType.VarChar, Document_Description.ToString()));
            objdal.executespreturnnd("procDocuments_Insert2", objlist);
        }

        public void updateDocumentz2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objdal.executespreturnnd("procDocuments_Update2", objlist);
        }

        public void updateDocuments_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@File_Name", SqlDbType.VarChar, File_Name.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procDocument_File_Update", objlist);
        }

        public void updateDocuments()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@Document_Description", SqlDbType.VarChar, Document_Description.ToString()));
            objlist.Add(new csParameterListType("@ShowOrHide", SqlDbType.VarChar, ShowOrHide.ToString()));
            objdal.executespreturnnd("procDocuments_Update", objlist);
        }

        public void updateDocuments_Download_Count()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objdal.executespreturnnd("procDocuments_Download_Count_Update", objlist);
        }

        public DataTable viewDocuments_ByClient_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procDocuments_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewDocuments_ByClient_ID_and_Category(Int32 Client_ID, String Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_By_Client_ID_and_Category", objpar);
            return dt;
        }

        public DataTable viewDocuments_ByClient_ID_and_Category2(Int32 Client_ID, String Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_By_Client_ID_and_Category2", objpar);
            return dt;
        }

        public DataTable viewDocuments_ByDocument_ID(Int32 Document_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            dt = objdal.search("procDocuments_By_Document_ID", objpar);
            return dt;
        }

        public DataTable viewDocuments_with_data_ByDocument_ID(Int32 Document_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            dt = objdal.search("procDocuments_with_data_By_Document_ID", objpar);
            return dt;
        }

        public DataTable viewDocuments_with_base64data_ByDocument_ID(Int32 Document_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            dt = objdal.search("procDocuments_with_base64data_By_Document_ID", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_ViewAll_By_Category", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory_and_DocName(string Category, string Document_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objpar.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            dt = objdal.search("procDocuments_ViewAll_By_Category_and_DocName", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory_Public(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_ViewAll_Public", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory_Public_File(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_ViewAll_Public_File", objpar);
            return dt;
        }

        public DataTable viewAl_Documents()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procDocuments_ViewALL");
            return dt;
        }

        public void deleteDocuments()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objdal.executespreturndr("procDocuments_Delete", objpar);
        }




        public void addDocuments2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@Document_Title", SqlDbType.VarChar, Document_Title.ToString()));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objlist.Add(new csParameterListType("@File_Name", SqlDbType.VarChar, File_Name.ToString()));
            objlist.Add(new csParameterListType("@ShowOrHide", SqlDbType.VarChar, ShowOrHide.ToString()));
            //objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procDocuments_Insert2", objlist);
        }

        public void updateDocuments2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@Document_Title", SqlDbType.VarChar, Document_Title.ToString()));
            objlist.Add(new csParameterListType("@File_Name", SqlDbType.VarChar, File_Name.ToString()));
            objlist.Add(new csParameterListType("@ShowOrHide", SqlDbType.VarChar, ShowOrHide.ToString()));
            objdal.executespreturnnd("procDocuments_Update2", objlist);
        }

        public void updateDocuments_Download_Count2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objdal.executespreturnnd("procDocuments_Download_Count_Update2", objlist);
        }

        public DataTable viewDocuments_ByDocument_ID2(Int32 Document_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            dt = objdal.search("procDocuments_By_Document_ID", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory2(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_ViewAll_By_Category2", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory_and_DocName2(string Category, string Document_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objpar.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            dt = objdal.search("procDocuments_ViewAll_By_Category_and_DocName2", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory_Public2(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_ViewAll_Public2", objpar);
            return dt;
        }

        public DataTable viewAllDocuments_ByCategory_Public_File2(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procDocuments_ViewAll_Public_File", objpar);
            return dt;
        }

        public DataTable viewAl_Documents2()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procDocuments_ViewALL");
            return dt;
        }

        public void deleteDocuments2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objdal.executespreturndr("procDocuments_Delete", objpar);
        }


        //---------------Category Documents---------------------------
        public void addCategory_Documents()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@Document_Description", SqlDbType.VarChar, Document_Description.ToString()));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objlist.Add(new csParameterListType("@ShowOrHide", SqlDbType.VarChar, ShowOrHide.ToString()));
            objdal.executespreturnnd("procCategory_Documents_Insert", objlist);
        }

        public void updateCategory_Documents_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@File_Name", SqlDbType.VarChar, File_Name.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procCategory_Document_File_Update", objlist);
        }

        public void updateCategory_Documents()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@Document_Date", SqlDbType.VarChar, Document_Date.ToString()));
            objlist.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            objlist.Add(new csParameterListType("@Document_Description", SqlDbType.VarChar, Document_Description.ToString()));
            objlist.Add(new csParameterListType("@ShowOrHide", SqlDbType.VarChar, ShowOrHide.ToString()));
            objdal.executespreturnnd("procCategory_Documents_Update", objlist);
        }

        public void updateCategory_Documents_Download_Count()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objlist.Add(new csParameterListType("@Download_Count", SqlDbType.BigInt, Download_Count));
            objdal.executespreturnnd("procCategory_Documents_Download_Count_Update", objlist);
        }

        public DataTable viewCategory_Documents_ByClient_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procCategory_Documents_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewCategory_Documents_ByClient_ID_and_Category_ID(Int32 Client_ID, Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procCategory_Documents_By_Client_ID_and_Category_ID", objpar);
            return dt;
        }

        public DataTable viewCategory_Documents_ByClient_ID_and_Category(Int32 Client_ID, String Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procCategory_Documents_By_Client_ID_and_Category", objpar);
            return dt;
        }

        public DataTable viewCategory_Documents_ByClient_ID_and_Category2(Int32 Client_ID, String Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procCategory_Documents_By_Client_ID_and_Category2", objpar);
            return dt;
        }

        public DataTable viewCategory_Documents_ByDocument_ID(Int32 Document_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            dt = objdal.search("procCategory_Documents_By_Document_ID", objpar);
            return dt;
        }

        public DataTable viewCategory_Documents_with_data_ByDocument_ID(Int32 Document_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            dt = objdal.search("procCategory_Documents_with_data_By_Document_ID", objpar);
            return dt;
        }

        public DataTable viewAllCategory_Documents_ByCategory(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procCategory_Documents_ViewAll_By_Category", objpar);
            return dt;
        }

        public DataTable viewAllCategory_Documents_ByCategory_and_DocName(string Category, string Document_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objpar.Add(new csParameterListType("@Document_Name", SqlDbType.VarChar, Document_Name.ToString()));
            dt = objdal.search("procCategory_Documents_ViewAll_By_Category_and_DocName", objpar);
            return dt;
        }

        public DataTable viewAllCategory_Documents_ByCategory_Public(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procCategory_Documents_ViewAll_Public", objpar);
            return dt;
        }

        public DataTable viewAllCategory_Documents_ByCategory_Public_File(string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procCategory_Documents_ViewAll_Public_File", objpar);
            return dt;
        }

        public DataTable viewAl_Category_Documents()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procCategory_Documents_ViewALL");
            return dt;
        }

        public void deleteCategory_Documents()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Document_ID", SqlDbType.BigInt, Document_ID));
            objdal.executespreturndr("procCategory_Documents_Delete", objpar);
        }


        #endregion

        #region MySermons

        public void addMySermons()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Sermon_Number", SqlDbType.VarChar, Sermon_Number.ToString()));
            objlist.Add(new csParameterListType("@Sermon_Category", SqlDbType.VarChar, Sermon_Category.ToString()));
            objlist.Add(new csParameterListType("@Sermon_Date", SqlDbType.VarChar, Sermon_Date.ToString()));
            objlist.Add(new csParameterListType("@Sermon_Title", SqlDbType.VarChar, Sermon_Title.ToString()));
            objlist.Add(new csParameterListType("@Series_Title", SqlDbType.VarChar, Series_Title.ToString()));
            objlist.Add(new csParameterListType("@Sermon_Content", SqlDbType.VarChar, Sermon_Content));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procMySermons_Insert", objlist);
        }

        public void updateMySermons()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Sermon_ID", SqlDbType.BigInt, Sermon_ID));
            objlist.Add(new csParameterListType("@Sermon_Category", SqlDbType.VarChar, Sermon_Category.ToString()));
            objlist.Add(new csParameterListType("@Sermon_Date", SqlDbType.VarChar, Sermon_Date.ToString()));
            objlist.Add(new csParameterListType("@Sermon_Title", SqlDbType.VarChar, Sermon_Title.ToString()));
            objlist.Add(new csParameterListType("@Series_Title", SqlDbType.VarChar, Series_Title.ToString()));
            objlist.Add(new csParameterListType("@Sermon_Content", SqlDbType.VarChar, Sermon_Content));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procMySermons_Update", objlist);
        }

        public DataTable viewMySermons_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procMySermons_By_Profile_ID", objlist);
            return dt;
        }

        public DataTable viewMySermons_By_Profile_ID_Date(Int32 Profile_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
            objlist.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
            dt = objdal.search("procMySermons_By_Profile_ID_Date", objlist);
            return dt;
        }

        public DataTable viewMySermons_By_Sermon_ID(Int32 Sermon_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Sermon_ID", SqlDbType.BigInt, Sermon_ID));
            dt = objdal.search("procMySermons_By_Sermon_ID", objlist);
            return dt;
        }

        #endregion

        #region Counselling

        public void addCounselling()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Counselling_Number", SqlDbType.VarChar, Counselling_Number.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Category", SqlDbType.VarChar, Counselling_Category.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Date", SqlDbType.VarChar, Counselling_Date.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Title", SqlDbType.VarChar, Counselling_Title.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Profile_ID", SqlDbType.BigInt, Counselling_Profile_ID));
            objlist.Add(new csParameterListType("@Counselling_Full_Name", SqlDbType.VarChar, Counselling_Full_Name.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Contacts", SqlDbType.VarChar, Counselling_Contacts.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Content", SqlDbType.VarChar, Counselling_Content));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procCounselling_Insert", objlist);
        }

        public void updateCounselling()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Counselling_ID", SqlDbType.BigInt, Counselling_ID));
            objlist.Add(new csParameterListType("@Counselling_Category", SqlDbType.VarChar, Counselling_Category.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Date", SqlDbType.VarChar, Counselling_Date.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Title", SqlDbType.VarChar, Counselling_Title.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Profile_ID", SqlDbType.BigInt, Counselling_Profile_ID));
            objlist.Add(new csParameterListType("@Counselling_Full_Name", SqlDbType.VarChar, Counselling_Full_Name.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Contacts", SqlDbType.VarChar, Counselling_Contacts.ToString()));
            objlist.Add(new csParameterListType("@Counselling_Content", SqlDbType.VarChar, Counselling_Content));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procCounselling_Update", objlist);
        }

        public DataTable viewCounselling_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procCounselling_By_Profile_ID", objlist);
            return dt;
        }

        public DataTable viewCounselling_By_Profile_ID_and_Date(Int32 Profile_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objlist.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procCounselling_By_Profile_ID_and_Date", objlist);
            return dt;
        }

        public DataTable viewCounselling_By_Counselling_ID(Int32 Counselling_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Counselling_ID", SqlDbType.BigInt, Counselling_ID));
            dt = objdal.search("procCounselling_By_Counselling_ID", objlist);
            return dt;
        }

        #endregion

        #region MyNotes

        public void addMyNotes()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Note_Number", SqlDbType.VarChar, Note_Number.ToString()));
            objlist.Add(new csParameterListType("@Note_Date", SqlDbType.VarChar, Note_Date.ToString()));
            objlist.Add(new csParameterListType("@Note_Title", SqlDbType.VarChar, Note_Title.ToString()));
            objlist.Add(new csParameterListType("@Note_Content", SqlDbType.VarChar, Note_Content));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procMyNotes_Insert", objlist);
        }

        public void updateMyNotes()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Note_ID", SqlDbType.BigInt, Note_ID));
            objlist.Add(new csParameterListType("@Note_Date", SqlDbType.VarChar, Note_Date.ToString()));
            objlist.Add(new csParameterListType("@Note_Title", SqlDbType.VarChar, Note_Title.ToString()));
            objlist.Add(new csParameterListType("@Note_Content", SqlDbType.VarChar, Note_Content));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procMyNotes_Update", objlist);
        }

        public DataTable viewMyNotes_By_Profile_ID_and_Date(Int32 Profile_ID, string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objlist.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procMyNotes_By_Profile_ID_and_Date", objlist);
            return dt;
        }

        public DataTable viewMyNotes_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procMyNotes_By_Profile_ID", objlist);
            return dt;
        }

        public DataTable viewMyNotes_By_Note_ID(Int32 Note_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Note_ID", SqlDbType.BigInt, Note_ID));
            dt = objdal.search("procMyNotes_By_Note_ID", objlist);
            return dt;
        }

        #endregion

        #region MyVision

        public void addMyVision()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procMyVision_Insert", objlist);
        }

        public void updateMyVision()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Vision_Date", SqlDbType.VarChar, Vision_Date.ToString()));
            objlist.Add(new csParameterListType("@Vision_Title", SqlDbType.VarChar, Vision_Title.ToString()));
            objlist.Add(new csParameterListType("@Vision_Content", SqlDbType.VarChar, Vision_Content));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procMyVision_Update", objlist);
        }

        public DataTable viewMyVision_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procMyVision_By_Profile_ID", objlist);
            return dt;
        }

        public DataTable viewMyVision_By_Vision_ID(Int32 Vision_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Vision_ID", SqlDbType.BigInt, Vision_ID));
            dt = objdal.search("procMyVision_By_Vision_ID", objlist);
            return dt;
        }

        #endregion

        #region MyDiary

        public void addMyDiary()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date.ToString()));
            objlist.Add(new csParameterListType("@Diary_Times", SqlDbType.VarChar, Diary_Times.ToString()));
            objlist.Add(new csParameterListType("@Appointment", SqlDbType.VarChar, Appointment.ToString()));
            objlist.Add(new csParameterListType("@ToDo", SqlDbType.VarChar, ToDo.ToString()));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objdal.executespreturnnd("procMyDiary_Insert", objlist);
        }

        public void updateMyDiary()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date.ToString()));
            objlist.Add(new csParameterListType("@Diary_Times", SqlDbType.VarChar, Diary_Times.ToString()));
            objlist.Add(new csParameterListType("@Appointment", SqlDbType.VarChar, Appointment.ToString()));
            objlist.Add(new csParameterListType("@ToDo", SqlDbType.VarChar, ToDo.ToString()));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status));
            objdal.executespreturnnd("procMyDiary_Update", objlist);
        }

        public DataTable viewMyDiary_By_Profile_ID_and_Diary_Date_and_Diary_Times(Int32 Profile_ID, string Diary_Date, string Diary_Times)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date));
            objlist.Add(new csParameterListType("@Diary_Times", SqlDbType.VarChar, Diary_Times));
            dt = objdal.search("procMyDiary_View_By_Profile_ID_and_Diary_Date_and_Diary_Times", objlist);
            return dt;
        }

        public DataTable viewMyDiary_By_Profile_ID_and_Diary_Date(Int32 Profile_ID, string Diary_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Diary_Date", SqlDbType.VarChar, Diary_Date.ToString()));
            dt = objdal.search("procMyDiary_View_By_Profile_ID_and_Diary_Date", objlist);
            return dt;
        }

        public DataTable viewAll_MyDiary()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procMyDiary_Times_View_All");
            return dt;
        }

        #endregion

    }
}
