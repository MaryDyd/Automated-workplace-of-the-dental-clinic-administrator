using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace clinic
{
    internal class DataBase
    {
        private static string constr;
        SqlConnection _connection = new
        SqlConnection(constr);
        public bool OpenCon()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                try { _connection.Open(); }
                catch
                {
                    ErrorSignal ErSignal = new ErrorSignal();
                    ErSignal.Show();
                }
                return true;
            }
            else return false;
        }
        public void CloseCon()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        public bool IsCon()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else return false;
        }
        public string GetConString()
        {
            return File.ReadAllText("DataBaseConnestion.txt");
        }
        public void SetLogPass(string _login, string _password)
        {
            constr = GetConString();
            constr = constr.Replace("login", _login);
            constr = constr.Replace("password", _password);
        }

        public SqlConnection GetCon()
        {
            return _connection;
        }
    }

}

