using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AmenService1
{
    public class csAds
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        //-------------Pics-------------------
        public Int32 Ad_ID { set; get; }
        public string NavigateUrl { set; get; }
        public string AlternateText { set; get; }
        public string Keyword { set; get; }
        public Int32 Impressions { set; get; }
        public Int32 Width { set; get; }
        public Int32 Height { set; get; }
        public string Status { set; get; }


        //-------------Pics-------------------
        public Int32 Pic_ID { set; get; }
        public string Pic_Image { set; get; }
        public string Used_Pic { set; get; }
        public string Event { set; get; }
        public string Event_Rename { set; get; }
        public Int32 Folder_ID { set; get; }
        public string Folder_Rename { set; get; }
        public string filename { set; get; }
        public byte[] blobdata { set; get; }
        public byte[] thumbdata { set; get; }

        public Int32 Gallery_ID { set; get; }

        public Int32 About_ID { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }

        public csAds()
        { }

        public csAds(int cProfile_ID)
        {
            //Profile_ID = cProfile_ID;
        }


        //----------Slides---------------------
        public void addSlides()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@NavigateUrl", SqlDbType.VarChar, NavigateUrl.ToString()));
            objlist.Add(new csParameterListType("@AlternateText", SqlDbType.VarChar, AlternateText.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objdal.executespreturnnd("procAds_Insert", objlist);
        }

        public void updateSlides()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ad_ID", SqlDbType.BigInt, Ad_ID));
            objlist.Add(new csParameterListType("@NavigateUrl", SqlDbType.VarChar, NavigateUrl.ToString()));
            objlist.Add(new csParameterListType("@AlternateText", SqlDbType.VarChar, AlternateText.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objdal.executespreturnnd("procAds_Update2", objlist);
        }

        public void updateSlides2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Ad_ID", SqlDbType.BigInt, Ad_ID));
            objlist.Add(new csParameterListType("@NavigateUrl", SqlDbType.VarChar, NavigateUrl.ToString()));
            objlist.Add(new csParameterListType("@AlternateText", SqlDbType.VarChar, AlternateText.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objdal.executespreturnnd("procAds_Update", objlist);
        }

        public DataTable viewAdsByAd_ID(int Ad_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Ad_ID", SqlDbType.BigInt, Ad_ID));
            dt = objdal.search("procAds_By_Ad_ID", objpar);
            return dt;
        }

        public DataTable Delete_AdsByAd_ID(int Ad_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Ad_ID", SqlDbType.BigInt, Ad_ID));
            dt = objdal.search("procAds_Delete", objpar);
            return dt;
        }

        public DataTable ViewAllAds()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procAds_View_All");
            return dt;
        }
        //------------------------Photos----------------------------------
        public void addPics()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            objlist.Add(new csParameterListType("@Used_Pic", SqlDbType.VarChar, Used_Pic.ToString()));
            objdal.executespreturnnd("procPics_Salon_Insert", objlist);
        }

        public void updatePics()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Pic_ID", SqlDbType.BigInt, Pic_ID));
            objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            objlist.Add(new csParameterListType("@Used_Pic", SqlDbType.VarChar, Used_Pic.ToString()));
            objdal.executespreturnnd("procPics_Salon_Update", objlist);
        }


        public DataTable viewPicByPic_ID(int Pic_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_ID", SqlDbType.BigInt, Pic_ID));
            dt = objdal.search("procPic_Salon_By_PicID", objpar);
            return dt;
        }

        public DataTable viewAllPic()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPics_Salon_All");
            return dt;
        }

        public DataTable viewAllPic_Used()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPics_Salon_Used");
            return dt;
        }

        public DataTable viewPicBy_PicName()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            dt = objdal.search("procPic_Salon_By_PicName", objpar);
            return dt;
        }

        public DataTable DeletePicBy_PicID()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_ID", SqlDbType.BigInt, Pic_ID));
            dt = objdal.search("procPics_Salon_Delete", objpar);
            return dt;
        }

        public DataTable DeletePicBy_PicName()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            dt = objdal.search("procPic_Salon_By_PicName_Delete", objpar);
            return dt;
        }

        //------------------------Events---------------------

        public void addPics_Events()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Used_Pic", SqlDbType.VarChar, Used_Pic.ToString()));
            objlist.Add(new csParameterListType("@Folder_ID", SqlDbType.BigInt, Folder_ID));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procPics_Events_Insert", objlist);
        }

        public void updatePics_Events()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Pic_ID", SqlDbType.BigInt, Pic_ID));
            objlist.Add(new csParameterListType("@Used_Pic", SqlDbType.VarChar, Used_Pic.ToString()));
            objlist.Add(new csParameterListType("@Folder_ID", SqlDbType.BigInt, Folder_ID));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procPics_Events_Update", objlist);
        }


        public DataTable viewPic_EventsByPic_ID(int Pic_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_ID", SqlDbType.BigInt, Pic_ID));
            dt = objdal.search("procPic_Events_By_PicID", objpar);
            return dt;
        }

        public DataTable viewPic_EventsByFolder_ID(int Folder_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Folder_ID", SqlDbType.BigInt, Folder_ID));
            dt = objdal.search("procPic_Events_By_Folder_ID", objpar);
            return dt;
        }

        public DataTable viewPic_EventzByPic_ID(int Pic_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_ID", SqlDbType.BigInt, Pic_ID));
            dt = objdal.search("procPic_Eventz_By_PicID", objpar);
            return dt;
        }

        public DataTable viewAllPic_Events()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPics_Events_All");
            return dt;
        }

        public DataTable viewAllPic_Events_Used()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPics_Events_Used");
            return dt;
        }

        public DataTable viewAllPic_Events_Distinct()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPics_Events_Distinct");
            return dt;
        }

        public DataTable viewPic_EventsBy_PicName()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            dt = objdal.search("procPic_Events_By_PicName", objpar);
            return dt;
        }

        public DataTable DeletePic_EventsBy_PicID()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_ID", SqlDbType.BigInt, Pic_ID));
            dt = objdal.search("procPics_Events_Delete", objpar);
            return dt;
        }

        public DataTable DeletePic_EventsBy_PicName()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            dt = objdal.search("procPic_Events_By_PicName_Delete", objpar);
            return dt;
        }


        public void updatePics_Events_Folder_Rename()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Folder_ID", SqlDbType.BigInt, Folder_ID));
            objlist.Add(new csParameterListType("@Folder_Rename", SqlDbType.VarChar, Folder_Rename.ToString()));
            objdal.executespreturnnd("procPics_Events_Folder_Rename_Update", objlist);
        }


        public DataTable viewAllPic_Events_Folder_Rename()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPics_Events_Folder_Rename");
            return dt;
        }

        public DataTable Pic_Events_Folder_Rename_By_FolderID(Int32 FolderID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Folder_ID", SqlDbType.BigInt, Folder_ID));
            dt = objdal.search("procPics_Events_Folder_By_Folder_ID", objpar);
            return dt;
        }

        //-----------------Gallery----------------------
        public void addGallery()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@NavigateUrl", SqlDbType.VarChar, NavigateUrl.ToString()));
            objlist.Add(new csParameterListType("@AlternateText", SqlDbType.VarChar, AlternateText.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objdal.executespreturnnd("procGallery_Insert", objlist);
        }

        public void updateGallery()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Gallery_ID", SqlDbType.BigInt, Gallery_ID));
            objlist.Add(new csParameterListType("@NavigateUrl", SqlDbType.VarChar, NavigateUrl.ToString()));
            objlist.Add(new csParameterListType("@AlternateText", SqlDbType.VarChar, AlternateText.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objdal.executespreturnnd("procGallery_Update", objlist);
        }

        public DataTable viewGalleryByClient_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procGallery_By_Client_ID", objpar);
            return dt;
        }


        public DataTable viewGalleryByGallery_ID(int Gallery_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Gallery_ID", SqlDbType.BigInt, Gallery_ID));
            dt = objdal.search("procGallery_By_Gallery_ID", objpar);
            return dt;
        }

        public DataTable Delete_GalleryByGallery_ID(int Gallery_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Gallery_ID", SqlDbType.BigInt, Gallery_ID));
            dt = objdal.search("procGallery_Delete", objpar);
            return dt;
        }

        public DataTable ViewAllGallery()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procGallery_View_All");
            return dt;
        }



        //-----------------About----------------------
        public void addAbout()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procAbout_Insert", objlist);
        }

        public void updateAbout()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@About_ID", SqlDbType.BigInt, About_ID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objdal.executespreturnnd("procAbout_Update", objlist);
        }

        public void updateAbout_File()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@About_ID", SqlDbType.BigInt, About_ID));
            objlist.Add(new csParameterListType("@Title", SqlDbType.VarChar, Title.ToString()));
            objlist.Add(new csParameterListType("@Content", SqlDbType.VarChar, Content.ToString()));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procAbout_Update_File", objlist);
        }


        public DataTable viewAboutByAbout_ID(int About_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@About_ID", SqlDbType.BigInt, About_ID));
            dt = objdal.search("procAbout_By_About_ID", objpar);
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


        //-----------------Makeovers----------------------
        public DataTable viewAllMakeover_Used()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procMakeover_Salon");
            return dt;
        }
    }
}