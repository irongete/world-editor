using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using World_Editor.Database;
using World_Editor.Database.Emulators;

namespace World_Editor.Model
{
    public class ProjectModel
    {
        private MySqlConnector _connection;
        private CoreType _coreType;

        public MySqlConnector GetMysqlConnector()
        {
            if (_connection == null)
            {
                _connection = new MySqlConnector(Host, Database, User, Password, GetCoreInstance());
            }
            return _connection;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string WowDir { get; set; }
        public bool IsLast { get; set; }
        public string Host { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public CoreType Core
        {
            get { return _coreType; }
            set
            {
                if (_coreType != value)
                {
                    if (_connection != null)
                    {
                        _connection.Disconnect();
                        _connection = null;
                    }
                    _coreType = value;
                }
            }
        }

        public override string ToString()
        {
            return Name + " - " + Path;
        }

        private ICore GetCoreInstance()
        {
            switch (_coreType)
            {
                case CoreType.Arcemu:
                    return new Arcemu();
                case CoreType.Mangos:
                    return new Mangos();
                case CoreType.Trinity:
                    return new Trinity();
                default:
                    throw new Exception("No Core defined");
            }
        }

        public enum CoreType
        {
            Arcemu = 1,
            Mangos = 2,
            Trinity = 3
        }

    }
}
