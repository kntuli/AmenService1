using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csTrainings
    {

        csDAL objdal = new csDAL();

        public Int32 Training_ID { set; get; }
        public string Training_Number { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Release_Date { set; get; }
        public string Copyright { set; get; }
        public string Reg_Date { set; get; }
        public string Last_Modified_Date { set; get; }

        public Int32 Contributor_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Contributor_Number { set; get; }
        public string Contributor_Name { set; get; }
        public string Contributor_Profile { set; get; }
        public string Tel { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public string SocialMedia { set; get; }
        

        public Int32 Training_Item_ID { set; get; }
        public string Item { set; get; }

        public Int32 Training_File_ID { set; get; }
        public string AudioVideoPDF { set; get; }
        public byte[] FileData { set; get; }
        public string FileType { set; get; }
        public string FileSize { set; get; }
        public string FileDuration { set; get; }
        public string FileName { set; get; }
        public string FileDownloadCount { set; get; }
        public string FileLastDateDownload { set; get; }
        public string FilePlayCount { set; get; }
        public string FileLastDatePlay { set; get; }
        public string FileUploadDate { set; get; }
        public string IsAvailable { set; get; }
        public byte[] FileImage { set; get; }
        public byte[] FileImageThumb { set; get; }
        public string FileNameImage { set; get; }
        public string HasSample { set; get; }
        public byte[] FileDataSample { set; get; }
        public string PlaySample { set; get; }
        public string Training_File_Number { set; get; }
        public string Training_File_Name { set; get; }
        

        public Int32 Category_ID { set; get; }
        public string Category { set; get; }

        public Int32 Type_ID { set; get; }
        public string Type { set; get; }


        public Int32 Order_ID { set; get; }
        public string Order_Number { set; get; }
        public string Order_Name { set; get; }
        public string Order_Description { set; get; }
        public string Order_Amount { set; get; }
        public string Order_Qty { set; get; }
        public string Order_Status { set; get; }
        public string Order_Date { set; get; }

        public Int32 Shopper_ID { set; get; }
        public string Shopper_Number { set; get; }
        public string Shopper_Name { set; get; }
        public string Shopper_RegDate { set; get; }
        public string Shopper_Status { set; get; }
        public string Shopper_Address { set; get; }
        public string Shopper_Mobile { set; get; }
        public string Shopper_Tel { set; get; }
        public string Shopper_Email { set; get; }
        public string Shopper_Country { set; get; }
        public string Shopper_Province { set; get; }
        public string Shopper_City { set; get; }
        public string Shopper_PostalCode { set; get; }

        public Int32 Order_Item_ID { set; get; }

        public string Pic_Image { set; get; }

        public Int32 Pic_ID { set; get; }
        public byte[] Pic_Img { set; get; }
        public string Item_Pic { set; get; }

        public string From_Date { set; get; }
        public string To_Date { set; get; }

        public csTrainings()
        { }


        #region Trainings


        //--------------Trainings----------------------------------------
        public void addTrainings()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contributor_ID", SqlDbType.BigInt, Contributor_ID));
            objlist.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            objlist.Add(new csParameterListType("@Training_Item_ID", SqlDbType.BigInt, Training_Item_ID));
            objlist.Add(new csParameterListType("@Training_Number", SqlDbType.VarChar, Training_Number.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
            objlist.Add(new csParameterListType("@Copyright", SqlDbType.VarChar, Copyright.ToString()));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procTrainings_Insert", objlist);
        }

        public void updateTrainings()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_ID", SqlDbType.BigInt, Training_ID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
            objlist.Add(new csParameterListType("@Copyright", SqlDbType.VarChar, Copyright.ToString()));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procTrainings_Update", objlist);
        }

        public DataTable viewTrainings_By_Training_ID(Int32 Training_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_ID", SqlDbType.BigInt, Training_ID));
            dt = objdal.search("procTrainings_By_Training_ID", objpar);
            return dt;
        }

        public DataTable viewTrainings_By_Contributor_ID(Int32 Contributor_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contributor_ID", SqlDbType.BigInt, Contributor_ID));
            dt = objdal.search("procTrainings_By_Contributor_ID", objpar);
            return dt;
        }

        public DataTable viewTrainings_By_Training_Number(string Training_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_Number", SqlDbType.VarChar, Training_Number));
            dt = objdal.search("procTrainings_By_Training_Number", objpar);
            return dt;
        }

        public DataTable viewTrainings_By_Period(string From_Date, string To_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
            objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
            dt = objdal.search("procTrainings_By_Period", objpar);
            return dt;
        }

        public DataTable viewTrainings_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procTrainings_View_All");
            return dt;
        }

        public void deleteTrainings()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_ID", SqlDbType.BigInt, Training_ID));
            objdal.executespreturndr("procTrainings_Delete", objpar);
        }

        public DataTable viewTrainings_Join_AllByAnyField(string Item, string AudioVideoPDF, string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item));
            objpar.Add(new csParameterListType("@AudioVideoPDF", SqlDbType.VarChar, AudioVideoPDF));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procTrainings_Join_AllByAnyField", objpar);
            return dt;
        }

        #endregion

        #region Training Contributors

        //--------------Training_Contributors----------------------------------------

        public void addTraining_Contributors()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contributor_Number", SqlDbType.VarChar, Contributor_Number.ToString()));
            objlist.Add(new csParameterListType("@Contributor_Name", SqlDbType.VarChar, Contributor_Name.ToString()));
            objlist.Add(new csParameterListType("@Contributor_Profile", SqlDbType.VarChar, Contributor_Profile.ToString()));
            objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, Tel.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@SocialMedia", SqlDbType.VarChar, SocialMedia.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procTraining_Contributors_Insert", objlist);
        }

        public void updateTraining_Contributors()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contributor_ID", SqlDbType.BigInt, Contributor_ID));
            objlist.Add(new csParameterListType("@Contributor_Name", SqlDbType.VarChar, Contributor_Name.ToString()));
            objlist.Add(new csParameterListType("@Contributor_Profile", SqlDbType.VarChar, Contributor_Profile.ToString()));
            objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, Tel.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@SocialMedia", SqlDbType.VarChar, SocialMedia.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procTraining_Contributors_Update", objlist);
        }

        public DataTable viewTraining_Contributors_By_Contributor_ID(Int32 Contributor_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contributor_ID", SqlDbType.BigInt, Contributor_ID));
            dt = objdal.search("procTraining_Contributors_By_Contributor_ID", objpar);
            return dt;
        }

        public DataTable viewTraining_Contributors_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procTraining_Contributors_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewTraining_Contributors_By_Owner_Number(string Contributor_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contributor_Number", SqlDbType.VarChar, Contributor_Number));
            dt = objdal.search("procTraining_Contributors_By_Contributor_Number", objpar);
            return dt;
        }

        public DataTable viewTraining_Contributors_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procTraining_Contributors_View_All");
            return dt;
        }


        public void deleteTraining_Contributors()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contributor_ID", SqlDbType.BigInt, Contributor_ID));
            objdal.executespreturndr("procTraining_Contributors_Delete", objpar);
        }
        #endregion

        #region Training Items

        //--------------Shop_Items----------------------------------------
        public void addTraining_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item.ToString()));
            objdal.executespreturnnd("procTraining_Items_Insert", objlist);
        }

        public void updateTraining_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_Item_ID", SqlDbType.BigInt, Training_Item_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item.ToString()));
            objdal.executespreturnnd("procTraining_Items_Update", objlist);
        }

        public DataTable viewTraining_Items_By_Training_Item_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_Item_ID", SqlDbType.BigInt, Training_Item_ID));
            dt = objdal.search("procTraining_Items_By_Training_Item_ID", objpar);
            return dt;
        }

        public DataTable viewTraining_Items_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procTraining_Items_ViewAll");
            return dt;
        }

        public void deleteTraining_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_Item_ID", SqlDbType.BigInt, Training_Item_ID));
            objdal.executespreturndr("procTraining_Items_Delete", objpar);
        }

        #endregion

        #region Training Files

        public void AddTraining_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_File_Number", SqlDbType.VarChar, Training_File_Number));
            objlist.Add(new csParameterListType("@FileUploadDate", SqlDbType.VarChar, FileUploadDate));
            objlist.Add(new csParameterListType("@IsAvailable", SqlDbType.VarChar, IsAvailable));
            objlist.Add(new csParameterListType("@HasSample", SqlDbType.VarChar, HasSample));
            objlist.Add(new csParameterListType("@PlaySample", SqlDbType.VarChar, PlaySample));
            objdal.executespreturnnd("procTraining_File_Insert", objlist);
        }

        public void updateTraining_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            objlist.Add(new csParameterListType("@Training_File_Name", SqlDbType.VarChar, Training_File_Name));
            objlist.Add(new csParameterListType("@AudioVideoPDF", SqlDbType.VarChar, AudioVideoPDF));
            objlist.Add(new csParameterListType("@FileType", SqlDbType.VarChar, FileType));
            objlist.Add(new csParameterListType("@FileSize", SqlDbType.VarChar, FileSize));
            objlist.Add(new csParameterListType("@FileDuration", SqlDbType.VarChar, FileDuration));
            objlist.Add(new csParameterListType("@IsAvailable", SqlDbType.VarChar, IsAvailable));
            objdal.executespreturnnd("procTraining_File_Update", objlist);
        }

        public void updateTraining_File_Data()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            objlist.Add(new csParameterListType("@FileData", SqlDbType.VarBinary, FileData));
            objdal.executespreturnnd("procTraining_File_Data_Update", objlist);
        }

        public DataTable viewTraining_File_Data_ByTraining_File_ID(Int32 Training_File_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            dt = objdal.search("procTraining_File_Data_By_Training_File_ID", objpar);
            return dt;
        }

        public void updateTraining_File_Data_Sample()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            objlist.Add(new csParameterListType("@FileDataSample", SqlDbType.VarBinary, FileDataSample));
            objlist.Add(new csParameterListType("@HasSample", SqlDbType.VarChar, HasSample));
            objlist.Add(new csParameterListType("@PlaySample", SqlDbType.VarChar, PlaySample));
            objdal.executespreturnnd("procTraining_File_Data_Sample_Update", objlist);
        }

        public DataTable viewTraining_File_Data_Sample_ByTraining_File_ID(Int32 Training_File_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            dt = objdal.search("procTraining_File_Data_Sample_By_Training_File_ID", objpar);
            return dt;
        }

        public void updateTraining_File_Data_Image()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            objlist.Add(new csParameterListType("@FileImage", SqlDbType.VarBinary, FileImage));
            objlist.Add(new csParameterListType("@FileImageThumb", SqlDbType.VarBinary, FileImageThumb));
            objdal.executespreturnnd("procTraining_File_Data_Image_Update", objlist);
        }

        public DataTable viewTraining_File_Data_Image_ByTraining_File_ID(Int32 Training_File_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            dt = objdal.search("procTraining_File_Data_Image_By_Training_File_ID", objpar);
            return dt;
        }

        public void updateTraining_File_Play()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            objlist.Add(new csParameterListType("@FilePlayCount", SqlDbType.VarChar, FilePlayCount));
            objlist.Add(new csParameterListType("@FileLastDatePlay", SqlDbType.VarChar, FileLastDatePlay));
            objdal.executespreturnnd("procTraining_File_Play_Update", objlist);
        }

        public void updateTraining_File_Download()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            objlist.Add(new csParameterListType("@FileDownloadCount", SqlDbType.VarChar, FileDownloadCount));
            objlist.Add(new csParameterListType("@FileLastDateDownload", SqlDbType.VarChar, FileLastDateDownload));
            objdal.executespreturnnd("procTraining_File_Download_Update", objlist);
        }

        public DataTable viewTraining_Files_ByTraining_File_ID(Int32 Training_File_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Training_File_ID", SqlDbType.BigInt, Training_File_ID));
            dt = objdal.search("procTraining_File_By_Training_File_ID", objpar);
            return dt;
        }

        public DataTable viewTraining_Files_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procTraining_Files_ViewAll");
            return dt;
        }
      
        #endregion
                
        #region Training Orders


        ////-----------------Shop Categories-----------------------

        //public void addShop_Categories()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
        //    objdal.executespreturnnd("procShop_Items_Categories_Insert", objlist);
        //}

        //public DataTable viewAllShop_Categories()
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    dt = objdal.search("procShop_Items_Categories_ViewAll");
        //    return dt;
        //}

        ////----------------Shop Types-----------------------------------
        //public void addShop_Types()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Type", SqlDbType.VarChar, Type.ToString()));
        //    objdal.executespreturnnd("procShop_Items_Types_Insert", objlist);
        //}

        //public DataTable viewAllShop_Type()
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    dt = objdal.search("procShop_Items_Types_ViewAll");
        //    return dt;
        //}


        ////--------------Shop Orders----------------------------------------

        //public void addShop_Orders()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Order_Number", SqlDbType.VarChar, Order_Number.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
        //    objlist.Add(new csParameterListType("@Order_Name", SqlDbType.VarChar, Order_Name.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Description", SqlDbType.VarChar, Order_Description.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Amount", SqlDbType.VarChar, Order_Amount.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Qty", SqlDbType.VarChar, Order_Qty.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Date", SqlDbType.VarChar, Order_Date.ToString()));
        //    objdal.executespreturnnd("procShop_Orders_Insert", objlist);
        //}

        //public void updateShop_Orders()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
        //    objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
        //    objlist.Add(new csParameterListType("@Order_Name", SqlDbType.VarChar, Order_Name.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Description", SqlDbType.VarChar, Order_Description.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Amount", SqlDbType.VarChar, Order_Amount.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Qty", SqlDbType.VarChar, Order_Qty.ToString()));
        //    objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
        //    objdal.executespreturnnd("procShop_Orders_Update", objlist);
        //}

        //public void updateShop_Order_Status()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
        //    objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
        //    objdal.executespreturnnd("procShop_Orders_Update_Status", objlist);
        //}

        //public DataTable viewShop_OrdersByOrder_ID(Int32 Order_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
        //    dt = objdal.search("procShop_Orders_By_Order_ID", objpar);
        //    return dt;
        //}

        //public DataTable viewShop_OrdersByShopper_ID(Int32 Shopper_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
        //    dt = objdal.search("procShop_Orders_By_Shopper_ID", objpar);
        //    return dt;
        //}

        //public DataTable viewOrder_ID_ByOrder_Number(string Order_Number)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Order_Number", SqlDbType.VarChar, Order_Number));
        //    dt = objdal.search("procShop_Order_ID_By_Order_Number", objpar);
        //    return dt;
        //}

        //public DataTable viewAllShop_Orders()
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    dt = objdal.search("procShop_Orders_ViewAll");
        //    return dt;
        //}
        #endregion

        #region Training Subscribers

        ////--------------Shoppers----------------------------------------

        //public void addShoppers()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_RegDate", SqlDbType.VarChar, Shopper_RegDate.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Status", SqlDbType.VarChar, Shopper_Status.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Email", SqlDbType.VarChar, Shopper_Email.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
        //    objdal.executespreturnnd("procShoppers_Insert", objlist);
        //}

        //public void updateShoppers()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
        //    objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_RegDate", SqlDbType.VarChar, Shopper_RegDate.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Status", SqlDbType.VarChar, Shopper_Status.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Email", SqlDbType.VarChar, Shopper_Email.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
        //    objdal.executespreturnnd("procShoppers_Update", objlist);
        //}

        //public void updateShoppers2()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
        //    objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Email", SqlDbType.VarChar, Shopper_Email.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
        //    objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
        //    objdal.executespreturnnd("procShoppers_Update2", objlist);
        //}

        //public DataTable viewShoppersByShopper_ID(Int32 Shopper_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
        //    dt = objdal.search("procShoppers_By_Shopper_ID", objpar);
        //    return dt;
        //}

        //public DataTable viewShopperID_ByShopper_Number(string Shopper_Number)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
        //    dt = objdal.search("procShopper_ID_By_Shopper_Number", objpar);
        //    return dt;
        //}

        //public DataTable viewAllShoppers()
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    dt = objdal.search("procShoppers_ViewAll");
        //    return dt;
        //}


        ////--------------Shop Order_Items----------------------------------------

        //public void addShop_Order_Items()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
        //    objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
        //    objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.BigInt, Item_Qty));
        //    objdal.executespreturnnd("procShop_Order_Items_Insert", objlist);
        //}

        //public void updateShop_Order_Items()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Order_Item_ID", SqlDbType.BigInt, Order_Item_ID));
        //    objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
        //    objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
        //    objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.BigInt, Item_Qty));
        //    objdal.executespreturnnd("procShop_Order_Items_Update", objlist);
        //}

        //public DataTable viewShop_Order_ItemsByOrder_ID(Int32 Order_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
        //    dt = objdal.search("procShop_Order_Items_By_Order_ID", objpar);
        //    return dt;
        //}

        //public DataTable viewShop_Order_ItemsByOrder_ID2(Int32 Order_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
        //    dt = objdal.search("procShop_Order_Items_By_Order_ID2", objpar);
        //    return dt;
        //}

        //public DataTable viewShop_Order_ItemsByItem_ID(Int32 Item_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
        //    dt = objdal.search("procShop_Order_Items_By_Item_ID", objpar);
        //    return dt;
        //}

        ////--------------Shopping_Content----------------------------------------
        //public DataTable viewShopping_Content()
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    dt = objdal.search("procShopping_Content");
        //    return dt;
        //}

        #endregion
        



    }
}
