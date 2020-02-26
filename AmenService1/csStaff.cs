using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csStaff
    {
        csDAL objdal = new csDAL();

        //------Staff------------
        public int Staff_ID { set; get; }
        public string DateEmployed { set; get; }
        public string JobType { set; get; }
        public string Position { set; get; }
        public string JobDescription { set; get; }
        public string Payroll { set; get; }
        public string Payroll_Level { set; get; }

        //---------Member------------
        public int Profile_ID { set; get; }
        public string Profile_Number { set; get; }
        public string Full_Name { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }
        public string ID_No { set; get; }
        public string Category { set; get; }
        public string Gender { set; get; }
        public string Marital { set; get; }
        public DateTime Birth_Date { set; get; }
        public DateTime Reg_Date { set; get; }
        public string Legal_Docs { set; get; }
        public string Position_Other { set; get; }
        public int MainDepartment_ID { set; get; }

        //-------------Company-------------------
        public int Client_ID { set; get; }
        public string Client_Number { set; get; }
        public string Client_Name { set; get; }


        //--------------Contacts--------------
        public int Contact_ID { set; get; }
        public string Cellphone { set; get; }
        public string Telephone { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }

        //-------------Location---------------
        public int Location_ID { set; get; }
        public string Continent { set; get; }
        public string City { set; get; }
        public string Province { set; get; }
        public string Country { set; get; }
        public string Area_Category { set; get; }
        public string Directions { set; get; }
        public string GPSCoordinates { set; get; }

        //-------------Address---------------
        public int Address_ID { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
        public string AddressCode { set; get; }

       
        
        //--------------Training--------------
        public int Training_ID { set; get; }
        public string Training_Category { set; get; }
        public DateTime Date_Training { set; get; }
        public string Training_Description { set; get; }
        public string Trainer { set; get; }
        public string Training_Material { set; get; }

        //--------------Promotion--------------
        public int Promotion_ID { set; get; }
        public string Promotion_Category { set; get; }
        public DateTime Date_Promotion { set; get; }
        public string Promotion_Description { set; get; }

        //--------------Awards--------------
        public int Award_ID { set; get; }
        public string Award_Category { set; get; }
        public DateTime Date_Awarded { set; get; }
        public string Award_Description { set; get; }

        //--------------Schedule--------------
        public int Schedule_ID { set; get; }
        public string Schedule_Category { set; get; }
        public DateTime Date_Scheduled { set; get; }
        public string Schedule_Description { set; get; }

        //--------------Archives--------------
        public int Archive_ID { set; get; }
        public string Archive_Category { set; get; }
        public string Archived_File { set; get; }
        public DateTime Date_Archived { set; get; }
        public string Archive_Description { set; get; }

        //--------------Medical--------------
        public int Medical_ID { set; get; }
        public string Medical_Category { set; get; }
        public DateTime Date_Medical { set; get; }
        public string Medical_Description { set; get; }

        //--------------Disciplinary--------------
        public int Disciplinary_ID { set; get; }
        public string Disciplinary_Category { set; get; }
        public DateTime Date_Disciplinary { set; get; }
        public string Disciplinary_Description { set; get; }


        public csStaff()
        { }
        

        public void addStaff()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@JobType", SqlDbType.VarChar, JobType.ToString()));
            objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
            objlist.Add(new csParameterListType("@JobDescription", SqlDbType.VarChar, JobDescription.ToString()));
            objdal.executespreturnnd("procStaff_Insert", objlist);
        }

        public void updateStaff()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Staff_ID", SqlDbType.BigInt, Staff_ID));
            objlist.Add(new csParameterListType("@DateEmployed", SqlDbType.VarChar, DateEmployed));
            objlist.Add(new csParameterListType("@JobType", SqlDbType.VarChar, JobType.ToString()));
            objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
            objlist.Add(new csParameterListType("@JobDescription", SqlDbType.VarChar, JobDescription.ToString()));
            objlist.Add(new csParameterListType("@Payroll", SqlDbType.VarChar, Payroll.ToString()));
            objlist.Add(new csParameterListType("@Payroll_Level", SqlDbType.VarChar, Payroll_Level.ToString()));
            objdal.executespreturnnd("procStaff_Update", objlist);
        }

        public void addStaff_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objdal.executespreturnnd("procStaffPre_Insert", objlist);
        }

        public DataTable viewStaffByClient_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procStaff_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewStaffByProfile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procStaff_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewStaffByStaff_ID(int Staff_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Staff_ID", SqlDbType.BigInt, Staff_ID));
            dt = objdal.search("procStaff_By_Staff_ID", objpar);
            return dt;
        }

        public DataTable searchForStaffByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procSearchSatffByAnyField1", objpar);
            return dt;
        }

       
        
        //------------Training----------------------
        public void addTraining()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Training_Category", SqlDbType.VarChar, Training_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Training", SqlDbType.DateTime, Date_Training));
             objlist.Add(new csParameterListType("@Trainer", SqlDbType.VarChar, Trainer.ToString()));
             objlist.Add(new csParameterListType("@Training_Material", SqlDbType.VarChar, Training_Material.ToString()));
             objlist.Add(new csParameterListType("@Training_Description", SqlDbType.VarChar, Training_Description.ToString()));
             objdal.executespreturnnd("procStaff_Trainings_Insert", objlist);

         }

        public void updateTraining()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Training_ID", SqlDbType.BigInt, Training_ID));
             objlist.Add(new csParameterListType("@Training_Category", SqlDbType.VarChar, Training_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Training", SqlDbType.DateTime, Date_Training));
             objlist.Add(new csParameterListType("@Trainer", SqlDbType.VarChar, Trainer.ToString()));
             objlist.Add(new csParameterListType("@Training_Material", SqlDbType.VarChar, Training_Material.ToString()));
             objlist.Add(new csParameterListType("@Training_Description", SqlDbType.VarChar, Training_Description.ToString()));
             objdal.executespreturnnd("procStaff_Trainings_Update", objlist);
         }

        
         public DataTable viewTrainingByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procStaff_Trainings_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewTrainingByTraining_ID(int Training_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Training_ID", SqlDbType.BigInt, Training_ID));
             dt = objdal.search("procStaff_Trainings_By_TrainingID", objpar);
             return dt;
         }

         //------------Promotions----------------------
         public void addPromotion()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Promotion_Category", SqlDbType.VarChar, Promotion_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Promotion", SqlDbType.DateTime, Date_Promotion));
             objlist.Add(new csParameterListType("@Promotion_Description", SqlDbType.VarChar, Promotion_Description.ToString()));
             objdal.executespreturnnd("procStaff_Promotions_Insert", objlist);

         }

         public void updatePromotion()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Promotion_ID", SqlDbType.BigInt, Promotion_ID));
             objlist.Add(new csParameterListType("@Promotion_Category", SqlDbType.VarChar, Promotion_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Promotion", SqlDbType.DateTime, Date_Promotion));
             objlist.Add(new csParameterListType("@Promotion_Description", SqlDbType.VarChar, Promotion_Description.ToString()));
             objdal.executespreturnnd("procStaff_Promotions_Update", objlist);

         }

         public DataTable viewPromotionByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procStaff_Promotions_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewPromotionByPromotion_ID(int Promotion_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Promotion_ID", SqlDbType.BigInt, Promotion_ID));
             dt = objdal.search("procStaff_Promotions_By_PromotionID", objpar);
             return dt;
         }


         //------------Awards----------------------
         public void addAwards()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Award_Category", SqlDbType.VarChar, Award_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Awarded", SqlDbType.DateTime, Date_Awarded));
             objlist.Add(new csParameterListType("@Award_Description", SqlDbType.VarChar, Award_Description.ToString()));
             objdal.executespreturnnd("procStaff_Awards_Insert", objlist);

         }

         public void updateAwards()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Award_ID", SqlDbType.BigInt, Award_ID));
             objlist.Add(new csParameterListType("@Award_Category", SqlDbType.VarChar, Award_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Awarded", SqlDbType.DateTime, Date_Awarded));
             objlist.Add(new csParameterListType("@Award_Description", SqlDbType.VarChar, Award_Description.ToString()));
             objdal.executespreturnnd("procStaff_Awards_Update", objlist);

         }


         public DataTable viewAwardsByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procStaff_Awards_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewAwardsByAward_ID(int Award_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Award_ID", SqlDbType.BigInt, Award_ID));
             dt = objdal.search("procStaff_Awards_By_AwardID", objpar);
             return dt;
         }


         //------------Schedules----------------------
         public void addSchedules()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Schedule_Category", SqlDbType.VarChar, Schedule_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Scheduled", SqlDbType.DateTime, Date_Scheduled));
             objlist.Add(new csParameterListType("@Schedule_Description", SqlDbType.VarChar, Schedule_Description.ToString()));
             objdal.executespreturnnd("procStaff_Schedule_Insert", objlist);

         }

         public void updateSchedules()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Schedule_ID", SqlDbType.BigInt, Schedule_ID));
             objlist.Add(new csParameterListType("@Schedule_Category", SqlDbType.VarChar, Schedule_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Scheduled", SqlDbType.DateTime, Date_Scheduled));
             objlist.Add(new csParameterListType("@Schedule_Description", SqlDbType.VarChar, Schedule_Description.ToString()));
             objdal.executespreturnnd("procStaff_Schedule_Update", objlist);

         }


         public DataTable viewSchedules_By_Profile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procStaff_Schedule_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewSchedulesBySchedule_ID(int Schedule_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Schedule_ID", SqlDbType.BigInt, Schedule_ID));
             dt = objdal.search("procStaff_Schedule_By_ScheduleID", objpar);
             return dt;
         }


         //------------Archives----------------------
         public void addArchives()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Archive_Category", SqlDbType.VarChar, Archive_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Archived", SqlDbType.DateTime, Date_Archived));
             objlist.Add(new csParameterListType("@Archived_File", SqlDbType.VarChar, Archived_File.ToString()));
             objlist.Add(new csParameterListType("@Archive_Description", SqlDbType.VarChar, Archive_Description.ToString()));
             objdal.executespreturnnd("procStaff_Archives_Insert", objlist);

         }

         public void updateArchives()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Archive_ID", SqlDbType.BigInt, Archive_ID));
             objlist.Add(new csParameterListType("@Archive_Category", SqlDbType.VarChar, Archive_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Archived", SqlDbType.DateTime, Date_Archived));
             objlist.Add(new csParameterListType("@Archived_File", SqlDbType.VarChar, Archived_File.ToString()));
             objlist.Add(new csParameterListType("@Archive_Description", SqlDbType.VarChar, Archive_Description.ToString()));
             objdal.executespreturnnd("procStaff_Archives_Update", objlist);

         }


         public DataTable viewArchivesByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procStaff_Archives_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewArchivesByArchive_ID(int Archive_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Archive_ID", SqlDbType.BigInt, Archive_ID));
             dt = objdal.search("procStaff_Archives_By_ArchiveID", objpar);
             return dt;
         }


         //------------Medical----------------------
         public void addMedical()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Medical_Category", SqlDbType.VarChar, Medical_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Medical", SqlDbType.DateTime, Date_Medical));
             objlist.Add(new csParameterListType("@Medical_Description", SqlDbType.VarChar, Medical_Description.ToString()));
             objdal.executespreturnnd("procStaff_Medical_Insert", objlist);

         }

         public void updateMedical()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Medical_ID", SqlDbType.BigInt, Medical_ID));
             objlist.Add(new csParameterListType("@Medical_Category", SqlDbType.VarChar, Medical_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Medical", SqlDbType.DateTime, Date_Medical));
             objlist.Add(new csParameterListType("@Medical_Description", SqlDbType.VarChar, Medical_Description.ToString()));
             objdal.executespreturnnd("procStaff_Medical_Update", objlist);

         }


         public DataTable viewMedicalByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procStaff_Medical_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewMedicalByMedical_ID(int Medical_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Medical_ID", SqlDbType.BigInt, Medical_ID));
             dt = objdal.search("procStaff_Medical_By_MedicalID", objpar);
             return dt;
         }


         //------------Disciplinary----------------------
         public void addDisciplinary()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Disciplinary_Category", SqlDbType.VarChar, Disciplinary_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Disciplinary", SqlDbType.DateTime, Date_Disciplinary));
             objlist.Add(new csParameterListType("@Disciplinary_Description", SqlDbType.VarChar, Disciplinary_Description.ToString()));
             objdal.executespreturnnd("procStaff_Disciplinary_Insert", objlist);
         }

         public void updateDisciplinary()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Disciplinary_ID", SqlDbType.BigInt, Disciplinary_ID));
             objlist.Add(new csParameterListType("@Disciplinary_Category", SqlDbType.VarChar, Disciplinary_Category.ToString()));
             objlist.Add(new csParameterListType("@Date_Disciplinary", SqlDbType.DateTime, Date_Disciplinary));
             objlist.Add(new csParameterListType("@Disciplinary_Description", SqlDbType.VarChar, Disciplinary_Description.ToString()));
             objdal.executespreturnnd("procStaff_Disciplinary_Update", objlist);
         }


         public DataTable viewDisciplinaryByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procStaff_Disciplinary_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewDisciplinaryByDisciplinary_ID(int Disciplinary_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Disciplinary_ID", SqlDbType.BigInt, Disciplinary_ID));
             dt = objdal.search("procStaff_Disciplinary_By_DisciplinaryID", objpar);
             return dt;
         }
    }
}
