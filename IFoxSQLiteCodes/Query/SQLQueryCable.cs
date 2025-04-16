#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace IFoxSQLiteCodes.Query
{
    public class SQLQueryCable
    {
        public static Dtos.SQLCableQueryClass01? SQL_Query_Cable01(double inValue)
        {
            var result = new Dtos.SQLCableQueryClass01();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SQLConnection.SQLCable01_Config.ConnectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM dypd_cable01 WHERE \"izd\" = {inValue} LIMIT 1;";
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

                                var byj380 = reader["byj380"];
                                if (byj380 != DBNull.Value) { result.Byj380 = Convert.ToString(byj380); }
                                else { result.Byj380 = string.Empty; }

                                var byj220 = reader["byj220"];
                                if (byj220 != DBNull.Value) { result.Byj220 = Convert.ToString(byj220); }
                                else { result.Byj220 = string.Empty; }

                                var yjy380 = reader["yjy380"];
                                if (yjy380 != DBNull.Value) { result.Yjy380 = Convert.ToString(yjy380); }
                                else { result.Yjy380 = string.Empty; }

                                var yjy220 = reader["yjy220"];
                                if (yjy220 != DBNull.Value) { result.Yjy220 = Convert.ToString(yjy220); }
                                else { result.Yjy220 = string.Empty; }

                                var scbyj380 = reader["scbyj380"];
                                if (scbyj380 != DBNull.Value) { result.Scbyj380 = Convert.ToString(scbyj380); }
                                else { result.Scbyj380 = string.Empty; }

                                var scbyj220 = reader["scbyj220"];
                                if (scbyj220 != DBNull.Value) { result.Scbyj220 = Convert.ToString(scbyj220); }
                                else { result.Scbyj220 = string.Empty; }

                                var scyjy380 = reader["scyjy380"];
                                if (scyjy380 != DBNull.Value) { result.Scyjy380 = Convert.ToString(scyjy380); }
                                else { result.Scyjy380 = string.Empty; }

                                var scyjy220 = reader["scyjy220"];
                                if (scyjy220 != DBNull.Value) { result.Scyjy220 = Convert.ToString(scyjy220); }
                                else { result.Scyjy220 = string.Empty; }
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
