using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace DataAccess
{
  public   interface IDBManager
    {

        DataProvider ProviderType { get; set; }
        string ConnectionString { get; set; }

        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }

        IDataReader DataReader { get; }
        IDbCommand Command { get; }
        IDbDataParameter[] Parameters { get; }

        void Open();
        void BeginTransaction();
        void CommitTransaction();
        void CreateParameters(int paramsCount);
        void AddParameters(int index, string paramName, object objValue);
        IDataReader ExecuteReader(CommandType commandType, string commandText, int? requestTimeout = null);
        DataSet ExecuteDataset(CommandType commandType, string commandText, int? requestTimeout = null);
        DataTable ExecuteDataTable(CommandType commandType, string commandText, int? requestTimeout = null);
        DataRow ExecuteDataRow(CommandType commandType, string commandText, int? requestTimeout = null);
        object ExecuteScalar(CommandType commandType, string commandText, int? requestTimeout = null);
        int ExecuteNonQuery(CommandType commandType, string commandText, int? requestTimeout = null);
        void CloseReader();
        void Close();
        void Dispose();
    }
}
