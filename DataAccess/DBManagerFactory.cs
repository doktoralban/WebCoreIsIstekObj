using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public sealed class DBManagerFactory
    {
        private DBManagerFactory() { }


        public static IDbConnection GetConnection(DataProvider providerType)
        {
            IDbConnection iDbConnection = null;
            switch (providerType)
            {
                case DataProvider.SqlServer:
                    iDbConnection = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                   // iDbConnection = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    //iDbConnection = new OdbcConnection();
                    break;

                default: return null;
            }
            return iDbConnection;
        }


        public static IDbCommand GetCommand(DataProvider providerType)
        {
            IDbCommand iDbCommand = null;
            switch (providerType)
            {
                case DataProvider.SqlServer:
                    iDbCommand = new SqlCommand();
                    break;
                case DataProvider.OleDb:
                    //iDbCommand = new OleDbCommand();
                    //break;
                case DataProvider.Odbc:
                    //iDbCommand = new OdbcCommand();
                    //break;


                default: return null;
            }
            return iDbCommand;
        }

        public static IDbDataAdapter GetDataAdapter(DataProvider providerType)
        {
            IDbDataAdapter iDbDataAdapter = null;
            switch (providerType)
            {
                case DataProvider.SqlServer:
                    iDbDataAdapter = new SqlDataAdapter();
                    break;
                case DataProvider.OleDb:
                    //iDbDataAdapter = new OleDbDataAdapter();
                    //break;
                case DataProvider.Odbc:
                    //iDbDataAdapter = new OdbcDataAdapter();
                    //break;

                default: return null;
            }
            return iDbDataAdapter;
        }

        public static IDbTransaction GetTransaction(DataProvider providerType)
        {
            IDbConnection iDbConnection = GetConnection(providerType);
            IDbTransaction iDbTransaction = iDbConnection.BeginTransaction();
            return iDbTransaction;
        }

        public static IDbDataParameter GetParameter(DataProvider providerType)
        {
            IDbDataParameter idbDataParameter = null;
            switch (providerType)
            {
                case DataProvider.SqlServer:
                    idbDataParameter = new SqlParameter();
                    break;
                case DataProvider.OleDb:
                    //idbDataParameter = new OleDbParameter();
                    //break;
                case DataProvider.Odbc:
                    //idbDataParameter = new OdbcParameter();
                    //break;

                default: return null;
            }
            return idbDataParameter;
        }

        public static IDbDataParameter[] GetParameter(DataProvider providerType, int paramsCount)
        {
            IDbDataParameter[] idbParams = new IDbDataParameter[paramsCount];
            switch (providerType)
            {
                case DataProvider.SqlServer:
                    for (int i = 0; i < paramsCount; i++)
                    {
                        idbParams[i] = new SqlParameter();
                    }
                    break;
                case DataProvider.OleDb:
                    //for (int i = 0; i < paramsCount; i++)
                    //{
                    //    idbParams[i] = new OleDbParameter();
                    //}
                    break;
                case DataProvider.Odbc:
                    //for (int i = 0; i < paramsCount; i++)
                    //{
                    //    idbParams[i] = new OdbcParameter();
                    //}
                    break;


                default: return null;
            }
            return idbParams;
        }
    }
}
