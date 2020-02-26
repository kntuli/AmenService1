using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace AmenService1
{
    public class csParameterListType
    {
        public string Name { get; set; }
        public SqlDbType sqlType { get; set; }
        public object Value { get; set; }

        public csParameterListType(string nam, SqlDbType sql, object val)
        {
            Name = nam;
            sqlType = sql;
            Value = val;
        }
    }
}