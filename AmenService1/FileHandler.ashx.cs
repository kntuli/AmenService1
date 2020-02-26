using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AmenService1
{
    /// <summary>
    /// Summary description for FileHandler
    /// </summary>
    public class FileHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            //var httpPostedFile = HttpContext.Current.Request.Files["UploadedImage"];
            HttpFileCollection httpFileCollection = context.Request.Files;
            string fName = "";
            string fSize = "";
            string fType = "";
            foreach (string fileName in httpFileCollection)
            {

                csPhoto objFile = new csPhoto();

                HttpPostedFile file = httpFileCollection.Get(fileName);
                    //[EnableCors(origins: "*", headers: "*", methods: "*")]
                //context.Response.ContentType = "text/plain";
                //context.Response.AppendHeader("Content-Type", "application/json; charset=utf-8"); 
                //context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
                //context.Response.AppendHeader("Access-Control-Allow-Methods", "POST");
                //context.Response.AppendHeader("Access-Control-Request-Headers", "X-PINGOTHER");
                //HttpPostedFile file = context.Request.Files["fileToUpload"];

                //if (context.Request.HttpMethod == "OPTIONS")
                //{
                //    context.Response.AddHeader("Access-Control-Allow-Origin", "*");
                //    context.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
                //    context.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
                //}

                fName = file.FileName;
                fSize = file.ContentLength.ToString();
                fType = file.ContentType;

                if (file != null && file.ContentLength > 0)
                {
                    string MainCategory = context.Request["MainCategory"];

                    if (MainCategory == "Profile")
                    {
                        Int32 profileID = Convert.ToInt32(context.Request["profileID"]);
                        //string category = context.Request["category"];
                            
                        BinaryReader b = new BinaryReader(file.InputStream);
                        byte[] byte_original = b.ReadBytes(file.ContentLength);

                        //byte[] byte_original = new byte[file.InputStream.Length];
                        //file.InputStream.Read(byte_original, 0, byte_original.Length);
                        csCreateThumb objCreateThumb = new csCreateThumb();
                        byte[] byte_thumb = objCreateThumb.CreateThumbnail(byte_original, 100, 50, 50);

                        objFile.Profile_ID = profileID;
                        objFile.blobdata = byte_original;
                        objFile.thumbdata = byte_thumb;
                        objFile.filename = fName;
                        objFile.Photo_Date = DateTime.Now.Date.ToString();
                        objFile.addPhoto2();

                    }

                }

            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

}