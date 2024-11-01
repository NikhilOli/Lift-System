using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lift_System
{
    internal class DatabaseManager
    {
        string connectionString = @"Server = LAPTOP-CD92AG1V; Database = lift_system; Trusted_Connection = True";


        public void logEvents(string message, DataTable dt, DataGridView DataTable)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            dt.Rows.Add(currentTime, message);
            DataTable.Rows.Add(currentTime, message);

            InsertLoginIntoDB(dt);
        }

        

        public void InsertLoginIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"Insert into LiftData (LogTime, EventDescription) values (@Time, @Log)";
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "Time");
                        adapter.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "EventDescription");

                        conn.Open();
                        adapter.Update(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB: " + ex.Message);
            }

        }
        public void loadLogsFromDB(DataTable dt, DataGridView DataTable)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"Select LogTime, EventDescription from LiftData order by LogTime desc";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();
                        adapter.Fill(dt);

                        DataTable.Invoke((MethodInvoker)(() =>
                        {
                            DataTable.Rows.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                string currentTime = row["LogTime"] != DBNull.Value
                                    ? Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss")
                                    : "N/A"; // Handle null value

                                string events = row["EventDescription"] != DBNull.Value
                                    ? row["EventDescription"].ToString()
                                    : "No Description"; // Handle null value

                                DataTable.Rows.Add(currentTime, events);
                            }
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs From DB: " + ex.Message);
            }
        }



        public void LoadLogsAsync(DataTable dt, DataGridView DataTable)
        {
            BackgroundWorker bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (sender, e) =>
            {
                // Perform the database loading in the background
                loadLogsFromDB(dt, DataTable);
            };
            bgWorker.RunWorkerCompleted += (sender, e) =>
            {
                MessageBox.Show("Logs loaded successfully.");
            };
            bgWorker.RunWorkerAsync();
        }
        public void DeleteLogsFromDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM LiftData";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting logs from DB: " + ex.Message);
            }
        }
    }
}
