using Microsoft.Data.SqlClient;
using System.Data;

namespace PimpMyRideServer.Data
{
    public class BackupService
    {
        static BackupService()
        {
            string sourceConnectionString = @"Data Source=DESKTOP-T1R5O2U;Initial Catalog=Garage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string destinationConnectionString = @"Data Source=DESKTOP-T1R5O2U;Initial Catalog=BackupDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection sourceConnection = new SqlConnection(sourceConnectionString))
            using (SqlConnection destinationConnection = new SqlConnection(destinationConnectionString))
            {
                sourceConnection.Open();
                destinationConnection.Open();

                // Retrieve all tables from the source database
                DataTable tables = GetTables(sourceConnection);

                foreach (DataRow tableRow in tables.Rows)
                {
                    string tableName = tableRow["TABLE_NAME"].ToString();

                    // Retrieve all columns for the current table
                    DataTable columns = GetColumns(sourceConnection, tableName);

                    // Check if the destination table exists, and create it if not
                    EnsureDestinationTable(destinationConnection, tableName, columns);

                    // Generate and execute the dynamic insert query
                    string insertQuery = GenerateInsertQuery(tableName, columns);
                    ExecuteNonQuery(destinationConnection, insertQuery);
                }

                Console.WriteLine("Data copied successfully to the destination database.");
            }
        }

        static DataTable GetTables(SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", connection))
            {
                DataTable table = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
                return table;
            }
        }

        static DataTable GetColumns(SqlConnection connection, string tableName)
        {
            using (SqlCommand command = new SqlCommand($"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", connection))
            {
                DataTable columns = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(columns);
                }
                return columns;
            }
        }

        static void EnsureDestinationTable(SqlConnection connection, string tableName, DataTable columns)
        {
            string destinationTableName = $"Backup_{tableName}";

            if (!TableExists(connection, destinationTableName))
            {
                // Create the destination table if it does not exist
                string createTableQuery = GenerateCreateTableQuery(destinationTableName, columns);
                ExecuteNonQuery(connection, createTableQuery);
            }
        }

        static bool TableExists(SqlConnection connection, string tableName)
        {
            using (SqlCommand command = new SqlCommand($"SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'", connection))
            {
                return command.ExecuteScalar() != null;
            }
        }

        static string GenerateCreateTableQuery(string tableName, DataTable columns)
        {
            string columnDefinitions = string.Join(", ", columns.Rows.Cast<DataRow>().Select(row =>
                $"{row["COLUMN_NAME"]} {row["DATA_TYPE"]}"));

            return $"CREATE TABLE {tableName} ({columnDefinitions})";
        }

        static string GenerateInsertQuery(string tableName, DataTable columns)
        {
            string columnList = string.Join(", ", columns.Rows.Cast<DataRow>().Select(row => row["COLUMN_NAME"].ToString()));
            return $"INSERT INTO {tableName} ({columnList}) SELECT {columnList} FROM {tableName}";
        }

        static void ExecuteNonQuery(SqlConnection connection, string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}

