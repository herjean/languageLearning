using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //DECLARATION OF VARIABLES
        int wordCount = 0;
        List<string> thaiWords = new List<string>();
        List<string> phoneticWords = new List<string>();
        Timer countDownTimer = new Timer();
        
        public Form1()
        {
            InitializeComponent();
        }

        #region DISPLAY THAI WORDS

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToAccessDB();

            //GET TOTAL NUMBER OF WORDS
            wordCount = thaiWords.Count();

            //INITIALISE TIMER
            countDownTimer.Interval = 5000;
            countDownTimer.Enabled = true;
            countDownTimer.Tick += new EventHandler(countDownTimer_Tick);
        }

        private async void countDownTimer_Tick(object sender, EventArgs e)
        {
            //RANDOMISE DISPLAY OF EVERY WORD WITH 5 SECONDS INTERVAL
            Random r = new Random();
            int rInt = r.Next(0, wordCount);

            phoneticLabel.Text = "";
            thaiLabel.Text = thaiWords[rInt].ToString();

            //DISPLAY PHONETIC AFTER 2 SECONDS
            await DisplayPhoneticWords(rInt);
        }

        private async Task DisplayPhoneticWords(int rInt)
        {
            await Task.Delay(2000);
            phoneticLabel.Text = phoneticWords[rInt].ToString();
        }

        #endregion

        private void ConnectToAccessDB()
        {

            string dbConnString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            //CONNECT TO ACCESS DATABASE
            using (OleDbConnection conn = new OleDbConnection(dbConnString))
            using (OleDbCommand cmd = new OleDbCommand("SELECT * from Thai_Words", conn))
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                //GET LIST OF WORDS
                while (reader.Read())
                {
                    thaiWords.Add(reader["thai"].ToString());
                    phoneticWords.Add(reader["english"].ToString());
                }
                conn.Close();
            }
        }

    }
}
