using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TUF_2000M_challenge
{
    public partial class _Default : Page
    {

        public DateTime date;
        public List<String> values = new List<String>();
        public String[] variable_name = new String[] {
            "Flow Rate", "Flow Rate",
            "Energy Flow Rate", "Energy Flow Rate",
            "Velocity", "Velocity",
            "Fluid sound speed", "Fluid sound speed",
            "Positive accumulator", "Positive accumulator",
            "Positive decimal fraction", "Positive decimal fraction",
            "Negative accumulator", "Negative accumulator",
            "Negative decimal fraction", "Negative decimal fraction",
            "Positive energy accumulator", "Positive energy accumulator",
            "Positive energy decimal fraction", "Positive energy decimal fraction",
            "Negative energy accumulator", "Negative energy accumulator",
            "Negative energy decimal fraction", "Negative energy decimal fraction",
            "Net accumulator", "Net accumulator",
            "Net decimal fraction", "Net decimal fraction",
            "Net energy accumulator", "Net energy accumulator",
            "Net energy decimal fraction", "Net energy decimal fraction",
            "Temperature #1/inlet", "Temperature #1/inlet",
            "Temperature #2/outlet", "Temperature #2/outlet",
            "Analog input AI3", "Analog input AI3",
            "Analog input AI4", "Analog input AI4",
            "Analog input AI5", "Analog input AI5",
            "Current input at AI3", "Current input at AI3",
            "Current input at AI3", "Current input at AI3",
            "Current input at AI3", "Current input at AI3",
            "System password", "System password",
            "Password for hardware", "",
            "Calendar (date and time)", "Calendar (date and time)", "Calendar (date and time)",
            "Day+Hour for autosave", "", "",
            "Key to input",
            "Go to Window #",
            "LCD Back-lit lights for number of seconds",
            "Timoes for beeper",
            "Pulses left for OCT", "", "", "", "", "", "", "", "",
            "Error Code", "", "", "", "",
            "PT100 resistance of inlet", "PT100 resistnce of inlet",
            "PT100 resistance of outlet", "PT100 resistnce of outlet",
            "Total travel time", "Total travel time",
            "Delta travel time", "Delta travel time",
            "Upstream travel time", "Upstream Travel time",
            "Downstream travel time", "Downstream travel time",
            "Output current", "Output current", "",
            "Working step and Signal Quality",
            "Upstream strength",
            "Downstream strength", "",
            "Language used in user interface",
            "The rate of measured travel time by calculated travel time", "The rate of measured travel time by calculated travel time",
            "Reynolds number", "Reynolds number"
        };
        public String[] format = new String[] {
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "LONG","LONG",
            "REAL4","REAL4",
            "LONG","LONG",
            "REAL4","REAL4",
            "LONG","LONG",
            "REAL4","REAL4",
            "LONG", "LONG",
            "REAL4","REAL4",
            "LONG", "LONG",
            "REAL4","REAL4",
            "LONG","LONG",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "REAL4","REAL4",
            "BCD", "BCD",
            "BCD","",
            "BCD", "BCD", "BCD",
            "BCD", "", "",
            "INTEGER",
            "INTEGER",
            "INTEGER",
            "INTEGER",
            "INTEGER", "", "", "", "", "", "", "", "",
            "BIT", "", "", "", "",
            "REAL4", "REAL4",
            "REAL4", "REAL4",
            "REAL4", "REAL4",
            "REAL4", "REAL4",
            "REAL4", "REAL4",
            "REAL4", "REAL4",
            "REAL4", "REAL4", "",
            "INTEGER",
            "INTEGER",
            "INTEGER", "",
            "INTEGER",
            "REAL4", "REAL4",
            "REAL4", "REAL4"
        };

        protected void Page_Load(object sender, EventArgs e)
        {

            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                String response = client.DownloadString("http://tuftuf.gambitlabs.fi/feed.txt");
                String[] rows = response.Split('\n');
                // first row is date
                date = DateTime.ParseExact(rows[0], "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                for (int i = 1; i < rows.Length - 1; i++)
                {
                    String row = rows[i];
                    String[] col = row.Split(':');
                    values.Add(col[1]);
                }

            }

        }
    }
}