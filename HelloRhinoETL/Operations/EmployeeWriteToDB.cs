using System.Data.SqlClient;
using Rhino.Etl.Core.Operations;

namespace HelloRhinoETL.Operations
{
    public class EmployeeWriteToDB: SqlBulkInsertOperation
    {
        public EmployeeWriteToDB(string connectionStringName, string targetTable) : base(connectionStringName, targetTable)
        {
        }

       
        protected override void PrepareSchema()
        {
            Schema["FirstName"] = typeof (string);
            Schema["LastName"] = typeof (string);
            Schema["Title"] = typeof (string);
        }

        protected override void onSqlRowsCopied(object sender, SqlRowsCopiedEventArgs e)
        {
            base.onSqlRowsCopied(sender, e);
        }
    }
}
