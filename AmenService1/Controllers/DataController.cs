using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
//using System.Web.Routing;
namespace AmenService1.Controllers
{
    public class DataController : ApiController
    {
        [HttpGet]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        //[Route("api/UploadImage")]
        public HttpResponseMessage UploadImage()
        {
            //string imageName = null;
            var httpRequest = HttpContext.Current.Request;
            var postedFile = httpRequest.Files["Image"];

            //imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", ".");
            //imageName = imageName + DateTime.Now.ToString("yymmssfff")+ Path.GetExtension(postedFile.FileName);
            //var filePath = HttpContext.Current.Server.MapPath("~/Images/" + imageName);
            //postedFile.SaveAs(filePath);

            //Save to DB
            csPhoto objFile = new csPhoto();

            string fName = "";
            string fSize = "";
            string fType = "";

            fName = postedFile.FileName;
            fSize = postedFile.ContentLength.ToString();
            fType = postedFile.ContentType;

            if (postedFile != null && postedFile.ContentLength > 0)
            {
                string MainCategory = httpRequest["MainCategory"];

                if (MainCategory == "Profile")
                {
                    Int32 profileID = Convert.ToInt32(httpRequest["profileID"]);
                    //string category = context.Request["category"];

                    BinaryReader b = new BinaryReader(postedFile.InputStream);
                    byte[] byte_original = b.ReadBytes(postedFile.ContentLength);

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
            //----------------------------Save to DB-------------------------------------



            return Request.CreateResponse(HttpStatusCode.Created);

        }
    }
}