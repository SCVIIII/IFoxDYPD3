using IFOXSQLiteCodes01.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFOXSQLiteCodes01.Query
{
    public class SQLQueryCircuitBreaker
    {

        /// <summary>
        /// 从SQLITE中查询对应品牌的断路器型号
        /// </summary>
        public static SQL_CircuitBreaker_QueryClass01 SQL_Query_CircuitBreaker01(string CircuitBreaker_Brand,double inValue) 
        {
            var result = new SQL_CircuitBreaker_QueryClass01();
            string SQL_Name =string.Empty;
            if (string.IsNullOrEmpty(CircuitBreaker_Brand)) return null;
            else if(CircuitBreaker_Brand== "schneider")
            {
                SQL_Name = "dypd_switch_schneider01";
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SQLConnection.SQLCable01_Config.ConnectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {SQL_Name} WHERE \"izd\" = {inValue} LIMIT 1;";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                var Idkey = reader["idkey"];
                                if (Idkey != DBNull.Value) { result.Idkey = Convert.ToInt32(Idkey); } else { return null; }

                                var Izd = reader["izd"];
                                if (Izd != DBNull.Value) { result.Izd = Convert.ToDouble(Izd); } else { return null; }

                                var Mcb_shell = reader["mcb_shell"];
                                if (Mcb_shell != DBNull.Value) { result.Mcb_shell = Convert.ToString(Mcb_shell); }
                                else { result.Mcb_shell = string.Empty; }

                                var Mcb_fas = reader["mcb_fas"];
                                if (Mcb_fas != DBNull.Value) { result.Mcb_fas = Convert.ToString(Mcb_fas); }
                                else { result.Mcb_fas = string.Empty; }

                                //_mcb_ma
                                var Mcb_ma = reader["mcb_ma"];
                                if (Mcb_ma != DBNull.Value) { result.Mcb_ma = Convert.ToString(Mcb_ma); }
                                else { result.Mcb_ma = string.Empty; }

                                //_mccb_shell
                                var Mccb_shell = reader["mccb_shell"];
                                if (Mccb_shell != DBNull.Value) { result.Mccb_shell = Convert.ToString(Mccb_shell); }
                                else { result.Mccb_shell = string.Empty; }

                                //_rcb0_shell
                                var Rcb0_shell = reader["rcb0_shell"];
                                if (Rcb0_shell != DBNull.Value) { result.Rcb0_shell = Convert.ToString(Rcb0_shell); }
                                else { result.Rcb0_shell = string.Empty; }

                                //_rcb0_suf
                                var Rcb0_suf = reader["rcb0_suf"];
                                if (Rcb0_suf != DBNull.Value) { result.Rcb0_suf = Convert.ToString(Rcb0_suf); }
                                else { result.Rcb0_suf = string.Empty; }

                                return result;

                            } //end of if (reader.Read())

                            return null;
                        } //end of using (SQLiteDataReader reader = command.ExecuteReader())
                    } //end of using (SQLiteCommand command = new SQLiteCommand(query, connection))
                } //end of using (SQLiteConnection connection = new SQLiteConnection(SQLConnection.SQLCable01_Config.ConnectionString))
            } //end of try 
            catch (Exception ex)
            {
                Console.WriteLine($"发生错误: {ex.Message}");
                return null;
            }
        }
    }
}
