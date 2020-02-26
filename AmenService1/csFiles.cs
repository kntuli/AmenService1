using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csFiles
    {
        csDAL obdal = new csDAL();

        public Int32 fileID { set; get; }
        public Int32 profileID { set; get; }
        public Int32 companyID { set; get; }
        public string category { set; get; }
        public byte[] fileData { set; get; }
        public string fileTitle { set; get; }
        public string fileName { set; get; }
        public string fileSize { set; get; }
        public string fileType { set; get; }

        public Int32 complianceID { set; get; }
        public Int32 taskID { set; get; }

        public Int32 clientID { set; get; }
        public Int32 expenseID { set; get; }

        public csFiles()
        { }

        #region Shop

        #region Books
        public DataTable viewBooksShopItemImageByItemID(int itemID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, itemID));
            dt = objdal.search("procAmen_Shop_Books_ImageOnly_By_Item_ID", objpar);
            return dt;
        }
        #endregion

        #region Sermons
        public DataTable viewSermonsShopItemImageByItemID(int itemID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, itemID));
            dt = objdal.search("procAmen_Shop_Sermons_ImageOnly_By_Item_ID", objpar);
            return dt;
        }
        #endregion

        #region Music
        public DataTable viewMusicShopItemImageByItemID(int itemID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, itemID));
            dt = objdal.search("procAmen_Shop_Music_ImageOnly_By_Item_ID", objpar);
            return dt;
        }
        #endregion

        #region Variety
        public DataTable viewVarietyShopItemImageByItemID(int itemID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, itemID));
            dt = objdal.search("procAmen_Shop_Variety_ImageOnly_By_Item_ID", objpar);
            return dt;
        }
        #endregion

        #endregion

        #region ClientFiles
        public DataTable viewClient_Files_By_Client_ID_And_Category(int Client_ID, string category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@category", SqlDbType.VarChar, category));
            dt = objdal.search("procClient_Files_View_By_Client_ID", objpar);
            return dt;
        }

        #endregion

        #region Expenses
        public void addExpenseFile()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Expense_ID", SqlDbType.BigInt, expenseID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, category));
            objlist.Add(new csParameterListType("@FileData", SqlDbType.VarBinary, fileData));
            objlist.Add(new csParameterListType("@FileName", SqlDbType.VarChar, fileName.ToString()));
            objlist.Add(new csParameterListType("@FileSize", SqlDbType.VarChar, fileSize.ToString()));
            objlist.Add(new csParameterListType("@FileType", SqlDbType.VarChar, fileType.ToString()));
            objdal.executespreturnnd("procExpenseFileInsert", objlist);
        }

        public DataTable viewExpenseFileByFileID(int File_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@File_ID", SqlDbType.BigInt, File_ID));
            dt = objdal.search("procExpenseFileByFileID", objpar);
            return dt;
        }

        public DataTable viewExpenseFileRemoveByFileID(int File_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@File_ID", SqlDbType.BigInt, File_ID));
            dt = objdal.search("procExpenseFileRemoveByFileID", objpar);
            return dt;
        }

        #endregion
    }
}