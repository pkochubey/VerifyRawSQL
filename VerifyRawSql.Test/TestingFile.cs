﻿using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // string 1
            var sql1 = String.Format("Select * From Test1 Where Id = {0}", 0);

            // string 2
            var sql2 = "Select * From Test2 Where Id = 1";

            // string 3
            var sql3 = "Select * From Test3 Where Id = " + 1;

            // string 4
            var result = "";
            result = db.Query<string>("Select * From Test4 Where Id = " + id).ToString();

            // string 5
            return db.Query<string>("Select * From Test5 Where Id = 1").ToString();

            // string 6
            var result = db.Query<string>("Select * From Test6 Where Id = " + id).ToString();
            return result;

            // string 7
            var sql7 = $"Select * From Test7 Where Id = {result}";

            // string 8
            var sql8 = db.Query<string>(";WITH cte AS (" + Environment.NewLine +
                    "  SELECT " + Environment.NewLine +
                    "    id, name, " + Environment.NewLine +
                    "    ROW_NUMBER() OVER (PARTITION BY name ORDER BY name) AS rn " + Environment.NewLine +
                    "  FROM Names" + Environment.NewLine +
                    "  WHERE CONTAINS(name, '\"*" + value.Trim() + "*\"'))" + Environment.NewLine +
                    "SELECT * FROM cte WHERE cte.rn <= 1").ToList();
        }
    }
}