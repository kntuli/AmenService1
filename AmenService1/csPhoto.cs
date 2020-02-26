using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csPhoto
    {
        csDAL objdal = new csDAL();

        public Int32 Photo_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public string filename { set; get; }
        public byte[] blobdata { set; get; }
        public byte[] thumbdata { set; get; }
        public string base64blobdata { set; get; }
        public string base64thumbdata { set; get; }
        public string Profile_Photo { set; get; }
        public string Photo_Date { set; get; }
        
        public csPhoto()
        { }

        //----------Photo---------------------
        public void addPhoto()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procPhoto_Insert", objlist);
        }

        public void addPhoto2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objlist.Add(new csParameterListType("@Photo_Date", SqlDbType.VarChar, Photo_Date.ToString()));
            objdal.executespreturnnd("procPhoto_Insert2", objlist);
        }

        public void addPhoto2a()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename));
            objlist.Add(new csParameterListType("@base64blobdata", SqlDbType.VarChar, base64blobdata));
            objlist.Add(new csParameterListType("@base64thumbdata", SqlDbType.VarChar, base64thumbdata));
            objlist.Add(new csParameterListType("@Photo_Date", SqlDbType.VarChar, Photo_Date));
            objdal.executespreturnnd("procPhoto_Insert2a", objlist);
        }


        public void updatePhoto()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Photo_ID", SqlDbType.BigInt, Photo_ID));
            objlist.Add(new csParameterListType("@filename", SqlDbType.VarChar, filename.ToString()));
            objlist.Add(new csParameterListType("@blobdata", SqlDbType.VarBinary, blobdata));
            objdal.executespreturnnd("procPhoto_Update", objlist);
        }

        public void updatePhoto2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Photo_ID", SqlDbType.BigInt, Photo_ID));
            objlist.Add(new csParameterListType("@thumbdata", SqlDbType.VarBinary, thumbdata));
            objdal.executespreturnnd("procPhoto_Update2", objlist);
        }

        public void updateProfile_Photo()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Photo_ID", SqlDbType.BigInt, Photo_ID));
            objdal.executespreturnnd("procProfile_Photo_Update", objlist);
        }

        public DataTable viewPhoto_Profile_By_Profile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPhoto_Profile_View_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewPhotoByProfile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPhoto_View_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewPhotoByProfile_ID_Public(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPhoto_View_By_Profile_ID_Public", objpar);
            return dt;
        }

        public DataTable viewPhotoByProfile_ID_Public_Yes(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPhoto_View_By_Profile_ID_Public_Yes", objpar);
            return dt;
        }

        public DataTable viewPhotoByProfile_ID_Nodata(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPhoto_View_By_Profile_ID_Nodata", objpar);
            return dt;
        }

        public DataTable viewPhotoByPhoto_ID(Int32 Photo_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Photo_ID", SqlDbType.BigInt, Photo_ID));
            dt = objdal.search("procPhoto_View_By_Photo_ID", objpar);
            return dt;
        }

        public DataTable Delete_Photo()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Photo_ID", SqlDbType.BigInt, Photo_ID));
            dt = objdal.search("procPhoto_Delete", objpar);
            return dt;
        }

        public DataTable setAsProfilePhoto()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Photo_ID", SqlDbType.BigInt, Photo_ID));
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPhoto_SetAs_Profile", objpar);
            return dt;
        }

        public DataTable ViewAllPhoto()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPhoto_View_All");
            return dt;
        }

    }
}
