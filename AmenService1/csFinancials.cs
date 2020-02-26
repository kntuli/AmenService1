using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;


namespace AmenService1
{
    public class csFinancials
    {

        csDAL objdal = new csDAL();

        public Int32 Financial_ID { set; get; }
        public Int32 Profile_ID { set; get; }
        public Int32 Client_ID { set; get; }

        public string Financial_Date { set; get; }
        public string Financial_Amount { set; get; }
        public string Financial_For { set; get; }
        public string Financial_Description { set; get; }
        public string Payment_Type { set; get; }
        public string Confirmed { set; get; }
        public string Confirm_Date { set; get; }
        public string Financial_Items { set; get; }
        public string Category { set; get; }

        public Int32 MoneyInItem_ID { set; get; }
        public string MoneyIn_Items { set; get; }
        public string MoneyIn_Items_SMS { set; get; }
        public string MoneyIn_Items_App_Message { set; get; }
        public string Item_SMS { set; get; }
        public string App_Message { set; get; }

        public Int32 VoidedBy_ID { set; get; }
        public string Void_Date { set; get; }

        public Int32 Counting_ID { set; get; }
        public string ServiceDate { set; get; }
        public string ServiceName { set; get; }
        public string ItemName { set; get; }
        public Int32 ItemTotal { set; get; }
        public Int32 ItemValue1 { set; get; }
        public Int32 ItemValue2 { set; get; }
        public Int32 ItemValue3 { set; get; }
        public Int32 ItemValue4 { set; get; }
        public Int32 ItemValue5 { set; get; }
        public Int32 ItemValue6 { set; get; }
        public Int32 ItemValue7 { set; get; }
        public Int32 ItemValue8 { set; get; }


        public Int32 Pledge_ID { set; get; }
        public string Pledge_Date { set; get; }
        public string Pledge_Amount { set; get; }
        public string Pledge_Name { set; get; }
        public string Pledge_Method { set; get; }
        public string Pledge_Collection_Method { set; get; }

        public Int32 Pledge_Item_ID { set; get; }
        public string Pledge_Start_Date { set; get; }
        public string Pledge_End_Date { set; get; }
        public string Pledge_Targeted_Amount { set; get; }


        public Int32 Expense_ID { set; get; }
        public Int32 ExpenseItem_ID { set; get; }
        public string Expense_Date { set; get; }
        public string Expense_Amount { set; get; }
        public string Expense_Items { set; get; }
        public string Expense_Description { set; get; }

        public Int32 Authorization_ID { set; get; }
        public string Request_For { set; get; }
        public string Requestor { set; get; }
        public string Authorized_By { set; get; }

        public Int32 Benefit_ID { set; get; }
        public int Deduction_ID { set; get; }
        public string Item { set; get; }

        public string Deduction1 { set; get; }
        public string Deduction2 { set; get; }
        public string Deduction3 { set; get; }
        public string Deduction4 { set; get; }
        public string Deduction5 { set; get; }
        public string Deduction6 { set; get; }
        public string Deduction7 { set; get; }
        public string Deduction8 { set; get; }
        public string Deduction9 { set; get; }
        public string Deduction10 { set; get; }

        public string Benefit1 { set; get; }
        public string Benefit2 { set; get; }
        public string Benefit3 { set; get; }
        public string Benefit4 { set; get; }
        public string Benefit5 { set; get; }
        public string Benefit6 { set; get; }
        public string Benefit7 { set; get; }
        public string Benefit8 { set; get; }
        public string Benefit9 { set; get; }
        public string Benefit10 { set; get; }

        public Int32 Level { set; get; }
        public Int32 Level_ID { set; get; }
        public string Package_Gross { set; get; }

        public Int32 Payroll_ID { set; get; }
        public string Payroll_Level { set; get; }
        public string Payroll_Date { set; get; }
        public string Payroll_Amount { set; get; }
        public string Pay_Day { set; get; }
        public string Pay_Active { set; get; }
        public Int32 Payroll_Staff_ID { set; get; }


        public Int32 Bank_ID { set; get; }
        public string Account_Holder { set; get; }
        public string Bank_Name { set; get; }
        public string Account_Number { set; get; }
        public string Account_Type { set; get; }
        public string Branch_Name { set; get; }
        public string Branch_Code { set; get; }
        public string Swift_No { set; get; }
        public string Bank_Country { set; get; }
        public string Account_View { set; get; }

        public Int32 GroupItem_ID { set; get; }
        public string Group_Items { set; get; }
        public string Group_Name { set; get; }

        public Int32 Petty_Cash_ID { set; get; }
        public string Request_Date { set; get; }
        public string Petty_Cash_Amount { set; get; }
        public string Petty_Cash_Description { set; get; }
        public string Grant_Date { set; get; }
        public string IsGranted { set; get; }

        public csFinancials()
        { }
        

        #region Financials

        public DataTable financialCrude(string crude, Int32 financialID, Int32 profileID, Int32 clientID, string financialDate, string financialAmount, Int32 moneyInItemID, string financialFor, string description, string collectionMethod, string confirmed, string confirmDate, string dateFrom, string dateTo)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, financialID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Financial_Date", SqlDbType.VarChar, financialDate));
            objlist.Add(new csParameterListType("@Financial_Amount", SqlDbType.VarChar, financialAmount));
            objlist.Add(new csParameterListType("@MoneyInItem_ID", SqlDbType.BigInt, moneyInItemID));
            objlist.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, financialFor));
            objlist.Add(new csParameterListType("@Financial_Description", SqlDbType.VarChar, description));
            objlist.Add(new csParameterListType("@Payment_Type", SqlDbType.VarChar, collectionMethod));
            objlist.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, confirmed));
            objlist.Add(new csParameterListType("@Confirm_Date", SqlDbType.VarChar, confirmDate));
            objlist.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, dateFrom));
            objlist.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, dateTo));
            dt = objdal.search("procFinancialsCrude", objlist);
            return dt;
        }

        public DataTable financialCrude2(string crude, Int32 financialID, Int32 profileID, Int32 clientID, string financialDate, string financialAmount, Int32 moneyInItemID, string financialFor, string description, string collectionMethod, string confirmed, string confirmDate, string dateFrom, string dateTo, Int32 moneyInSpecialGroupID, string personOrGroup)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, financialID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, profileID));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@Financial_Date", SqlDbType.VarChar, financialDate));
            objlist.Add(new csParameterListType("@Financial_Amount", SqlDbType.VarChar, financialAmount));
            objlist.Add(new csParameterListType("@MoneyInItem_ID", SqlDbType.BigInt, moneyInItemID));
            objlist.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, financialFor));
            objlist.Add(new csParameterListType("@Financial_Description", SqlDbType.VarChar, description));
            objlist.Add(new csParameterListType("@Payment_Type", SqlDbType.VarChar, collectionMethod));
            objlist.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, confirmed));
            objlist.Add(new csParameterListType("@Confirm_Date", SqlDbType.VarChar, confirmDate));
            objlist.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, dateFrom));
            objlist.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, dateTo));
            objlist.Add(new csParameterListType("@MoneyInSpecialGroup_ID", SqlDbType.BigInt, moneyInSpecialGroupID));
            objlist.Add(new csParameterListType("@PersonOrGroup", SqlDbType.VarChar, personOrGroup));
            dt = objdal.search("procFinancialsCrude2", objlist);
            return dt;
        }


        public void add_Financials()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Financial_Date", SqlDbType.VarChar, Financial_Date));
            objlist.Add(new csParameterListType("@Financial_Amount", SqlDbType.VarChar, Financial_Amount.ToString()));
            objlist.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For.ToString()));
            objlist.Add(new csParameterListType("@Financial_Description", SqlDbType.VarChar, Financial_Description.ToString()));
            objlist.Add(new csParameterListType("@Payment_Type", SqlDbType.VarChar, Payment_Type.ToString()));
            objlist.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, Confirmed.ToString()));
            objlist.Add(new csParameterListType("@Confirm_Date", SqlDbType.VarChar, Confirm_Date.ToString()));
            objdal.executespreturnnd("procFinancials_Insert", objlist);
        }

        public void update_Financials()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            objlist.Add(new csParameterListType("@Financial_Date", SqlDbType.VarChar, Financial_Date));
            objlist.Add(new csParameterListType("@Financial_Amount", SqlDbType.VarChar, Financial_Amount.ToString()));
            objlist.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For.ToString()));
            objlist.Add(new csParameterListType("@Financial_Description", SqlDbType.VarChar, Financial_Description.ToString()));
            objlist.Add(new csParameterListType("@Payment_Type", SqlDbType.VarChar, Payment_Type.ToString()));
            objdal.executespreturnnd("procFinancials_Update", objlist);
        }

        public void update_Financials_Void()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            objlist.Add(new csParameterListType("@Void_Date", SqlDbType.VarChar, Void_Date.ToString()));
            objlist.Add(new csParameterListType("@VoidedBy_ID", SqlDbType.BigInt, VoidedBy_ID));
            objdal.executespreturnnd("procFinancials_Update_Void", objlist);
        }

        public void update_Financials_CMS()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            objlist.Add(new csParameterListType("@Financial_Date", SqlDbType.VarChar, Financial_Date));
            objlist.Add(new csParameterListType("@Financial_Amount", SqlDbType.VarChar, Financial_Amount.ToString()));
            objlist.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For.ToString()));
            objlist.Add(new csParameterListType("@Financial_Description", SqlDbType.VarChar, Financial_Description.ToString()));
            objlist.Add(new csParameterListType("@Payment_Type", SqlDbType.VarChar, Payment_Type.ToString()));
            objlist.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, Confirmed.ToString()));
            objdal.executespreturnnd("procFinancials_Update_CMS", objlist);
        }

        public void update_Financials_Partaking()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            objlist.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, Confirmed.ToString()));
            objlist.Add(new csParameterListType("@Confirm_Date", SqlDbType.VarChar, Confirm_Date.ToString()));
            objdal.executespreturnnd("procFinancials_Update_Partaking", objlist);
        }

        public DataTable viewFinancials_By_Profile_ID(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procFinancials_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Profile_ID0(int Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procFinancials_By_Profile_ID0", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Profile_ID(int Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Profile_ID0(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_ID0", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Profile_ID0a(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_ID0a", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Financial_ID(Int32 Financial_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            dt = objdal.search("procFinancials_By_Financial_ID", objpar);
            return dt;
        }


        public DataTable viewFinancials_By_Profile_IDand_For(int Profile_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_IDand_For", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Profile_IDand_For0(int Profile_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_IDand_For0", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Profile_IDand_For0_Confirmed(int Profile_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_IDand_For0_Confirmed", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Profile_IDand_For0_NotConfirmed(int Profile_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_IDand_For0_NotConfirmed", objpar);
            return dt;
        }


        public DataTable viewFinancials_By_Client_ID(int Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_ID0(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_ID0", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_ID1(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_ID1", objpar);
            return dt;
        }

        public void update_FinancialsVoid()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            objdal.executespreturnnd("procFinancials_Void", objlist);
        }




        public DataTable viewFinancials_Statements_By_Profile_ID(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Statements_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_Statements_Totals_By_Profile_ID(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Statements_Totals_By_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_Statements_Totals_By_SpecialGroup_ID(Int32 SpecialGroup_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@SpecialGroup_ID", SqlDbType.BigInt, SpecialGroup_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Statements_Totals_By_SpecialGroup_ID", objpar);
            return dt;
        }



        public DataTable viewFinancials_CollectionHistory_By_Client_ID(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_CollectionHistory_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_CollectionHistory_By_Client_ID_and_FinanceItem(Int32 Client_ID, string Date_From, string Date_To, string FinanceItem)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@FinanceItem", SqlDbType.VarChar, FinanceItem));
            dt = objdal.search("procFinancials_CollectionHistory_By_Client_ID_and_FinanceItem", objpar);
            return dt;
        }

        public DataTable viewFinancials_CollectionHistory_Totals_By_Client_ID(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_CollectionHistory_Totals_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_CollectionHistory_Totals_By_Client_ID_and_FinanceItem_ID(Int32 Client_ID, Int32 FinanceItem_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@FinanceItem_ID", SqlDbType.BigInt, FinanceItem_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_CollectionHistory_Totals_By_Client_ID_and_FinanceItem_ID", objpar);
            return dt;
        }

        //---------------Counting--------------------------------

        public DataTable viewFinancials_Counting_By_Client_ID(Int32 Client_ID, string ServiceDate, string ServiceName)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@ServiceDate", SqlDbType.VarChar, ServiceDate));
            objpar.Add(new csParameterListType("@ServiceName", SqlDbType.VarChar, ServiceName));
            dt = objdal.search("procMoneyIn_Counting_By_ServiceDate_and_ServiceName_Client_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_Counting_GrandTotal_By_Client_ID(Int32 Client_ID, string ServiceDate, string ServiceName)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@ServiceDate", SqlDbType.VarChar, ServiceDate));
            objpar.Add(new csParameterListType("@ServiceName", SqlDbType.VarChar, ServiceName));
            dt = objdal.search("procMoneyIn_Counting_GrandTotal_By_ServiceDate_and_ServiceName_Client_ID", objpar);
            return dt;
        }


        public void add_Financials_Counting()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@ServiceDate", SqlDbType.VarChar, ServiceDate));
            objlist.Add(new csParameterListType("@ServiceName", SqlDbType.VarChar, ServiceName));
            objlist.Add(new csParameterListType("@ItemName", SqlDbType.VarChar, ItemName));
            objlist.Add(new csParameterListType("@ItemTotal", SqlDbType.BigInt, ItemTotal));
            objlist.Add(new csParameterListType("@ItemValue1", SqlDbType.BigInt, ItemValue1));
            objlist.Add(new csParameterListType("@ItemValue2", SqlDbType.BigInt, ItemValue2));
            objlist.Add(new csParameterListType("@ItemValue3", SqlDbType.BigInt, ItemValue3));
            objlist.Add(new csParameterListType("@ItemValue4", SqlDbType.BigInt, ItemValue4));
            objlist.Add(new csParameterListType("@ItemValue5", SqlDbType.BigInt, ItemValue5));
            objlist.Add(new csParameterListType("@ItemValue6", SqlDbType.BigInt, ItemValue6));
            objlist.Add(new csParameterListType("@ItemValue7", SqlDbType.BigInt, ItemValue7));
            objlist.Add(new csParameterListType("@ItemValue8", SqlDbType.BigInt, ItemValue8));
            objdal.executespreturnnd("procMoneyIn_Counting_Insert", objlist);
        }

        public void remove_Financials_Counting()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Counting_ID", SqlDbType.BigInt, Counting_ID));
            objdal.executespreturnnd("procMoneyIn_Counting_Delete", objlist);
        }

        //-----------------------End Counting-----------------------------


        public DataTable viewFinancials_By_Profile_ID1(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Profile_ID1", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_ID_NotClear(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_ID_NotClear", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For(Int32 Client_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_IDand_For", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For0(Int32 Client_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_IDand_For0", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For0_and_ByRefNumber(int Client_ID, string Financial_For, string Date_From, string Date_To, string Ref_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Ref_Number", SqlDbType.VarChar, Ref_Number));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_and_ByRefNumber", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For0_and_ByConfirmed(int Client_ID, string Financial_For, string Date_From, string Date_To, string strConfirmed)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, strConfirmed));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_and_ByConfirmed", objpar);
            return dt;
        }


        public DataTable viewFinancials_By_Client_IDand_For0_Confirmed(int Client_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_Confirmed", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For0_Confirmed_and_ByRefNumber(int Client_ID, string Financial_For, string Date_From, string Date_To, string Ref_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Ref_Number", SqlDbType.VarChar, Ref_Number));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_Confirmed_and_ByRefNumber", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For0_NotConfirmed(int Client_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_NotConfirmed", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For0_NotConfirmed_and_ByRefNumber(int Client_ID, string Financial_For, string Date_From, string Date_To, string Ref_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Ref_Number", SqlDbType.VarChar, Ref_Number));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_NotConfirmed_and_ByRefNumber", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For_Distinct_RefNumber(int Client_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_Distinct_RefNumber", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For_Distinct_RefNumber_and_ByRefNumber(int Client_ID, string Financial_For, string Date_From, string Date_To, string Ref_Number)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Ref_Number", SqlDbType.VarChar, Ref_Number));
            dt = objdal.search("procFinancials_By_Client_IDand_For0_Distinct_RefNumber_and_ByRefNumber", objpar);
            return dt;
        }

        //Unknown
        public void add_Financials_Unknown()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Financial_Date", SqlDbType.VarChar, Financial_Date));
            objlist.Add(new csParameterListType("@Financial_Amount", SqlDbType.VarChar, Financial_Amount.ToString()));
            objlist.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For.ToString()));
            objlist.Add(new csParameterListType("@Financial_Description", SqlDbType.VarChar, Financial_Description.ToString()));
            objdal.executespreturnnd("procFinancials_Insert_Unknown", objlist);
        }

        public void update_Financials_Unknown()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            objlist.Add(new csParameterListType("@Financial_Date", SqlDbType.VarChar, Financial_Date));
            objlist.Add(new csParameterListType("@Financial_Amount", SqlDbType.VarChar, Financial_Amount.ToString()));
            objlist.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For.ToString()));
            objlist.Add(new csParameterListType("@Financial_Description", SqlDbType.VarChar, Financial_Description.ToString()));
            objdal.executespreturnnd("procFinancials_Update_Unknown", objlist);
        }

        public void update_Financials_Unknown_Void()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            objdal.executespreturnnd("procFinancials_Update_Unknown_Void", objlist);
        }

        public DataTable viewFinancials_By_Client_ID_Unknown(int Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_ID_Unknown", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Client_IDand_For_Unknown(int Client_ID, string Financial_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Financial_For", SqlDbType.VarChar, Financial_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_By_Client_IDand_For_Unknown", objpar);
            return dt;
        }

        public DataTable viewFinancials_By_Financial_ID_Unknown(int Financial_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Financial_ID", SqlDbType.BigInt, Financial_ID));
            dt = objdal.search("procFinancials_By_Financial_ID_Unknown", objpar);
            return dt;
        }

        #endregion

        #region MoneyInItems

        public DataTable financeItemsCrude(string crude, Int32 clientID, Int32 moneyInItemID, string itemName, string SMSMessage, string AppMessage)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@MoneyInItem_ID", SqlDbType.BigInt, moneyInItemID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, itemName));
            objlist.Add(new csParameterListType("@Item_SMS", SqlDbType.VarChar, SMSMessage));
            objlist.Add(new csParameterListType("@App_Message", SqlDbType.VarChar, AppMessage));
            dt = objdal.search("procFinanceItemsCrude", objlist);
            return dt;
        }
    
        public void add_MoneyIn_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, MoneyIn_Items.ToString()));
            objlist.Add(new csParameterListType("@Item_SMS", SqlDbType.VarChar, MoneyIn_Items_SMS.ToString()));
            objdal.executespreturnnd("procMoneyIn_Items_Insert", objlist);
        }

        public void add_MoneyIn_Items_Pre()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objdal.executespreturnnd("procMoneyIn_Items_Insert_Pre", objlist);
        }

        public void update_MoneyIn_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@MoneyInItem_ID", SqlDbType.BigInt, MoneyInItem_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, MoneyIn_Items.ToString()));
            objlist.Add(new csParameterListType("@Item_SMS", SqlDbType.VarChar, MoneyIn_Items_SMS.ToString()));
            objdal.executespreturnnd("procMoneyIn_Items_Update", objlist);
        }

        public void update_MoneyIn_Items2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@MoneyInItem_ID", SqlDbType.BigInt, MoneyInItem_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item.ToString()));
            objlist.Add(new csParameterListType("@Item_SMS", SqlDbType.VarChar, Item_SMS.ToString()));
            objlist.Add(new csParameterListType("@App_Message", SqlDbType.VarChar, App_Message.ToString()));
            objdal.executespreturnnd("procMoneyIn_Items_Update2", objlist);
        }

        public void remove_MoneyIn_Item()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@MoneyInItem_ID", SqlDbType.BigInt, MoneyInItem_ID));
            objdal.executespreturnnd("procMoneyIn_Item_Delete", objlist);
        }

        public DataTable viewAllMoneyIn_Items()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procMoneyIn_Items");
            return dt;
        }

        public DataTable viewMoneyIn_Item_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procMoneyIn_Items_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewMoneyIn_Item_By_Item_ID(Int32 MoneyInItem_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@MoneyInItem_ID", SqlDbType.BigInt, MoneyInItem_ID));
            dt = objdal.search("procMoneyIn_Item_By_MoneyInItem_ID", objpar);
            return dt;
        }

        #endregion

        #region MoneyInSpecialGroup

        public DataTable financeSpecialGroupCrude(string crude, Int32 clientID, Int32 moneyInSpecialGroupID, string itemName, string SMSMessage, string AppMessage)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objlist.Add(new csParameterListType("@MoneyInSpecialGroup_ID", SqlDbType.BigInt, moneyInSpecialGroupID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, itemName));
            objlist.Add(new csParameterListType("@Item_SMS", SqlDbType.VarChar, SMSMessage));
            objlist.Add(new csParameterListType("@App_Message", SqlDbType.VarChar, AppMessage));
            dt = objdal.search("procFinanceSpecialGroupCrude", objlist);
            return dt;
        }

        #endregion

        #region Financial Items

        //--------------------Financial Items---------------------------


        public void add_Financial_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Financial_Items", SqlDbType.VarChar, Financial_Items.ToString()));
            objdal.executespreturnnd("procFinancial_Items_Insert", objlist);
        }

        public DataTable viewAllFinancial_Item()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procFinancial_Items");
            return dt;
        }

        public DataTable viewAllHeavenly_Accounts()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procHeavenly_Accounts");
            return dt;
        }

        public DataTable viewAllHeavenly_Accounts1()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procHeavenly_Accounts1");
            return dt;
        }

        public DataTable viewAllHeavenly_Accounts2()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procHeavenly_Accounts2");
            return dt;
        }

        public DataTable viewAllHeavenly_Accounts_Items()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procHeavenly_Accounts_Items");
            return dt;
        }

        public DataTable viewAllHeavenly_Accounts_Items_Unknown()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procHeavenly_Accounts_Items_Unknown");
            return dt;
        }

        #endregion

        #region Plegdes

        public void add_Financials_Pledges()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Pledge_Date", SqlDbType.VarChar, Pledge_Date));
            objlist.Add(new csParameterListType("@Pledge_Amount", SqlDbType.VarChar, Pledge_Amount.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Method", SqlDbType.VarChar, Pledge_Method.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Collection_Method", SqlDbType.VarChar, Pledge_Collection_Method.ToString()));
            objlist.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, Confirmed.ToString()));
            objlist.Add(new csParameterListType("@Confirm_Date", SqlDbType.VarChar, Confirm_Date.ToString()));
            objlist.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objlist.Add(new csParameterListType("@Group_Name", SqlDbType.VarChar, Group_Name.ToString()));
            objdal.executespreturnnd("procFinancials_Pledges_Insert", objlist);
        }

        public DataTable viewFinancials_Pledges_By_Client_IDand_For(Int32 Client_ID, string Pledge_Name, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Pledges_By_Client_IDand_For", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Profile_IDand_For(Int32 Profile_ID, string Pledge_Name, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Pledges_By_Profile_IDand_For", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_IDand_For_and_Cateory(Int32 Client_ID, string Pledge_Name, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procFinancials_Pledges_By_Client_IDand_For_and_Cateory", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Profile_IDand_For_and_Cateory(Int32 Profile_ID, string Pledge_Name, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            dt = objdal.search("procFinancials_Pledges_By_Profile_IDand_For_and_Cateory", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_IDand_For_and_Cateory_and_Group(Int32 Client_ID, string Pledge_Name, string Date_From, string Date_To, string Category, string Group_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objpar.Add(new csParameterListType("@Group_Name", SqlDbType.VarChar, Group_Name.ToString()));
            dt = objdal.search("procFinancials_Pledges_By_Client_IDand_For_and_Cateory_and_Group", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Profile_IDand_For_and_Cateory_and_Group(Int32 Profile_ID, string Pledge_Name, string Date_From, string Date_To, string Category, string Group_Name)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category.ToString()));
            objpar.Add(new csParameterListType("@Group_Name", SqlDbType.VarChar, Group_Name.ToString()));
            dt = objdal.search("procFinancials_Pledges_By_Profile_IDand_For_and_Cateory_and_Group", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID_and_Pledge_Name(Int32 Client_ID, string Pledge_Name, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name.ToString()));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID_and_Pledge_Name", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID_and_Group(Int32 Client_ID, string Group_Name, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Group_Name", SqlDbType.VarChar, Group_Name.ToString()));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID_and_Group", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID0(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID0", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID2(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID2", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Profile_ID2(Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Pledges_By_Profile_ID2", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID1(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID1", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID_and_Category(Int32 Client_ID, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID_By_Category", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Profile_ID_and_Category(Int32 Profile_ID, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procFinancials_Pledges_By_Profile_ID_By_Category", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Profile_ID_and_Category2(Int32 Profile_ID, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procFinancials_Pledges_By_Profile_ID_By_Category2", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID_and_Category2(Int32 Client_ID, string Date_From, string Date_To, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID_By_Category2", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_By_Client_ID_NotClear(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Pledges_By_Client_ID_NotClear", objpar);
            return dt;
        }

        public void update_Financials_Pledges_Void()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Pledge_ID", SqlDbType.BigInt, Pledge_ID));
            objlist.Add(new csParameterListType("@Void_Date", SqlDbType.VarChar, Void_Date.ToString()));
            objlist.Add(new csParameterListType("@VoidedBy_ID", SqlDbType.BigInt, VoidedBy_ID));
            objdal.executespreturnnd("procFinancials_Pledges_Update_Void", objlist);
        }

        public void update_Financials_Pledges_Partaking()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Pledge_ID", SqlDbType.BigInt, Pledge_ID));
            objlist.Add(new csParameterListType("@Confirmed", SqlDbType.VarChar, Confirmed.ToString()));
            objlist.Add(new csParameterListType("@Confirm_Date", SqlDbType.VarChar, Confirm_Date.ToString()));
            objdal.executespreturnnd("procFinancials_Pledges_Update_Partaking", objlist);
        }



        #endregion

        #region Plegdes Items

        public void add_Financials_Pledges_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Pledge_Start_Date", SqlDbType.VarChar, Pledge_Start_Date));
            objlist.Add(new csParameterListType("@Pledge_End_Date", SqlDbType.VarChar, Pledge_End_Date.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Targeted_Amount", SqlDbType.VarChar, Pledge_Targeted_Amount.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Date", SqlDbType.VarChar, Pledge_Date.ToString()));
            objdal.executespreturnnd("procFinancials_Pledges_Items_Insert", objlist);
        }

        public void Update_Financials_Pledges_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Pledge_Item_ID", SqlDbType.BigInt, Pledge_Item_ID));
            objlist.Add(new csParameterListType("@Pledge_Start_Date", SqlDbType.VarChar, Pledge_Start_Date));
            objlist.Add(new csParameterListType("@Pledge_End_Date", SqlDbType.VarChar, Pledge_End_Date.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Name", SqlDbType.VarChar, Pledge_Name.ToString()));
            objlist.Add(new csParameterListType("@Pledge_Targeted_Amount", SqlDbType.VarChar, Pledge_Targeted_Amount.ToString()));
            objdal.executespreturnnd("procFinancials_Pledges_Items_Update", objlist);
        }
        
        public DataTable viewFinancials_Pledges_Items_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procFinancial_Pledges_Items", objpar);
            return dt;
        }

        public DataTable viewFinancials_Pledges_Item_Name_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procFinancial_Pledges_Item_Name_By_Client_ID", objpar);
            return dt;
        }

        #endregion

        #region Group Items

        public void add_Group_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Group_Items.ToString()));
            objdal.executespreturnnd("procFinancials_Pledges_Groups_Insert", objlist);
        }

        public void update_Group_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@GroupItem_ID", SqlDbType.BigInt, GroupItem_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Group_Items.ToString()));
            objdal.executespreturnnd("procFinancials_Pledges_Groups_Update", objlist);
        }

        public DataTable viewGroup_Item_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procFinancials_Pledges_Groups_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewGroup_Item_By_GroupItem_ID(Int32 GroupItem_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@GroupItem_ID", SqlDbType.BigInt, GroupItem_ID));
            dt = objdal.search("procFinancials_Pledges_Groups_By_GroupItem_ID", objpar);
            return dt;
        }

        public DataTable viewGroup_Item_Distinct_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procFinancials_Pledges_Groups_Distinct_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewGroup_Item_Distinct_By_Client_ID2(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procFinancials_Pledges_Groups_Distinct_By_Client_ID2", objpar);
            return dt;
        }

        #endregion

        #region Expenses

        //--------------------Expenses-------------------------

        public void add_Expenses()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Expense_Date", SqlDbType.VarChar, Expense_Date));
            objlist.Add(new csParameterListType("@Expense_Amount", SqlDbType.VarChar, Expense_Amount.ToString()));
            objlist.Add(new csParameterListType("@Expense_Item", SqlDbType.VarChar, Expense_Items.ToString()));
            objlist.Add(new csParameterListType("@Expense_Description", SqlDbType.VarChar, Expense_Description.ToString()));
            objdal.executespreturnnd("procExpenses_Insert", objlist);
        }

        public void add_Expenses2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Expense_Date", SqlDbType.VarChar, Expense_Date));
            objlist.Add(new csParameterListType("@Expense_Amount", SqlDbType.VarChar, Expense_Amount.ToString()));
            objlist.Add(new csParameterListType("@ExpenseItem_ID", SqlDbType.BigInt, ExpenseItem_ID));
            objlist.Add(new csParameterListType("@Expense_Description", SqlDbType.VarChar, Expense_Description.ToString()));
            objdal.executespreturnnd("procExpenses_Insert2", objlist);
        }

        public void update_Expenses()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Expense_ID", SqlDbType.BigInt, Expense_ID));
            objlist.Add(new csParameterListType("@Expense_Date", SqlDbType.VarChar, Expense_Date));
            objlist.Add(new csParameterListType("@Expense_Amount", SqlDbType.VarChar, Expense_Amount.ToString()));
            objlist.Add(new csParameterListType("@Expense_Item", SqlDbType.VarChar, Expense_Items.ToString()));
            objlist.Add(new csParameterListType("@Expense_Description", SqlDbType.VarChar, Expense_Description.ToString()));
            objdal.executespreturnnd("procExpenses_Update", objlist);
        }

        public void update_Expenses2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Expense_ID", SqlDbType.BigInt, Expense_ID));
            objlist.Add(new csParameterListType("@Expense_Date", SqlDbType.VarChar, Expense_Date));
            objlist.Add(new csParameterListType("@Expense_Amount", SqlDbType.VarChar, Expense_Amount.ToString()));
            objlist.Add(new csParameterListType("@Expense_Description", SqlDbType.VarChar, Expense_Description.ToString()));
            objdal.executespreturnnd("procExpenses_Update2", objlist);
        }

        public void remove_Expenses2()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Expense_ID", SqlDbType.BigInt, Expense_ID));
            objdal.executespreturnnd("procExpenses_Delete2", objlist);
        }

        public DataTable viewExpenses_By_Client_ID(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procExpenses_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewExpensesCrude(string crude, int clientID, int expenseID, int expenseItemID, string expenseDate, string expenseAmount, string expenseDescription, int serviceProviderID, string paymentDate, string paymentMethod, int costAreaItemID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objpar.Add(new csParameterListType("@Expense_ID", SqlDbType.BigInt, expenseID));
            objpar.Add(new csParameterListType("@ExpenseItem_ID", SqlDbType.BigInt, expenseItemID));
            objpar.Add(new csParameterListType("@Expense_Date", SqlDbType.VarChar, expenseDate));
            objpar.Add(new csParameterListType("@Expense_Amount", SqlDbType.VarChar, expenseAmount));
            objpar.Add(new csParameterListType("@Expense_Description", SqlDbType.VarChar, expenseDescription));
            objpar.Add(new csParameterListType("@ServiceProvider_ID", SqlDbType.BigInt, serviceProviderID));
            objpar.Add(new csParameterListType("@Payment_Date", SqlDbType.VarChar, paymentDate));
            objpar.Add(new csParameterListType("@Payment_Method", SqlDbType.VarChar, paymentMethod));
            objpar.Add(new csParameterListType("@CostAreaItem_ID", SqlDbType.BigInt, costAreaItemID));
            dt = objdal.search("procExpense_Crude", objpar);
            return dt;
        }

        public DataTable viewExpenses_By_Client_ID2(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procExpenses_By_Client_ID2", objpar);
            return dt;
        }

        public DataTable viewFinancials_ExpenseHistory_Totals_By_Client_ID(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_ExpenseHistory_Totals_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewExpenses_By_Client_IDand_For(int Client_ID, string Expense_Items, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Expense_Item", SqlDbType.VarChar, Expense_Items));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procExpenses_By_Client_IDand_For", objpar);
            return dt;
        }

        public DataTable viewExpenses_By_Expense_ID(int Expense_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Expense_ID", SqlDbType.BigInt, Expense_ID));
            dt = objdal.search("procExpenses_By_Expense_ID", objpar);
            return dt;
        }


        public DataTable viewAllExpenses_Empty()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procExpenses_Empty");
            return dt;
        }

        #endregion

        #region Expenses Items
        //--------------------Expenses Items---------------------------

        public DataTable viewExpenseItemCrude(string crude, int clientID, int expenseItemID, string item)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@crude", SqlDbType.VarChar, crude));
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, clientID));
            objpar.Add(new csParameterListType("@ExpenseItem_ID", SqlDbType.BigInt, expenseItemID));
            objpar.Add(new csParameterListType("@Item", SqlDbType.VarChar, item));
            dt = objdal.search("procExpense_Items_Crude", objpar);
            return dt;
        }
        public void add_Expense_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Expense_Items.ToString()));
            objdal.executespreturnnd("procExpense_Items_Insert", objlist);
        }

        public void update_Expense_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@ExpenseItem_ID", SqlDbType.BigInt, ExpenseItem_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Expense_Items.ToString()));
            objdal.executespreturnnd("procExpense_Items_Update", objlist);
        }

        public void remove_Expense_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@ExpenseItem_ID", SqlDbType.BigInt, ExpenseItem_ID));
            objdal.executespreturnnd("procExpense_Items_Delete", objlist);
        }

        public DataTable viewAllExpense_Items()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procExpense_Items");
            return dt;
        }

        public DataTable viewExpenses_Item_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procExpense_Items_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewExpenses_Item_By_Item_ID(Int32 Item_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Item_ID", SqlDbType.BigInt, Item_ID));
            dt = objdal.search("procExpenses_Item_By_Item_ID", objpar);
            return dt;
        }



        #endregion

        #region Expenses Authorization
        //--------------------Expenses Authorization-------------------------

        public void add_Expenses_Authorization()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Expense_Date", SqlDbType.VarChar, Expense_Date));
            objlist.Add(new csParameterListType("@Request_For", SqlDbType.VarChar, Request_For.ToString()));
            objlist.Add(new csParameterListType("@Expense_Amount", SqlDbType.VarChar, Expense_Amount.ToString()));
            objlist.Add(new csParameterListType("@Expense_Item", SqlDbType.VarChar, Expense_Items.ToString()));
            objlist.Add(new csParameterListType("@Expense_Description", SqlDbType.VarChar, Expense_Description.ToString()));
            objlist.Add(new csParameterListType("@Requestor", SqlDbType.VarChar, Requestor.ToString()));
            objlist.Add(new csParameterListType("@Authorized_By", SqlDbType.VarChar, Authorized_By.ToString()));
            objdal.executespreturnnd("procExpenses_Authorization_Insert", objlist);
        }

        public void update_Expenses_Authorization()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Authorization_ID", SqlDbType.BigInt, Authorization_ID));
            objlist.Add(new csParameterListType("@Expense_Date", SqlDbType.VarChar, Expense_Date));
            objlist.Add(new csParameterListType("@Request_For", SqlDbType.VarChar, Request_For.ToString()));
            objlist.Add(new csParameterListType("@Expense_Amount", SqlDbType.VarChar, Expense_Amount.ToString()));
            objlist.Add(new csParameterListType("@Expense_Item", SqlDbType.VarChar, Expense_Items.ToString()));
            objlist.Add(new csParameterListType("@Expense_Description", SqlDbType.VarChar, Expense_Description.ToString()));
            objlist.Add(new csParameterListType("@Requestor", SqlDbType.VarChar, Requestor.ToString()));
            objlist.Add(new csParameterListType("@Authorized_By", SqlDbType.VarChar, Authorized_By.ToString()));
            objdal.executespreturnnd("procExpenses_Authorization_Update", objlist);
        }

        public DataTable viewExpenses_Authorization_By_Client_ID(int Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procExpenses_Authorization_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewExpenses_Authorization_By_Client_IDand_For(int Client_ID, string Request_For, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Request_For", SqlDbType.VarChar, Request_For));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procExpenses_Authorization_By_Client_IDand_For", objpar);
            return dt;
        }

        public DataTable viewExpenses_Authorization_By_Authorization_ID(int Authorization_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Authorization_ID", SqlDbType.BigInt, Authorization_ID));
            dt = objdal.search("procExpenses_Authorization_By_Authorization_ID", objpar);
            return dt;
        }

        public DataTable viewAllExpenses_Authorization_Empty()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procExpenses_Empty");
            return dt;
        }


        //--------------------Expenses Authorization Items---------------------------
        public void add_Expense_Authorization_Items()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Expense_Items.ToString()));
            objdal.executespreturnnd("procExpense_Authorization_Items_Insert", objlist);
        }

        public DataTable viewAllExpense_Authorization_Items()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procExpense_Authorization_Items");
            return dt;
        }

        #endregion

        #region Payroll Deductions


        //--------------------Payroll Deductions---------------------------

        public DataTable viewPayroll_Deductions_By_Client_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPayroll_Deductions_By_Client_ID", objpar);
            return dt;
        }

        public void update_Payroll_Deductions()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Deduction_ID", SqlDbType.BigInt, Deduction_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item.ToString()));
            objdal.executespreturnnd("procPayroll_Deductions_Update", objlist);
        }

        #endregion

        #region Payroll Benefits
        //--------------------Payroll Benefits---------------------------

        public DataTable viewPayroll_Benefits_By_Client_ID(int Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPayroll_Benefits_By_Client_ID", objpar);
            return dt;
        }

        public void update_Payroll_Benefits()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Benefit_ID", SqlDbType.BigInt, Benefit_ID));
            objlist.Add(new csParameterListType("@Item", SqlDbType.VarChar, Item.ToString()));
            objdal.executespreturnnd("procPayroll_Benefits_Update", objlist);
        }

        #endregion

        #region Payroll Levels
        //--------------------Payroll Levels---------------------------

        public DataTable viewPayroll_Levels_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPayroll_Levels_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewPayroll_Levels_Empty()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPayroll_Levels_Empty");
            return dt;
        }

        public DataTable viewPayroll_Levels_By_Client_ID_and_Level(Int32 Client_ID, string Level)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Level", SqlDbType.VarChar, Level));
            dt = objdal.search("procPayroll_Levels_By_Client_ID_and_Level", objpar);
            return dt;
        }

        public DataTable viewPayroll_Levels_By_Level_ID(Int32 Level_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Level_ID", SqlDbType.BigInt, Level_ID));
            dt = objdal.search("procPayroll_Levels_By_Level_ID", objpar);
            return dt;
        }

        public void update_Payroll_Levels()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Level_ID ", SqlDbType.BigInt, Level_ID));
            objlist.Add(new csParameterListType("@Level", SqlDbType.BigInt, Level));
            objlist.Add(new csParameterListType("@Package_Gross", SqlDbType.VarChar, Package_Gross.ToString()));
            objlist.Add(new csParameterListType("@Deduction1", SqlDbType.VarChar, Deduction1.ToString()));
            objlist.Add(new csParameterListType("@Deduction2", SqlDbType.VarChar, Deduction2.ToString()));
            objlist.Add(new csParameterListType("@Deduction3", SqlDbType.VarChar, Deduction3.ToString()));
            objlist.Add(new csParameterListType("@Deduction4", SqlDbType.VarChar, Deduction4.ToString()));
            objlist.Add(new csParameterListType("@Deduction5", SqlDbType.VarChar, Deduction5.ToString()));
            objlist.Add(new csParameterListType("@Deduction6", SqlDbType.VarChar, Deduction6.ToString()));
            objlist.Add(new csParameterListType("@Deduction7", SqlDbType.VarChar, Deduction7.ToString()));
            objlist.Add(new csParameterListType("@Deduction8", SqlDbType.VarChar, Deduction8.ToString()));
            objlist.Add(new csParameterListType("@Deduction9", SqlDbType.VarChar, Deduction9.ToString()));
            objlist.Add(new csParameterListType("@Deduction10", SqlDbType.VarChar, Deduction10.ToString()));
            objlist.Add(new csParameterListType("@Benefit1", SqlDbType.VarChar, Benefit1.ToString()));
            objlist.Add(new csParameterListType("@Benefit2", SqlDbType.VarChar, Benefit2.ToString()));
            objlist.Add(new csParameterListType("@Benefit3", SqlDbType.VarChar, Benefit3.ToString()));
            objlist.Add(new csParameterListType("@Benefit4", SqlDbType.VarChar, Benefit4.ToString()));
            objlist.Add(new csParameterListType("@Benefit5", SqlDbType.VarChar, Benefit5.ToString()));
            objlist.Add(new csParameterListType("@Benefit6", SqlDbType.VarChar, Benefit6.ToString()));
            objlist.Add(new csParameterListType("@Benefit7", SqlDbType.VarChar, Benefit7.ToString()));
            objlist.Add(new csParameterListType("@Benefit8", SqlDbType.VarChar, Benefit8.ToString()));
            objlist.Add(new csParameterListType("@Benefit9", SqlDbType.VarChar, Benefit9.ToString()));
            objlist.Add(new csParameterListType("@Benefit10", SqlDbType.VarChar, Benefit10.ToString()));
            objdal.executespreturnnd("procPayroll_Levels_Update", objlist);
        }

        public void Remove_Payroll_Levels()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Level_ID ", SqlDbType.BigInt, Level_ID));
            objdal.executespreturnnd("procPayroll_Levels_Remove", objlist);
        }

        public void add_Payroll_Levels()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Level", SqlDbType.BigInt, Level));
            objlist.Add(new csParameterListType("@Package_Gross", SqlDbType.VarChar, Package_Gross.ToString()));
            objlist.Add(new csParameterListType("@Deduction1", SqlDbType.VarChar, Deduction1.ToString()));
            objlist.Add(new csParameterListType("@Deduction2", SqlDbType.VarChar, Deduction2.ToString()));
            objlist.Add(new csParameterListType("@Deduction3", SqlDbType.VarChar, Deduction3.ToString()));
            objlist.Add(new csParameterListType("@Deduction4", SqlDbType.VarChar, Deduction4.ToString()));
            objlist.Add(new csParameterListType("@Deduction5", SqlDbType.VarChar, Deduction5.ToString()));
            objlist.Add(new csParameterListType("@Deduction6", SqlDbType.VarChar, Deduction6.ToString()));
            objlist.Add(new csParameterListType("@Deduction7", SqlDbType.VarChar, Deduction7.ToString()));
            objlist.Add(new csParameterListType("@Deduction8", SqlDbType.VarChar, Deduction8.ToString()));
            objlist.Add(new csParameterListType("@Deduction9", SqlDbType.VarChar, Deduction9.ToString()));
            objlist.Add(new csParameterListType("@Deduction10", SqlDbType.VarChar, Deduction10.ToString()));
            objlist.Add(new csParameterListType("@Benefit1", SqlDbType.VarChar, Benefit1.ToString()));
            objlist.Add(new csParameterListType("@Benefit2", SqlDbType.VarChar, Benefit2.ToString()));
            objlist.Add(new csParameterListType("@Benefit3", SqlDbType.VarChar, Benefit3.ToString()));
            objlist.Add(new csParameterListType("@Benefit4", SqlDbType.VarChar, Benefit4.ToString()));
            objlist.Add(new csParameterListType("@Benefit5", SqlDbType.VarChar, Benefit5.ToString()));
            objlist.Add(new csParameterListType("@Benefit6", SqlDbType.VarChar, Benefit6.ToString()));
            objlist.Add(new csParameterListType("@Benefit7", SqlDbType.VarChar, Benefit7.ToString()));
            objlist.Add(new csParameterListType("@Benefit8", SqlDbType.VarChar, Benefit8.ToString()));
            objlist.Add(new csParameterListType("@Benefit9", SqlDbType.VarChar, Benefit9.ToString()));
            objlist.Add(new csParameterListType("@Benefit10", SqlDbType.VarChar, Benefit10.ToString()));
            objdal.executespreturnnd("procPayroll_Levels_Insert", objlist);
        }
        #endregion

        #region Payroll
        //--------------------Payroll---------------------------

        public void add_Payroll_Staff()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Payroll_Date", SqlDbType.VarChar, Payroll_Date));
            objlist.Add(new csParameterListType("@Payroll_Level", SqlDbType.VarChar, Payroll_Level));
            objlist.Add(new csParameterListType("@Pay_Day", SqlDbType.VarChar, Pay_Day.ToString()));
            objlist.Add(new csParameterListType("@Pay_Active", SqlDbType.VarChar, Pay_Active.ToString()));
            objdal.executespreturnnd("procPayroll_Staff_Insert", objlist);
        }

        public void update_Payroll_Staff()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Payroll_Staff_ID", SqlDbType.BigInt, Payroll_Staff_ID));
            objlist.Add(new csParameterListType("@Payroll_Level", SqlDbType.VarChar, Payroll_Level));
            objlist.Add(new csParameterListType("@Pay_Day", SqlDbType.VarChar, Pay_Day.ToString()));
            objlist.Add(new csParameterListType("@Pay_Active", SqlDbType.VarChar, Pay_Active.ToString()));
            objdal.executespreturnnd("procPayroll_Staff_Update", objlist);
        }

        public void Remove_Payroll_Staff()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Payroll_Staff_ID", SqlDbType.BigInt, Payroll_Staff_ID));
            objdal.executespreturnnd("procPayroll_Staff_Remove", objlist);
        }

        public DataTable viewPayroll_Staff_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPayroll_Staff_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewPayroll_Staff_By_Client_ID2(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procPayroll_Staff_By_Client_ID2", objpar);
            return dt;
        }

        public DataTable viewPayroll_Staff_By_Profile_ID(Int32 Profile_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            dt = objdal.search("procPayroll_Staff_By_Profile_ID", objpar);
            return dt;
        }

        //public DataTable viewPayroll_By_Client_ID(Int32 Client_ID)
        //{
        //    csDAL objdal = new csDAL();
        //    DataTable dt = new DataTable();
        //    List<csParameterListType> objpar = new List<csParameterListType>();
        //    objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
        //    dt = objdal.search("procPayroll_By_Client_ID", objpar);
        //    return dt;
        //}

        public DataTable viewPayroll_By_Client_ID_and_Profile_ID(Int32 Client_ID, Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPayroll_By_Client_ID_and_Profile_ID", objpar);
            return dt;
        }

        public DataTable viewPayroll_By_Client_ID_and_Profile_ID0(Int32 Client_ID, Int32 Profile_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPayroll_By_Client_ID_and_Profile_ID0", objpar);
            return dt;
        }

        public DataTable viewPayroll_By_Client_ID(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPayroll_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewPayroll_By_Client_ID2(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procPayroll_By_Client_ID2", objpar);
            return dt;
        }

        public DataTable viewPayroll_By_Payroll_ID(Int32 Payroll_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Payroll_ID", SqlDbType.BigInt, Payroll_ID));
            dt = objdal.search("procPayroll_By_Payroll_ID", objpar);
            return dt;
        }

        public DataTable viewPayroll_Empty()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procPayroll_Empty");
            return dt;
        }

        public void add_Payroll()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Profile_ID", SqlDbType.BigInt, Profile_ID));
            objlist.Add(new csParameterListType("@Payroll_Level", SqlDbType.BigInt, Payroll_Level));
            objlist.Add(new csParameterListType("@Payroll_Date", SqlDbType.VarChar, Payroll_Date));
            objlist.Add(new csParameterListType("@Payroll_Gross", SqlDbType.VarChar, Payroll_Amount.ToString()));
            objdal.executespreturnnd("procPayroll_Insert", objlist);
        }

        public void Update_Payroll()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Payroll_ID", SqlDbType.BigInt, Payroll_ID));
            objlist.Add(new csParameterListType("@Payroll_Date", SqlDbType.VarChar, Payroll_Date));
            objlist.Add(new csParameterListType("@Payroll_Gross", SqlDbType.VarChar, Payroll_Amount.ToString()));
            objdal.executespreturnnd("procPayroll_Update", objlist);
        }

        public void Remove_Payroll()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Payroll_ID", SqlDbType.BigInt, Payroll_ID));
            objdal.executespreturnnd("procPayroll_Remove", objlist);
        }

        //-------Money Out------------------------------------
        public DataTable viewMoney_Out()
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            dt = objdal.search("procMoney_Out");
            return dt;
        }
        #endregion

        #region Banking

        //--------------------Banking---------------------------
        public void add_Banking()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Account_Holder", SqlDbType.VarChar, Account_Holder.ToString()));
            objlist.Add(new csParameterListType("@Bank_Name", SqlDbType.VarChar, Bank_Name.ToString()));
            objlist.Add(new csParameterListType("@Account_Number", SqlDbType.VarChar, Account_Number.ToString()));
            objlist.Add(new csParameterListType("@Account_Type", SqlDbType.VarChar, Account_Type.ToString()));
            objlist.Add(new csParameterListType("@Branch_Name", SqlDbType.VarChar, Branch_Name.ToString()));
            objlist.Add(new csParameterListType("@Branch_Code", SqlDbType.VarChar, Branch_Code.ToString()));
            objlist.Add(new csParameterListType("@Swift_No", SqlDbType.VarChar, Swift_No.ToString()));
            objlist.Add(new csParameterListType("@Bank_Country", SqlDbType.VarChar, Bank_Country.ToString()));
            objlist.Add(new csParameterListType("@Account_View", SqlDbType.VarChar, Account_View.ToString()));
            objdal.executespreturnnd("procBanking_Insert", objlist);
        }



        public void update_Banking()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Bank_ID", SqlDbType.BigInt, Bank_ID));
            objlist.Add(new csParameterListType("@Account_Holder", SqlDbType.VarChar, Account_Holder.ToString()));
            objlist.Add(new csParameterListType("@Bank_Name", SqlDbType.VarChar, Bank_Name.ToString()));
            objlist.Add(new csParameterListType("@Account_Number", SqlDbType.VarChar, Account_Number.ToString()));
            objlist.Add(new csParameterListType("@Account_Type", SqlDbType.VarChar, Account_Type.ToString()));
            objlist.Add(new csParameterListType("@Branch_Name", SqlDbType.VarChar, Branch_Name.ToString()));
            objlist.Add(new csParameterListType("@Branch_Code", SqlDbType.VarChar, Branch_Code.ToString()));
            objlist.Add(new csParameterListType("@Swift_No", SqlDbType.VarChar, Swift_No.ToString()));
            objlist.Add(new csParameterListType("@Bank_Country", SqlDbType.VarChar, Bank_Country.ToString()));
            objlist.Add(new csParameterListType("@Account_View", SqlDbType.VarChar, Account_View.ToString()));
            objdal.executespreturnnd("procBanking_Update", objlist);
        }


        public DataTable viewBanking_By_Client_ID(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procBanking_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewBanking_By_Client_ID0(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procBanking_By_Client_ID0", objpar);
            return dt;
        }

        public DataTable viewBanking_By_Bank_ID(Int32 Bank_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Bank_ID", SqlDbType.BigInt, Bank_ID));
            dt = objdal.search("procBanking_By_Bank_ID", objpar);
            return dt;
        }

        public DataTable viewBanking_By_Client_IDandAccount_View(int Client_ID, string Account_View)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Account_View", SqlDbType.VarChar, Account_View.ToString()));
            dt = objdal.search("procBanking_By_Client_IDandAccount_View", objpar);
            return dt;
        }
        #endregion

        #region Petty_Cash

        public void add_Financials_Petty_Cash()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objlist.Add(new csParameterListType("@Request_Date", SqlDbType.VarChar, Request_Date));
            objlist.Add(new csParameterListType("@Petty_Cash_Amount", SqlDbType.VarChar, Petty_Cash_Amount.ToString()));
            objlist.Add(new csParameterListType("@Petty_Cash_Description", SqlDbType.VarChar, Petty_Cash_Description.ToString()));
            objdal.executespreturnnd("procFinancials_Petty_Cash_Insert", objlist);
        }

        public void Update_Financials_Petty_Cash()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Petty_Cash_ID", SqlDbType.BigInt, Petty_Cash_ID));
            objlist.Add(new csParameterListType("@Request_Date", SqlDbType.VarChar, Request_Date));
            objlist.Add(new csParameterListType("@Petty_Cash_Amount", SqlDbType.VarChar, Petty_Cash_Amount.ToString()));
            objlist.Add(new csParameterListType("@Petty_Cash_Description", SqlDbType.VarChar, Petty_Cash_Description.ToString()));
            objdal.executespreturnnd("procFinancials_Petty_Cash_Update", objlist);
        }

        public void Update_Financials_Petty_Cash_Grant()
        {
            csDAL objdal = new csDAL();
            List<csParameterListType> objlist = new List<csParameterListType>();
            objlist.Add(new csParameterListType("@Petty_Cash_ID", SqlDbType.BigInt, Petty_Cash_ID));
            objlist.Add(new csParameterListType("@Grant_Date", SqlDbType.VarChar, Grant_Date));
            objdal.executespreturnnd("procFinancials_Petty_Cash_Grant_Update", objlist);
        }

        public DataTable viewFinancials_Petty_Cash_By_Client_ID(Int32 Client_ID, string Date_From, string Date_To)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Date_From", SqlDbType.VarChar, Date_From));
            objpar.Add(new csParameterListType("@Date_To", SqlDbType.VarChar, Date_To));
            dt = objdal.search("procFinancials_Petty_Cash_By_Client_ID", objpar);
            return dt;
        }

        public DataTable viewFinancials_Petty_Cash_By_Client_ID2(Int32 Client_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            dt = objdal.search("procFinancials_Petty_Cash_By_Client_ID2", objpar);
            return dt;
        }

        public DataTable viewFinancials_Petty_Cash_By_Client_ID_and_Category(Int32 Client_ID, string Category)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@Category", SqlDbType.VarChar, Category));
            dt = objdal.search("procFinancials_Petty_Cash_By_Client_ID_and_Category", objpar);
            return dt;
        }

        public DataTable viewFinancials_Petty_Cash_By_Client_ID_and_IsGranted(Int32 Client_ID, string IsGranted)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Client_ID", SqlDbType.BigInt, Client_ID));
            objpar.Add(new csParameterListType("@IsGranted", SqlDbType.VarChar, IsGranted));
            dt = objdal.search("procFinancials_Petty_Cash_By_Client_ID_and_IsGranted", objpar);
            return dt;
        }

        public DataTable viewFinancials_Petty_Cash_By_Petty_Cash_ID(Int32 Petty_Cash_ID)
        {
            csDAL objdal = new csDAL();
            DataTable dt = new DataTable();
            List<csParameterListType> objpar = new List<csParameterListType>();
            objpar.Add(new csParameterListType("@Petty_Cash_ID", SqlDbType.BigInt, Petty_Cash_ID));
            dt = objdal.search("procFinancials_Petty_Cash_By_Petty_Cash_ID", objpar);
            return dt;
        }

        #endregion



    }
}
