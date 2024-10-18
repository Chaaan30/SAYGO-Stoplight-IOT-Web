using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT128_SAYGO_PROJECT.Properties;
using IT152P_SAYGO_PROJECT.Properties;
using MySql.Data.MySqlClient;
using TheArtOfDevHtmlRenderer.Adapters;

namespace IT152P_SAYGO_PROJECT
{
    public partial class Form1 : Form
    {
        string s_port = "";

        MySqlConnection connection;
        string server = "localhost"; // change IP address or use xampp if using xampp use localhost
        string database = "it152p"; //database name

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            s_port = serial_port.ReadExisting();

            if (s_port.Contains("green"))
            {
                trafficlight.Image = Resources.Green_traf_light;
                pedlight.Image = Resources.Red_ped_light;
            }
            else if (s_port.Contains("0") || s_port.Contains("yellow"))
            {
                trafficlight.Image = Resources.Yellow_traf_light;
            }
            else if (s_port.Contains("red"))
            {
                trafficlight.Image = Resources.Red_traf_light;
                pedlight.Image = Resources.Green_ped_light;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial_port.Open();
            timer1.Start();
        }

        private void InitializeDatabase()
        {
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID=root;PASSWORD=;";

            connection = new MySqlConnection(connectionString);
        }

        private void InsertOrUpdateData(string state)
        {
            string updateQuery = $"UPDATE sequence SET state = @state WHERE 1";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@state", state);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully");
                }
                else
                {
                    MessageBox.Show("No existing data to update. Inserting new data.");
                    string insertQuery = $"INSERT INTO sequence (state) VALUES (@state)";
                    cmd = new MySqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New data inserted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }



        private void resetbutton_Click(object sender, EventArgs e)
        {
            InsertOrUpdateData("reset");
        }

        private void morningbutton_Click(object sender, EventArgs e)
        {
            InsertOrUpdateData("morning");
        }
    }
}
