using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace AmenService1
{
    public class csProfiles
    {

        csDAL objdal = new csDAL();

        public Int32 Profile_ID { set; get; }
        public string Profile_Number { set; get; }
        public string Full_Name { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }
        public string ID_No { set; get; }
        public string Category { set; get; }

        public string AgeCategory { set; get; }
        public string Gender { set; get; }
        public string Marital { set; get; }

        public string Birth_Date { set; get; }
        public string Birth_Year { set; get; }
        public string Birth_Month { set; get; }
        public string Birth_Day { set; get; }

        public string Wedding_Date { set; get; }
        public string Wedding_Year { set; get; }
        public string Wedding_Month { set; get; }
        public string Wedding_Day { set; get; }

        public Int32 ageBracket_ID { set; get; }
        public string Age_Bracket { set; get; }
        public string Reg_Date { set; get; }
        public string Legal_Docs { set; get; }
        public string Position_Other { set; get; }
        public Int32 MainDepartment_ID { set; get; }
        public Int32 Category_ID { set; get; }
        public Int32 Category_ID_From { set; get; }
        public string LastUpdate_Date { set; get; }
        public string Church_Worker { set; get; }
        public Int32 HomeCell_ID { set; get; }
        public Int32 Network_ID { set; get; }

        //-------------Harvest-------------------
        public Int32 Harvest_ID { set; get; }
        public string Harvest_Number { set; get; }
        public string Harvest_Status { set; get; }
        public string Church_Attending { set; get; }
        public string Harvest_Date { set; get; }

        //-------------Harvesting-------------------
        public string HowDoYouKnow_Harvest { set; get; }
        public string ChurchAttending_Harvest { set; get; }
        public string PersonHarvestKnowInOurChurch { set; get; }
        public string Notes_Harvesting { set; get; }

        //-------------Company-------------------
        public Int32 Client_ID { set; get; }
        public string Client_Number { set; get; }
        public string Client_Name { set; get; }   
 
        //--------------Contacts--------------
        public Int32 Contact_ID { set; get; }
        public string Cellphone { set; get; }
        public string Telephone { set; get; }
        public string PhoneH { set; get; }
        public string PhoneW { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public string SocialMedia { set; get; }
        public string SocialMedia1 { set; get; }
        public string SocialMedia2 { set; get; }
        public string SocialMedia3 { set; get; }

        //-------------Location---------------
        public Int32 Location_ID { set; get; }
        public string Continent { set; get; }
        public string City { set; get; }
        public string Province { set; get; }
        public string Country { set; get; }
        public string Area_Category { set; get; }
        public string Area_Name { set; get; }
        public string Directions { set; get; }
        public string GPSCoordinates { set; get; }

        //-------------Address---------------
        public Int32 Address_ID { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
        public string AddressCode { set; get; }


        //-------------Education--------------
        public Int32 Education_ID { set; get; }
        public string Tetiary { set; get; }
        public string High_School { set; get; }
        public string Institution { set; get; }
        public string Qualification { set; get; }
        public string Qualification_Level { set; get; }
        public string Intended_Career { set; get; }
        public string Study_Period { set; get; }
        public string Study_Years { set; get; }
        public string Study_Status { set; get; }

        //-------------Work-------------------
        public Int32 Work_ID { set; get; }
        public string Employer { set; get; }
        public string Position { set; get; }
        public string JobDescription { set; get; }
        public string JobStatus { set; get; }

        //-------------Pics-------------------
        public Int32 Pic_ID { set; get; }
        public string Pic_Image { set; get; }
        public string Profile_Pic { set; get; }

        //-----------Spiritual_Activities----------------

        public Int32 Activity_ID { set; get; }
        public string Activity { set; get; }
        public string Description { set; get; }
        public string Date { set; get; }

        //-----------Family----------------

        public Int32 Family_ID { set; get; }
        public string Relationship { set; get; }
        public string FullNames { set; get; }
        public string Birthdate { set; get; }
        public string WorkPlace { set; get; }
        public string StudyPalce { set; get; }
        public string StudyLevels { set; get; }
        public string ChurchAttending { set; get; }
        public string Saved { set; get; }
        public string Baptised { set; get; }

        //--------Career---------------
        public Int32 Career_ID { set; get; }
        public string Work_Status { set; get; }
        public string Work_For { set; get; }
        public string Work_For_Name { set; get; }
        public string Department_Name { set; get; }
        public string Work_Position { set; get; }
        public string Work_Period { set; get; }
        public string Work_Years { set; get; }


        //----------Spiritual Questionare----------
        public string Questionare_Date { set; get; }
        public string Saved_Date { set; get; }
        public string HolySpirit { set; get; }
        public string ChurchMember { set; get; }
        public string Ministry { set; get; }
        public string Submission { set; get; }

        //----------Prayer Items----------
        public Int32 Prayer_Item_ID { set; get; }
        public string Prayer_Item_Type { set; get; }
        public string Prayer_Item_Date { set; get; }
        public string Prayer_Item_Number { set; get; }
        public string Prayer_Item { set; get; }
        public string Prayer_Item_Verses { set; get; }
        public string Pray_With_Me { set; get; }

        //----------Testimonies----------
        public Int32 Testimonies_ID { set; get; }
        public string Testimonies_Number { set; get; }
        public string Testimonies_Date { set; get; }
        public string Testimonies { set; get; }
        public string Testimonies_Show { set; get; }

        //----------Friends------------
        public Int32 Friend_Profile_ID { set; get; }

        //----------Followups----------
        public Int32 Followup_ID { set; get; }
        public string Followup_Date { set; get; }
        public string Followup_Description { set; get; }


        //----------Converts----------
        public Int32 NewConvert_ID { set; get; }
        public string Convertion_Date { set; get; }
        public string WhoLedToChrist_By { set; get; }
        public string WhereDidItHappen { set; get; }
        public string HowDidYouHereAboutChurch { set; get; }
        public string PreviousChurch { set; get; }
        public string PersonYouKnowInOurChurch { set; get; }
        public string AnyPrayerNeeds { set; get; }


        //----------NewConvert Followups----------
        public Int32 Followup_By_ID { set; get; }
        public string Followup_Notes { set; get; }
        public string Followup_Recommendations { set; get; }

        //----------Attritions----------
        public Int32 Attrition_ID { set; get; }
        public string Attrition_Date { set; get; }
        public string Attrition_Description { set; get; }

        //----------Attritions----------
        public Int32 Guest_ID { set; get; }
        public string Guest_Date { set; get; }
        public string Guest_Type { set; get; }
        public string isSaved { set; get; }
        public string isBaptised { set; get; }
        public string LifeStatus { set; get; }

        //----------Home Cells----------

        public Int32 Home_Cell_Member_ID { set; get; }
        public Int32 Cell_ID { set; get; }
        public string Cell_Number { set; get; }
        public string Start_Date { set; get; }
        public string Cell_Name { set; get; }
        public string Cell_Venue { set; get; }
        public string Cell_Day { set; get; }
        public string Cell_Time { set; get; }
        public Int32 Leader_ID { set; get; }
        public Int32 Intern1_ID { set; get; }
        public Int32 Intern2_ID { set; get; }
        public string Cell_Active { set; get; }
        public Int32 Group_ID { set; get; }

        //----------Home Cell Members----------
        public Int32 Member_ID { set; get; }
        public string Member_Contacts { set; get; }
        public string Member_AreaName { set; get; }
        public string Status { set; get; }
        public string Church_Member { set; get; }
        public string Member_Active { set; get; }

        //----------Home Cell Visitors----------
        public Int32 Visitor_ID { set; get; }
        public string Contacts { set; get; }
        public string Physical_Address { set; get; }
        public string Attend_Church { set; get; }
        public string Visit_Regular { set; get; }
        public Int32  Invited_By_ID { set; get; }
        
        //----------Home Cell Reports----------
        public Int32 Report_ID { set; get; }
        public string Report_Date { set; get; }
        public string Total_Attended { set; get; }
        public string Total_Absent { set; get; }
        public string Total_Visitors { set; get; }
        public string Cell_Topic { set; get; }
        public string Cell_Topic_Understanding { set; get; }
        public string Cell_Topic_Comments { set; get; }

        public Int32 New_Members { set; get; }
        public Int32 Members_Present { set; get; }
        public Int32 Adult_Guest_Present { set; get; }
        public Int32 Children_Present { set; get; }
        public Int32 Tot_Absent { set; get; }
        public Int32 Total_Present { set; get; }
        public string Welcome { set; get; }
        public string Worship { set; get; }
        public string Word { set; get; }
        public string Works { set; get; }

        public string From_Date { set; get; }
        public string To_Date { set; get; }

        //-----------Attendance--------------
        public Int32 Attendance_ID { set; get; }
        public string MemberOrGuest { set; get; }
        public string GuestOrMember { set; get; }
        public string Guest_Name { set; get; }
        public string PresentOrAbsent { set; get; }


        //----------------Home Cell Events-----------------------
        public Int32 Event_ID { set; get; }
        public string Event_Date { set; get; }
        public string Event_Name { set; get; }
        public string Event_Time { set; get; }
        public string Event_Venue { set; get; }
        public string Event_Description { set; get; }


        //----------Home Cell Multiplications----------
        public Int32 Multiplication_ID { set; get; }
        public string Multiplication_Date { set; get; }
        public string New_Cell_Name { set; get; }
        public string New_Cell_Venue { set; get; }
        public Int32 New_Cell_Leader_ID { set; get; }
        public Int32 New_Cell_Intern1_ID { set; get; }
        public Int32 New_Cell_Intern2_ID { set; get; }

        public Int32 Worker_ID { set; get; }
        public Int32 Department_ID { set; get; }
        public string Workers_Year { set; get; }
        public string Responsibilities { set; get; }
        public string Period { set; get; }
        public string End_Date { set; get; }
        public string Personal_Status { set; get; }
        public string IsActive { set; get; }
        public string Migration_Date { set; get; }
        
        public string Year_From { set; get; }
        public string Year_To { set; get; }
        public string Promoted_Date { set; get; }

        public Int32 District_ID { set; get; }
        public string District { set; get; }
        public string Leadership_Year { set; get; }
        public string Mandate { set; get; }
        public string Leadership_Period { set; get; }

        public Int32 Zone_ID { set; get; }
        public string Zone { set; get; }

        public Int32 Manager_ID { set; get; }

        public Int32 Structure_ID { set; get; }
        public Int32 Diagram_ID { set; get; }
        public Int32 Parent_ID { set; get; }
        public Int32 Child_ID { set; get; }
        public Int32 Child_Name_ID { set; get; }
        public string Child_Name { set; get; } 
        public string Designation { set; get; } 
 
        public csProfiles()
        { }

        #region Attrition

        public DataTable crudeAttrition(string crude, Int32 clientID, Int32 profileID, int attritionID, string attritionDate, string category, string attritionDescription)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
            objlist.Add(new csParameterListType("@Attrition_ID", SqlDbType.BigInt, attritionID));
            objlist.Add(new csParameterListType("@Attrition_Date", SqlDbType.VarChar, attritionDate));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, category));
            objlist.Add(new csParameterListType("@Attrition_Description", SqlDbType.VarChar, attritionDescription));
            dt = objdal.search("procAttritionCrude", objlist);
            return dt;
        }

        #endregion

        #region Profile
        //--------------Profile----------------------------------------

        //public void addNewProfile()
        //{
        //    csDAL objdal = new csDAL();
        //    List<csParameterListType> objlist = new List<csParameterListType>();
        //    objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
        //    objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
        //    objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
        //    objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
        //    objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
        //    objlist.Add(new csParameterListType("@Age_Bracket", SqlDbType.VarChar, Age_Bracket.ToString()));
        //    objlist.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
        //    objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
        //    objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
        //    objdal.executespreturnnd("procProfileNew_Insert", objlist);
        //}

        public DataTable addNewProfile()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
            objpar.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
            objpar.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objpar.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
            objpar.Add(new csParameterListType("@Age_Bracket", SqlDbType.VarChar, Age_Bracket.ToString()));
            objpar.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
            objpar.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
            objpar.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
            dt = objdal.search("procProfileNew_Insert", objpar);
            return dt;
        }

        public DataTable addNewProfile2()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objpar.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
            objpar.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
            objpar.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            objpar.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
            objpar.Add(new csParameterListType("@ageBracket_ID", SqlDbType.BigInt, ageBracket_ID));
            objpar.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
            objpar.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
            objpar.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
            dt = objdal.search("procProfileNew_Insert2", objpar);
            return dt;
        }


         public void addProfile()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procProfile_Insert", objlist);
         }

         public void updateProfile()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
             objdal.executespreturnnd("procProfile_Update", objlist);
         }

         public void updateProfile_ChurchReg()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
             objdal.executespreturnnd("procProfile_Update_ChurchReg", objlist);
         }

         public void updateProfile_MemberReg()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procProfile_Update_MemberReg", objlist);
         }

         public void updateProfile_CMember()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@ID_No", SqlDbType.VarChar, ID_No.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
             objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
             objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
             objlist.Add(new csParameterListType("@Age_Bracket", SqlDbType.VarChar, Age_Bracket.ToString()));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Date", SqlDbType.VarChar, Wedding_Date.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Year", SqlDbType.VarChar, Wedding_Year.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Month", SqlDbType.VarChar, Wedding_Month.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Day", SqlDbType.VarChar, Wedding_Day.ToString()));
             objlist.Add(new csParameterListType("@Church_Worker", SqlDbType.VarChar, Church_Worker.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procProfile_Update_CMember", objlist);
         }

         public void updateProfile_CMember2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@ID_No", SqlDbType.VarChar, ID_No.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
             objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
             objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
             objlist.Add(new csParameterListType("@Age_Bracket", SqlDbType.VarChar, Age_Bracket.ToString()));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Date", SqlDbType.VarChar, Wedding_Date.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Year", SqlDbType.VarChar, Wedding_Year.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Month", SqlDbType.VarChar, Wedding_Month.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Day", SqlDbType.VarChar, Wedding_Day.ToString()));
             objlist.Add(new csParameterListType("@HomeCell_ID", SqlDbType.BigInt, HomeCell_ID));
             objlist.Add(new csParameterListType("@Network_ID", SqlDbType.BigInt, Network_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procProfile_Update_CMember2", objlist);
         }

         public void updateProfile_CMember3()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@ID_No", SqlDbType.VarChar, ID_No.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
             objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
             objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
             objlist.Add(new csParameterListType("@ageBracket_ID", SqlDbType.BigInt, ageBracket_ID));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Date", SqlDbType.VarChar, Wedding_Date.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Year", SqlDbType.VarChar, Wedding_Year.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Month", SqlDbType.VarChar, Wedding_Month.ToString()));
             objlist.Add(new csParameterListType("@Wedding_Day", SqlDbType.VarChar, Wedding_Day.ToString()));
             objlist.Add(new csParameterListType("@HomeCell_ID", SqlDbType.BigInt, HomeCell_ID));
             objlist.Add(new csParameterListType("@Network_ID", SqlDbType.BigInt, Network_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procProfile_Update_CMember3", objlist);
         }

         public void updateProfile_Position_By_Profile_ID()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
             objdal.executespreturnnd("procProfile_Position_By_Profile_ID_Update", objlist);
         }

         public DataTable viewProfileDetailsByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procProfileDetails_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewProfileByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procProfiles_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewProfilePreAllByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procProfilePre_All", objpar);
             return dt;
         }

         public DataTable viewProfilePreAllByProfile_ID2(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procProfilePre_All2", objpar);
             return dt;
         }


         public DataTable viewProfileID_ByProfile_Number(string Profile_Number)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_Number", SqlDbType.VarChar, Profile_Number.ToString()));
             dt = objdal.search("procProfileID_By_ClientNumber", objpar);
             return dt;
         }

         public DataTable viewProfileByMainDepartment_ID(int MainDepartment_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@MainDepartment_ID", SqlDbType.BigInt, MainDepartment_ID));
             dt = objdal.search("procProfiles_By_MainDepartment_ID", objpar);
             return dt;
         }

         public DataTable viewProfileByClient_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewProfileByClient_ID_NoEmpty_Name(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_By_Client_ID_NoEmpty_Name", objpar);
             return dt;
         }

         public DataTable viewProfile_MembersOny_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_MembersOnly_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewProfile_Members_SmallOrLarge_By_Client_ID(Int32 Client_ID, string smallOrLarge)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@SmallOrLarge", SqlDbType.VarChar, smallOrLarge));
             dt = objdal.search("procProfiles_Members_SmallOrLarge_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewProfile_MembersOny_By_Client_ID2(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_MembersOnly_By_Client_ID2", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID_Date(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date", objpar);
             return dt;
         }

         public DataTable viewProfileByClient_ID0(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_By_Client_ID0", objpar);
             return dt;
         }


         public DataTable viewProfileByClient_IDandMainDepartment_ID(int Client_ID, int MainDepartment_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@MainDepartment_ID", SqlDbType.BigInt, MainDepartment_ID));
             dt = objdal.search("procProfiles_By_Client_MainDepartment_ID", objpar);
             return dt;
         }

         public void addProfile_Pre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_Number", SqlDbType.VarChar, Profile_Number.ToString()));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@MainDepartment_ID", SqlDbType.BigInt, MainDepartment_ID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procProfilePre_Insert", objlist);
         }

            //        objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            //objpar.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
            //objpar.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
            //objpar.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
            //objpar.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
            //objpar.Add(new csParameterListType("@ageBracket_ID", SqlDbType.BigInt, ageBracket_ID));
            //objpar.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
            //objpar.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
            //objpar.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));


         public DataTable getAllProfiles()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procProfile_ViewALL");
             return dt;
         }

         public void deleteProfile(int User_ID)
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturndr("procProfile_Delete", objpar);
         }

         public DataTable searchForProfileByAnyField(string sVariable)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearch_ByAnyField", objpar);
             return dt;
         }

         public DataTable searchForProfileByAnyField1(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchProfileByAnyField1", objpar);
             return dt;
         }

         public DataTable searchForProfileByAnyField2(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchProfileByAnyField2", objpar);
             return dt;
         }
    

         public DataTable getClientIDByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClientBy_ProfileID", objpar);
             return dt;
         }

         public DataTable searchForProfileByAnyField1(string sVariable)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procMembers_Search_ByAnyField1", objpar);
             return dt;
         }

         public DataTable searchForPartakersByAnyFieldExcl_Profile_ID_Searching(string sVariable, int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procMembers_Search_ByAnyFieldExcl_Profile_ID_Searching", objpar);
             return dt;
         }

         #endregion

         #region BirthDays
         //-------------------------------BirthDays-------------------------


         public DataTable viewAllBirthdaysByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procBirthdays_Today_By_Client_ID_New", objpar);
             return dt;
         }

         public DataTable viewAllBirthdays_NextWeek_ByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procBirthdays_NextWeek_By_Client_ID_New", objpar);
             return dt;
         }

         public DataTable viewAllBirthdays_WholeYear_ByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procBirthdays_All_By_Client_ID_New", objpar);
             return dt;
         }

         public DataTable viewAllBirthdays_LastWeek_ByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procBirthdays_LastWeek_By_Client_ID_New", objpar);
             return dt;
         }

         public DataTable viewAllBirthdays()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procBirthdays_Today_By_Client_ID_New");
             return dt;
         }
         #endregion

         #region Weddings
         //-------------------------------Weddings-------------------------


         public DataTable viewAllWeddingByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procWedding_Today_By_Client_ID_New", objpar);
             return dt;
         }

         public DataTable viewAllWedding_NextWeek_ByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procWedding_NextWeek_By_Client_ID_New", objpar);
             return dt;
         }

         public DataTable viewAllWedding_WholeYear_ByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procWedding_WholeYear_By_Client_ID_New", objpar);
             return dt;
         }


         public DataTable viewAllWedding_LastWeek_ByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procWedding_LastWeek_By_Client_ID_New", objpar);
             return dt;
         }

         public DataTable viewAllWedding()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procWedding_Today_By_Client_ID_New");
             return dt;
         }
         #endregion
         
         #region Harvest
         public void addHarvest_Pre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Harvest_Number", SqlDbType.VarChar, Harvest_Number.ToString()));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procHarvest_Pre_Insert", objlist);
         }

         public void updateHarvests()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
             objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Age_Bracket", SqlDbType.VarChar, Age_Bracket.ToString()));
             objlist.Add(new csParameterListType("@Personal_Status", SqlDbType.VarChar, Personal_Status.ToString()));
             objlist.Add(new csParameterListType("@Harvest_Date", SqlDbType.VarChar, Harvest_Date.ToString()));
             objlist.Add(new csParameterListType("@HowDoYouKnow_Harvest", SqlDbType.VarChar, HowDoYouKnow_Harvest.ToString()));
             objlist.Add(new csParameterListType("@ChurchAttending_Harvest", SqlDbType.VarChar, ChurchAttending_Harvest.ToString()));
             objlist.Add(new csParameterListType("@PersonHarvestKnowInOurChurch", SqlDbType.VarChar, PersonHarvestKnowInOurChurch.ToString()));
             objlist.Add(new csParameterListType("@Notes_Harvesting", SqlDbType.VarChar, Notes_Harvesting.ToString()));
             objdal.executespreturnnd("procHarvest_Update", objlist);
         }

         public DataTable viewHarvests_By_Profile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procHarvest_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewHarvests_By_Harvest_ID(Int32 Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procHarvest_By_HarvestID", objpar);
             return dt;
         }

         public DataTable searchForHarvestByAnyField1(string sVariable, int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchHarvestByAnyField1", objpar);
             return dt;
         }


         public DataTable viewHarvestByHarvest_ID(Int32 Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procHarvest_By_HarvestID", objpar);
             return dt;
         }

         public DataTable viewHarvestByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procHarvest_By_ProfileID", objpar);
             return dt;
         }


         public DataTable viewHarvestID_ByHarvest_Number(string Harvest_Number)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_Number", SqlDbType.VarChar, Harvest_Number.ToString()));
             dt = objdal.search("procHarvestID_By_HarvestNumber", objpar);
             return dt;
         }

         public DataTable viewHarvests_All()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procHarvest_View_All");
             return dt;
         }
        


         #region Harvest Contacts
        //------------------------Contacts Harvest---------------------------
         public DataTable viewContactsByHarvest_ID(int Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procContacts_Harvest_By_HarvestID", objpar);
             return dt;
         }

         public void updateContacts_Harvest()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
             objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
             objlist.Add(new csParameterListType("@SocialMedia", SqlDbType.VarChar, SocialMedia.ToString()));
             objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
             objdal.executespreturnnd("procContacts_Harvest_Update", objlist);
         }

        #endregion

         #region Harvest Location

         //-------------------Location Harvest----------------------------------

         public void updateLocation_Harvest()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
             objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
             objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
             objlist.Add(new csParameterListType("@Area_Category", SqlDbType.VarChar, Area_Category.ToString()));
             objlist.Add(new csParameterListType("@Area_Name", SqlDbType.VarChar, Area_Name.ToString()));
             objlist.Add(new csParameterListType("@Directions", SqlDbType.VarChar, Directions.ToString()));
             objlist.Add(new csParameterListType("@GPSCoordinates", SqlDbType.VarChar, GPSCoordinates.ToString()));
             objdal.executespreturnnd("procLocation_Harvest_Update", objlist);
         }

         public DataTable viewLocationByHarvest_ID(int Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procLocation_Harvest_By_HarvestID", objpar);
             return dt;
         }
         #endregion

         #region Harvest Address
         //-----------------------Address-Harvest---------------------------------------------
         public void updateAddress_Harvest()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             objlist.Add(new csParameterListType("@AddressLine1", SqlDbType.VarChar, AddressLine1.ToString()));
             objlist.Add(new csParameterListType("@AddressLine2", SqlDbType.VarChar, AddressLine2.ToString()));
             objlist.Add(new csParameterListType("@AddressCode", SqlDbType.VarChar, AddressCode.ToString()));
             objdal.executespreturnnd("procAddress_Harvest_Update", objlist);
         }

         public DataTable viewAddressByHarvest_ID(int Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procAddress_Harvest_By_HarvestID", objpar);
             return dt;
         }


         #endregion

         #region Harvest_Followups

         //-----------------------Client_Followups------------------------
         public void AddHarvest_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
             objdal.executespreturnnd("procHarvest_Followup_Insert", objlist);
         }

         public void updateHarvest_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
             objdal.executespreturnnd("procHarvest_Followup_Update", objlist);
         }

         public DataTable viewHarvest_Followups_By_Profile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procHarvest_Followup_By_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewHarvest_Followups_By_Harvest_ID(Int32 Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procHarvest_Followup_By_Harvest_ID", objpar);
             return dt;
         }

         public DataTable viewHarvest_Followups_By_Followup_ID(Int32 Followup_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             dt = objdal.search("procHarvest_Followups_By_Followup_ID", objpar);
             return dt;
         }


         public DataTable viewHarvests_By_Harvest_ID_Pre(Int32 Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procHarvest_By_HarvestID_Pre", objpar);
             return dt;
         }

         #endregion
         #endregion

         #region Friends

         public void addFriend_Request()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Friend_Profile_ID", SqlDbType.BigInt, Friend_Profile_ID));
             objdal.executespreturnnd("procFriend_Request_Insert", objlist);
         }

         public DataTable viewFriend_RequestsByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procFriend_RequestsBy_ProfileID", objpar);
             return dt;
         }


         public DataTable viewFriend_AcceptedByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procFriend_AcceptedBy_ProfileID", objpar);
             return dt;
         }

         public DataTable viewFriend_AcceptedByProfile_IDandGroup_ID(int Profile_ID, int Group_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             dt = objdal.search("procFriend_AcceptedBy_ProfileIDandGroup_ID", objpar);
             return dt;
         }

         public DataTable viewFriend_AcceptedByProfile_IDandFriend_Profile_ID(int Profile_ID, int Friend_Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Friend_Profile_ID", SqlDbType.BigInt, Friend_Profile_ID));
             dt = objdal.search("procFriend_AcceptedBy_ProfileIDandFriend_ProfileID", objpar);
             return dt;
         }

         public DataTable viewFriend_AcceptedByProfile_IDandFriend_Profile_IDandGroup_ID(int Profile_ID, int Friend_Profile_ID , int Group_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Friend_Profile_ID", SqlDbType.BigInt, Friend_Profile_ID));
             objpar.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             dt = objdal.search("procFriend_AcceptedBy_ProfileIDandFriend_ProfileIDandGroup_ID", objpar);
             return dt;
         }

         public DataTable viewFriend_RequestedByProfile_IDandFriend_Profile_ID(int Profile_ID, int Friend_Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Friend_Profile_ID", SqlDbType.BigInt, Friend_Profile_ID));
             dt = objdal.search("procFriend_RequestedBy_ProfileIDandFriend_ProfileID", objpar);
             return dt;
         }

         public void updateFriend_Accept()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Friend_Profile_ID", SqlDbType.BigInt, Friend_Profile_ID));
             objdal.executespreturnnd("procFriend_Accept_Update", objlist);
         }

         public void AddFriend_Accept()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Friend_Profile_ID", SqlDbType.BigInt, Friend_Profile_ID));
             objdal.executespreturnnd("procFriend_Accepted_Insert", objlist);
         }

         #endregion

         #region Contacts
         //-------------------------Contacts-----------------------------------

         public void updateContacts()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
             objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
             objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
             objlist.Add(new csParameterListType("@PhoneW", SqlDbType.VarChar, PhoneW.ToString()));
             objlist.Add(new csParameterListType("@SocialMedia1", SqlDbType.VarChar, SocialMedia1.ToString()));
             objlist.Add(new csParameterListType("@SocialMedia2", SqlDbType.VarChar, SocialMedia2.ToString()));
             objlist.Add(new csParameterListType("@SocialMedia3", SqlDbType.VarChar, SocialMedia3.ToString()));
             objdal.executespreturnnd("procContacts_Update_New", objlist);
         }


         public void updateContacts_Church()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
             objlist.Add(new csParameterListType("@Telephone", SqlDbType.VarChar, Telephone.ToString()));
             objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
             objlist.Add(new csParameterListType("@Website", SqlDbType.VarChar, Website.ToString()));
             objdal.executespreturnnd("procContacts_Update_Church", objlist);
         }

         public DataTable viewContactsByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procContacts_By_ProfileID", objpar);
             return dt;
         }

         #endregion

         #region Location
         //-------------------Location----------------------------------
         public void updateLocation()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
             objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
             objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
             objlist.Add(new csParameterListType("@Area_Category", SqlDbType.VarChar, Area_Category.ToString()));
             objlist.Add(new csParameterListType("@Area_Name", SqlDbType.VarChar, Area_Name.ToString()));
             objlist.Add(new csParameterListType("@Directions", SqlDbType.VarChar, Directions.ToString()));
             objlist.Add(new csParameterListType("@GPSCoordinates", SqlDbType.VarChar, GPSCoordinates.ToString()));
             objdal.executespreturnnd("procLocation_Update", objlist);
         }

         public void updateLocation_and_Address()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@City", SqlDbType.VarChar, City.ToString()));
             objlist.Add(new csParameterListType("@Province", SqlDbType.VarChar, Province.ToString()));
             objlist.Add(new csParameterListType("@Country", SqlDbType.VarChar, Country.ToString()));
             objlist.Add(new csParameterListType("@Area_Category", SqlDbType.VarChar, Area_Category.ToString()));
             objlist.Add(new csParameterListType("@Area_Name", SqlDbType.VarChar, Area_Name.ToString()));
             objlist.Add(new csParameterListType("@Directions", SqlDbType.VarChar, Directions.ToString()));
             objlist.Add(new csParameterListType("@GPSCoordinates", SqlDbType.VarChar, GPSCoordinates.ToString()));
             objlist.Add(new csParameterListType("@AddressLine1", SqlDbType.VarChar, AddressLine1.ToString()));
             objlist.Add(new csParameterListType("@AddressLine2", SqlDbType.VarChar, AddressLine2.ToString()));
             objlist.Add(new csParameterListType("@AddressCode", SqlDbType.VarChar, AddressCode.ToString()));
             objdal.executespreturnnd("procLocation_and_Address_Update", objlist);
         }

         public DataTable viewLocation_and_AddressByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procLocation_and_Address_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewLocationByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procLocation_By_ProfileID", objpar);
             return dt;
         }

         #endregion

         #region address
         //-----------------------Address----------------------------------------------
         public void updateAddress()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@AddressLine1", SqlDbType.VarChar, AddressLine1.ToString()));
             objlist.Add(new csParameterListType("@AddressLine2", SqlDbType.VarChar, AddressLine2.ToString()));
             objlist.Add(new csParameterListType("@AddressCode", SqlDbType.VarChar, AddressCode.ToString()));
             objdal.executespreturnnd("procAddress_Update", objlist);
         }

         public DataTable viewAddressByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procAddress_By_ProfileID", objpar);
             return dt;
         }

         #endregion

         #region Spiritual_Activities
         //----------------Spiritual_Activities----------------------------------------------------------

         public DataTable crudeActivity(string crude, Int32 profileID, Int32 activityID, string activity, string description, string date, string status)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
             objlist.Add(new csParameterListType("@Activity_ID", SqlDbType.BigInt, activityID));
             objlist.Add(new csParameterListType("@Activity", SqlDbType.VarChar, activity));
             objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, description));
             objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, date));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, status));
             dt = objdal.search("procSpiritual_ActivitiesCrude", objlist);
             return dt;
         }

         public void addSpiritual_Activities()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Activity", SqlDbType.VarChar, Activity.ToString()));
             objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
             objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objdal.executespreturnnd("procSpiritual_Activities_Insert", objlist);

         }

         public void addSpiritual_ActivitiesPre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procSpiritual_Activities_Insert_Pre", objlist);

         }


         public void updateSpiritual_Activities()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Activity_ID", SqlDbType.BigInt, Activity_ID));
             objlist.Add(new csParameterListType("@Activity", SqlDbType.VarChar, Activity.ToString()));
             objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
             objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objdal.executespreturnnd("procSpiritual_Activities_Update", objlist);
         }

         public void updateSpiritual_ActivitiesApp()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Activity_ID", SqlDbType.BigInt, Activity_ID));
             objlist.Add(new csParameterListType("@Activity", SqlDbType.VarChar, Activity.ToString()));
             objlist.Add(new csParameterListType("@Description", SqlDbType.VarChar, Description.ToString()));
             objlist.Add(new csParameterListType("@Date", SqlDbType.VarChar, Date.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objdal.executespreturnnd("procSpiritual_ActivitiesApp_Update", objlist);
         }


         public DataTable viewSpiritual_ActivitiesByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procSpiritual_Activities_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewSpiritual_ActivitiesByActivity_ID(int Activity_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Activity_ID", SqlDbType.BigInt, Activity_ID));
             dt = objdal.search("procSpiritual_Activities_By_Activity_ID", objpar);
             return dt;
         }

         public void removeSpiritual_Activities()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Activity_ID", SqlDbType.BigInt, Activity_ID));
             objdal.executespreturnnd("procSpiritual_Activities_Delete", objlist);
         }

         public void removeSpiritual_ActivitiesApp()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Activity_ID", SqlDbType.BigInt, Activity_ID));
             objdal.executespreturnnd("procSpiritual_Activities_Delete", objlist);
         }

         #endregion
 
         #region Family
         //----------------Family----------------------------------------------------------

         public DataTable crudeFamily(string crude, Int32 profileID, int familyID, string relationship, string fullName, string mobile, string churchAttending, string isSaved, string isBaptised)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
             objlist.Add(new csParameterListType("@Family_ID", SqlDbType.BigInt, familyID));
             objlist.Add(new csParameterListType("@Relationship", SqlDbType.VarChar, relationship));
             objlist.Add(new csParameterListType("@FullNames", SqlDbType.VarChar, fullName));
             objlist.Add(new csParameterListType("@CellNumber", SqlDbType.VarChar, mobile));
             objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, churchAttending));
             objlist.Add(new csParameterListType("@Saved", SqlDbType.VarChar, isSaved));
             objlist.Add(new csParameterListType("@Baptised", SqlDbType.VarChar, isBaptised));
             dt = objdal.search("procFamilyCrude", objlist);
             return dt;
         }

         public void addFamily()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Relationship", SqlDbType.VarChar, Relationship.ToString()));
             objlist.Add(new csParameterListType("@FullNames", SqlDbType.VarChar, FullNames.ToString()));
             objlist.Add(new csParameterListType("@CellNumber", SqlDbType.VarChar, Cellphone.ToString()));
             objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
             objlist.Add(new csParameterListType("@BirthDate", SqlDbType.VarChar, Birthdate));
             objlist.Add(new csParameterListType("@WorkPlace", SqlDbType.VarChar, WorkPlace.ToString()));
             objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
             objlist.Add(new csParameterListType("@StudyPalce", SqlDbType.VarChar, StudyPalce.ToString()));
             objlist.Add(new csParameterListType("@StudyLevel", SqlDbType.VarChar, StudyLevels.ToString()));
             objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, ChurchAttending.ToString()));
             objlist.Add(new csParameterListType("@Saved", SqlDbType.VarChar, Saved.ToString()));
             objlist.Add(new csParameterListType("@Baptised", SqlDbType.VarChar, Baptised.ToString()));
             objdal.executespreturnnd("procFamily_Insert", objlist);

         }

         public void addFamilyPre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procFamily_Insert_Pre", objlist);

         }

        public void updateFamily()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Family_ID", SqlDbType.BigInt, Family_ID));
             objlist.Add(new csParameterListType("@Relationship", SqlDbType.VarChar, Relationship.ToString()));
             objlist.Add(new csParameterListType("@FullNames", SqlDbType.VarChar, FullNames.ToString()));
             objlist.Add(new csParameterListType("@CellNumber", SqlDbType.VarChar, Cellphone.ToString()));
             objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email.ToString()));
             objlist.Add(new csParameterListType("@BirthDate", SqlDbType.VarChar, Birthdate));
             objlist.Add(new csParameterListType("@WorkPlace", SqlDbType.VarChar, WorkPlace.ToString()));
             objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
             objlist.Add(new csParameterListType("@StudyPalce", SqlDbType.VarChar, StudyPalce.ToString()));
             objlist.Add(new csParameterListType("@StudyLevel", SqlDbType.VarChar, StudyLevels.ToString()));
             objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, ChurchAttending.ToString()));
             objlist.Add(new csParameterListType("@Saved", SqlDbType.VarChar, Saved.ToString()));
             objlist.Add(new csParameterListType("@Baptised", SqlDbType.VarChar, Baptised.ToString()));
             objdal.executespreturnnd("procFamily_Update", objlist);
         }

        public void updateFamilyApp()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Family_ID", SqlDbType.BigInt, Family_ID));
            objlist.Add(new csParameterListType("@Relationship", SqlDbType.VarChar, Relationship.ToString()));
            objlist.Add(new csParameterListType("@FullNames", SqlDbType.VarChar, FullNames.ToString()));
            objlist.Add(new csParameterListType("@CellNumber", SqlDbType.VarChar, Cellphone.ToString()));
            objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, ChurchAttending.ToString()));
            objlist.Add(new csParameterListType("@Saved", SqlDbType.VarChar, Saved.ToString()));
            objlist.Add(new csParameterListType("@Baptised", SqlDbType.VarChar, Baptised.ToString()));
            objdal.executespreturnnd("procFamilyApp_Update", objlist);
        }

        
         public DataTable viewFamilyByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procFamily_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewFamilyByFamily_ID(int Family_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Family_ID", SqlDbType.BigInt, Family_ID));
             dt = objdal.search("procFamily_By_FamilyID", objpar);
             return dt;
         }

         public void removeFamilyApp()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Family_ID", SqlDbType.BigInt, Family_ID));
             objdal.executespreturnnd("procFamily_Delete", objlist);
         }

         #endregion

         #region Education
         //----------------Education----------------------------------------------------------

         public DataTable crudeEducation(string crude, Int32 profileID, Int32 educationID, string institution, string qualification, string qualificationLevel, string intendedCareer, string studyPeriod, string studyYears, string studyStatus)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
             objlist.Add(new csParameterListType("@Education_ID", SqlDbType.BigInt, educationID));
             objlist.Add(new csParameterListType("@Institution", SqlDbType.VarChar, institution));
             objlist.Add(new csParameterListType("@Qualification", SqlDbType.VarChar, qualification));
             objlist.Add(new csParameterListType("@Qualification_Level", SqlDbType.VarChar, qualificationLevel));
             objlist.Add(new csParameterListType("@Intended_Career", SqlDbType.VarChar, intendedCareer));
             objlist.Add(new csParameterListType("@Study_Period", SqlDbType.VarChar, studyPeriod));
             objlist.Add(new csParameterListType("@Study_Years", SqlDbType.VarChar, studyYears));
             objlist.Add(new csParameterListType("@Study_Status", SqlDbType.VarChar, studyStatus));
             dt = objdal.search("procEducationCrude", objlist);
             return dt;
         }


         public void AddEducation()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Institution", SqlDbType.VarChar, Institution.ToString()));
             objlist.Add(new csParameterListType("@Qualification", SqlDbType.VarChar, Qualification.ToString()));
             objlist.Add(new csParameterListType("@Qualification_Level", SqlDbType.VarChar, Qualification_Level.ToString()));
             objlist.Add(new csParameterListType("@Intended_Career", SqlDbType.VarChar, Intended_Career.ToString()));
             objlist.Add(new csParameterListType("@Study_Period", SqlDbType.VarChar, Study_Period.ToString()));
             objlist.Add(new csParameterListType("@Study_Years", SqlDbType.VarChar, Study_Years.ToString()));
             objlist.Add(new csParameterListType("@Study_Status", SqlDbType.VarChar, Study_Status.ToString()));
             objdal.executespreturnnd("procEducation_Insert", objlist);
         }

         public void AddEducationPre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procEducation_Insert_Pre", objlist);
         }
        
        public void updateEducation()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Education_ID", SqlDbType.BigInt, Education_ID));
             objlist.Add(new csParameterListType("@Institution", SqlDbType.VarChar, Institution.ToString()));
             objlist.Add(new csParameterListType("@Qualification", SqlDbType.VarChar, Qualification.ToString()));
             objlist.Add(new csParameterListType("@Qualification_Level", SqlDbType.VarChar, Qualification_Level.ToString()));
             objlist.Add(new csParameterListType("@Intended_Career", SqlDbType.VarChar, Intended_Career.ToString()));
             objlist.Add(new csParameterListType("@Study_Period", SqlDbType.VarChar, Study_Period.ToString()));
             objlist.Add(new csParameterListType("@Study_Years", SqlDbType.VarChar, Study_Years.ToString()));
             objlist.Add(new csParameterListType("@Study_Status", SqlDbType.VarChar, Study_Status.ToString()));
             objdal.executespreturnnd("procEducation_Update", objlist);
         }

        public void removeEducation()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Education_ID", SqlDbType.BigInt, Education_ID));
            objdal.executespreturnnd("procEducation_Delete", objlist);
        }



         public DataTable viewEducationByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procEducation_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewEducationByEducation_ID(int Education_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Education_ID", SqlDbType.BigInt, Education_ID));
             dt = objdal.search("procEducation_By_EducationID", objpar);
             return dt;
         }
         #endregion

         #region PrayersAndTestimonies
         //public DataTable crudePrayers(string crude, Int32 profileID, Int32 careerID, string workStatus, string workFor, string workForName, string departmentName, string workPosition, string workPeriod, string workYears)
         //{
         //    csDAL objdal = new csDAL();
         //    DataTable dt = new DataTable();
         //    List<csParameterListType> objlist = new List<csParameterListType>();
         //    objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
         //    objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
         //    objlist.Add(new csParameterListType("@Career_ID", SqlDbType.BigInt, Career_ID));
         //    objlist.Add(new csParameterListType("@Work_Status", SqlDbType.VarChar, Work_Status.ToString()));
         //    objlist.Add(new csParameterListType("@Work_For", SqlDbType.VarChar, Work_For.ToString()));
         //    objlist.Add(new csParameterListType("@Work_For_Name", SqlDbType.VarChar, Work_For_Name.ToString()));
         //    objlist.Add(new csParameterListType("@Department_Name", SqlDbType.VarChar, Department_Name.ToString()));
         //    objlist.Add(new csParameterListType("@Work_Position", SqlDbType.VarChar, Work_Position.ToString()));
         //    objlist.Add(new csParameterListType("@Work_Period", SqlDbType.VarChar, Work_Period.ToString()));
         //    objlist.Add(new csParameterListType("@Work_Years", SqlDbType.VarChar, Work_Years.ToString()));
         //    dt = objdal.search("procCareerCrude", objlist);
         //    return dt;
         //}

         #region Prayer Items


         //-----------------------Prayer Items------------------------
         public void AddPrayer_Items()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Prayer_Item_Type", SqlDbType.VarChar, Prayer_Item_Type.ToString()));
             objlist.Add(new csParameterListType("@Prayer_Item_Date", SqlDbType.VarChar, Prayer_Item_Date.ToString()));
             objlist.Add(new csParameterListType("@Prayer_Item", SqlDbType.VarChar, Prayer_Item.ToString()));
             objlist.Add(new csParameterListType("@Prayer_Item_Verses", SqlDbType.VarChar, Prayer_Item_Verses.ToString()));
             objlist.Add(new csParameterListType("@Pray_With_Me", SqlDbType.VarChar, Pray_With_Me.ToString()));
             objdal.executespreturnnd("procPrayer_Items_Insert", objlist);
         }
         public void updatePrayer_Items()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Prayer_Item_ID", SqlDbType.BigInt, Prayer_Item_ID));
             objlist.Add(new csParameterListType("@Prayer_Item_Type", SqlDbType.VarChar, Prayer_Item_Type.ToString()));
             objlist.Add(new csParameterListType("@Prayer_Item_Date", SqlDbType.VarChar, Prayer_Item_Date.ToString()));
             objlist.Add(new csParameterListType("@Prayer_Item", SqlDbType.VarChar, Prayer_Item.ToString()));
             objlist.Add(new csParameterListType("@Prayer_Item_Verses", SqlDbType.VarChar, Prayer_Item_Verses.ToString()));
             objlist.Add(new csParameterListType("@Pray_With_Me", SqlDbType.VarChar, Pray_With_Me.ToString()));
             objdal.executespreturnnd("procPrayer_Items_Update", objlist);
         }

         public DataTable viewPrayer_Items_By_Profile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procPrayer_Items_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewPrayer_Items_By_Prayer_Item_ID(int Prayer_Item_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Prayer_Item_ID", SqlDbType.BigInt, Prayer_Item_ID));
             dt = objdal.search("procPrayer_Items_By_Prayer_ItemID", objpar);
             return dt;
         }


         public void addPrayer_Items_Pre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Prayer_Item_Number", SqlDbType.VarChar, Prayer_Item_Number.ToString()));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procPrayer_ItemsPre_Insert", objlist);
         }

         public DataTable viewPrayer_ItemID_ByPrayer_Item_Number(string Prayer_Item_Number)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Prayer_Item_Number", SqlDbType.VarChar, Prayer_Item_Number.ToString()));
             dt = objdal.search("procPrayer_ItemsID_By_Prayer_Item_Number", objpar);
             return dt;
         }

         public DataTable searchForPrayer_ItemByAnyField1(string sVariable, int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchPrayer_ItemsByAnyField1", objpar);
             return dt;
         }
         #endregion

         #region Testimonies

         //-----------------------Testimonies------------------------
         public void AddTestimonies()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Testimonies_Date", SqlDbType.VarChar, Testimonies_Date.ToString()));
             objlist.Add(new csParameterListType("@Testimonies", SqlDbType.VarChar, Testimonies.ToString()));
             objdal.executespreturnnd("procTestimonies_Insert", objlist);
         }

         public void updateTestimonies()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Testimonies_ID", SqlDbType.BigInt, Testimonies_ID));
             objlist.Add(new csParameterListType("@Testimonies_Date", SqlDbType.VarChar, Testimonies_Date.ToString()));
             objlist.Add(new csParameterListType("@Testimonies", SqlDbType.VarChar, Testimonies.ToString()));
             objdal.executespreturnnd("procTestimonies_Update", objlist);
         }

         public DataTable viewTestimoniesByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procTestimonies_By_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewTestimoniesByTestimonies_ID(int Testimonies_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Testimonies_ID", SqlDbType.BigInt, Testimonies_ID));
             dt = objdal.search("procTestimonies_By_TestimoniesID", objpar);
             return dt;
         }

         public void addTestimonies_Pre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Testimonies_Number", SqlDbType.VarChar, Testimonies_Number.ToString()));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procTestimoniesPre_Insert", objlist);
         }

         public DataTable viewTestimoniesID_ByTestimonies_Number(string Testimonies_Number)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Testimonies_Number", SqlDbType.VarChar, Testimonies_Number.ToString()));
             dt = objdal.search("procTestimoniesID_By_Testimonies_Number", objpar);
             return dt;
         }

         public DataTable searchForTestimoniesByAnyField1(string sVariable, int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchTestimoniesByAnyField1", objpar);
             return dt;
         }
         #endregion

        #endregion

         #region Career
         //----------------Career----------------------------------------------------------


         public DataTable crudeCareer(string crude, Int32 profileID, Int32 careerID, string workStatus, string workFor, string workForName, string departmentName, string workPosition, string workPeriod, string workYears)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
             objlist.Add(new csParameterListType("@Career_ID", SqlDbType.BigInt, careerID));
             objlist.Add(new csParameterListType("@Work_Status", SqlDbType.VarChar, workStatus));
             objlist.Add(new csParameterListType("@Work_For", SqlDbType.VarChar, workFor));
             objlist.Add(new csParameterListType("@Work_For_Name", SqlDbType.VarChar, workForName));
             objlist.Add(new csParameterListType("@Department_Name", SqlDbType.VarChar, departmentName));
             objlist.Add(new csParameterListType("@Work_Position", SqlDbType.VarChar, workPosition));
             objlist.Add(new csParameterListType("@Work_Period", SqlDbType.VarChar, workPeriod));
             objlist.Add(new csParameterListType("@Work_Years", SqlDbType.VarChar, workYears));
             dt = objdal.search("procCareerCrude", objlist);
             return dt;
         }

         public void AddCareer()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Work_Status", SqlDbType.VarChar, Work_Status.ToString()));
             objlist.Add(new csParameterListType("@Work_For", SqlDbType.VarChar, Work_For.ToString()));
             objlist.Add(new csParameterListType("@Work_For_Name", SqlDbType.VarChar, Work_For_Name.ToString()));
             objlist.Add(new csParameterListType("@Department_Name", SqlDbType.VarChar, Department_Name.ToString()));
             objlist.Add(new csParameterListType("@Work_Position", SqlDbType.VarChar, Work_Position.ToString()));
             objlist.Add(new csParameterListType("@Work_Period", SqlDbType.VarChar, Work_Period.ToString()));
             objlist.Add(new csParameterListType("@Work_Years", SqlDbType.VarChar, Work_Years.ToString()));
             objdal.executespreturnnd("procCareer_Insert", objlist);
         }

         public void AddCareerPre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procCareer_Insert_Pre", objlist);
         }

         public void updateCareer()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Career_ID", SqlDbType.BigInt, Career_ID));
             objlist.Add(new csParameterListType("@Work_Status", SqlDbType.VarChar, Work_Status.ToString()));
             objlist.Add(new csParameterListType("@Work_For", SqlDbType.VarChar, Work_For.ToString()));
             objlist.Add(new csParameterListType("@Work_For_Name", SqlDbType.VarChar, Work_For_Name.ToString()));
             objlist.Add(new csParameterListType("@Department_Name", SqlDbType.VarChar, Department_Name.ToString()));
             objlist.Add(new csParameterListType("@Work_Position", SqlDbType.VarChar, Work_Position.ToString()));
             objlist.Add(new csParameterListType("@Work_Period", SqlDbType.VarChar, Work_Period.ToString()));
             objlist.Add(new csParameterListType("@Work_Years", SqlDbType.VarChar, Work_Years.ToString()));
             objdal.executespreturnnd("procCareer_Update", objlist);
         }


         public void removeCareer()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Career_ID", SqlDbType.BigInt, Career_ID));
             objdal.executespreturnnd("procCareer_Delete", objlist);
         }


         public DataTable viewCareerByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procCareer_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewCareerByCareer_ID(int Career_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Career_ID", SqlDbType.BigInt, Career_ID));
             dt = objdal.search("procCareer_By_CareerID", objpar);
             return dt;
         }

         #region work
         //-----------------------Work----------------------------------------------
         public void updateWork()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Employer", SqlDbType.VarChar, Employer.ToString()));
             objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
             objlist.Add(new csParameterListType("@JobDescription", SqlDbType.VarChar, JobDescription.ToString()));
             objlist.Add(new csParameterListType("@JobStatus", SqlDbType.VarChar, JobStatus.ToString()));
             objdal.executespreturnnd("procWork_Update", objlist);
         }
         public DataTable viewWorkByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procWork_By_ProfileID", objpar);
             return dt;
         }
         #endregion

         #endregion
     
         #region Photos
         //------------------------Photos----------------------------------

         public void addPics()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
             objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
             objdal.executespreturnnd("procPics_Insert", objlist);
         }
         
        public void updatePics()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
             objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
             objdal.executespreturnnd("procPics_Update", objlist);
         }

        public void updatePics1()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
            objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
            objdal.executespreturnnd("procPics_ByName_Update", objlist);
        }

        public void updatePicsAll()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Profile_Pic", SqlDbType.VarChar, Profile_Pic.ToString()));
            objdal.executespreturnnd("procPics_All_Update", objlist);
        }

         public DataTable viewPicByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procPics_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewPicAllByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procPics_AllBy_ProfileID", objpar);
             return dt;
         }

         public DataTable viewAllPicByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procPics_All_By_ProfileID", objpar);
             return dt;
         }

         public DataTable viewPicByProfile_ID_and_PicName()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
             dt = objdal.search("procPic_By_ProfileIDandPicName", objpar);
             return dt;
         }

         public DataTable DeletePicByProfile_ID_and_PicName()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Pic_Image", SqlDbType.VarChar, Pic_Image.ToString()));
             dt = objdal.search("procPics_ByName_Delete", objpar);
             return dt;
         }

         #endregion

         #region Departments
         //--------------Departments----------------
         public DataTable viewMainDepartment_ByMainID(int MainDepartment_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Main_ID", SqlDbType.BigInt, MainDepartment_ID));
             dt = objdal.search("procDepartmentsMainBy_MainID", objpar);
             return dt;
         }

         public DataTable viewSubDepartment_ByMainID(int MainDepartment_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Main_ID", SqlDbType.BigInt, MainDepartment_ID));
             dt = objdal.search("procDepartmentsSubBy_MainID", objpar);
             return dt;
         }
         #endregion

         #region Spiritual Quuestionare

         //-----------------------Spiritual Questionare------------------------
         public void updateSpiritual_Questionare()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Questionare_Date", SqlDbType.VarChar, Questionare_Date));
             objlist.Add(new csParameterListType("@Saved", SqlDbType.VarChar, Saved.ToString()));
             objlist.Add(new csParameterListType("@Saved_Date", SqlDbType.VarChar, Saved_Date.ToString()));
             objlist.Add(new csParameterListType("@Baptised", SqlDbType.VarChar, Baptised.ToString()));
             objlist.Add(new csParameterListType("@HolySpirit", SqlDbType.VarChar, HolySpirit.ToString()));
             objlist.Add(new csParameterListType("@ChurchMember", SqlDbType.VarChar, ChurchMember.ToString()));
             objlist.Add(new csParameterListType("@Ministry", SqlDbType.VarChar, Ministry.ToString()));
             objlist.Add(new csParameterListType("@Submission", SqlDbType.VarChar, Submission.ToString()));
             objdal.executespreturnnd("procSpiritual_Questionare_Update", objlist);
         }

         public DataTable viewSpiritual_QuestionareByProfile_ID(int Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procSpiritual_Questionare_By_Profile_ID", objpar);
             return dt;
         }

         #endregion

         #region NewConverts

         #region Summary
         public DataTable viewProfile_NewConverts_By_Client_ID_Date_Gender(Int32 Client_ID, string Gender, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date_Gender", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID_Date_withFollowups(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date_withFollowups", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID_Date_withNoFollowups(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date_withNoFollowups", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID_Date_Baptised(Int32 Client_ID, string Baptised, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Baptised", SqlDbType.VarChar, Baptised));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date_Baptised", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID_Date_Promoted(Int32 Client_ID, Int32 Category_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date_Promoted", objpar);
             return dt;
         }
         #endregion

         #region AllNewConverts

         public DataTable viewProfile_NewConverts_By_Client_ID_SmallOrLarge(Int32 Client_ID, string smallOrLarge)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@SmallOrLarge", SqlDbType.VarChar, smallOrLarge));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_SmallOrLarge", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_Promoted_By_Client_ID_SmallOrLarge(Int32 Client_ID, string smallOrLarge)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@SmallOrLarge", SqlDbType.VarChar, smallOrLarge));
             dt = objdal.search("procProfiles_NewConverts_Promoted_By_Client_ID_SmallOrLarge", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID_Date2(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date2", objpar);
             return dt;
         }

         public DataTable viewProfile_NewConverts_By_Client_ID_NoDate2(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_NoDate2", objpar);
             return dt;
         }
        #endregion

         public DataTable newconvertCardCrude(string crude, Int32 profileID, Int32 newconvertID, string category, string convertionDate, string howDidYouHereAboutChurch, string churchAttending, string personYouKnowInOurChurch, string anyPrayerNeeds, string isBaptised, string lifeStatus)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
             objlist.Add(new csParameterListType("@NewConvert_ID", SqlDbType.BigInt, newconvertID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, category));
             objlist.Add(new csParameterListType("@Convertion_Date", SqlDbType.VarChar, convertionDate));
             objlist.Add(new csParameterListType("@HowDidYouHereAboutChurch", SqlDbType.VarChar, howDidYouHereAboutChurch));
             objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, churchAttending));
             objlist.Add(new csParameterListType("@PersonYouKnowInOurChurch", SqlDbType.VarChar, personYouKnowInOurChurch));
             objlist.Add(new csParameterListType("@AnyPrayerNeeds", SqlDbType.VarChar, anyPrayerNeeds));
             objlist.Add(new csParameterListType("@isBaptised", SqlDbType.VarChar, isBaptised));
             objlist.Add(new csParameterListType("@LifeStatus", SqlDbType.VarChar, lifeStatus));
             dt = objdal.search("procNewConvertCardCrude", objlist);
             return dt;
         }

         public DataTable viewNewConvertCard_By_Profile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_NewConvertCard_By_Profile_ID", objpar);
             return dt;
         }

         //-----------------------NewConverts------------------------

         public void AddNewConverts()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objdal.executespreturnnd("procClient_NewConverts_Insert", objlist);
         }

         public void AddNewConvert2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Convertion_Date", SqlDbType.VarChar, Convertion_Date.ToString()));
             objdal.executespreturnnd("procClient_NewConverts_Insert2", objlist);
         }

         public void updateConverts()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Convertion_Date", SqlDbType.VarChar, Convertion_Date.ToString()));
             objlist.Add(new csParameterListType("@WhoLedToChrist_By", SqlDbType.VarChar, WhoLedToChrist_By.ToString()));
             objlist.Add(new csParameterListType("@WhereDidItHappen", SqlDbType.VarChar, WhereDidItHappen.ToString()));
             objlist.Add(new csParameterListType("@HowDidYouHereAboutChurch", SqlDbType.VarChar, HowDidYouHereAboutChurch.ToString()));
             objlist.Add(new csParameterListType("@PreviousChurch", SqlDbType.VarChar, PreviousChurch.ToString()));
             objlist.Add(new csParameterListType("@PersonYouKnowInOurChurch", SqlDbType.VarChar, PersonYouKnowInOurChurch.ToString()));
             objlist.Add(new csParameterListType("@isBaptised", SqlDbType.VarChar, isBaptised.ToString()));
             objlist.Add(new csParameterListType("@LifeStatus", SqlDbType.VarChar, LifeStatus.ToString()));
             objlist.Add(new csParameterListType("@AnyPrayerNeeds", SqlDbType.VarChar, AnyPrayerNeeds.ToString()));
             objdal.executespreturnnd("procClient_NewConverts_Update", objlist);
         }

         public void updateConverts2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Convertion_Date", SqlDbType.VarChar, Convertion_Date.ToString()));
             objlist.Add(new csParameterListType("@WhoLedToChrist_By", SqlDbType.VarChar, WhoLedToChrist_By.ToString()));
             objlist.Add(new csParameterListType("@WhereDidItHappen", SqlDbType.VarChar, WhereDidItHappen.ToString()));
             objlist.Add(new csParameterListType("@HowDidYouHereAboutChurch", SqlDbType.VarChar, HowDidYouHereAboutChurch.ToString()));
             objlist.Add(new csParameterListType("@PreviousChurch", SqlDbType.VarChar, PreviousChurch.ToString()));
             objlist.Add(new csParameterListType("@PersonYouKnowInOurChurch", SqlDbType.VarChar, PersonYouKnowInOurChurch.ToString()));
             objlist.Add(new csParameterListType("@isBaptised", SqlDbType.VarChar, isBaptised.ToString()));
             objlist.Add(new csParameterListType("@LifeStatus", SqlDbType.VarChar, LifeStatus.ToString()));
             objlist.Add(new csParameterListType("@AnyPrayerNeeds", SqlDbType.VarChar, AnyPrayerNeeds.ToString()));
             objdal.executespreturnnd("procClient_NewConverts_Update2", objlist);
         }

         public DataTable viewConvertsByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procClient_NewConverts_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewConvertsByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_NewConverts_By_Profile_ID", objpar);
             return dt;
         }

         #endregion

         #region Client_NewConvert_Followups

         //-----------------------Client_Followups------------------------
         public void AddClient_NewConvert_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@NewConvert_ID", SqlDbType.BigInt, NewConvert_ID));
             objlist.Add(new csParameterListType("@Followup_By_ID", SqlDbType.BigInt, Followup_By_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
             objdal.executespreturnnd("procClient_NewConverts_Followup_Insert", objlist);
         }

         public void updateClient_NewConvert_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             objlist.Add(new csParameterListType("@Followup_By_ID", SqlDbType.BigInt, Followup_By_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
             objdal.executespreturnnd("procClient_NewConverts_Followup_Update", objlist);
         }

         public DataTable viewNewConvert_Followups_By_Client_ID_and_Category_ID(Int32 Client_ID, Int32 Category_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             dt = objdal.search("procClient_Followups_By_Client_ID_and_Category_ID", objpar);
             return dt;
         }

         public DataTable viewNewConvert_Followups_By_Profile_ID_and_Category_ID(Int32 Category_ID, Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             dt = objdal.search("procClient_Followups_By_Profile_ID_and_Category_ID", objpar);
             return dt;
         }

         public DataTable viewClient_NewConvert_Followups_By_Profile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_NewConverts_Followup_By_NewConvert_ID", objpar);
             return dt;
         }

         public DataTable viewClient_NewConvert_Followups_By_NewConvert_ID(Int32 NewConvert_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@NewConvert_ID", SqlDbType.BigInt, NewConvert_ID));
             dt = objdal.search("procClient_NewConverts_Followup_By_NewConvert_ID", objpar);
             return dt;
         }

         public DataTable viewClient_NewConvert_Followups_By_Followup_ID(Int32 Followup_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             dt = objdal.search("procClient_NewConverts_Followup_By_Followup_ID", objpar);
             return dt;
         }


         public DataTable searchForNewConverts_Followup_ByAnyField1(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchNewConvertsByAnyField1", objpar);
             return dt;
         }

         #endregion

         #region Client_Followups

         //-----------------------Client_Followups------------------------
         public void AddClient_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Followup_By_ID", SqlDbType.BigInt, Followup_By_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
             objdal.executespreturnnd("procClient_Followups_Insert", objlist);
         }

         public void updateClient_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             objlist.Add(new csParameterListType("@Followup_By_ID", SqlDbType.BigInt, Followup_By_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
             objdal.executespreturnnd("procClient_Followups_Update", objlist);
         }


         public DataTable viewFollowups_By_Client_ID_and_Category_ID(Int32 Client_ID, Int32 Category_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             dt = objdal.search("procClient_Followups_By_Client_ID_and_Category_ID", objpar);
             return dt;
         }

         public DataTable viewFollowups_By_Profile_ID_and_Category_ID(Int32 Category_ID,Int32 Profile_ID )
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             dt = objdal.search("procClient_Followups_By_Profile_ID_and_Category_ID", objpar);
             return dt;
         }

         public DataTable viewClient_Followups_By_Profile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_Followups_By_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewClient_Followups_By_Profile_ID2(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_Followups_By_Profile_ID2", objpar);
             return dt;
         }

         public DataTable viewClient_Followups_By_Followup_ID(Int32 Followup_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             dt = objdal.search("procClient_Followups_By_Followup_ID", objpar);
             return dt;
         }


         public DataTable searchForNewConvertsByAnyField1(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchNewConvertsByAnyField1", objpar);
             return dt;
         }


         public void AddClient_FollowupsPre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objdal.executespreturnnd("procClient_Followups_InsertPre", objlist);
         }

         public void updateClient_Guest_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             objlist.Add(new csParameterListType("@Followup_By_ID", SqlDbType.BigInt, Followup_By_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, Followup_Notes.ToString()));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, Followup_Recommendations.ToString()));
             objdal.executespreturnnd("procClient_Followups_Update", objlist);
         }

         public void deleteClient_Guest_Followups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             objdal.executespreturnnd("procClient_Followups_Delete", objlist);
         }

         #endregion
        
         #region Followups
         //-----------------------Followups------------------------

         public DataTable followupsCrude(string crude, Int32 clientID, Int32 categoryID, Int32 profileID, Int32 followupID, int followupByID, string followupDate, string followupNotes, string followupRecommendations)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, categoryID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
             objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, followupID));
             objlist.Add(new csParameterListType("@followup_By_ID", SqlDbType.BigInt, followupByID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, followupDate));
             objlist.Add(new csParameterListType("@Followup_Notes", SqlDbType.VarChar, followupNotes));
             objlist.Add(new csParameterListType("@Followup_Recommendations", SqlDbType.VarChar, followupRecommendations));
             dt = objdal.search("procFollowupsCrude", objlist);
             return dt;
         }

         public void AddFollowups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Description", SqlDbType.VarChar, Followup_Description.ToString()));
             objdal.executespreturnnd("procFollowup_Harvest_Insert", objlist);
         }
         public void updateFollowups()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             objlist.Add(new csParameterListType("@Followup_Date", SqlDbType.VarChar, Followup_Date));
             objlist.Add(new csParameterListType("@Followup_Description", SqlDbType.VarChar, Followup_Description.ToString()));
             objdal.executespreturnnd("procFollowup_Harvest_Update", objlist);
         }

         public DataTable viewFollowupsByHarvest_ID(int Harvest_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Harvest_ID", SqlDbType.BigInt, Harvest_ID));
             dt = objdal.search("procHarvest_Followups_By_HarvestID", objpar);
             return dt;
         }

         public DataTable viewFollowupsByFollowup_ID(int Followup_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Followup_ID", SqlDbType.BigInt, Followup_ID));
             dt = objdal.search("procHarvest_Followups_By_Followup_ID", objpar);
             return dt;
         }

         #endregion

         #region Promote to Member
         //---------------Promote to Member-------------------------
         public void updateProfile_Promote()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objlist.Add(new csParameterListType("@Promoted_Date", SqlDbType.VarChar, Promoted_Date.ToString()));
             objdal.executespreturnnd("procProfile_Promote_Update", objlist);
         }

         public void updateProfile_PromoteToFrom()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objlist.Add(new csParameterListType("@Category_ID_From", SqlDbType.BigInt, Category_ID_From));
             objlist.Add(new csParameterListType("@Promoted_Date", SqlDbType.VarChar, Promoted_Date.ToString()));
             objdal.executespreturnnd("procProfile_PromoteToFrom_Update", objlist);
         }

         public void updateProfile_Promote1()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objdal.executespreturnnd("procProfile_Promote_Update1", objlist);
         }

         public DataTable viewPromoted_Converts_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_Promoted_Converts_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewPromoted_Converts_By_Client_ID_Date(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
             dt = objdal.search("procProfiles_Promoted_Converts_By_Client_ID_Date", objpar);
             return dt;
         }

         public DataTable viewPromoted_Guests_By_Client_IDsmallOrLarge(Int32 Client_ID, string smallOrLarge)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@SmallOrLarge", SqlDbType.VarChar, smallOrLarge));
             dt = objdal.search("procProfiles_Promoted_Guests_By_Client_ID_SmallOrLarge", objpar);
             return dt;
         }


         public DataTable viewPromoted_Guests_By_Client_ID_Date(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
             dt = objdal.search("procProfiles_Promoted_Guests_By_Client_ID_Date", objpar);
             return dt;
         }

        
         public DataTable viewPromoted_NewConverts_By_Client_ID_Date(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
             dt = objdal.search("procProfiles_Promoted_Converts_By_Client_ID_Date", objpar);
             return dt;
         }

         public DataTable viewPromoted_NewConverts_By_Client_ID_Date_Summary(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
             dt = objdal.search("procProfiles_NewConverts_By_Client_ID_Date_Summary", objpar);
             return dt;
         }

        

         public DataTable viewPromoted_ToFrom_Count_By_Client_ID_Date(Int32 Client_ID, Int32 Category_ID_To, Int32 Category_ID_From, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Category_ID_To", SqlDbType.BigInt, Category_ID_To));
             objpar.Add(new csParameterListType("@Category_ID_From", SqlDbType.BigInt, Category_ID_From));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
             dt = objdal.search("procProfiles_Count_By_Client_ID_Date_Promoted_ToFrom", objpar);
             return dt;
         }

         #endregion

         #region Attritions
         //---------------------Attritions------------------------------------------
         public void AddNewAttritions()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objdal.executespreturnnd("procClient_Attritions_Insert", objlist);
         }

         public void updateAttritions()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Attrition_ID", SqlDbType.BigInt, Attrition_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Attrition_Date", SqlDbType.VarChar, Attrition_Date.ToString()));
             objlist.Add(new csParameterListType("@Attrition_Description", SqlDbType.VarChar, Attrition_Description.ToString()));
             objdal.executespreturnnd("procClient_Attritions_Update", objlist);
         }

         public DataTable viewAttritionsByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procClient_Attritions_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewAttritionsByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_Attritions_By_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewAttritionsByAttrition_ID(Int32 Attrition_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Attrition_ID", SqlDbType.BigInt, Attrition_ID));
             dt = objdal.search("procClient_Attritions_By_Attrition_ID", objpar);
             return dt;
         }

         public DataTable viewProfile_Attritions_SmallOrLarge_By_Client_ID(int Client_ID, string smallOrLarge)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@SmallOrLarge", SqlDbType.VarChar, smallOrLarge));
             dt = objdal.search("procProfiles_Attritions_SmallOrLarge_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewProfile_Attritions_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_Attritions_By_Client_ID", objpar);
             return dt;
         }

         public DataTable searchForAttritionsByAnyField1(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchAttritionsByAnyField1", objpar);
             return dt;
         }


         #endregion

         #region Guests

         //-----------------------Guests------------------------

         public DataTable guestCardCrude(string crude, Int32 profileID, Int32 guestID, string category, string guestType, string guestDate, string howDidYouHereAboutChurch, string churchAttending, string personYouKnowInOurChurch, string anyPrayerNeeds, string isSaved, string isBaptised, string lifeStatus)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
             objlist.Add(new csParameterListType("@Guest_ID", SqlDbType.BigInt, guestID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, category));
             objlist.Add(new csParameterListType("@Guest_Type", SqlDbType.VarChar, guestType));
             objlist.Add(new csParameterListType("@Guest_Date", SqlDbType.VarChar, guestDate));
             objlist.Add(new csParameterListType("@HowDidYouHereAboutChurch", SqlDbType.VarChar, howDidYouHereAboutChurch));
             objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, churchAttending));
             objlist.Add(new csParameterListType("@PersonYouKnowInOurChurch", SqlDbType.VarChar, personYouKnowInOurChurch));
             objlist.Add(new csParameterListType("@AnyPrayerNeeds", SqlDbType.VarChar, anyPrayerNeeds));
             objlist.Add(new csParameterListType("@isSaved", SqlDbType.VarChar, isSaved));
             objlist.Add(new csParameterListType("@isBaptised", SqlDbType.VarChar, isBaptised));
             objlist.Add(new csParameterListType("@LifeStatus", SqlDbType.VarChar, lifeStatus));
             dt = objdal.search("procGuestCardCrude", objlist);
             return dt;
         }

         public void AddNewGuests()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objdal.executespreturnnd("procClient_Guests_Insert", objlist);
         }

         public DataTable addGuestNew(Int32 clientID, string guestDate, string guestType, string firstName, string lastName, string mobile, string gender, Int32 ageBracketID, string birthyear, string birthmonth, string birthday)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
             objlist.Add(new csParameterListType("@Guest_Date", SqlDbType.VarChar, guestDate));
             objlist.Add(new csParameterListType("@Guest_Type", SqlDbType.VarChar, guestType));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, firstName));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, lastName));
             objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, mobile));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, gender));
             objlist.Add(new csParameterListType("@ageBracket_ID", SqlDbType.BigInt, ageBracketID));
             objlist.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, birthyear));
             objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, birthmonth));
             objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, birthday));
             dt = objdal.search("procGuestNew_Insert", objlist);
             return dt;
         }


         public void addGuest()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Guest_Date", SqlDbType.VarChar, Guest_Date.ToString()));
             objlist.Add(new csParameterListType("@Guest_Type", SqlDbType.VarChar, Guest_Type.ToString()));
             objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
             objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name.ToString()));
             objlist.Add(new csParameterListType("@Cellphone", SqlDbType.VarChar, Cellphone.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@ageBracket_ID", SqlDbType.BigInt, ageBracket_ID));
             objlist.Add(new csParameterListType("@Birth_Year", SqlDbType.VarChar, Birth_Year.ToString()));
             objlist.Add(new csParameterListType("@Birth_Month", SqlDbType.VarChar, Birth_Month.ToString()));
             objlist.Add(new csParameterListType("@Birth_Day", SqlDbType.VarChar, Birth_Day.ToString()));
             objdal.executespreturnnd("procGuestNew_Insert", objlist);
         }



         public void AddNewGuests2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Guest_Date", SqlDbType.VarChar, Guest_Date.ToString()));
             objdal.executespreturnnd("procClient_Guests_Insert2", objlist);
         }

         public void updateGuests()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@Guest_Date", SqlDbType.VarChar, Guest_Date.ToString()));
             objlist.Add(new csParameterListType("@HowDidYouHereAboutChurch", SqlDbType.VarChar, HowDidYouHereAboutChurch.ToString()));
             objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, ChurchAttending.ToString()));
             objlist.Add(new csParameterListType("@PersonYouKnowInOurChurch", SqlDbType.VarChar, PersonYouKnowInOurChurch.ToString()));
             objlist.Add(new csParameterListType("@AnyPrayerNeeds", SqlDbType.VarChar, AnyPrayerNeeds.ToString()));
             objdal.executespreturnnd("procClient_Guests_Update", objlist);
         }


         public void updateGuestCard()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Guest_Type", SqlDbType.VarChar, Guest_Type.ToString()));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
             objlist.Add(new csParameterListType("@isSaved", SqlDbType.VarChar, isSaved.ToString()));
             objlist.Add(new csParameterListType("@isBaptised", SqlDbType.VarChar, isBaptised.ToString()));
             objlist.Add(new csParameterListType("@Guest_Date", SqlDbType.VarChar, Guest_Date.ToString()));
             objlist.Add(new csParameterListType("@HowDidYouHereAboutChurch", SqlDbType.VarChar, HowDidYouHereAboutChurch.ToString()));
             objlist.Add(new csParameterListType("@ChurchAttending", SqlDbType.VarChar, ChurchAttending.ToString()));
             objlist.Add(new csParameterListType("@PersonYouKnowInOurChurch", SqlDbType.VarChar, PersonYouKnowInOurChurch.ToString()));
             objlist.Add(new csParameterListType("@LifeStatus", SqlDbType.VarChar, LifeStatus.ToString()));
             objlist.Add(new csParameterListType("@AnyPrayerNeeds", SqlDbType.VarChar, AnyPrayerNeeds.ToString()));
             objdal.executespreturnnd("procClient_GuestCard_Update", objlist);
         }

         public DataTable viewProfile_Guests_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_Guests_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewGuestCard_By_Profile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_GuestCard_By_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date2(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date2", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_NoDate2(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_NoDate2", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_NoDate2_Small_and_Large(Int32 Client_ID, string smallOrLarge)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@SmallOrLarge", SqlDbType.VarChar, smallOrLarge));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_NoDate2_Small_and_Large", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Regulars_Small_and_Large(Int32 Client_ID, string smallOrLarge)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@SmallOrLarge", SqlDbType.VarChar, smallOrLarge));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Regulars_Small_and_Large", objpar);
             return dt;
         }


         public DataTable viewProfile_Guests_By_Client_ID_NoDate2_Regulars(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_NoDate2_Regulars", objpar);
             return dt;
         }

         public DataTable viewGuests_By_Client_ID_Date_Summary(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date.ToString()));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date.ToString()));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_Summary", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_Gender(Int32 Client_ID, string Gender, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_Gender", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_withFollowups(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_withFollowups", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_withNoFollowups(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_withNoFollowups", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_ChurchAttending(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_ChurchAttending", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_NoChurchAttending(Int32 Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_NoChurchAttending", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_Saved(Int32 Client_ID, string Saved, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Saved", SqlDbType.VarChar, Saved));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_Saved", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_Baptised(Int32 Client_ID, string Baptised, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Baptised", SqlDbType.VarChar, Baptised));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_Baptised", objpar);
             return dt;
         }

         public DataTable viewProfile_Guests_By_Client_ID_Date_Promoted(Int32 Client_ID, Int32 Category_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procProfiles_Guests_By_Client_ID_Date_Promoted", objpar);
             return dt;
         }


         public DataTable viewGuestsByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procClient_Guests_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewGuestsByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_Guests_By_Profile_ID", objpar);
             return dt;
         }

         public DataTable searchForGuestsByAnyField1(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchGuestsByAnyField1", objpar);
             return dt;
         }
         #endregion

         #region Home Cells
         //--------------Home Cells----------------------------------------

         public DataTable crudeHomeCell(string crude, Int32 clientID, int cellID, string cellName, string cellVenue, string cellDay, string cellTime, Int32 leaderID, Int32 intern1ID, Int32 intern2ID, string startDate, string cellActive)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, cellID));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, cellName));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, cellVenue));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, cellDay));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, cellTime));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, leaderID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, intern1ID));
             objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, intern2ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, startDate));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, cellActive));
             dt = objdal.search("procHome_Cells_Crude", objlist);
             return dt;
         }

         public void crudeHomeCells()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cells_Update", objlist);
         }


         public void addHome_Cell_Pre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_Number", SqlDbType.VarChar, Cell_Number.ToString()));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_CellPre_Insert", objlist);
         }

         //public void addHome_Cell_Pre2()
         //{
         //    csDAL objdal = new csDAL();
         //    List<csParameterListType> objlist = new List<csParameterListType>();
         //    objlist.Add(new csParameterListType("@Cell_Number", SqlDbType.VarChar, Cell_Number.ToString()));
         //    objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
         //    objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
         //    objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
         //    objdal.executespreturnnd("procHome_CellPre_Insert2", objlist);
         //}

         public DataTable viewHome_Cell_ID_ByCell_Number(string Cell_Number)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_Number", SqlDbType.VarChar, Cell_Number.ToString()));
             dt = objdal.search("procHome_Cell_ID_By_Cell_Number", objpar);
             return dt;
         }

         public void updateCell()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cells_Update", objlist);
         }

         public void deleteCell()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objdal.executespreturnnd("procHome_Cells_Delete", objlist);
         }

         public void updateCell2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             //objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             //objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objdal.executespreturnnd("procHome_Cells_Update2", objlist);
         }

         public void updateCell2_Category()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             //objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             //objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             //objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             //objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             objdal.executespreturnnd("procHome_Cells_Update2_Category", objlist);
         }

         public void updateCell3_Category()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             //objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             //objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             objdal.executespreturnnd("procHome_Cells_Update3_Category", objlist);
         }

         public void updateCell_No_Interns()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             //objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             //objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cells_Update_No_Interns", objlist);
         }


         public void updateCell_No_Intern2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             //objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             //objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             //objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             objdal.executespreturnnd("procHome_Cells_Update_No_Intern2", objlist);
         }

         public void updateCell_No_Interns_1()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             //objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             //objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             //objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             //objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cells_Update_No_Interns_1", objlist);
         }


         public void updateCell_No_Interns_1_Category()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             //objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             //objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             //objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             //objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             //objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             //objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             objdal.executespreturnnd("procHome_Cells_Update_No_Interns_1_Category", objlist);
         }


         public void updateCell_No_Intern_2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             //objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             //objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             //objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objdal.executespreturnnd("procHome_Cells_Update_No_Intern_2", objlist);
         }

         public void updateCell_No_Intern_2_Category()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             //objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             //objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             //objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             //objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             //objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             objdal.executespreturnnd("procHome_Cells_Update_No_Intern_2_Category", objlist);
         }

         public DataTable viewHome_Cell_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cells_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Members_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Members_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_By_Leader_ID(Int32 Leader_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             dt = objdal.search("procHome_Cells_By_Leader_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_By_Member_ID_and_Category_ID(Int32 Member_ID, Int32 Category_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
             objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             dt = objdal.search("procHome_Cells_By_Member_ID_and_Category_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_By_Member_ID(Int32 Member_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
             dt = objdal.search("procHome_Cells_By_Member_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cells_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_By_Client_ID_and_NoDates(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cells_By_Client_ID_NoDates", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_By_Client_ID_and_Dates(int Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procHome_Cells_By_Client_ID_with_Dates", objpar);
             return dt;
         }


         public DataTable viewHome_Cell_GroupID_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cells_GroupID_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_GroupID_By_Client_ID2(int Client_ID, int Group_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             dt = objdal.search("procHome_Cells_GroupID_By_Client_ID2", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_GroupID_By_Client_ID_Category(int Client_ID, string Category)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Category", SqlDbType.BigInt, Category));
             dt = objdal.search("procHome_Cells_GroupID_By_Client_ID_Category", objpar);
             return dt;
         }

         public DataTable viewAll_Home_Cell_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cells_All_By_Client_ID", objpar);
             return dt;
         }

         public DataTable searchForHome_CellsByAnyField1(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchHome_CellsByAnyField1", objpar);
             return dt;
         }


         public void addHome_Cell_Pre_District()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.BigInt, Category));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_CellPre_District_Insert", objlist);
         }

         public void addHome_Cell_Pre_Zone()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.BigInt, Category));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_CellPre_Zone_Insert", objlist);
         }


         #region Cell Members
         //---------------Cell Members------------------------------

         public void addCell_Memberz()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objlist.Add(new csParameterListType("@Member_Active", SqlDbType.VarChar, Member_Active.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procHome_Cell_Memberz_Insert", objlist);
         }

         public void updateCell_Memberz()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Home_Cell_Member_ID", SqlDbType.BigInt, Home_Cell_Member_ID));
             objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
             objlist.Add(new csParameterListType("@Member_Active", SqlDbType.VarChar, Member_Active.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Memberz_Update", objlist);
         }

         public DataTable viewHome_Cell_Categories()
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             dt = objdal.search("procHome_Cells_Categories");
             return dt;
         }

         public DataTable viewHome_Cell_Memberz_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Memberz_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Memberz_By_Member_ID(Int32 Member_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
             dt = objdal.search("procHome_Cell_Memberz_By_Member_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Memberz_By_Home_Cell_Member_ID(Int32 Home_Cell_Member_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Home_Cell_Member_ID", SqlDbType.BigInt, Home_Cell_Member_ID));
             dt = objdal.search("procHome_Cell_Memberz_By_Home_Cell_Member_ID", objpar);
             return dt;
         }

         public void addCell_Member()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@Member_Contacts", SqlDbType.VarChar, Member_Contacts.ToString()));
             objlist.Add(new csParameterListType("@Member_AreaName", SqlDbType.VarChar, Member_AreaName.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objlist.Add(new csParameterListType("@Church_Member", SqlDbType.VarChar, Church_Member.ToString()));
             objlist.Add(new csParameterListType("@Member_Active", SqlDbType.VarChar, Member_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procHome_Cell_Member_Insert", objlist);
         }

         public void addCell_Member_New()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             //objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             //objlist.Add(new csParameterListType("@Member_Contacts", SqlDbType.VarChar, Member_Contacts.ToString()));
             //objlist.Add(new csParameterListType("@Member_AreaName", SqlDbType.VarChar, Member_AreaName.ToString()));
             //objlist.Add(new csParameterListType("@AgeCategory", SqlDbType.VarChar, AgeCategory.ToString()));
             //objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             //objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             //objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             //objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             //objlist.Add(new csParameterListType("@Church_Member", SqlDbType.VarChar, Church_Member.ToString()));
             //objlist.Add(new csParameterListType("@Member_Active", SqlDbType.VarChar, Member_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procHome_Cell_Member_Insert", objlist);
         }

         public void updateCell_Member()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@Member_Contacts", SqlDbType.VarChar, Member_Contacts.ToString()));
             objlist.Add(new csParameterListType("@Member_AreaName", SqlDbType.VarChar, Member_AreaName.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objlist.Add(new csParameterListType("@Church_Member", SqlDbType.VarChar, Church_Member.ToString()));
             objlist.Add(new csParameterListType("@Member_Active", SqlDbType.VarChar, Member_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Member_Update", objlist);
         }

         public void updateCell_Member_New()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             //objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             //objlist.Add(new csParameterListType("@Member_Contacts", SqlDbType.VarChar, Member_Contacts.ToString()));
             //objlist.Add(new csParameterListType("@Member_AreaName", SqlDbType.VarChar, Member_AreaName.ToString()));
             //objlist.Add(new csParameterListType("@AgeCategory", SqlDbType.VarChar, AgeCategory.ToString()));
             //objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             //objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             //objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             //objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             //objlist.Add(new csParameterListType("@Church_Member", SqlDbType.VarChar, Church_Member.ToString()));
             //objlist.Add(new csParameterListType("@Member_Active", SqlDbType.VarChar, Member_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Member_New_Update", objlist);
         }

         public DataTable viewHome_Cell_Member_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Member_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Member_New_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Members_New_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Member_By_Member_ID(Int32 Member_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Member_ID));
             dt = objdal.search("procHome_Cell_Member_By_Member_ID", objpar);
             return dt;
         }

         public DataTable viewPHome_Cell_Member_PreAllByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procProfilePre_All_HomeCells", objpar);
             return dt;
         }

         #endregion

         #region Cell_Districts

         public DataTable viewDistrictByDistrict_ID(Int32 District_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             dt = objdal.search("procClient_District_By_District_ID", objpar);
             return dt;
         }

         public void addDistrict()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@District", SqlDbType.VarChar, District));
             objlist.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, Leadership_Year));
             objlist.Add(new csParameterListType("@Mandate", SqlDbType.VarChar, Mandate));
             objlist.Add(new csParameterListType("@Leadership_Period", SqlDbType.VarChar, Leadership_Period));
             objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
             objdal.executespreturnnd("procClient_Districts_Insert", objlist);
         }


         public void updateDistrict()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@District", SqlDbType.VarChar, District.ToString()));
             objlist.Add(new csParameterListType("@Mandate", SqlDbType.VarChar, Mandate.ToString()));
             objlist.Add(new csParameterListType("@Leadership_Period", SqlDbType.VarChar, Leadership_Period.ToString()));
             objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
             objdal.executespreturnnd("procClient_District_Update", objlist);
         }

         public void updateDistrict2()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@District", SqlDbType.VarChar, District.ToString()));
             objlist.Add(new csParameterListType("@Mandate", SqlDbType.VarChar, Mandate.ToString()));
             objlist.Add(new csParameterListType("@Leadership_Period", SqlDbType.VarChar, Leadership_Period.ToString()));
             objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
             objdal.executespreturnnd("procClient_District_Update2", objlist);
         }

         public void deleteDistrict()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objdal.executespreturnnd("procClient_District_delete", objlist);
         }

         public DataTable viewDistrictByClient_ID(Int32 Client_ID, string LeadershipYear)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
             dt = objdal.search("procClient_District_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewAllDistrictByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procClient_District_All_By_Client_ID", objpar);
             return dt;
         }

         #endregion

         #region Cell_Zones

         public DataTable viewZoneByZone_ID(Int32 Zone_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             dt = objdal.search("procClient_Zone_By_Zone_ID", objpar);
             return dt;
         }

         public void addZone()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Zone", SqlDbType.VarChar, Zone));
             objlist.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, Leadership_Year));
             objlist.Add(new csParameterListType("@Mandate", SqlDbType.VarChar, Mandate));
             objlist.Add(new csParameterListType("@Leadership_Period", SqlDbType.VarChar, Leadership_Period));
             objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
             objdal.executespreturnnd("procClient_Zone_Insert", objlist);
         }


         public void updateZone()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Zone", SqlDbType.VarChar, Zone.ToString()));
             objlist.Add(new csParameterListType("@Mandate", SqlDbType.VarChar, Mandate.ToString()));
             objlist.Add(new csParameterListType("@Leadership_Period", SqlDbType.VarChar, Leadership_Period.ToString()));
             objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
             objdal.executespreturnnd("procClient_Zone_Update", objlist);
         }

         public void deleteZone()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             objdal.executespreturnnd("procClient_Zone_Delete", objlist);
         }

         public DataTable viewZoneByClient_ID(Int32 Client_ID, string LeadershipYear)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Leadership_Year", SqlDbType.VarChar, LeadershipYear));
             dt = objdal.search("procClient_Zone_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewAllZoneByClient_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procClient_Zone_All_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewAllZoneByClient_ID_and_District_ID(Int32 Client_ID, Int32 District_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             dt = objdal.search("procClient_Zone_All_By_Client_ID_and_District_ID", objpar);
             return dt;
         }

         #endregion

         #region Cell_Structure

         public DataTable viewAll_Cell_Structure_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cell_Structures_All_By_Client_ID", objpar);
             return dt;
         }

         public void addCell_Structure()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Manager_ID", SqlDbType.BigInt, Manager_ID));
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             objlist.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             objdal.executespreturnnd("procHome_Cell_Structure_Insert", objlist);
         }

         public DataTable viewAll_Cell_Structure_By_Client_ID_and_Zone_ID(int Client_ID, int Zone_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Zone_ID", SqlDbType.BigInt, Zone_ID));
             dt = objdal.search("procHome_Cell_Structures_All_By_Client_ID_and_Zone_ID", objpar);
             return dt;
         }

         public DataTable viewAll_Cell_Structure_By_Client_ID_and_District_ID(int Client_ID, int District_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@District_ID", SqlDbType.BigInt, District_ID));
             dt = objdal.search("procHome_Cell_Structures_All_By_Client_ID_and_District_ID", objpar);
             return dt;
         }

         public DataTable viewAll_Cell_Structure_By_Client_ID_and_Category(int Client_ID, string Category)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             dt = objdal.search("procHome_Cell_Structures_All_By_Client_ID_and_Category", objpar);
             return dt;
         }

         public void deleteCell_Structure()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Structure_ID", SqlDbType.BigInt, Structure_ID));
             objdal.executespreturnnd("procDelete_Home_Cells_Structure_All_By_Structure_ID", objlist);
         }


         public void addCell_Diagram()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Parent_ID", SqlDbType.BigInt, Parent_ID));
             objpar.Add(new csParameterListType("@Child_ID", SqlDbType.BigInt, Child_ID));
             objpar.Add(new csParameterListType("@Child_Name_ID", SqlDbType.BigInt, Child_Name_ID));
             objpar.Add(new csParameterListType("@Child_Name", SqlDbType.VarChar, Child_Name));
             objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
             objdal.executespreturnnd("procHome_Cell_Diagram_Insert", objpar);
         }

         public void removeCell_Diagram()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Diagram_ID", SqlDbType.BigInt, Diagram_ID));
             objdal.executespreturnnd("procHome_Cell_Diagram_Remove", objpar);
         }

         #endregion

         #region Cell Visitors

         public DataTable crudeHomeGuestCell(string crude, Int32 clientID, int visitorID, int cellID, string guestName, string guestMobile, string guestAddress, string guestBirthDate, string gender, string marital, string status, string attendChurch, string visitRegular, Int32 invitedByID, string regDate)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Visitor_ID", SqlDbType.BigInt, visitorID));
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, cellID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, guestName));
             objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, guestMobile));
             objlist.Add(new csParameterListType("@Physical_Address", SqlDbType.VarChar, guestAddress));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, guestBirthDate));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, gender));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, marital));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, status));
             objlist.Add(new csParameterListType("@Attend_Church", SqlDbType.VarChar, attendChurch));
             objlist.Add(new csParameterListType("@Visit_Regular", SqlDbType.VarChar, visitRegular));
             objlist.Add(new csParameterListType("@Invited_By_ID", SqlDbType.BigInt, invitedByID));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, regDate));
             dt = objdal.search("procHome_Cell_Visitors_Crude", objlist);
             return dt;
         }


         public void addCell_Visitor()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@Contacts", SqlDbType.VarChar, Contacts.ToString()));
             objlist.Add(new csParameterListType("@Physical_Address", SqlDbType.VarChar, Physical_Address.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender.ToString()));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objlist.Add(new csParameterListType("@Attend_Church", SqlDbType.VarChar, Attend_Church.ToString()));
             objlist.Add(new csParameterListType("@Visit_Regular", SqlDbType.VarChar, Visit_Regular.ToString()));
             objlist.Add(new csParameterListType("@Invited_By_ID", SqlDbType.BigInt, Invited_By_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procHome_Cell_Visitors_Insert", objlist);
         }

         public void updateCell_Visitor()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Visitor_ID", SqlDbType.BigInt, Visitor_ID));
             objlist.Add(new csParameterListType("@Full_Name", SqlDbType.VarChar, Full_Name.ToString()));
             objlist.Add(new csParameterListType("@Contacts", SqlDbType.VarChar, Contacts.ToString()));
             objlist.Add(new csParameterListType("@Physical_Address", SqlDbType.VarChar, Physical_Address.ToString()));
             objlist.Add(new csParameterListType("@Birth_Date", SqlDbType.VarChar, Birth_Date.ToString()));
             objlist.Add(new csParameterListType("@Marital", SqlDbType.VarChar, Marital.ToString()));
             objlist.Add(new csParameterListType("@Status", SqlDbType.VarChar, Status.ToString()));
             objlist.Add(new csParameterListType("@Attend_Church", SqlDbType.VarChar, Attend_Church.ToString()));
             objlist.Add(new csParameterListType("@Visit_Regular", SqlDbType.VarChar, Visit_Regular.ToString()));
             objlist.Add(new csParameterListType("@Invited_By_ID", SqlDbType.BigInt, Invited_By_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
             objdal.executespreturnnd("procHome_Cell_Visitors_Update", objlist);
         }

         public DataTable viewHome_Cell_Visitors_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Visitors_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Visitors_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cell_Visitors_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Visitors_By_Visitor_ID(Int32 Visitor_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Visitor_ID", SqlDbType.BigInt, Visitor_ID));
             dt = objdal.search("procHome_Cell_Visitors_By_Visitor_ID", objpar);
             return dt;
         }





         #endregion

         #region Cell Reports
         //---------------Cell Reports------------------------------

         public void addCell_Report()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Report_Date", SqlDbType.VarChar, Report_Date.ToString()));
             objlist.Add(new csParameterListType("@Total_Attended", SqlDbType.VarChar, Total_Attended.ToString()));
             objlist.Add(new csParameterListType("@Total_Absent", SqlDbType.VarChar, Total_Absent.ToString()));
             objlist.Add(new csParameterListType("@Total_Visitors", SqlDbType.VarChar, Total_Visitors.ToString()));
             objlist.Add(new csParameterListType("@Cell_Topic", SqlDbType.VarChar, Cell_Topic.ToString()));
             objlist.Add(new csParameterListType("@Cell_Topic_Understanding", SqlDbType.VarChar, Cell_Topic_Understanding.ToString()));
             objlist.Add(new csParameterListType("@Cell_Topic_Comments", SqlDbType.VarChar, Cell_Topic_Comments.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Reports_Insert", objlist);
         }

         public void addCell_Report_New()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Report_Date", SqlDbType.VarChar, Report_Date.ToString()));
             objdal.executespreturnnd("procHome_Cell_Report_New_Insert", objlist);
         }

         public void updateCell_Report()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Report_ID", SqlDbType.BigInt, Report_ID));
             objlist.Add(new csParameterListType("@Report_Date", SqlDbType.VarChar, Report_Date.ToString()));
             objlist.Add(new csParameterListType("@Total_Attended", SqlDbType.VarChar, Total_Attended.ToString()));
             objlist.Add(new csParameterListType("@Total_Absent", SqlDbType.VarChar, Total_Absent.ToString()));
             objlist.Add(new csParameterListType("@Total_Visitors", SqlDbType.VarChar, Total_Visitors.ToString()));
             objlist.Add(new csParameterListType("@Cell_Topic", SqlDbType.VarChar, Cell_Topic.ToString()));
             objlist.Add(new csParameterListType("@Cell_Topic_Understanding", SqlDbType.VarChar, Cell_Topic_Understanding.ToString()));
             objlist.Add(new csParameterListType("@Cell_Topic_Comments", SqlDbType.VarChar, Cell_Topic_Comments.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Reports_Update", objlist);
         }



         public DataTable viewHome_Cell_Report_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Reports_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Report_By_Report_ID(Int32 Report_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Report_ID", SqlDbType.BigInt, Report_ID));
             dt = objdal.search("procHome_Cell_Reports_By_Report_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Report_By_Client_ID(Int32 Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cell_Reports_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Report_By_Client_ID_and_Report_Date(Int32 Client_ID, String From_Date, String To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procHome_Cell_Reports_By_Client_ID_and_Report_Date", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Report_By_Client_ID_and_Report_Date_and_Cell_Name(Int32 Client_ID, String From_Date, String To_Date, String Cell_Name)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             objpar.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name));
             dt = objdal.search("procHome_Cell_Reports_By_Client_ID_and_Report_Date_and_Cell_Name", objpar);
             return dt;
         }


         //--------------New------------
         public void updateCell_Report_New()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Report_ID", SqlDbType.BigInt, Report_ID));
             objlist.Add(new csParameterListType("@Report_Date", SqlDbType.VarChar, Report_Date.ToString()));
             objlist.Add(new csParameterListType("@New_Members", SqlDbType.BigInt, New_Members));
             objlist.Add(new csParameterListType("@Members_Present", SqlDbType.BigInt, Members_Present));
             objlist.Add(new csParameterListType("@Adult_Guest_Present", SqlDbType.BigInt, Adult_Guest_Present));
             objlist.Add(new csParameterListType("@Children_Present", SqlDbType.BigInt, Children_Present));
             objlist.Add(new csParameterListType("@Total_Absent", SqlDbType.BigInt, Tot_Absent));
             objlist.Add(new csParameterListType("@Total_Present", SqlDbType.BigInt, Total_Present));
             objlist.Add(new csParameterListType("@Welcome", SqlDbType.VarChar, Welcome.ToString()));
             objlist.Add(new csParameterListType("@Word", SqlDbType.VarChar, Word.ToString()));
             objlist.Add(new csParameterListType("@Worship", SqlDbType.VarChar, Worship.ToString()));
             objlist.Add(new csParameterListType("@Works", SqlDbType.VarChar, Works.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Report_New_Update", objlist);
         }



         public DataTable viewHome_Cell_Report_New_By_Client_ID(int Client_ID, String From_Date, String To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procHome_Cell_Report_New_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Report_New_By_Client_ID_and_Cell_ID(int Client_ID, int Cell_ID, String From_Date, String To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procHome_Cell_Report_New_By_Client_ID_and_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Report_Get_Report_ID(int Client_ID, int Cell_ID, String Report_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objpar.Add(new csParameterListType("@Report_Date", SqlDbType.VarChar, Report_Date));
             dt = objdal.search("procHome_Cell_Report_Get_Report_ID", objpar);
             return dt;
         }

         //--------------New------------

         public DataTable viewHome_Cell_Report_AttendanceReg_By_Report_ID(int Report_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Report_ID", SqlDbType.BigInt, Report_ID));
             dt = objdal.search("procHome_Cell_Report_AttendanceReg_By_Report_ID", objpar);
             return dt;
         }


         public void updateCell_Attendance_New()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Attendance_ID", SqlDbType.BigInt, Attendance_ID));
             objlist.Add(new csParameterListType("@Member_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Guest_Name", SqlDbType.VarChar, Full_Name));
             objlist.Add(new csParameterListType("@GuestOrMember", SqlDbType.VarChar, MemberOrGuest));
             objlist.Add(new csParameterListType("@Age_Bracket", SqlDbType.VarChar, Age_Bracket));
             objlist.Add(new csParameterListType("@PresentOrAbsent", SqlDbType.VarChar, PresentOrAbsent));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_AttendanceReg_Update", objlist);
         }


         #endregion

         #region Cell Events
         //---------------Cell Events------------------------------

         public void addCell_Event()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Event_Date", SqlDbType.VarChar, Event_Date.ToString()));
             objlist.Add(new csParameterListType("@Event_Time", SqlDbType.VarChar, Event_Time.ToString()));
             objlist.Add(new csParameterListType("@Event_Name", SqlDbType.VarChar, Event_Name.ToString()));
             objlist.Add(new csParameterListType("@Event_Venue", SqlDbType.VarChar, Event_Venue.ToString()));
             objlist.Add(new csParameterListType("@Event_Description", SqlDbType.VarChar, Event_Description.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
             objdal.executespreturnnd("procHome_Cell_Events_Insert", objlist);
         }


         public void updateCell_Event()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
             objlist.Add(new csParameterListType("@Event_Date", SqlDbType.VarChar, Event_Date.ToString()));
             objlist.Add(new csParameterListType("@Event_Time", SqlDbType.VarChar, Event_Time.ToString()));
             objlist.Add(new csParameterListType("@Event_Name", SqlDbType.VarChar, Event_Name.ToString()));
             objlist.Add(new csParameterListType("@Event_Venue", SqlDbType.VarChar, Event_Venue.ToString()));
             objlist.Add(new csParameterListType("@Event_Description", SqlDbType.VarChar, Event_Description.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
             objdal.executespreturnnd("procHome_Cell_Events_Update", objlist);
         }

         public DataTable viewHome_Cell_Event_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Events_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Event_By_Event_ID(Int32 Event_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Event_ID", SqlDbType.BigInt, Event_ID));
             dt = objdal.search("procHome_Cell_Events_By_Event_ID", objpar);
             return dt;
         }

         #endregion

         #region Cell Multiplication

         //---------------Cell Multiplication------------------------------

         public void addCell_Multiplication()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Multiplication_Date", SqlDbType.VarChar, Multiplication_Date.ToString()));
             objlist.Add(new csParameterListType("@New_Cell_Name", SqlDbType.VarChar, New_Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@New_Cell_Venue", SqlDbType.VarChar, New_Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@New_Cell_Leader_ID", SqlDbType.BigInt, New_Cell_Leader_ID));
             objlist.Add(new csParameterListType("@New_Cell_Intern1_ID", SqlDbType.BigInt, New_Cell_Intern1_ID));
             objlist.Add(new csParameterListType("@New_Cell_Intern2_ID", SqlDbType.BigInt, New_Cell_Intern2_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Multiplication_Insert", objlist);
         }

         public void updateCell_Multiplication()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Multiplication_ID", SqlDbType.BigInt, Multiplication_ID));
             objlist.Add(new csParameterListType("@Multiplication_Date", SqlDbType.VarChar, Multiplication_Date.ToString()));
             objlist.Add(new csParameterListType("@New_Cell_Name", SqlDbType.VarChar, New_Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@New_Cell_Venue", SqlDbType.VarChar, New_Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@New_Cell_Leader_ID", SqlDbType.BigInt, New_Cell_Leader_ID));
             objlist.Add(new csParameterListType("@New_Cell_Intern1_ID", SqlDbType.BigInt, New_Cell_Intern1_ID));
             objlist.Add(new csParameterListType("@New_Cell_Intern2_ID", SqlDbType.BigInt, New_Cell_Intern2_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cell_Multiplication_Update", objlist);
         }

         public DataTable viewHome_Cell_Multiplication_By_Cell_ID(Int32 Cell_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             dt = objdal.search("procHome_Cell_Multiplication_By_Cell_ID", objpar);
             return dt;
         }

         public DataTable viewHome_Cell_Multiplication_By_Multiplication_ID(Int32 Multiplication_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Multiplication_ID", SqlDbType.BigInt, Multiplication_ID));
             dt = objdal.search("procHome_Cell_Multiplication_By_Multiplication_ID", objpar);
             return dt;
         }


         #endregion

         #endregion

         #region Workers

         //---------------------Workers------------------------------------------
         public void AddNewWorkers()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Workers_Year", SqlDbType.VarChar, Workers_Year.ToString()));
             objdal.executespreturnnd("procClient_Workers_Insert", objlist);
         }

         public void updateWorkers()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Worker_ID", SqlDbType.BigInt, Worker_ID));
             objlist.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
             objlist.Add(new csParameterListType("@Position", SqlDbType.VarChar, Position.ToString()));
             objlist.Add(new csParameterListType("@Responsibilities", SqlDbType.VarChar, Responsibilities.ToString()));
             objlist.Add(new csParameterListType("@Period", SqlDbType.VarChar, Period.ToString()));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date.ToString()));
             objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date.ToString()));
             objdal.executespreturnnd("procClient_Workers_Update", objlist);
         }

         public DataTable viewWorkersByClient_ID(Int32 Client_ID, string Workers_Year)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Workers_Year", SqlDbType.VarChar, Workers_Year.ToString()));
             dt = objdal.search("procClient_Workers_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewWorkers_By_Client_ID2(Int32 Client_ID, string Workers_Year)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Workers_Year", SqlDbType.VarChar, Workers_Year.ToString()));
             dt = objdal.search("procClient_Workers_By_Client_ID2", objpar);
             return dt;
         }

         public DataTable viewWorkers_By_Client_ID2_and_Department_ID(Int32 Client_ID, string Workers_Year, Int32 Department_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Workers_Year", SqlDbType.VarChar, Workers_Year.ToString()));
             objpar.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
             dt = objdal.search("procClient_Workers_By_Client_ID2_and_Department_ID", objpar);
             return dt;
         }

         public DataTable viewWorkersByProfile_ID(Int32 Profile_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
             dt = objdal.search("procClient_Workers_By_Profile_ID", objpar);
             return dt;
         }

         public DataTable viewWorkersByWorker_ID(Int32 Worker_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Worker_ID", SqlDbType.BigInt, Worker_ID));
             dt = objdal.search("procClient_Workers_By_Worker_ID", objpar);
             return dt;
         }

         public DataTable viewProfile_Workers_By_Client_ID(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procProfiles_Workers_By_Client_ID", objpar);
             return dt;
         }

         public DataTable searchForWorkersByAnyField1(string sVariable, int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
             dt = objdal.search("procSearchWorkersByAnyField1", objpar);
             return dt;
         }

         public void addWorkers_Migrate()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Year_From", SqlDbType.VarChar, Year_From.ToString()));
             objlist.Add(new csParameterListType("@Year_To", SqlDbType.VarChar, Year_To.ToString()));
             objlist.Add(new csParameterListType("@Migration_Date", SqlDbType.VarChar, Migration_Date.ToString()));
             objdal.executespreturnnd("procClient_Workers_Insert_Migrate", objlist);
         }

         #endregion

         #region with_AmenApp

         public DataTable viewWorkers_with_AmenApp_By_Client_ID(Int32 Client_ID, string Workers_Year)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Workers_Year", SqlDbType.VarChar, Workers_Year.ToString()));
             dt = objdal.search("procReport_All_Workers_with_AmenApp_By_Client_ID", objpar);
             return dt;
         }

         public DataTable viewWorkers_with_AmenApp_By_Client_ID_and_Department_ID(Int32 Client_ID, string Workers_Year, Int32 Department_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@Workers_Year", SqlDbType.VarChar, Workers_Year.ToString()));
             objpar.Add(new csParameterListType("@Department_ID", SqlDbType.BigInt, Department_ID));
             dt = objdal.search("procReport_All_Workers_with_AmenApp_By_Client_ID_and_Department_ID", objpar);
             return dt;
         }

        #endregion

         #region Events
         //--------------Events----------------------------------------

         public void addEvents_Pre()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_Number", SqlDbType.VarChar, Cell_Number.ToString()));
             objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objlist.Add(new csParameterListType("@Group_ID", SqlDbType.BigInt, Group_ID));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_CellPre_Insert", objlist);
         }

         public DataTable viewEvents_ID_ByEvent_Number(string Cell_Number)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Cell_Number", SqlDbType.VarChar, Cell_Number.ToString()));
             dt = objdal.search("procHome_Cell_ID_By_Cell_Number", objpar);
             return dt;
         }

         public void updateEvents()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
             objlist.Add(new csParameterListType("@Cell_Name", SqlDbType.VarChar, Cell_Name.ToString()));
             objlist.Add(new csParameterListType("@Cell_Venue", SqlDbType.VarChar, Cell_Venue.ToString()));
             objlist.Add(new csParameterListType("@Cell_Day", SqlDbType.VarChar, Cell_Day.ToString()));
             objlist.Add(new csParameterListType("@Cell_Time", SqlDbType.VarChar, Cell_Time));
             objlist.Add(new csParameterListType("@Leader_ID", SqlDbType.BigInt, Leader_ID));
             objlist.Add(new csParameterListType("@Intern1_ID", SqlDbType.BigInt, Intern1_ID));
             objlist.Add(new csParameterListType("@Intern2_ID", SqlDbType.BigInt, Intern2_ID));
             objlist.Add(new csParameterListType("@Cell_Active", SqlDbType.VarChar, Cell_Active.ToString()));
             objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
             objdal.executespreturnnd("procHome_Cells_Update", objlist);
         }

         public void deleteEvents()
         {
             csDAL objdal = new csDAL();
             List<csParameterListType> objlist = new List<csParameterListType>();
             objlist.Add(new csParameterListType("@Cell_ID", SqlDbType.BigInt, Cell_ID));
             objdal.executespreturnnd("procHome_Cells_Delete", objlist);
         }



         public DataTable viewEvents_By_Client_ID_and_NoDates(int Client_ID)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             dt = objdal.search("procHome_Cells_By_Client_ID_NoDates", objpar);
             return dt;
         }

         public DataTable viewEvents_By_Client_ID_and_Dates(int Client_ID, string From_Date, string To_Date)
         {
             csDAL objdal = new csDAL();
             DataTable dt = new DataTable();
             List<csParameterListType> objpar = new List<csParameterListType>();
             objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
             objpar.Add(new csParameterListType("@From_Date", SqlDbType.VarChar, From_Date));
             objpar.Add(new csParameterListType("@To_Date", SqlDbType.VarChar, To_Date));
             dt = objdal.search("procHome_Cells_By_Client_ID_with_Dates", objpar);
             return dt;
         }


         #endregion

    }
}
