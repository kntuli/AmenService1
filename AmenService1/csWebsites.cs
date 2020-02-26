using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csWebsites
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Website_ID { set; get; }
        public string Website_Number { set; get; }
        public string Domain_Name { set; get; }
        public string Host_Name { set; get; }
        public string Host_Package { set; get; }
        public string LastUpdate_Date { set; get; }
        public string Reg_Date { set; get; }


        public Int32 Page_Content_ID { set; get; }
        public string Page_Date { set; get; }
        public string Category { set; get; }
        public string Page { set; get; }
        public string Title { set; get; }
        public string Sub_Title { set; get; }
        public string Content { set; get; }
        public string filename { set; get; }
        public byte[] blobdata { set; get; }
        public byte[] thumbdata { set; get; }
        public string ShowHide { set; get; }

        public string NavigateUrl { set; get; }
        public string AlternateText { set; get; }

        public Int32 Contact_ID { set; get; }
        public string Tel { set; get; }
        public string Mobile { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        
        public string Facebook { set; get; }
        public string Twitter { set; get; }
        public string Instagram { set; get; }
        public string Youtube { set; get; }

        public Int32 Item_ID { set; get; }
        public string Sermon_Number { set; get; }
        public string Release_Date { set; get; }
        public string Sermon_By { set; get; }
        //public string Title { set; get; }
        public string Description { set; get; }
        public string Format { set; get; }
        public string Length { set; get; }
        public string Price { set; get; }
        public string Discount { set; get; }
        public string Available { set; get; }
        public string Last_Modified_Date { set; get; }

        public string Music_Number { set; get; }
        public string Music_By { set; get; }
        public string Label { set; get; }
        public string Album { set; get; }
        public string Genre { set; get; }
        public string Rights { set; get; }
        public string Lyrics { set; get; }
        public string Publish { set; get; }

        public string Book_Number { set; get; }
        public string ISBN { set; get; }
        public string Author { set; get; }
        public string Publisher { set; get; }
        public string Publication_Date { set; get; }
        public string GenresSubjects { set; get; }
        public string Dimensions { set; get; }
        public string PlotSummary { set; get; }
        public string Language { set; get; }
        public string LoCClassification { set; get; }
        public string Dewey { set; get; }
        public string Website { set; get; }


        public string Item_Name { set; get; }
        public string Item_Number { set; get; }
        public string Weight { set; get; }
        public string Specification { set; get; }
        public string Item_By { set; get; }


        public string Img_Front_Filename { set; get; }
        public byte[] Img_Front_Cover_Thumb { set; get; }
        public byte[] Img_Front_Cover { set; get; }

        public string Img_Back_Filename { set; get; }
        public byte[] Img_Back_Cover_Thumb { set; get; }
        public byte[] Img_Back_Cover { set; get; }

        public byte[] AudioVideo { set; get; }
        public string AudioVideo_Filename { set; get; }

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

        public Int32 Order_ID { set; get; }
        public string Order_Number { set; get; }
        public string Order_Name { set; get; }
        public string Order_Description { set; get; }
        public string Order_Amount { set; get; }
        public string Order_Qty { set; get; }
        public string Order_Status { set; get; }
        public string Order_Date { set; get; }

        public Int32 Ordered_Item_ID { set; get; }
    
        public Int32 Item_Qty { set; get; }
        public string Item_Price { set; get; }
        public string Item_Discount { set; get; }
        public string Item_Description { set; get; }
        public string Transaction { set; get; }
        public string Status { set; get; }

        public Int32 Redeem_ID { set; get; }
        public string Redeem_Number { set; get; }
        public string Redeem_Total { set; get; }
        public string Redeem_Date { set; get; }

        public Int32 Bank_ID { set; get; }
        public string Bank_Name { set; get; }
        public string Account_Number { set; get; }
        public string Branch_Code { set; get; }
        public string Account_Holder { set; get; }
        public string Account_Holder_Email { set; get; }

        public Int32 Downloads { set; get; }
        public string Link { set; get; }
        public string Category_Link { set; get; }
        
        public csWebsites()
        {}


        public void addWebsite_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_Number", SqlDbType.VarChar, Website_Number.ToString()));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_Pre_Insert", objlist);
        }

        public void updateWebsite()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Domain_Name", SqlDbType.VarChar, Domain_Name.ToString()));
            objlist.Add(new csParameterListType("@Host_Name", SqlDbType.VarChar, Host_Name.ToString()));
            objlist.Add(new csParameterListType("@Host_Package", SqlDbType.VarChar, Host_Package.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_Update", objlist);
        }

        public DataTable viewWebsite_ID_ByWebsite_Number(string Website_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_Number", SqlDbType.VarChar, Website_Number.ToString()));
            dt = objdal.search("procWebsite_ID_By_Website_Number", objpar);
            return dt;
        }

        public DataTable viewWebsites_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procWebsites_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Category_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procWebsites_Category_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_By_Website_ID(Int32 Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procWebsites_By_Website_ID", objpar);
            return dt;
        }

        public DataTable searchForWebsitesByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procWebsites_SearchByAnyField1", objpar);
            return dt;
        }



        //------------------Home--------------------

        public void AddHome_Home()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_Home_Insert", objlist);
        }

        public void updateHome_Home()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_Home_Update", objlist);
        }

        public DataTable viewWebsites_Pages_By_Website_ID_and_Page_and_Category(Int32 Website_ID, string Page, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objpar.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procWebsites_Home_View_By_Website_ID_and_Page_and_Category", objpar);
            return dt;
        }

        public void updateHeader_File_Remove(Int32 Website_ID, string Page, string Category, string LastUpdate_Date)
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_Header_File_Update_Remove", objlist);
        }

        //-----------------About----------------------
        public void addPage_Content()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objdal.executespreturnnd("procWebsites_Pages_Insert", objlist);
        }

        public void updateAbout()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_About_Update", objlist);
        }

        public void updateAbout_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_About_File_Update", objlist);
        }

        public void updateAbout_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_About_File_Update_Remove", objlist);
        }


        public DataTable viewAboutByAbout_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procWebsites_About_By_Website_ID", objpar);
            return dt;
        }

        public DataTable Delete_AboutByAbout_ID(int About_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@About_ID", SqlDbType.BigInt, About_ID));
            dt = objdal.search("procAbout_Delete", objpar);
            return dt;
        }

        public DataTable ViewAllAbout()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAbout_View_All");
            return dt;
        }

        public DataTable viewWebsites_About_By_Page_Content_ID(Int32 Page_Content_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            dt = objdal.search("procWebsites_Pages_By_Page_Content_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_About_Data_By_Page_Content_ID(Int32 Page_Content_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            dt = objdal.search("procWebsites_Pages_Data_By_Page_Content_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Pages_By_Website_ID_and_Page(Int32 Website_ID, string Page)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objpar.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            dt = objdal.search("procWebsites_Pages_By_Website_ID_and_Page", objpar);
            return dt;
        }


        public void addGallery()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@NavigateUrl", SqlDbType.VarChar, NavigateUrl.ToString()));
            objlist.Add(new csParameterListType("@AlternateText", SqlDbType.VarChar, AlternateText.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objdal.executespreturnnd("procWebsites_Gallery_Insert", objlist);
        }

        public DataTable viewWebsites_Gallery_By_Website_ID(Int32 Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procWebsites_Gallery_By_Website_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Gallery_Data_By_Website_ID(Int32 Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procWebsites_Gallery_Data_By_Website_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Gallery_Data_By_Page_Content_ID(Int32 Page_Content_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            dt = objdal.search("procWebsites_Gallery_Data_By_Page_Content_ID", objpar);
            return dt;
        }


        public DataTable viewWebsites_Slides_By_Website_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procWebsites_Slides_By_Website_ID", objpar);
            return dt;
        }

        public DataTable Delete_Websites_Slides()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            dt = objdal.search("procWebsites_Slides_Delete", objpar);
            return dt;
        }

        //-----------------BodyItems----------------------------------------

        public DataTable viewWebsites_BodyItem_By_Website_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procWebsites_BodyItem_By_Website_ID", objpar);
            return dt;
        }

        public DataTable Delete_Websites_BodyItem()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            dt = objdal.search("procWebsites_BodyItem_Delete", objpar);
            return dt;
        }

        public DataTable Update_Websites_BodyItem()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            dt = objdal.search("procWebsites_BodyItem_Update", objlist);
            return dt;
        }

        public DataTable Update_Websites_BodyItem2()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Sub_Title", SqlDbType.VarChar, Sub_Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            dt = objdal.search("procWebsites_BodyItem_Update2", objlist);
            return dt;
        }


        public DataTable viewWebsites_BodyItem_By_Website_ID_and_Category(int Website_ID, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procWebsites_BodyItem_By_Website_ID_and_Category", objpar);
            return dt;
        }

        public void AddDailyDevotions_Content()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_DailyDevotions_Insert", objlist);
        }

        public void UpdateDailyDevotions_Content()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_DailyDevotions_Update", objlist);
        }


        public void AddServiceTimes()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Sub_Title", SqlDbType.VarChar, Sub_Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_ServiceTimes_Insert", objlist);
        }

        public void UpdateServiceTimes()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Page_Content_ID", SqlDbType.BigInt, Page_Content_ID));
            objlist.Add(new csParameterListType("@Page_Date", SqlDbType.VarChar, Page_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Page", SqlDbType.VarChar, Page.ToString()));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Sub_Title", SqlDbType.VarChar, Sub_Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_ServiceTimes_Update", objlist);
        }

        //------------------------Contacts----------------------------

        public void AddWebsites_Contacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, Tel.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));

            objlist.Add(new csParameterListType("@Facebook", SqlDbType.VarChar, Facebook.ToString()));
            objlist.Add(new csParameterListType("@Twitter", SqlDbType.VarChar, Twitter.ToString()));
            objlist.Add(new csParameterListType("@Instagram", SqlDbType.VarChar, Instagram.ToString()));
            objlist.Add(new csParameterListType("@Youtube", SqlDbType.VarChar, Youtube.ToString()));

            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_Contacts_Insert", objlist);
        }

        public void UpdateWebsites_Contacts()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            objlist.Add(new csParameterListType("@Tel", SqlDbType.VarChar, Tel.ToString()));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile.ToString()));
            objlist.Add(new csParameterListType("@Fax", SqlDbType.VarChar, Fax.ToString()));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));

            objlist.Add(new csParameterListType("@Facebook", SqlDbType.VarChar, Facebook.ToString()));
            objlist.Add(new csParameterListType("@Twitter", SqlDbType.VarChar, Twitter.ToString()));
            objlist.Add(new csParameterListType("@Instagram", SqlDbType.VarChar, Instagram.ToString()));
            objlist.Add(new csParameterListType("@Youtube", SqlDbType.VarChar, Youtube.ToString()));

            objlist.Add(new csParameterListType("@ShowHide", SqlDbType.VarChar, ShowHide));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procWebsites_Contacts_Update", objlist);
        }

        public DataTable viewWebsites_Contacts_By_Website_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procWebsites_Contacts_By_Website_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Contacts_By_Contact_ID(int Contact_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            dt = objdal.search("procWebsites_Contacts_By_Contact_ID", objpar);
            return dt;
        }

        public DataTable Delete_Websites_Contacts()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Contact_ID", SqlDbType.BigInt, Contact_ID));
            dt = objdal.search("procWebsites_Contacts_Delete", objpar);
            return dt;
        }

        //-----------------Shop---------------------------------

        #region Sermons

        public DataTable viewWebsites_Amen_Shop_Sermons_By_Website_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procAmen_Shop_Sermons_By_Website_ID2", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Sermons_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_By_Item_ID2(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Sermons_By_Item_ID2", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_ImageOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Sermons_ImageOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_FilenameOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Sermons_FilenameOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Sermons_View_All");
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_By_Website_ID_and_Title(int Website_ID, string Title)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objpar.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            dt = objdal.search("procAmen_Shop_Sermons_By_Website_ID_and_Title", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_By_Title(string Title)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            dt = objdal.search("procAmen_Shop_Sermons_By_Title", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Sermons_By_Sermon_Number(string Sermon_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Sermon_Number", SqlDbType.VarChar, Sermon_Number));
            dt = objdal.search("procAmen_Shop_Sermons_By_Sermon_Number", objpar);
            return dt;
        }

        public void AddShop_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Sermon_Number", SqlDbType.VarChar, Sermon_Number.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Sermons_Insert", objlist);
        }

        public void UpdateAmen_Shop_Sermons_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date.ToString()));
            objlist.Add(new csParameterListType("@Sermon_By", SqlDbType.VarChar, Sermon_By));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description));
            objlist.Add(new csParameterListType("@Format", SqlDbType.VarChar, Format));
            objlist.Add(new csParameterListType("@Length", SqlDbType.VarChar, Length));
            objlist.Add(new csParameterListType("@Price", SqlDbType.VarChar, Price));
            objlist.Add(new csParameterListType("@Discount", SqlDbType.VarChar, Discount));
            objlist.Add(new csParameterListType("@Available", SqlDbType.VarChar, Available));
            objlist.Add(new csParameterListType("@Publish", SqlDbType.VarChar, Publish));
            objlist.Add(new csParameterListType("@Link", SqlDbType.VarChar, Link.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date));
            objdal.executespreturnnd("procAmen_Shop_Sermons_Update2", objlist);
        }

        public void Delete_Amen_Shop_Sermons_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Sermons_Delete", objlist);
        }

        public void UpdateShop_Items_Front_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Front_Filename", SqlDbType.VarChar, Img_Front_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Front_Cover_Thumb", SqlDbType.VarBinary, Img_Front_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Front_Cover", SqlDbType.VarBinary, Img_Front_Cover));
            objdal.executespreturnnd("procAmen_Shop_Sermons_Front_File_Update", objlist);
        }

        public void UpdateShop_Items_Front_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Sermons_Front_File_Update_Remove", objlist);
        }

        public void UpdateShop_Items_Back_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Back_Filename", SqlDbType.VarChar, Img_Back_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Back_Cover_Thumb", SqlDbType.VarBinary, Img_Back_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Back_Cover", SqlDbType.VarBinary, Img_Back_Cover));
            objdal.executespreturnnd("procAmen_Shop_Sermons_Back_File_Update", objlist);
        }


        //----------------------------AudioVideo---------------------------------

        public void UpdateShop_Items_AudioVideo_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@AudioVideo_Filename", SqlDbType.VarChar, AudioVideo_Filename.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Sermons_AudioVideo_File_Update", objlist);
        }

        public void UpdateShop_Items_AudioVideo_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Sermons_AudioVideo_File_Update_Remove", objlist);
        }

        public void UpdateShop_Sermons_Items_Downloads()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Downloads", SqlDbType.BigInt, Downloads));
            objdal.executespreturnnd("procAmen_Shop_Sermons_Downloads_Update", objlist);
        }


        #endregion

        #region Music

        public DataTable viewWebsites_Amen_Shop_Music_By_Website_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procAmen_Shop_Music_By_Website_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Music_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_By_Item_ID2(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Music_By_Item_ID2", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_ImageOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Music_ImageOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_FilenameOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Music_FilenameOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Music_View_All");
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_By_Website_ID_and_Title(int Website_ID, string Title)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objpar.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            dt = objdal.search("procAmen_Shop_Music_By_Website_ID_and_Title", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_By_Music_Number(string Music_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Music_Number", SqlDbType.VarChar, Music_Number));
            dt = objdal.search("procAmen_Shop_Music_By_Music_Number", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Music_By_Title(string Title)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            dt = objdal.search("procAmen_Shop_Music_By_Title", objpar);
            return dt;
        }

        public void AddShop_Music_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Music_Number", SqlDbType.VarChar, Music_Number.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Music_Insert", objlist);
        }

        public void UpdateAmen_Shop_Music_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date.ToString()));
            objlist.Add(new csParameterListType("@Music_By", SqlDbType.VarChar, Music_By));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            objlist.Add(new csParameterListType("@Label", SqlDbType.VarChar, Label));
            objlist.Add(new csParameterListType("@Album", SqlDbType.VarChar, Album));
            objlist.Add(new csParameterListType("@Genre", SqlDbType.VarChar, Genre));
            objlist.Add(new csParameterListType("@Lyrics", SqlDbType.VarChar, Lyrics));
            objlist.Add(new csParameterListType("@Rights", SqlDbType.VarChar, Rights));
            objlist.Add(new csParameterListType("@Format", SqlDbType.VarChar, Format));
            objlist.Add(new csParameterListType("@Length", SqlDbType.VarChar, Length));
            objlist.Add(new csParameterListType("@Price", SqlDbType.VarChar, Price));
            objlist.Add(new csParameterListType("@Discount", SqlDbType.VarChar, Discount));
            objlist.Add(new csParameterListType("@Available", SqlDbType.VarChar, Available));
            objlist.Add(new csParameterListType("@Publish", SqlDbType.VarChar, Publish));
            objlist.Add(new csParameterListType("@Link", SqlDbType.VarChar, Link.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date));
            objdal.executespreturnnd("procAmen_Shop_Music_Update", objlist);
        }

        public void Delete_Amen_Shop_Music_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Music_Delete", objlist);
        }

        public void UpdateShop_Music_Items_Front_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Front_Filename", SqlDbType.VarChar, Img_Front_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Front_Cover_Thumb", SqlDbType.VarBinary, Img_Front_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Front_Cover", SqlDbType.VarBinary, Img_Front_Cover));
            objdal.executespreturnnd("procAmen_Shop_Music_Front_File_Update", objlist);
        }

        public void UpdateShop_Music_Items_Front_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Music_Front_File_Update_Remove", objlist);
        }

        public void UpdateShop_Music_Items_Back_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Back_Filename", SqlDbType.VarChar, Img_Back_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Back_Cover_Thumb", SqlDbType.VarBinary, Img_Back_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Back_Cover", SqlDbType.VarBinary, Img_Back_Cover));
            objdal.executespreturnnd("procAmen_Shop_Music_Back_File_Update", objlist);
        }



        //----------------------------AudioVideo---------------------------------

        public void UpdateShop_Music_Items_AudioVideo_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@AudioVideo_Filename", SqlDbType.VarChar, AudioVideo_Filename.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Music_AudioVideo_File_Update", objlist);
        }

        public void UpdateShop_Music_Items_AudioVideo_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Music_AudioVideo_File_Update_Remove", objlist);
        }

        public void UpdateShop_Music_Items_Downloads()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Downloads", SqlDbType.BigInt, Downloads));
            objdal.executespreturnnd("procAmen_Shop_Music_Downloads_Update", objlist);
        }

        #endregion

        #region Books

        public DataTable viewWebsites_Amen_Shop_Books_By_Website_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procAmen_Shop_Books_By_Website_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Books_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_By_Item_ID2(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Books_By_Item_ID2", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_ImageOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Books_ImageOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_FilenameOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Books_FilenameOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Books_View_All");
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_By_Website_ID_and_Title(int Website_ID, string Title)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objpar.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            dt = objdal.search("procAmen_Shop_Books_By_Website_ID_and_Title", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_By_Title(string Title)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            dt = objdal.search("procAmen_Shop_Books_By_Title", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Books_By_Book_Number(string Book_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Book_Number", SqlDbType.VarChar, Book_Number));
            dt = objdal.search("procAmen_Shop_Books_By_Book_Number", objpar);
            return dt;
        }

        public void AddShop_Books_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Book_Number", SqlDbType.VarChar, Book_Number.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Books_Insert", objlist);
        }

        public void UpdateAmen_Shop_Books_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date));
            objlist.Add(new csParameterListType("@Publication_Date", SqlDbType.VarChar, Publication_Date));
            objlist.Add(new csParameterListType("@ISBN", SqlDbType.VarChar, ISBN.ToString()));
            objlist.Add(new csParameterListType("@Author", SqlDbType.VarChar, Author));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title));
            objlist.Add(new csParameterListType("@Publisher", SqlDbType.VarChar, Publisher));
            objlist.Add(new csParameterListType("@PlotSummary", SqlDbType.VarChar, PlotSummary));
            objlist.Add(new csParameterListType("@Language", SqlDbType.VarChar, Language));
            objlist.Add(new csParameterListType("@GenresSubjects", SqlDbType.VarChar, GenresSubjects));
            objlist.Add(new csParameterListType("@Dimensions", SqlDbType.VarChar, Dimensions));
            objlist.Add(new csParameterListType("@LoCClassification", SqlDbType.VarChar, LoCClassification));
            objlist.Add(new csParameterListType("@Dewey", SqlDbType.VarChar, Dewey));
            objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website));
            objlist.Add(new csParameterListType("@Rights", SqlDbType.VarChar, Rights));
            objlist.Add(new csParameterListType("@Format", SqlDbType.VarChar, Format));
            objlist.Add(new csParameterListType("@Length", SqlDbType.VarChar, Length));
            objlist.Add(new csParameterListType("@Price", SqlDbType.VarChar, Price));
            objlist.Add(new csParameterListType("@Discount", SqlDbType.VarChar, Discount));
            objlist.Add(new csParameterListType("@Available", SqlDbType.VarChar, Available));
            objlist.Add(new csParameterListType("@Publish", SqlDbType.VarChar, Publish));
            objlist.Add(new csParameterListType("@Link", SqlDbType.VarChar, Link.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date));
            objdal.executespreturnnd("procAmen_Shop_Books_Update", objlist);
        }

        public void Delete_Amen_Shop_Books_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Books_Delete", objlist);
        }

        public void UpdateShop_Books_Items_Front_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Front_Filename", SqlDbType.VarChar, Img_Front_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Front_Cover_Thumb", SqlDbType.VarBinary, Img_Front_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Front_Cover", SqlDbType.VarBinary, Img_Front_Cover));
            objdal.executespreturnnd("procAmen_Shop_Books_Front_File_Update", objlist);
        }

        public void UpdateShop_Books_Items_Front_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Books_Front_File_Update_Remove", objlist);
        }

        public void UpdateShop_Books_Items_Back_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Back_Filename", SqlDbType.VarChar, Img_Back_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Back_Cover_Thumb", SqlDbType.VarBinary, Img_Back_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Back_Cover", SqlDbType.VarBinary, Img_Back_Cover));
            objdal.executespreturnnd("procAmen_Shop_Books_Back_File_Update", objlist);
        }


        //----------------------------AudioVideo---------------------------------

        public void UpdateShop_Books_Items_AudioVideo_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@AudioVideo_Filename", SqlDbType.VarChar, AudioVideo_Filename.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Books_AudioVideo_File_Update", objlist);
        }

        public void UpdateShop_Books_Items_AudioVideo_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Books_AudioVideo_File_Update_Remove", objlist);
        }

        public void UpdateShop_Books_Items_Downloads()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Downloads", SqlDbType.BigInt, Downloads));
            objdal.executespreturnnd("procAmen_Shop_Books_Downloads_Update", objlist);
        }

        #endregion

        #region Variety

        public DataTable viewWebsites_Amen_Shop_Variety_By_Website_ID(int Website_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            dt = objdal.search("procAmen_Shop_Variety_By_Website_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Variety_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_By_Item_ID2(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Variety_By_Item_ID2", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_ImageOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Variety_ImageOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_FilenameOnly_By_Item_ID(int Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Variety_FilenameOnly_By_Item_ID", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_View_All()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Variety_View_All");
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_By_Website_ID_and_Title(int Website_ID, string Item_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objpar.Add(new csParameterListType("@Item_Name", SqlDbType.VarChar, Item_Name));
            dt = objdal.search("procAmen_Shop_Variety_By_Website_ID_and_Title", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_By_Item_Number(string Item_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_Number", SqlDbType.VarChar, Item_Number));
            dt = objdal.search("procAmen_Shop_Variety_By_Item_Number", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_By_Title(string Item_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_Name", SqlDbType.VarChar, Item_Name));
            dt = objdal.search("procAmen_Shop_Variety_By_Title", objpar);
            return dt;
        }

        public DataTable viewWebsites_Amen_Shop_Variety_By_Item_Category(string ItemCategory)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@ItemCategory", SqlDbType.VarChar, ItemCategory.ToString()));
            dt = objdal.search("procAmen_Shop_Variety_By_Category", objpar);
            return dt;
        }

        public void AddShop_Variety_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Website_ID", SqlDbType.BigInt, Website_ID));
            objlist.Add(new csParameterListType("@Item_Number", SqlDbType.VarChar, Item_Number.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Variety_Insert", objlist);
        }

        public void UpdateAmen_Shop_Variety_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Release_Date", SqlDbType.VarChar, Release_Date.ToString()));
            objlist.Add(new csParameterListType("@Item_By", SqlDbType.VarChar, Item_By.ToString()));
            objlist.Add(new csParameterListType("@Item_Name", SqlDbType.VarChar, Item_Name.ToString()));
            objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
            objlist.Add(new csParameterListType("@Specification", SqlDbType.VarChar, Specification.ToString()));
            objlist.Add(new csParameterListType("@Dimensions", SqlDbType.VarChar, Dimensions.ToString()));
            objlist.Add(new csParameterListType("@Weight", SqlDbType.VarChar, Weight.ToString()));
            objlist.Add(new csParameterListType("@Price", SqlDbType.VarChar, Price.ToString()));
            objlist.Add(new csParameterListType("@Discount", SqlDbType.VarChar, Discount.ToString()));
            objlist.Add(new csParameterListType("@Available", SqlDbType.VarChar, Available.ToString()));
            objlist.Add(new csParameterListType("@Publish", SqlDbType.VarChar, Publish.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Link", SqlDbType.VarChar, Link.ToString()));
            objlist.Add(new csParameterListType("@Category_Link", SqlDbType.VarChar, Category_Link.ToString()));
            objlist.Add(new csParameterListType("@Last_Modified_Date", SqlDbType.VarChar, Last_Modified_Date));
            objdal.executespreturnnd("procAmen_Shop_Variety_Update", objlist);
        }

        public void Delete_Amen_Shop_Variety_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Variety_Delete", objlist);
        }

        public void UpdateShop_Variety_Items_Front_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Front_Filename", SqlDbType.VarChar, Img_Front_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Front_Cover_Thumb", SqlDbType.VarBinary, Img_Front_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Front_Cover", SqlDbType.VarBinary, Img_Front_Cover));
            objdal.executespreturnnd("procAmen_Shop_Variety_Front_File_Update", objlist);
        }

        public void UpdateShop_Variety_Items_Front_File_Remove()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Variety_Front_File_Update_Remove", objlist);
        }

        public void UpdateShop_Variety_Items_Back_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Img_Back_Filename", SqlDbType.VarChar, Img_Back_Filename.ToString()));
            objlist.Add(new csParameterListType("@Img_Back_Cover_Thumb", SqlDbType.VarBinary, Img_Back_Cover_Thumb));
            objlist.Add(new csParameterListType("@Img_Back_Cover", SqlDbType.VarBinary, Img_Back_Cover));
            objdal.executespreturnnd("procAmen_Shop_Variety_Back_File_Update", objlist);
        }

         public void UpdateShop_Variety_Items_Downloads()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Downloads", SqlDbType.BigInt, Downloads));
            objdal.executespreturnnd("procAmen_Shop_Variety_Downloads_Update", objlist);
        }

        #endregion




        //--------------------Shoppers----------------------------------

        public void addAmen_Shop_Shopper_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Category", SqlDbType.VarChar, Shopper_Category.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Shopper_Insert_Pre", objlist);
        }

        public void addAmen_Shop_Shopper()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_Number", SqlDbType.VarChar, Shopper_Number.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Name", SqlDbType.VarChar, Shopper_Name.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Category", SqlDbType.VarChar, Shopper_Category.ToString()));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Shopper_RegDate", SqlDbType.VarChar, Shopper_RegDate.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Mobile", SqlDbType.VarChar, Shopper_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Tel", SqlDbType.VarChar, Shopper_Tel.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Address", SqlDbType.VarChar, Shopper_Address.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Country", SqlDbType.VarChar, Shopper_Country.ToString()));
            objlist.Add(new csParameterListType("@Shopper_Province", SqlDbType.VarChar, Shopper_Province.ToString()));
            objlist.Add(new csParameterListType("@Shopper_City", SqlDbType.VarChar, Shopper_City.ToString()));
            objlist.Add(new csParameterListType("@Shopper_PostalCode", SqlDbType.VarChar, Shopper_PostalCode.ToString()));
            objlist.Add(new csParameterListType("@User_Name", SqlDbType.VarChar, User_Name.ToString()));
            objlist.Add(new csParameterListType("@User_Password", SqlDbType.VarChar, User_Password.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Shopper_Insert", objlist);
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

        //-----------------Orders-----------------------
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

        //--------------Order Items------------------------
        public void AddAmen_Shop_Ordered_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.BigInt, Item_Qty));
            objlist.Add(new csParameterListType("@Item_Price", SqlDbType.VarChar, Item_Price.ToString()));
            objlist.Add(new csParameterListType("@Item_Discount", SqlDbType.VarChar, Item_Discount.ToString()));
            objlist.Add(new csParameterListType("@Order_Date", SqlDbType.VarChar, Order_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Transaction", SqlDbType.VarChar, Transaction.ToString()));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Ordered_Items_Insert", objlist);
        }

        public void UpdateAmen_Shop_Ordered_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ordered_Item_ID", SqlDbType.BigInt, Ordered_Item_ID));
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            objlist.Add(new csParameterListType("@Item_Qty", SqlDbType.BigInt, Item_Qty));
            objlist.Add(new csParameterListType("@Item_Price", SqlDbType.VarChar, Item_Price.ToString()));
            objlist.Add(new csParameterListType("@Item_Discount", SqlDbType.VarChar, Item_Discount.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Ordered_Items_Update", objlist);
        }

        public void updateAmen_Shop_Ordered_Items_Status()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Ordered_Items_Status_Update", objlist);
        }


        public void DeleteAmen_Shop_Ordered_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ordered_Item_ID", SqlDbType.BigInt, Ordered_Item_ID));
            objdal.executespreturnnd("procAmen_Shop_Ordered_Items_Delete", objlist);
        }

        public DataTable viewAmen_Shop_Ordered_Items_By_Shopper_ID(Int32 Shopper_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Shopper_ID", SqlDbType.BigInt, Shopper_ID));
            dt = objdal.search("procAmen_Shop_Ordered_Items_By_Shopper_ID", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Ordered_Items_By_Order_ID(Int32 Order_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Order_ID", SqlDbType.BigInt, Order_ID));
            dt = objdal.search("procAmen_Shop_Ordered_Items_By_Order_ID", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Ordered_Items_By_Item_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procAmen_Shop_Ordered_Items_By_Item_ID", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Ordered_Items_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procAmen_Shop_Ordered_Items_By_Client_ID", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Ordered_Items_By_Client_ID_and_Status(Int32 Client_ID, string Status)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
            dt = objdal.search("procAmen_Shop_Ordered_Items_By_Client_ID_and_Status", objlist);
            return dt;
        }

        public DataTable viewAmen_Shop_Ordered_Items_By_Ordered_Items_ID(Int32 Ordered_Items_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ordered_Items_ID", SqlDbType.BigInt, Ordered_Items_ID));
            dt = objdal.search("procAmen_Shop_Ordered_Items_By_Ordered_Items_ID", objlist);
            return dt;
        }


        //Redeem

        public DataTable viewAmen_Shop_Redeem_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procAmen_Shop_Redeem_By_Client_ID", objlist);
            return dt;
        }

        public DataTable viewAllAmen_Shop_Redeem()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAmen_Shop_Redeem_ViewAll");
            return dt;
        }

        public DataTable viewAmen_Shop_Redeem_By_Client_ID_and_Transaction(Int32 Client_ID, string Transaction)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Transaction", SqlDbType.VarChar, Transaction.ToString()));
            dt = objdal.search("procAmen_Shop_Redeem_By_Client_ID_and_Transaction", objlist);
            return dt;
        }


        public void AddAmen_Shop_Redeem()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Redeem_Number", SqlDbType.VarChar, Redeem_Number.ToString()));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Redeem_Total", SqlDbType.VarChar, Redeem_Total.ToString()));
            objlist.Add(new csParameterListType("@Transaction", SqlDbType.VarChar, Transaction.ToString()));
            objlist.Add(new csParameterListType("@Redeem_Date", SqlDbType.VarChar, Redeem_Date.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Redeem_Insert", objlist);
        }


        public DataTable viewAmen_Shop_Redeemer_Bank_Detail_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procAmen_Shop_Redeemer_Banks_By_Client_ID", objlist);
            return dt;
        }

        public void AddOrUpdateAmen_Shop_Redeemer_Bank_Details()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Bank_Name", SqlDbType.VarChar, Bank_Name.ToString()));
            objlist.Add(new csParameterListType("@Account_Number", SqlDbType.VarChar, Account_Number.ToString()));
            objlist.Add(new csParameterListType("@Branch_Code", SqlDbType.VarChar, Branch_Code.ToString()));
            objlist.Add(new csParameterListType("@Account_Holder", SqlDbType.VarChar, Account_Holder.ToString()));
            objlist.Add(new csParameterListType("@Account_Holder_Email", SqlDbType.VarChar, Account_Holder_Email.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
            objdal.executespreturnnd("procAmen_Shop_Redeemer_Banks_UpdateOrInsert", objlist);
        }

    }
}
