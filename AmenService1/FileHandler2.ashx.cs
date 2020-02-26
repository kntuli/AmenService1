using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AmenService1
{
    /// <summary>
    /// Summary description for FileHandler2
    /// </summary>
    public class FileHandler2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpFileCollection httpFileCollection = context.Request.Files;
            string fName = "";
            string fSize = "";
            string fType = "";
            foreach (string fileName in httpFileCollection)
            {

                csFiles objFile = new csFiles();

                HttpPostedFile file = httpFileCollection.Get(fileName);

                //HttpPostedFile file = context.Request.Files["fileToUpload"];


                fName = file.FileName;
                fSize = file.ContentLength.ToString();
                fType = file.ContentType;

                if (file != null && file.ContentLength > 0)
                {
                    string MainCategory = context.Request["MainCategory"];

                    if (MainCategory == "Expense")
                    {
                        Int32 clientid = Convert.ToInt32(context.Request["clientid"]);
                        Int32 expenseid = Convert.ToInt32(context.Request["expenseid"]);
                        string category = context.Request["category"];

                        BinaryReader b = new BinaryReader(file.InputStream);
                        byte[] byte_original = b.ReadBytes(file.ContentLength);

                        //byte[] byte_original = new byte[file.InputStream.Length];
                        //file.InputStream.Read(byte_original, 0, byte_original.Length);
                        //csCreateThumb objCreateThumb = new csCreateThumb();
                        //byte[] byte_thumb = objCreateThumb.CreateThumbnail(byte_original, 100, 50, 50);

                        objFile.clientID = clientid;
                        objFile.expenseID = expenseid;
                        objFile.category = category;
                        objFile.fileData = byte_original;
                        objFile.fileName = fName;
                        objFile.fileSize = fSize;
                        objFile.fileType = fType;
                        objFile.addExpenseFile();

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