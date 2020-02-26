using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace AmenService1
{
    public class csInstitution
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Student_ID { set; get; }
        public string Student_No { set; get; }
        public string Course_Name { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }
        public string Gender { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string Start_Date { set; get; }
        public string End_Date { set; get; }
        public string IsActive { set; get; }
        public string LastUpdate_Date { set; get; }

        public csInstitution()
        { }

        public void addStudent()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Student_No", SqlDbType.VarChar, Student_No.ToString()));
            objlist.Add(new csParameterListType("@Course_Name", SqlDbType.VarChar, Course_Name.ToString()));
            objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
            objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name));
            objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive));
            objdal.executespreturnnd("procInstitution_Students_Insert", objlist);
        }

        public void UpdateStudent()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Student_ID", SqlDbType.BigInt, Student_ID));
            objlist.Add(new csParameterListType("@Student_No", SqlDbType.VarChar, Student_No.ToString()));
            objlist.Add(new csParameterListType("@Course_Name", SqlDbType.VarChar, Course_Name.ToString()));
            objlist.Add(new csParameterListType("@First_Name", SqlDbType.VarChar, First_Name.ToString()));
            objlist.Add(new csParameterListType("@Last_Name", SqlDbType.VarChar, Last_Name));
            objlist.Add(new csParameterListType("@Gender", SqlDbType.VarChar, Gender));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@End_Date", SqlDbType.VarChar, End_Date));
            objlist.Add(new csParameterListType("@IsActive", SqlDbType.VarChar, IsActive));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procInstitution_Students_Update", objlist);
        }
        
        public DataTable viewStudents_By_Student_ID(Int32 Student_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Student_ID", SqlDbType.BigInt, Student_ID));
            dt = objdal.search("procInstitution_Students_View_By_Student_ID", objlist);
            return dt;
        }

        public DataTable viewStudents_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procInstitution_Students_View_By_Client_ID", objlist);
            return dt;
        }

        public DataTable viewStudents_By_Client_ID_Period(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objlist.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procInstitution_Students_View_By_Client_ID_and_Period", objlist);
            return dt;
        }

        public DataTable viewStudents_By_IsStudent(Int32 Client_ID, string Student_No, string Mobile, string Email)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Student_No", SqlDbType.VarChar, Student_No));
            objlist.Add(new csParameterListType("@Mobile", SqlDbType.VarChar, Mobile));
            objlist.Add(new csParameterListType("@Email", SqlDbType.VarChar, Email));
            dt = objdal.search("procInstitution_Students_IsStudent", objlist);
            return dt;
        }

        public DataTable getAllStudents()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procStudents_ViewALL");
            return dt;
        }

        public DataTable viewStudents_By_Email(string Student_Email)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Student_Email", SqlDbType.BigInt, Student_Email));
            dt = objdal.search("procStudents_View_By_Client_ID", objlist);
            return dt;
        }

        public DataTable searchForStudentsByAnyField1(string sVariable, Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procSearchInstitution_StudentsByAnyField1_and_Period", objpar);
            return dt;
        }

        public DataTable viewStudents_By_Client_ID_Period_Past(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objlist.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procInstitution_Students_View_By_Client_ID_and_Period_Past", objlist);
            return dt;
        }

        public DataTable searchForStudentsByAnyField1_Past(string sVariable, Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procSearchInstitution_StudentsByAnyField1_and_Period_Past", objpar);
            return dt;
        }

        public DataTable viewStudents_By_Client_ID_Past(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procInstitution_Students_View_By_Client_ID_Past", objlist);
            return dt;
        }

    }
}
