using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;


namespace AmenService1
{
    public class csTranslator
    {
        csDAL objdal = new csDAL();

        public string ToTranslate { set; get; }
        public string FromLanguage { set; get; }
        public string ToLanguage { set; get; }

        public csTranslator()
        {

        } 

        public csTranslator(string cToTranslate, string cFromLanguage, string cToLanguage)
        {
            ToTranslate = cToTranslate;
            FromLanguage = cFromLanguage;
            ToLanguage = cToLanguage;
        }
     

        public string Traaanslator(string strToTranslate, string strFromLanguage, string strToLanguage)
        {

            String text = strToTranslate;
            String fromLanguage = strFromLanguage; // english
            String toLanguage = strToLanguage; // french
            String apiKey = "AIzaSyB64Xy_LUigKF54M141RtzZVEwTJ0UT8BI"; // get key from https://code.google.com/apis/console/

            // create the url for making web request
            String apiUrl = "https://www.googleapis.com/language/translate/v2?key={0}&source={1}&target={2}&q={3}";
            String url = String.Format(apiUrl, apiKey, fromLanguage, toLanguage, text);

            // get translated text using google API.
            String data = Translate(url);
 
            return data;

        }

       public string Translate(string url)
        {
            string text = string.Empty;
            string resit = string.Empty;
            string strFinal = string.Empty;

            try
            {
                // create the web request
                WebRequest req = HttpWebRequest.Create(url);

                // set the request method
                req.Method = "GET";

                // get the response
                using (WebResponse res = req.GetResponse())
                {
                    // read response stream
                    // you must specify the encoding as UTF8 
                    // because google returns the response in UTF8 format
                    //using (StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8))
                    using (StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8))
                    {
                        // read text from response stream
                        text = sr.ReadToEnd();

                        text = text.Remove(0, 61);

                        int index1 = text.LastIndexOf("}");
                        if (index1 > 0)
                            text = text.Substring(0, index1 - 10); // 
                        text = text.Trim();
                        text = stripLeadingAndTrailingQuotes(text);

                    }
                }
            }
            catch
            {
                //throw; // throw the exception as is/
            }

            // return text to callee
            return text;
        }

        public String stripLeadingAndTrailingQuotes(String str)
        {
            //if (str.StartsWith("\""))
            //{
            //    str = str.Substring(1, str.Length + 1);
            //}
            if (str.EndsWith("\""))
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }

        public String DetectLang()
        {
            HttpRequest Request = HttpContext.Current.Request;
            if (Request.UserLanguages == null)
                return null;

            string Lang = Request.UserLanguages[0];
            Lang = Request.UserLanguages[0].ToLowerInvariant().Trim();
            if (Lang != null)
            {
                Lang = Lang.Remove(2);
            }
            return Lang;
        }
    }
}
