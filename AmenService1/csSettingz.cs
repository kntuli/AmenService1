using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csSettingz
    {

        csDAL objdal = new csDAL();

        public int Setting_ID { set; get; }
        public string Lang_Translator { set; get; }
 

        public csSettingz()
        { }
        
        public void updateProfile_Settings_SignUp()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Setting_ID", SqlDbType.BigInt, Setting_ID));
            objlist.Add(new csParameterListType("@Lang_Translator", SqlDbType.VarChar, Lang_Translator.ToString()));
            objdal.executespreturnnd("procSettings_Update", objlist);
        }

         public DataTable viewSettings()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procView_Settings");
            return dt;
        }
        
    }
}
