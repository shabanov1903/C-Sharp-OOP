using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using L6_2.Skins.Base;

namespace L6_2.DataBase
{
    class DBase : IDBase
    {
        private readonly string _dbConfig;
        public DBase(string dbConfig)
        {
            _dbConfig = dbConfig;
        }
        public SkinObject ReadData(string name)
        {
            using var connection = new SqliteConnection(_dbConfig);
            SkinObject obj = connection.Query<SkinObject>($"SELECT * FROM skins WHERE Name = '{name}'").First();
            return obj;
        }
    }
}