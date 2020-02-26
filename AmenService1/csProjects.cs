using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csProjects
    {
        csDAL objdal = new csDAL();

        public Int32 Client_ID { set; get; }
        public Int32 Project_ID { set; get; }
        public string Project_Number { set; get; }
        public string Project_Name { set; get; }
        
        public string Start_Date { set; get; }
        public string Finish_Date { set; get; }
        
        public string Duration { set; get; }
        public string Current_Stage { set; get; }
        public string Project_Status { set; get; }
        public string Project_Objectives { set; get; }
        public string Deliverables { set; get; }
        public string Milestones { set; get; }
        public string Specification { set; get; }
        public string Limits { set; get; }
        public string LastUpdate_Date { set; get; }
        public string Reg_Date { set; get; }

        public Int32 Schedule_ID { set; get; }
        public string Task_Name { set; get; }

        public Int32 Budget_ID { set; get; }
        public string DirectCost1 { set; get; }
        public string DirectCost2 { set; get; }
        public string DirectCost3 { set; get; }
        public string DirectCost4 { set; get; }
        public string DirectCost5 { set; get; }
        public string DirectCost6 { set; get; }
        public string DirectCost7 { set; get; }
        public string DirectCost8 { set; get; }
        public string DirectCost9 { set; get; }
        public string DirectCost10 { set; get; }
        public string DirectCost11 { set; get; }
        public string DirectCost12 { set; get; }

        public string OverheadCost1 { set; get; }
        public string OverheadCost2 { set; get; }
        public string OverheadCost3 { set; get; }
        public string OverheadCost4 { set; get; }
        public string OverheadCost5 { set; get; }

        public string GeneralAdminCost { set; get; }
        public string GrandTotal { set; get; }


        public Int32 Risk_ID { set; get; }
        public string Risk_Planning { set; get; }
        public string Internal_Risks { set; get; }
        public string External_Risks { set; get; }

        public Int32 Quality_ID { set; get; }
        public string Quality_Standards { set; get; }
        public string Quality_Planning { set; get; }
        public string Quality_Assurance { set; get; }
        public string Quality_Control { set; get; }

        public Int32 Change_ID { set; get; }
        public string Change { set; get; }

        public Int32 Status_Report_ID { set; get; }
        public string Report_Date { set; get; }
        public string Project_Report_Title { set; get; }
        public string Project_Report { set; get; }


        public string Documents_Transfer { set; get; }
        public string Lessons { set; get; }


        public Int32 Stakeholder_ID { set; get; }
        public string Category { set; get; }
        public string Stakeholder_Name { set; get; }
        public string Is_Church_Member { set; get; }
        public string Stakeholder_Mobile { set; get; }
        public string Stakeholder_Email { set; get; }




      
        public csProjects()
        {}


        public void addProject_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_Number", SqlDbType.VarChar, Project_Number.ToString()));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Pre_Insert", objlist);
        }

        public void updateProject()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Project_Name", SqlDbType.VarChar, Project_Name.ToString()));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
            objlist.Add(new csParameterListType("@Finish_Date", SqlDbType.VarChar, Finish_Date.ToString()));
            objlist.Add(new csParameterListType("@Duration", SqlDbType.VarChar, Duration.ToString()));
            objlist.Add(new csParameterListType("@Current_Stage", SqlDbType.VarChar, Current_Stage));
            objlist.Add(new csParameterListType("@Project_Status", SqlDbType.VarChar, Project_Status));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Update", objlist);
        }

        public DataTable viewProject_ID_ByProject_Number(string Project_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_Number", SqlDbType.VarChar, Project_Number.ToString()));
            dt = objdal.search("procProject_ID_By_Project_Number", objpar);
            return dt;
        }

        public DataTable viewProjects_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procProjects_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_Category_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procMeetings_Category_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_By_Project_ID", objpar);
            return dt;
        }

        public DataTable searchForProjectsByAnyField1(string sVariable, int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@sVariable", SqlDbType.VarChar, sVariable));
            dt = objdal.search("procProjects_SearchByAnyField1", objpar);
            return dt;
        }


        public void updateProjects_Objectives()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Project_Objectives", SqlDbType.VarChar, Project_Objectives.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Objectives_Update", objlist);
        }

        public DataTable viewProjects_Objectives_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Objectives_By_Project_ID", objpar);
            return dt;
        }



        public void updateProjects_Deliverables()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Deliverables", SqlDbType.VarChar, Deliverables.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Deliverables_Update", objlist);
        }

        public DataTable viewProjects_Deliverables_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Deliverables_By_Project_ID", objpar);
            return dt;
        }


        public void updateProjects_Milestones()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Milestones", SqlDbType.VarChar, Milestones.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Milestones_Update", objlist);
        }

        public DataTable viewProjects_Milestones_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Milestones_By_Project_ID", objpar);
            return dt;
        }

        public void updateProjects_Specification()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Specification", SqlDbType.VarChar, Specification.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Specification_Update", objlist);
        }

        public DataTable viewProjects_Specification_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Specification_By_Project_ID", objpar);
            return dt;
        }


        public void updateProjects_Limits()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Limits", SqlDbType.VarChar, Limits.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Limits_Update", objlist);
        }

        public DataTable viewProjects_Limits_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Limits_By_Project_ID", objpar);
            return dt;
        }



        public void addProjects_Schedule()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Task_Name", SqlDbType.VarChar, Task_Name));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
            objlist.Add(new csParameterListType("@Finish_Date", SqlDbType.VarChar, Finish_Date.ToString()));
            objlist.Add(new csParameterListType("@Duration", SqlDbType.VarChar, Duration.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Schedule_Insert", objlist);
        }

        public void updateProjects_Schedule()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Schedule_ID", SqlDbType.BigInt, Schedule_ID));
            objlist.Add(new csParameterListType("@Task_Name", SqlDbType.VarChar, Task_Name));
            objlist.Add(new csParameterListType("@Start_Date", SqlDbType.VarChar, Start_Date.ToString()));
            objlist.Add(new csParameterListType("@Finish_Date", SqlDbType.VarChar, Finish_Date.ToString()));
            objlist.Add(new csParameterListType("@Duration", SqlDbType.VarChar, Duration.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Schedule_Update", objlist);
        }

        public DataTable viewProjects_Schedule_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Schedule_By_Project_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_Schedule_By_Schedule_ID(Int32 Schedule_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Schedule_ID", SqlDbType.BigInt, Schedule_ID));
            dt = objdal.search("procProjects_Schedule_By_Schedule_ID", objpar);
            return dt;
        }



        public void updateProjects_Budget()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@DirectCost1", SqlDbType.VarChar, DirectCost1));
            objlist.Add(new csParameterListType("@DirectCost2", SqlDbType.VarChar, DirectCost2));
            objlist.Add(new csParameterListType("@DirectCost3", SqlDbType.VarChar, DirectCost3));
            objlist.Add(new csParameterListType("@DirectCost4", SqlDbType.VarChar, DirectCost4));
            objlist.Add(new csParameterListType("@DirectCost5", SqlDbType.VarChar, DirectCost5));
            objlist.Add(new csParameterListType("@DirectCost6", SqlDbType.VarChar, DirectCost6));
            objlist.Add(new csParameterListType("@DirectCost7", SqlDbType.VarChar, DirectCost7));
            objlist.Add(new csParameterListType("@DirectCost8", SqlDbType.VarChar, DirectCost8));
            objlist.Add(new csParameterListType("@DirectCost9", SqlDbType.VarChar, DirectCost9));
            objlist.Add(new csParameterListType("@DirectCost10", SqlDbType.VarChar, DirectCost10));
            objlist.Add(new csParameterListType("@DirectCost11", SqlDbType.VarChar, DirectCost11));
            objlist.Add(new csParameterListType("@DirectCost12", SqlDbType.VarChar, DirectCost12));
            objlist.Add(new csParameterListType("@OverheadCost1", SqlDbType.VarChar, OverheadCost1));
            objlist.Add(new csParameterListType("@OverheadCost2", SqlDbType.VarChar, OverheadCost2));
            objlist.Add(new csParameterListType("@OverheadCost3", SqlDbType.VarChar, OverheadCost3));
            objlist.Add(new csParameterListType("@OverheadCost4", SqlDbType.VarChar, OverheadCost4));
            objlist.Add(new csParameterListType("@OverheadCost5", SqlDbType.VarChar, OverheadCost5));
            objlist.Add(new csParameterListType("@GeneralAdminCost", SqlDbType.VarChar, GeneralAdminCost));
            objlist.Add(new csParameterListType("@GrandTotal", SqlDbType.VarChar, GrandTotal));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Budget_Update", objlist);
        }

        public DataTable viewProjects_Budget_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Budget_By_Project_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_Budget_By_Budget_ID(Int32 Budget_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Budget_ID", SqlDbType.BigInt, Budget_ID));
            dt = objdal.search("procProjects_Budget_By_Budget_ID", objpar);
            return dt;
        }


        public void updateProjects_Budget_Labels()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@DirectCost1", SqlDbType.VarChar, DirectCost1));
            objlist.Add(new csParameterListType("@DirectCost2", SqlDbType.VarChar, DirectCost2));
            objlist.Add(new csParameterListType("@DirectCost3", SqlDbType.VarChar, DirectCost3));
            objlist.Add(new csParameterListType("@DirectCost4", SqlDbType.VarChar, DirectCost4));
            objlist.Add(new csParameterListType("@DirectCost5", SqlDbType.VarChar, DirectCost5));
            objlist.Add(new csParameterListType("@DirectCost6", SqlDbType.VarChar, DirectCost6));
            objlist.Add(new csParameterListType("@DirectCost7", SqlDbType.VarChar, DirectCost7));
            objlist.Add(new csParameterListType("@DirectCost8", SqlDbType.VarChar, DirectCost8));
            objlist.Add(new csParameterListType("@DirectCost9", SqlDbType.VarChar, DirectCost9));
            objlist.Add(new csParameterListType("@DirectCost10", SqlDbType.VarChar, DirectCost10));
            objlist.Add(new csParameterListType("@DirectCost11", SqlDbType.VarChar, DirectCost11));
            objlist.Add(new csParameterListType("@DirectCost12", SqlDbType.VarChar, DirectCost12));
            objlist.Add(new csParameterListType("@OverheadCost1", SqlDbType.VarChar, OverheadCost1));
            objlist.Add(new csParameterListType("@OverheadCost2", SqlDbType.VarChar, OverheadCost2));
            objlist.Add(new csParameterListType("@OverheadCost3", SqlDbType.VarChar, OverheadCost3));
            objlist.Add(new csParameterListType("@OverheadCost4", SqlDbType.VarChar, OverheadCost4));
            objlist.Add(new csParameterListType("@OverheadCost5", SqlDbType.VarChar, OverheadCost5));
            objlist.Add(new csParameterListType("@GeneralAdminCost", SqlDbType.VarChar, GeneralAdminCost));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Budget_Labels_Update", objlist);
        }

        public DataTable viewProjects_Budget_Labels_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Budget_Labels_By_Project_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_Budget_Labels_By_Budget_ID(Int32 Budget_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Budget_ID", SqlDbType.BigInt, Budget_ID));
            dt = objdal.search("procProjects_Budget_Labels_By_Budget_ID", objpar);
            return dt;
        }



        public void updateProjects_Risks()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Risk_Planning", SqlDbType.VarChar, Risk_Planning));
            objlist.Add(new csParameterListType("@Internal_Risks", SqlDbType.VarChar, Internal_Risks));
            objlist.Add(new csParameterListType("@External_Risks", SqlDbType.VarChar, External_Risks));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Risks_Update", objlist);
        }

        public DataTable viewProjects_Risks_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Risks_By_Project_ID", objpar);
            return dt;
        }

        //public DataTable viewProjects_Risks_By_Risk_ID(Int32 Risk_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Risk_ID", SqlDbType.BigInt, Risk_ID));
        //    dt = objdal.search("procProjects_Risks_By_Risk_ID", objpar);
        //    return dt;
        //}


        public void updateProjects_Quality()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Quality_Standards", SqlDbType.VarChar, Quality_Standards));
            objlist.Add(new csParameterListType("@Quality_Planning", SqlDbType.VarChar, Quality_Planning));
            objlist.Add(new csParameterListType("@Quality_Assurance", SqlDbType.VarChar, Quality_Assurance));
            objlist.Add(new csParameterListType("@Quality_Control", SqlDbType.VarChar, Quality_Control));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Quality_Update", objlist);
        }


        public DataTable viewProjects_Quality_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Quality_By_Project_ID", objpar);
            return dt;
        }



        public void updateProjects_Change()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Change", SqlDbType.VarChar, Change));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Change_Update", objlist);
        }


        public DataTable viewProjects_Change_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Change_By_Project_ID", objpar);
            return dt;
        }




        public void addProjects_Status_Report()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Report_Date", SqlDbType.VarChar, Report_Date));
            objlist.Add(new csParameterListType("@Project_Report_Title", SqlDbType.VarChar, Project_Report_Title.ToString()));
            objlist.Add(new csParameterListType("@Project_Report", SqlDbType.VarChar, Project_Report.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Status_Report_Insert", objlist);
        }

        public void updateProjects_Status_Report()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Status_Report_ID", SqlDbType.BigInt, Status_Report_ID));
            objlist.Add(new csParameterListType("@Report_Date", SqlDbType.VarChar, Report_Date));
            objlist.Add(new csParameterListType("@Project_Report_Title", SqlDbType.VarChar, Project_Report_Title.ToString()));
            objlist.Add(new csParameterListType("@Project_Report", SqlDbType.VarChar, Project_Report.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Status_Report_Update", objlist);
        }

        public DataTable viewProjects_Status_Report_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Status_Report_By_Project_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_Status_Report_By_Status_Report_ID(Int32 Status_Report_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Status_Report_ID", SqlDbType.BigInt, Status_Report_ID));
            dt = objdal.search("procProjects_Status_Report_By_Status_Report_ID", objpar);
            return dt;
        }



        public void updateProjects_Documents_Transfer()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Documents_Transfer", SqlDbType.VarChar, Documents_Transfer));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Documents_Transfer_Update", objlist);
        }

        public DataTable viewProjects_Documents_Transfer_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Documents_Transfer_By_Project_ID", objpar);
            return dt;
        }



        public void updateProjects_Lessons()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Lessons", SqlDbType.VarChar, Lessons));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Lessons_Update", objlist);
        }

        public DataTable viewProjects_Lessons_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Lessons_By_Project_ID", objpar);
            return dt;
        }





        public void addProjects_Stakeholder()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objlist.Add(new csParameterListType("@Stakeholder_Name", SqlDbType.VarChar, Stakeholder_Name.ToString()));
            objlist.Add(new csParameterListType("@Is_Church_Member", SqlDbType.VarChar, Is_Church_Member.ToString()));
            objlist.Add(new csParameterListType("@Stakeholder_Mobile", SqlDbType.VarChar, Stakeholder_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Stakeholder_Email", SqlDbType.VarChar, Stakeholder_Email.ToString()));
            objlist.Add(new csParameterListType("@Reg_Date", SqlDbType.VarChar, Reg_Date.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Stakeholder_Insert", objlist);
        }

        public void updateProjects_Stakeholder()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Stakeholder_ID", SqlDbType.BigInt, Stakeholder_ID));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            objlist.Add(new csParameterListType("@Stakeholder_Name", SqlDbType.VarChar, Stakeholder_Name.ToString()));
            objlist.Add(new csParameterListType("@Is_Church_Member", SqlDbType.VarChar, Is_Church_Member.ToString()));
            objlist.Add(new csParameterListType("@Stakeholder_Mobile", SqlDbType.VarChar, Stakeholder_Mobile.ToString()));
            objlist.Add(new csParameterListType("@Stakeholder_Email", SqlDbType.VarChar, Stakeholder_Email.ToString()));
            objlist.Add(new csParameterListType("@LastUpdate_Date", SqlDbType.VarChar, LastUpdate_Date));
            objdal.executespreturnnd("procProjects_Stakeholder_Update", objlist);
        }

        public DataTable viewProjects_Stakeholder_By_Project_ID(Int32 Project_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            dt = objdal.search("procProjects_Stakeholder_By_Project_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_Stakeholder_By_Stakeholder_ID(Int32 Stakeholder_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Stakeholder_ID", SqlDbType.BigInt, Stakeholder_ID));
            dt = objdal.search("procProjects_Stakeholder_By_Stakeholder_ID", objpar);
            return dt;
        }

        public DataTable viewProjects_Stakeholder_By_Project_ID_and_Category(Int32 Project_ID, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Project_ID", SqlDbType.BigInt, Project_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procProjects_Stakeholder_By_Project_ID_and_Category", objpar);
            return dt;
        }

    }
}
