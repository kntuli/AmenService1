using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csTasks
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Task_ID { set; get; }
        public Int32 Category_ID { set; get; }
        public string Task_Number { set; get; }
        public string Main_Category { set; get; }
        public string Category { set; get; }
        public Int32 Assigned_By_ID { set; get; }
        public string Assigned_By { set; get; }
        public Int32 Assigned_To_ID { set; get; }
        public string Assigned_To { set; get; }
        public string Is_Church_Member { set; get; }
        public string Contact_Mobile { set; get; }
        public string Contact_Email { set; get; }
        public string Start_Date { set; get; }
        public string Finish_Date { set; get; }
        public string Task_Title { set; get; }
        public string Task { set; get; }
        public string Task_Pending { set; get; }
        public string Task_Inprogress { set; get; }
        public string Task_Completed { set; get; }
        public string Task_Status { set; get; }
        public string Reg_Date { set; get; }
        public string Due_Date { set; get; }
        public Int32 Ministry_ID { set; get; }
        public Int32 Priority { set; get; }
        public string LastUpdate_Date { set; get; }

        public csTasks()
        { }

        public void addTask_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Task_Number", SqlDbType.VarChar, Task_Number.ToString()));
            objlist.Add(new csParameterListType("@Main_Category", SqlDbType.VarChar, Main_Category.ToString()));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procTasks_Pre_Insert", objlist);
        }

        public void updateTask()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Task_ID", SqlDbType.BigInt, Task_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Assigned_By_ID", SqlDbType.BigInt, Assigned_By_ID));
            objlist.Add(new csParameterListType("@Assigned_By", SqlDbType.VarChar, Assigned_By.ToString()));
            objlist.Add(new csParameterListType("@Assigned_To_ID", SqlDbType.BigInt, Assigned_To_ID));
            objlist.Add(new csParameterListType("@Assigned_To", SqlDbType.VarChar, Assigned_To.ToString()));
            objlist.Add(new csParameterListType("@Is_Church_Member", SqlDbType.VarChar, Is_Church_Member));
            objlist.Add(new csParameterListType("@Contact_Mobile", SqlDbType.VarChar, Contact_Mobile));
            objlist.Add(new csParameterListType("@Contact_Email", SqlDbType.VarChar, Contact_Email));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@Finish_Date", SqlDbType.VarChar, Finish_Date));
            objlist.Add(new csParameterListType("@Task_Title", SqlDbType.VarChar, Task_Title));
            objlist.Add(new csParameterListType("@Task", SqlDbType.VarChar, Task));
            objlist.Add(new csParameterListType("@Task_Status", SqlDbType.VarChar, Task_Status));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procTasks_Update", objlist);
        }

        public void updateTask2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Task_ID", SqlDbType.BigInt, Task_ID));
            objlist.Add(new csParameterListType("@Assigned_By_ID", SqlDbType.BigInt, Assigned_By_ID));
            objlist.Add(new csParameterListType("@Assigned_By", SqlDbType.VarChar, Assigned_By.ToString()));
            objlist.Add(new csParameterListType("@Assigned_To_ID", SqlDbType.BigInt, Assigned_To_ID));
            objlist.Add(new csParameterListType("@Assigned_To", SqlDbType.VarChar, Assigned_To.ToString()));
            objlist.Add(new csParameterListType("@Is_Church_Member", SqlDbType.VarChar, Is_Church_Member));
            objlist.Add(new csParameterListType("@Contact_Mobile", SqlDbType.VarChar, Contact_Mobile));
            objlist.Add(new csParameterListType("@Contact_Email", SqlDbType.VarChar, Contact_Email));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date));
            objlist.Add(new csParameterListType("@Finish_Date", SqlDbType.VarChar, Finish_Date));
            objlist.Add(new csParameterListType("@Task_Title", SqlDbType.VarChar, Task_Title));
            objlist.Add(new csParameterListType("@Task", SqlDbType.VarChar, Task));
            objlist.Add(new csParameterListType("@Task_Status", SqlDbType.VarChar, Task_Status));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procTasks_Update2", objlist);
        }

        public void updateTask_Pending()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Task_ID", SqlDbType.BigInt, Task_ID));
            objlist.Add(new csParameterListType("@Task", SqlDbType.VarChar, Task));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procTasks_Pending_Update", objlist);
        }


        public void updateTask_All()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Task_ID", SqlDbType.BigInt, Task_ID));
            objlist.Add(new csParameterListType("@Task_Pending", SqlDbType.VarChar, Task_Pending));
            objlist.Add(new csParameterListType("@Task_Inprogress", SqlDbType.VarChar, Task_Inprogress));
            objlist.Add(new csParameterListType("@Task_Completed", SqlDbType.VarChar, Task_Completed));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procTasks_All_Update", objlist);
        }

        public void AddNewDayTask_All()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objdal.executespreturnnd("procTasks_All_AddNewDay", objlist);
        }

        public void updateTask_For_Projects()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Task_ID", SqlDbType.BigInt, Task_ID));
            objlist.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procTasks_Update_For_Projects", objlist);
        }

        public DataTable viewTask_ID_ByTask_Number(string Task_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Task_Number", SqlDbType.VarChar, Task_Number.ToString()));
            dt = objdal.search("procTask_ID_By_Task_Number", objpar);
            return dt;
        }

        public DataTable viewTasks_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procTasks_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewTasks_By_Client_ID_and_Category_ID(Int32 Client_ID, Int32 Category_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category_ID", SqlDbType.BigInt, Category_ID));
            dt = objdal.search("procTasks_By_Client_ID_and_Category_ID", objpar);
            return dt;
        }

        public DataTable viewTasks_By_Client_ID_and_Main_Category_All(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procTasks_By_Client_ID_and_Main_Category_All", objpar);
            return dt;
        }

        public DataTable viewTasks_By_Client_ID_and_Main_Category(Int32 Client_ID, string Main_Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Main_Category", SqlDbType.VarChar, Main_Category));
            dt = objdal.search("procTasks_By_Client_ID_and_Main_Category", objpar);
            return dt;
        }

        public DataTable viewTasks_Category_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procTasks_Category_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewTasks_Main_Category_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procMain_Category_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewTasks_By_Task_ID(Int32 Task_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Task_ID", SqlDbType.BigInt, Task_ID));
            dt = objdal.search("procTasks_By_Task_ID", objpar);
            return dt;
        }

        public DataTable searchForTasksByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procTasks_SearchByAnyField1", objpar);
            return dt;
        }


        //-----------All-----------------------------------
        public DataTable viewTasks_All_By_Client_ID_and_Ministry_ID(Int32 Client_ID, Int32 Ministry_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            dt = objdal.search("procTasks_All_By_Client_ID_and_Ministry_ID", objpar);
            return dt;
        }

        public DataTable viewTasks_All_By_Client_ID_and_Ministry_ID_and_Date(Int32 Client_ID, Int32 Ministry_ID, string Reg_Date)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            objpar.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            dt = objdal.search("procTasks_All_By_Client_ID_and_Ministry_ID_and_Date", objpar);
            return dt;
        }

        public DataTable viewTasks_All_By_Task_ID(Int32 Task_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Task_ID", SqlDbType.BigInt, Task_ID));
            dt = objdal.search("procTasks_All_By_Task_ID", objpar);
            return dt;
        }

        //-----------Pending-----------------------------------
        public DataTable viewTasks_Pending_By_Client_ID_and_Ministry_ID(Int32 Client_ID, Int32 Ministry_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Ministry_ID", SqlDbType.BigInt, Ministry_ID));
            dt = objdal.search("procTasks_Pending_By_Client_ID_and_Ministry_ID", objpar);
            return dt;
        }


    }
}
