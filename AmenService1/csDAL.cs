using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace AmenService1
{
    public class csDAL
    {
        protected string _strconn;
        private SqlConnection conn;
        private string errorstr = string.Empty;
        public csDAL()
        {
            try
            {
                //.Properties.Settings.cms2011ConnectionString
                _strconn = ConfigurationManager.ConnectionStrings["DBConStr"].ToString();
                conn = new SqlConnection();
            }
            catch
            {
            }
        }
        public string ConnectionString
        {
            get { return _strconn; }
            set { _strconn = value; }
        }
        private bool Open_Connection()
        {
            if (conn == null)
                conn = new SqlConnection();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    conn.ConnectionString = _strconn;
                    conn.Open();
                    return true;
                }
                catch (Exception a)
                {
                    errorstr += " " + a.Message;
                    return false;
                }
            }
            else
                return true;
        }
        private SqlParameter add_parameters(csParameterListType objpar)
        {
            SqlParameter sqlpar = new SqlParameter();

            sqlpar.ParameterName = objpar.Name;
            sqlpar.SqlDbType = objpar.sqlType;
            sqlpar.SqlValue = objpar.Value;
            return sqlpar;
        }

        public System.Data.DataTable search(string spname, List<csParameterListType> objlist)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable t = new DataTable();

            if (Open_Connection())
            {
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = spname;

                    foreach (csParameterListType par in objlist)
                    {
                        cmd.Parameters.Add(add_parameters(par));
                    }

                    sda.SelectCommand = cmd;

                    sda.Fill(t);
                }
                catch
                {
                    //System.Windows.Forms.MessageBox.Show(em.Message);
                }
            }
            else
            {
                if (Open_Connection())
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = spname;

                        foreach (csParameterListType par in objlist)
                        {
                            cmd.Parameters.Add(add_parameters(par));
                        }

                        sda.SelectCommand = cmd;
                        sda.Fill(t);
                    }
                    catch
                    { }
                }
            }
            close_conn();
            return t;
        }

        public System.Data.DataTable search(string spname)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable t = new DataTable();

            if (Open_Connection())
            {
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = spname;
                    sda.SelectCommand = cmd;
                    sda.Fill(t);
                }
                catch
                {
                }
            }
            else
            {
                if (Open_Connection())
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = spname;
                        sda.SelectCommand = cmd;
                        sda.Fill(t);
                    }
                    catch
                    {
                    }
                }
            }
            close_conn();
            return t;
        }
        public IDataReader executespreturndr(string spname, List<csParameterListType> objlist)
        {
            SqlCommand cmd = new SqlCommand();
            IDataReader dr = null;
            try
            {
                if (Open_Connection())
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = spname;

                        foreach (csParameterListType par in objlist)
                        {
                            cmd.Parameters.Add(add_parameters(par));
                        }

                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    }
                    catch
                    {
                    }
                }
                else
                {
                    if (Open_Connection())
                    {
                        try
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.CommandText = spname;

                            foreach (csParameterListType par in objlist)
                            {
                                cmd.Parameters.Add(add_parameters(par));
                            }
                            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        }
                        catch
                        {
                        }
                    }
                }
                return dr;
            }
            catch (Exception e)
            {
                errorstr += " " + e.Message;
                return null;
            }
        }

        public IDataReader executespreturndr(string spname)
        {
            SqlCommand cmd = new SqlCommand();
            IDataReader dr = null;
            if (Open_Connection())
            {
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = spname;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch
                {
                }
            }
            else
            {

            }
            return dr;
        }


        public void executespreturnnd(string spname)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                if (Open_Connection())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = spname;
                    cmd.ExecuteNonQuery();
                }

                close_conn();
            }
            catch (Exception e)
            {
                errorstr += " " + e.Message;
            }
        }
        public void executespreturnnd(string spname, List<csParameterListType> objlist)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (Open_Connection())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = spname;

                    foreach (csParameterListType par in objlist)
                    {
                        cmd.Parameters.Add(add_parameters(par));
                    }

                    cmd.ExecuteNonQuery();
                }
                close_conn();
            }
            catch (Exception e)
            {
                errorstr += " " + e.Message;
            }
        }
        public void executespreturnds(string spname)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                if (Open_Connection())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = spname;
                    cmd.ExecuteNonQuery();
                }

                close_conn();
            }
            catch (Exception e)
            {
                errorstr += " " + e.Message;
            }
        }
        public void executespreturnds(string spname, List<csParameterListType> objlist)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (Open_Connection())
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = spname;

                        foreach (csParameterListType par in objlist)
                        {
                            cmd.Parameters.Add(add_parameters(par));
                        }

                        cmd.ExecuteNonQuery();
                    }
                    catch
                    { }
                }
                close_conn();
            }
            catch (Exception e)
            {
                errorstr += " " + e.Message;
            }
        }
        private void close_conn()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();

            conn = null;
        }
    }
}