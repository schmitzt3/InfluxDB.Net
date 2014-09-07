using System;
using System.Collections.Generic;
using InfluxDB.Net.Models;

namespace InfluxDB.Net.Core
{
    public class DatabaseConfiguration
    {
        private readonly List<string> _continuousQueries;
        private readonly List<ShardSpace> _spaces;

        public DatabaseConfiguration()
        {
            _spaces = new List<ShardSpace>();
            _continuousQueries = new List<string>();
        }

        public string Name { get; set; }

        public List<ShardSpace> GetSpaces()
        {
            return _spaces;
        }

        public void AddSpace(ShardSpace space)
        {
            _spaces.Add(space);
        }

        public List<String> GetContinuousQueries()
        {
            return _continuousQueries;
        }

        public void AddContinuousQueries(String continuousQuery)
        {
            _continuousQueries.Add(continuousQuery);
        }
    }
}