using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Drawing;
using System.IO;

namespace AmenService1
{
    public class csCreateThumb
    {

        public byte[] CreateThumbnail(byte[] PassedImage, int LargestSide, int Height, int Width)
        {
            byte[] ReturnedThumbnail;

            using (System.IO.MemoryStream StartMemoryStream = new System.IO.MemoryStream(), NewMemoryStream = new System.IO.MemoryStream())
            {
                // write the string to the stream  
                StartMemoryStream.Write(PassedImage, 0, PassedImage.Length);

                // create the start Bitmap from the MemoryStream that contains the image  
                System.Drawing.Bitmap startBitmap = new System.Drawing.Bitmap(StartMemoryStream);

                // set thumbnail height and width proportional to the original image.  
                int newHeight;
                int newWidth;
                double HW_ratio;
                if (startBitmap.Height > startBitmap.Width)
                {
                    newHeight = LargestSide;
                    HW_ratio = (double)((double)LargestSide / (double)startBitmap.Height);
                    newWidth = (int)(HW_ratio * (double)startBitmap.Width);
                }
                else
                {
                    newWidth = LargestSide;
                    HW_ratio = (double)((double)LargestSide / (double)startBitmap.Width);
                    newHeight = (int)(HW_ratio * (double)startBitmap.Height);
                }
                newHeight = Height;
                newWidth = Width;
                // create a new Bitmap with dimensions for the thumbnail.  
                System.Drawing.Bitmap newBitmap = new System.Drawing.Bitmap(newWidth, newHeight);

                // Copy the image from the START Bitmap into the NEW Bitmap.  
                // This will create a thumnail size of the same image.  
                newBitmap = ResizeImage(startBitmap, newWidth, newHeight);

                // Save this image to the specified stream in the specified format.  
                newBitmap.Save(NewMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Fill the byte[] for the thumbnail from the new MemoryStream.  
                ReturnedThumbnail = NewMemoryStream.ToArray();
            }
            // return the resized image as a string of bytes.  
            return ReturnedThumbnail;
        }

        // Resize a Bitmap  
        private static System.Drawing.Bitmap ResizeImage(System.Drawing.Bitmap image, int width, int height)
        {
            System.Drawing.Bitmap resizedImage = new System.Drawing.Bitmap(width, height);
            using (System.Drawing.Graphics gfx = System.Drawing.Graphics.FromImage(resizedImage))
            {
                gfx.DrawImage(image, new System.Drawing.Rectangle(0, 0, width, height),
                    new System.Drawing.Rectangle(0, 0, image.Width, image.Height), System.Drawing.GraphicsUnit.Pixel);
            }
            return resizedImage;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }


        //public static byte[] CreateThumbnail(string path, int maxHeight, int maxWidth, string extension)
        //{

        //    path = HttpContext.Current.Server.MapPath(path);

        //    Image img = System.Drawing.Image.FromFile(path);

        //    extension = extension.ToLower();



        //    byte[] buffer = null;

        //    try
        //    {

        //        int width = img.Size.Width;

        //        int height = img.Size.Height;



        //        bool doWidthResize = (maxWidth > 0 && width > maxWidth && width > maxHeight);

        //        bool doHeightResize = (maxHeight > 0 && height > maxHeight && height > maxWidth);



        //        //only resize if the image is bigger than the max

        //        if (doWidthResize || doHeightResize)
        //        {

        //            int iStart;

        //            Decimal divider;

        //            if (doWidthResize)
        //            {

        //                iStart = width;

        //                divider = Math.Abs((Decimal)iStart / (Decimal)maxWidth);

        //                width = maxWidth;

        //                height = (int)Math.Round((Decimal)(height / divider));

        //            }

        //            else
        //            {

        //                iStart = height;

        //                divider = Math.Abs((Decimal)iStart / (Decimal)maxHeight);

        //                height = maxHeight;

        //                width = (int)Math.Round((Decimal)(width / divider));

        //            }

        //            System.Drawing.Image newImg = img.GetThumbnailImage(width, height, null, new System.IntPtr());

        //            try
        //            {

        //                using (MemoryStream ms = new MemoryStream())
        //                {

        //                    if (extension.IndexOf("jpg") > -1)
        //                    {

        //                        newImg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

        //                    }

        //                    else if (extension.IndexOf("png") > -1)
        //                    {

        //                        newImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

        //                    }

        //                    else if (extension.IndexOf("gif") > -1)
        //                    {

        //                        newImg.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

        //                    }

        //                    else // if (extension.IndexOf("bmp") > -1)
        //                    {

        //                        newImg.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

        //                    }

        //                    buffer = ms.ToArray();

        //                }

        //            }

        //            finally
        //            {

        //                newImg.Dispose();

        //            }

        //        }

        //    }

        //    catch
        //    {

        //        System.Drawing.Image imNoimage = System.Drawing.Image.FromFile("/Images/noimage.gif");

        //        try
        //        {

        //            using (MemoryStream ms = new MemoryStream())
        //            {

        //                imNoimage.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

        //                buffer = ms.ToArray();

        //            }

        //        }

        //        finally
        //        {

        //            imNoimage.Dispose();

        //        }

        //    }

        //    finally
        //    {

        //        img.Dispose();

        //    }

        //    return buffer;

        //} 
    }
}
