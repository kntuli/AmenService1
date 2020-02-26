using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csShop
    {
        csDAL objdal = new csDAL();

        public Int32 Item_ID { set; get; }
        public string Item_Number { set; get; }
        //public Int32 Category_ID { set; get; }
        //public Int32 Type_ID { set; get; }
        public string Item_Name { set; get; }
        public string Item_Description { set; get; }
        public string Item_Price { set; get; }
        public string Item_Price1 { set; get; }
        public string Item_Price2 { set; get; }
        public string Item_Price3 { set; get; }
        public string Item_Price4 { set; get; }
        public string Item_Price5 { set; get; }
        public string Item_Type1 { set; get; }
        public string Item_Type2 { set; get; }
        public string Item_Type3 { set; get; }
        public string Item_Type4 { set; get; }
        public string Item_Type5 { set; get; }
        public string Item_Qty { set; get; }
        public string Item_Available { set; get; }
        public string Item_Date { set; get; }
        public string Last_Modified_Date { set; get; }

        public Int32 Audio_ID { set; get; }
        public byte[] AudioFile { set; get; }
        public string AudioFileType { set; get; }
        public string AudioFileSize { set; get; }
        public string AudioCount { set; get; }
        public string AudioFileName { set; get; }

        public Int32 Video_ID { set; get; }
        public byte[] VideoFile { set; get; }
        public string VideoFileType { set; get; }
        public string VideoFileSize { set; get; }
        public string VideoFileCount { set; get; }
        public string VideoFileName { set; get; }

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
        public Int32 Profile_ID { set; get; }
        public string Shopper_Number { set; get; }
        public string Shopper_Name { set; get; }
        public string Shopper_Category { set; get; }
        public string Shopper_RegDate { set; get; }
        public string Shopper_Address { set; get; }
        public string Shopper_Mobile { set; get; }
        public string Shopper_Tel { set; get; }
        public string Shopper_Email { set; get; }
        public string Shopper_Country { set; get; }
        public string Shopper_Province { set; get; }
        public string Shopper_City { set; get; }
        public string Shopper_PostalCode { set; get; }
        public string User_Name { set; get; }
        public string User_Password { set; get; }
        public string User_Active_Status { set; get; }
        public string Shopper_Status { set; get; }
        

        public Int32 Order_Item_ID { set; get; }

        public string Pic_Image { set; get; }

        public Int32 Pic_ID { set; get; }
        public byte[] Pic_Img { set; get; }
        public string Item_Pic { set; get; }

        public Int32 Owner_ID { set; get; }
        public string Owner_Number { set; get; }
        public string Owner_Name { set; get; }
        public string Owner_Profile { set; get; }
        public string Tel { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public string SocialMedia { set; get; }
        public string Reg_Date { set; get; }


        public Int32 Product_ID { set; get; }
        public string Product_Number { set; get; }
        public string Product_Name { set; get; }
        public string Product_Description { set; get; }
        public string Release_Date { set; get; }
        public string Copyright { set; get; }



        public csShop()
        { }


        #region Shop_Product_Owners
        
        //--------------Shop_Product_Owners----------------------------------------

        public void addShop_Product_Owners()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Owner_Number", SqlDbType.VarChar, Owner_Number.ToString()));
            objlist.Add(new csParameterListType("@Owner_Name", SqlDbType.VarChar, Owner_Name.ToString()));
            objlist.Add(new csParameterListType("@Owner_Profile", SqlDbType.VarChar, Owner_Profile.ToString()));
            objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, Tel.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@SocialMedia", SqlDbType.VarChar, SocialMedia.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procShop_Product_Owners_Insert", objlist);
        }

        public void updateShop_Product_Owners()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Owner_ID", SqlDbType.BigInt, Owner_ID));
            objlist.Add(new csParameterListType("@Owner_Name", SqlDbType.VarChar, Owner_Name.ToString()));
            objlist.Add(new csParameterListType("@Owner_Profile", SqlDbType.VarChar, Owner_Profile.ToString()));
            objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, Tel.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
            objlist.Add(new csParameterListType("@SocialMedia", SqlDbType.VarChar, SocialMedia.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procShop_Product_Owners_Update", objlist);
        }

        public DataTable viewShop_Product_Owners_By_Owner_ID(Int32 Owner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Owner_ID", SqlDbType.BigInt, Owner_ID));
            dt = objdal.search("procShop_Product_Owners_By_Owner_ID", objpar);
            return dt;
        }

        public DataTable viewShop_Product_Owners_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procShop_Product_Owners_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewShop_Product_Owners_By_Owner_Number(string Owner_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Owner_Number", SqlDbType.VarChar, Owner_Number));
            dt = objdal.search("procShop_Product_Owners_By_Owner_Number", objpar);
            return dt;
        }

        public DataTable viewAllShop_Product_Owners()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShop_Product_Owners_View_All");
            return dt;
        }


        public void deleteShop_Product_Owners()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturndr("procShop_Product_Owners_Delete", objpar);
        }
        
        #endregion

        #region Shop_Products
        //--------------Shop_Products----------------------------------------
        public void addShop_Products()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Owner_ID", SqlDbType.BigInt, Owner_ID));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@Product_Number", SqlDbType.VarChar, Product_Number.ToString()));
            objlist.Add(new csParameterListType("@Product_Name", SqlDbType.VarChar, Product_Name.ToString()));
            objlist.Add(new csParameterListType("@Product_Description", SqlDbType.VarChar, Product_Description.ToString()));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date.ToString()));
            objlist.Add(new csParameterListType("@Copyright", SqlDbType.VarChar, Copyright.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procShop_Products_Insert", objlist);
        }

        public void updateShop_Products()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@Product_Name", SqlDbType.VarChar, Product_Name.ToString()));
            objlist.Add(new csParameterListType("@Product_Description", SqlDbType.VarChar, Product_Description.ToString()));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date.ToString()));
            objlist.Add(new csParameterListType("@Copyright", SqlDbType.VarChar, Copyright.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procShop_Products_Update", objlist);
        }

        public DataTable viewShop_Products_By_Product_ID(Int32 Product_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            dt = objdal.search("procShop_Products_By_Product_ID", objpar);
            return dt;
        }

        public DataTable viewShop_Products_By_Owner_ID(Int32 Owner_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Owner_ID", SqlDbType.BigInt, Owner_ID));
            dt = objdal.search("procShop_Products_By_Owner_ID", objpar);
            return dt;
        }

        public DataTable viewShop_Products_By_Product_Number(string Product_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Product_Number", SqlDbType.VarChar, Product_Number));
            dt = objdal.search("procShop_Products_By_Product_Number", objpar);
            return dt;
        }

        public DataTable viewAllShop_Products()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShop_Products_View_All");
            return dt;
        }

        public void deleteShop_Products()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturndr("procShop_Products_Delete", objpar);
        }

        #endregion

        #region Shop_Items

        #region Books
        public DataTable viewAllBooks()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Books_View_All");
            return dt;
        }
        #endregion

        #region Sermons
        public DataTable viewAllSermons()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Sermons_View_All");
            return dt;
        }
        #endregion

        #region Music
        public DataTable viewAllMusic()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Music_View_All");
            return dt;
        }
        #endregion

        #region Variety
        public DataTable viewAllVariety()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Variety_View_All");
            return dt;
        }
        #endregion


        //--------------Shop_Items----------------------------------------
        public void addShop_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_Number", SqlDbType.VarChar, Item_Number.ToString()));
            objlist.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            objlist.Add(new csParameterListType("@Type_ID", SqlDbType.BigInt, Type_ID));
            objlist.Add(new csParameterListType("@Item_Name", SqlDbType.VarChar, Item_Name.ToString()));
            objlist.Add(new csParameterListType("@Item_Description", SqlDbType.VarChar, Item_Description.ToString()));
            objlist.Add(new csParameterListType("@Item_Price", SqlDbType.VarChar, Item_Price.ToString()));
            objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.VarChar, Item_Qty.ToString()));
            objlist.Add(new csParameterListType("@Item_Available", SqlDbType.VarChar, Item_Available.ToString()));
            objlist.Add(new csParameterListType("@Item_Date", SqlDbType.VarChar, Item_Date.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procShop_Itemz_Insert", objlist);
        }

        public void updateShop_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            objlist.Add(new csParameterListType("@Type_ID", SqlDbType.BigInt, Type_ID));
            objlist.Add(new csParameterListType("@Item_Name", SqlDbType.VarChar, Item_Name.ToString()));
            objlist.Add(new csParameterListType("@Item_Description", SqlDbType.VarChar, Item_Description.ToString()));
            objlist.Add(new csParameterListType("@Item_Price", SqlDbType.VarChar, Item_Price.ToString()));
            objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.VarChar, Item_Qty.ToString()));
            objlist.Add(new csParameterListType("@Item_Available", SqlDbType.VarChar, Item_Available.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date.ToString()));
            objdal.executespreturnnd("procShop_Itemz_Update", objlist);
        }

        public DataTable viewShop_ItemsByItem_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procShop_Itemz_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewShop_Items_By_Product_ID(Int32 Product_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            dt = objdal.search("procShop_Itemz_By_Product_ID", objpar);
            return dt;
        }

        public DataTable viewAllShop_Items()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShop_Itemz_ViewAll");
            return dt;
        }

        public DataTable viewShop_ItemsByCategory(Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procShop_Items_By_Category_ID", objpar);
            return dt;
        }

        public DataTable viewShop_ItemsByType(Int32 Type_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Type_ID", SqlDbType.BigInt, Type_ID));
            dt = objdal.search("procShop_Items_By_Type_ID", objpar);
            return dt;
        }

        public DataTable viewShop_Items_Type_By_Type_ID(Int32 Type_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Type_ID", SqlDbType.BigInt, Type_ID));
            dt = objdal.search("procShop_Itemz_Type_By_Type_ID", objpar);
            return dt;
        }

        public void deleteShop_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturndr("procShop_Items_Delete", objpar);
        }

        public DataTable searchForShop_ItemsByAnyField(string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procShop_ItemsSearch_ByAnyField", objpar);
            return dt;
        }

        public DataTable viewShop_Join_All(Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procShop_Join_All", objpar);
            return dt;
        }

        public DataTable viewShop_Join_All2(Int32 Category_ID, Int32 Product_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Product_ID", SqlDbType.BigInt, Product_ID));
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procShop_Join_All2", objpar);
            return dt;
        }

        public DataTable viewShop_Join_AllByAnyField(Int32 Category_ID, string sVariable)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procShop_Join_AllByAnyField", objpar);
            return dt;
        }

        public DataTable viewShop_Items_PricesByTypes_By_Item_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procShop_Items_PricesByTypes_By_Item_ID", objpar);
            return dt;
        }




        #endregion

        #region Shop_Item Pic

        //--------------Shop_Item Pic----------------------------------------
        public DataTable viewShop_Items_Pic_ByItem_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procShop_Itemz_Pic_By_Item_ID", objpar);
            return dt;
        }

        public void updateShop_Item_Pic()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Pic_Img", SqlDbType.VarBinary, Pic_Img));
            objdal.executespreturnnd("procShop_Itemz_Pic_Update", objlist);
        }
        #endregion

        #region Shop_Item Audio
        //--------------Shop_Item Audio----------------------------------------

        public DataTable viewShop_Items_Audio_ByItem_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procShop_Itemz_Audio_By_Item_ID", objpar);
            return dt;
        }

        public void InsertShop_Item_Audio()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@AudioFile", SqlDbType.VarBinary, AudioFile));
            objlist.Add(new csParameterListType("@AudioFileType", SqlDbType.VarChar, AudioFileType));
            objlist.Add(new csParameterListType("@AudioFileSize", SqlDbType.VarChar, AudioFileSize));
            objlist.Add(new csParameterListType("@AudioCount", SqlDbType.VarChar, AudioCount));
            objlist.Add(new csParameterListType("@AudioFileName", SqlDbType.VarChar, AudioFileName));
            objdal.executespreturnnd("procShop_Itemz_AudioFile_Insert", objlist);
        }

        public void updateShop_Item_Audio()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Audio_ID", SqlDbType.BigInt, Audio_ID));
            objlist.Add(new csParameterListType("@AudioFile", SqlDbType.VarBinary, AudioFile));
            objlist.Add(new csParameterListType("@AudioFileType", SqlDbType.VarChar, AudioFileType));
            objlist.Add(new csParameterListType("@AudioFileSize", SqlDbType.VarChar, AudioFileSize));
            objlist.Add(new csParameterListType("@AudioCount", SqlDbType.VarChar, AudioCount));
            objlist.Add(new csParameterListType("@AudioFileName", SqlDbType.VarChar, AudioFileName));
            objdal.executespreturnnd("procShop_Itemz_AudioFile_Update", objlist);
        }
        #endregion

        #region Shop_Item Video
        //--------------Shop_Item Video----------------------------------------

        public DataTable viewShop_Items_Video_ByItem_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procShop_Itemz_Video_By_Item_ID", objpar);
            return dt;
        }

        public void InsertShop_Item_Video()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@VideoFile", SqlDbType.VarBinary, VideoFile));
            objlist.Add(new csParameterListType("@VideoFileType", SqlDbType.VarChar, VideoFileType));
            objlist.Add(new csParameterListType("@VideoFileSize", SqlDbType.VarChar, VideoFileSize));
            objlist.Add(new csParameterListType("@VideoFileCount", SqlDbType.VarChar, VideoFileCount));
            objlist.Add(new csParameterListType("@VideoFileName", SqlDbType.VarChar, VideoFileName));
            objdal.executespreturnnd("procShop_Itemz_VideoFile_Insert", objlist);
        }

        public void updateShop_Item_Video()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Video_ID", SqlDbType.BigInt, Video_ID));
            objlist.Add(new csParameterListType("@VideoFile", SqlDbType.VarBinary, VideoFile));
            objlist.Add(new csParameterListType("@VideoFileType", SqlDbType.VarChar, VideoFileType));
            objlist.Add(new csParameterListType("@VideoFileSize", SqlDbType.VarChar, VideoFileSize));
            objlist.Add(new csParameterListType("@VideoFileCount", SqlDbType.VarChar, VideoFileCount));
            objlist.Add(new csParameterListType("@VideoFileName", SqlDbType.VarChar, VideoFileName));
            objdal.executespreturnnd("procShop_Itemz_VideoFile_Update", objlist);
        }

        //public byte[] AudioFile { set; get; }
        //public string AudioFileType { set; get; }
        //public string AudioFileSize { set; get; }
        //public string AudioCount { set; get; }

        //public byte[] VideoFile { set; get; }
        //public string VideoFileType { set; get; }
        //public string VideoFileSize { set; get; }
        //public string VideoFileCount { set; get; }


        #endregion

        #region Shop Categories
        //-----------------Shop Categories-----------------------

        public void addShop_Categories()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objdal.executespreturnnd("procShop_Items_Categories_Insert", objlist);
        }

        public DataTable viewAllShop_Categories()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShop_Items_Categories_ViewAll");
            return dt;
        }
        #endregion

        #region Shop Types
        //----------------Shop Types-----------------------------------
        public void addShop_Types()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Type", SqlDbType.VarChar, Type.ToString()));
            objdal.executespreturnnd("procShop_Items_Types_Insert", objlist);
        }

        public DataTable viewAllShop_Type()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShop_Items_Types_ViewAll");
            return dt;
        }

        #endregion

        #region Shop Orders
        //--------------Shop Orders----------------------------------------
        public void AddAmen_Shop_Orders()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_Number", SqlDbType.VarChar, Order_Number.ToString()));
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Order_Name", SqlDbType.VarChar, Order_Name.ToString()));
            objlist.Add(new csParameterListType("@Order_Description", SqlDbType.VarChar, Order_Description.ToString()));
            objlist.Add(new csParameterListType("@Order_Amount", SqlDbType.VarChar, Order_Amount.ToString()));
            objlist.Add(new csParameterListType("@Order_Qty", SqlDbType.VarChar, Order_Qty.ToString()));
            objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
            objlist.Add(new csParameterListType("@Order_Date", SqlDbType.VarChar, Order_Date.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Orders_Insert", objlist);
        }
        public void UpdateAmen_Shop_Orders()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Order_Name", SqlDbType.VarChar, Order_Name.ToString()));
            objlist.Add(new csParameterListType("@Order_Description", SqlDbType.VarChar, Order_Description.ToString()));
            objlist.Add(new csParameterListType("@Order_Amount", SqlDbType.VarChar, Order_Amount.ToString()));
            objlist.Add(new csParameterListType("@Order_Qty", SqlDbType.VarChar, Order_Qty.ToString()));
            objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Orders_Update", objlist);
        }

        public void updateAmen_Shop_Order_Status()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Order_Status_Update", objlist);
        }

        public void DeleteAmen_Shop_Orders()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objdal.executespreturnnd("procAmen_Shop_Orders_Delete", objlist);
        }

        public DataTable viewAmen_Shop_Orders_By_Shopper_ID(Int32 Shopper_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            dt = objdal.search("procAmen_Shop_Orders_By_Shopper_ID", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Orders_By_Order_Number(string Order_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_Number", SqlDbType.VarChar, Order_Number));
            dt = objdal.search("procAmen_Shop_Orders_By_Order_Number", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Orders_By_Order_ID(Int32 Order_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            dt = objdal.search("procAmen_Shop_Orders_By_Shopper_ID", objlist);
            return dt;
        }

        public DataTable viewAllAmen_Shop_Orders()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Orders_ViewAll");
            return dt;
        }





        public void addShop_Orders()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_Number", SqlDbType.VarChar, Order_Number.ToString()));
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Order_Name", SqlDbType.VarChar, Order_Name.ToString()));
            objlist.Add(new csParameterListType("@Order_Description", SqlDbType.VarChar, Order_Description.ToString()));
            objlist.Add(new csParameterListType("@Order_Amount", SqlDbType.VarChar, Order_Amount.ToString()));
            objlist.Add(new csParameterListType("@Order_Qty", SqlDbType.VarChar, Order_Qty.ToString()));
            objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
            objlist.Add(new csParameterListType("@Order_Date", SqlDbType.VarChar, Order_Date.ToString()));
            objdal.executespreturnnd("procShop_Orders_Insert", objlist);
        }

        public void updateShop_Orders()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Order_Name", SqlDbType.VarChar, Order_Name.ToString()));
            objlist.Add(new csParameterListType("@Order_Description", SqlDbType.VarChar, Order_Description.ToString()));
            objlist.Add(new csParameterListType("@Order_Amount", SqlDbType.VarChar, Order_Amount.ToString()));
            objlist.Add(new csParameterListType("@Order_Qty", SqlDbType.VarChar, Order_Qty.ToString()));
            objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
            objdal.executespreturnnd("procShop_Orders_Update", objlist);
        }

        public void updateShop_Order_Status()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Order_Status", SqlDbType.VarChar, Order_Status.ToString()));
            objdal.executespreturnnd("procShop_Orders_Update_Status", objlist);
        }

        public DataTable viewShop_OrdersByOrder_ID(Int32 Order_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            dt = objdal.search("procShop_Orders_By_Order_ID", objpar);
            return dt;
        }

        public DataTable viewShop_OrdersByShopper_ID(Int32 Shopper_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            dt = objdal.search("procShop_Orders_By_Shopper_ID", objpar);
            return dt;
        }

        public DataTable viewOrder_ID_ByOrder_Number(string Order_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Order_Number", SqlDbType.VarChar, Order_Number));
            dt = objdal.search("procAmen_Shop_Orders_Order_ID_by_Order_Number", objpar);
            return dt;
        }

        public DataTable viewAllShop_Orders()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShop_Orders_ViewAll");
            return dt;
        }

        #region Shop Order_Items

        //--------------Shop Order_Items----------------------------------------

        public void addShop_Order_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.BigInt, Item_Qty));
            objdal.executespreturnnd("procShop_Order_Items_Insert", objlist);
        }

        public void updateShop_Order_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_Item_ID", SqlDbType.BigInt, Order_Item_ID));
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.BigInt, Item_Qty));
            objdal.executespreturnnd("procShop_Order_Items_Update", objlist);
        }

        public DataTable viewShop_Order_ItemsByOrder_ID(Int32 Order_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            dt = objdal.search("procShop_Order_Items_By_Order_ID", objpar);
            return dt;
        }

        public DataTable viewShop_Order_ItemsByOrder_ID2(Int32 Order_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            dt = objdal.search("procShop_Order_Items_By_Order_ID2", objpar);
            return dt;
        }

        public DataTable viewShop_Order_ItemsByItem_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procShop_Order_Items_By_Item_ID", objpar);
            return dt;
        }
        #endregion

        #endregion

        #region Shoppers

        //--------------Shoppers----------------------------------------

        public void addShoppers()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
            objlist.Add(new csParameterListType("@Shopper_RegDate", SqlDbType.VarChar, Shopper_RegDate.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Status", SqlDbType.VarChar, Shopper_Status.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Email", SqlDbType.VarChar, Shopper_Email.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
            objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
            objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
            objdal.executespreturnnd("procShoppers_Insert", objlist);
        }

        public void addAmen_Shop_Shopper2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Category", SqlDbType.VarChar, Shopper_Category.ToString()));
            objlist.Add(new csParameterListType("@Shopper_RegDate", SqlDbType.VarChar, Shopper_RegDate.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Email", SqlDbType.VarChar, Shopper_Email.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
            objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
            objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
            objlist.Add(new csParameterListType("@User_Password", SqlDbType.VarChar, User_Password.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Shopper_Insert2", objlist);
        }

        public void UpdateAmen_Shop_Shopper()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
            objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
            objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Shopper_Update", objlist);
        }

        public void UpdateAmen_Shop_Shopper_Logins()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@User_Name", SqlDbType.VarChar, User_Name.ToString()));
            objlist.Add(new csParameterListType("@User_Password", SqlDbType.VarChar, User_Password.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Shopper_Login_Update", objlist);
        }

        public DataTable viewAmen_Shop_Shopper_ByEmail(string Email)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@User_Name", SqlDbType.VarChar, Email.ToString()));
            dt = objdal.search("procAmen_Shop_Shopper_By_Email", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Shopper_ByShopper_Number(string Shopper_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
            dt = objdal.search("procAmen_Shop_Shopper_By_Shopper_Number", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Shopper_By_Shopper_ID(Int32 Shopper_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            dt = objdal.search("procAmen_Shop_Shopper_By_Shopper_ID", objlist);
            return dt;
        }

        public DataTable viewAllAmen_Shop_Shoppers()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Shopper_View_All");
            return dt;
        }

        public DataTable viewShopperUserAccess(string username, string password)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Username", SqlDbType.VarChar, username));
            objlist.Add(new csParameterListType("@Password", SqlDbType.VarChar, password));
            dt = objdal.search("procAmen_Shop_Shopper_Login", objlist);
            return dt;
        }



//------------Old-----------------------------

        public void updateShoppers()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Email", SqlDbType.VarChar, Shopper_Email.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
            objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
            objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
            objdal.executespreturnnd("procShoppers_Update", objlist);
        }

        public void updateShoppers2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Email", SqlDbType.VarChar, Shopper_Email.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
            objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
            objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
            objdal.executespreturnnd("procShoppers_Update2", objlist);
        }

        public DataTable viewShoppersByShopper_ID(Int32 Shopper_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            dt = objdal.search("procShoppers_By_Shopper_ID", objpar);
            return dt;
        }

        public DataTable viewShopperID_ByShopper_Number(string Shopper_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
            dt = objdal.search("procShopper_ID_By_Shopper_Number", objpar);
            return dt;
        }

        public DataTable viewAllShoppers()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShoppers_ViewAll");
            return dt;
        }
        #endregion



        #region Shopping_Content
        //--------------Shopping_Content----------------------------------------
        public DataTable viewShopping_Content()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procShopping_Content");
            return dt;
        }

        #endregion



    }
}