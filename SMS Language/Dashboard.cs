using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Net;
using System.Drawing;

namespace SMS_Language
{
    public partial class frmSmsLanguage : Form
    {
        string abbreviationsFile = "Abbreviations.txt"; // file for abbreviations
        string definitionsFile = "Definitions.txt";  // file for definitions
        public frmSmsLanguage()
        {
            InitializeComponent();
        }

        private void FrmSmsLanguage_Load(object sender, EventArgs e)
        {
            // sets the icon for the internet after checking
            if (CheckForInternetConnection())
            {
                picWifiOn.Visible = true;
                picWifiOff.Visible = false;
            }
            else
            {
                picWifiOn.Visible = false;
                picWifiOff.Visible = true;
            }
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            string smsMessage = txtInputBox.Text.Trim(); // gets the input text
            string[] smsWords = smsMessage.Split(' '); // turns text into array of strings
            int lineNum = 0; // used to count lines of txt files

            txtDisplayBox.Text = ""; // sets text to empty
            btnAmharic.Visible = true;
            btnReadOut.Visible = true;

            if (smsMessage == "") // if no message has been written
            {
                txtDisplayBox.Text = "You have not written an sms message! ";
            }
            else
            {
                if (File.Exists(definitionsFile) && File.Exists(abbreviationsFile)) // checks if the needed files exist
                {
                    StreamReader reader = new StreamReader(abbreviationsFile);
                    string line = reader.ReadLine();
                    using (reader)
                    {
                        for (int i = 0; i < smsWords.Length; i++)
                        {
                            while (line!= null) // goes through every line of abbreviationsFile 
                            {
                                if (smsWords[i].Equals(line, StringComparison.InvariantCultureIgnoreCase)) //if a word in the input matches a line in the file
                                {
                                    smsWords[i] = definitionFinder(lineNum);
                                }
                                line = reader.ReadLine();
                                lineNum++;
                            }
                            lineNum = 0; // resets line num
                            reader.BaseStream.Seek(0, SeekOrigin.Begin); // resets start location
                            line = reader.ReadLine();
                        }

                        foreach (var item in smsWords) // finally displays the output
                        {
                            txtDisplayBox.Text += item + " ";
                        }

                    }
                }
                else // creates the files
                {
                    File.Create(definitionsFile);
                    File.Create(abbreviationsFile);
                    txtDisplayBox.Text = "You dont have any definitions for SMS abbreviations";
                }
            }
        }

        private string definitionFinder(int lineNum) // finds the defenition for an abbreviation
        {
            if (new FileInfo(definitionsFile).Length != 0) // checks if file is empty or not
            {
                string definition = "";
                StreamReader reader = new StreamReader(definitionsFile);
                using (reader)
                {
                    for (int i = 0; i < lineNum + 1; i++)// searches for the definition based on the line number passed
                    {
                        definition = reader.ReadLine();
                    }
                    return definition;
                }
            }
            else
            {
                string errorMessage = "You dont have any definitions for your abbreviations";
                return errorMessage;
            }
        }

        private void BtnShortenSms_Click(object sender, EventArgs e)
        { 
            // mostly similar to BtnTranslate_Click
            string smsMessage = txtInputBox.Text;
            int lineNum = 0;
            

            txtDisplayBox.Text = "";

            if (smsMessage == "")
            {
                txtDisplayBox.Text = "You have not written an sms message! ";
            }
            else
            {
                if (File.Exists(definitionsFile) && File.Exists(abbreviationsFile))
                {
                    StreamReader reader = new StreamReader(definitionsFile);
                    string line = reader.ReadLine();
                    using (reader)
                    {

                        while (line != null) // iterates through the lines of definitionsFile
                        {

                            if ((smsMessage.ToLower()).Contains((line.ToLower()).Trim())) // checks if the input contains a line from the definitionsFile (disregards Case and Space)
                            {
                                smsMessage = smsMessage.ToLower().Replace((line.ToLower()).Trim(), abbreviationFinder(lineNum)); // replaces that definition with its abbreviation
                            }

                            line = reader.ReadLine();
                            lineNum++;


                        }
                        txtDisplayBox.Text = smsMessage;
                    }
                }
                else
                {
                    File.Create(definitionsFile);
                    File.Create(abbreviationsFile);
                    txtDisplayBox.Text = "You dont have any definitions for SMS abbreviations";
                }
            }
        }
        private string abbreviationFinder(int lineNum) // finds the abbreviation for a definition
        {
            //mostly similar to definitionFinder
            if (new FileInfo(abbreviationsFile).Length != 0)
            {
                string abbreviation = "";
                StreamReader reader = new StreamReader(abbreviationsFile);
                using (reader)
                {
                    for (int i = 0; i <= lineNum ; i++)
                    {
                        abbreviation = reader.ReadLine();
                    }
                    return abbreviation;
                }
            }
            else
            {
                string errorMessage = "You dont have any abbreviations to match your definitions";
                return errorMessage;
            }
        }

        public string TranslateText(string input) //translates the text in txtDisplayBox into Amharic
        {
            // i input en=english and am=amharic into google translates url
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", "am", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;

            // Get all json data
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

            // Extract just the first array element (This is the only data we are interested in)
            var translationItems = jsonData[0];

            
            string translation = ""; // stores translated data

            // Loop through the collection extracting the translated objects
            foreach (object item in translationItems)
            {
                // Convert the item array to IEnumerable
                IEnumerable translationLineObject = item as IEnumerable;

                // Convert the IEnumerable translationLineObject to a IEnumerator
                IEnumerator translationLineString = translationLineObject.GetEnumerator();

                // Get first object in IEnumerator
                translationLineString.MoveNext();

                // Save its value (translated text)
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            // Remove first blank character
            if (translation.Length > 1) { translation = translation.Substring(1); };

            // Return translation
            return translation;
        }

        private void btnToAmharic(object sender, EventArgs e)
        {
            try
            {
                frmSmsLanguage lang = new frmSmsLanguage(); // creates object of the form
                string text = txtDisplayBox.Text;
                string translatedText = lang.TranslateText(text); // passes text to TranslateText()
                txtDisplayBox.Text = translatedText;
            }
            catch (Exception)
            {
                txtDisplayBox.Text = "Sorry, an error has occured! Check your internet connection. This feature is experimental, fell free to talk to the developer for further feedback.";
                
            }
            
        }

        private void BtnReadOut_Click(object sender, EventArgs e) // speaks the text
        {
            try
            {
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10

                // Synchronous
                synthesizer.Speak(txtDisplayBox.Text);

            }
            catch (Exception)
            {
                txtDisplayBox.Text = "Sorry, an error has occured! This feature is experimental, fell free to talk to the developer for further feedback.";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)//closes the form
        {
            Close();
        }
        public static bool CheckForInternetConnection()//checks for internect connection
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e) //changes color of buttons (purely asthetic)
        {
            btnDashboard.BackColor = Color.FromArgb(219, 230, 236);
            btnKeywords.BackColor = Color.FromArgb(233, 236, 239);
        }

        private void BtnKeywords_Click(object sender, EventArgs e)//shows the keywords form
        {
            Keywords keywords = new Keywords();  
            keywords.Show();
        }

        private void PnlDashboard_Paint(object sender, PaintEventArgs e)//sets visibility of settings panel false
        {
            pnlSettings.Visible = false;
        }

        private void PicSettings_Click(object sender, EventArgs e)//sets visibility of settings panel true
        {
            pnlSettings.Visible = true;
        }

        private void PicInfo_Click(object sender, EventArgs e)//opens information form
        {
            Information settings = new Information();
            settings.Show();
        }

        int flag = 0; // to hold information on the state of nightmode
        private void BtnNightMode_Click(object sender, EventArgs e)
        {
            
            if(flag == 0) // sets colors to dark
            {
                pnlDashboard.BackColor = Color.FromArgb(0, 24, 69);
                this.BackColor = Color.FromArgb(0, 18, 51);
                btnReadOut.BackColor = Color.FromArgb(0, 40, 85);
                btnAmharic.BackColor = Color.FromArgb(0, 40, 85);
                btnTranslate.BackColor = Color.FromArgb(0, 40, 85);
                btnShortenSms.BackColor = Color.FromArgb(0, 40, 85);
                txtDisplayBox.BackColor = Color.FromArgb(69, 123, 157);
                txtInputBox.BackColor = Color.FromArgb(69, 123, 157);
                btnReadOut.ForeColor = Color.FromArgb(255,255,255);
                btnAmharic.ForeColor = Color.FromArgb(255, 255, 255);
                btnTranslate.ForeColor = Color.FromArgb(255, 255, 255);
                btnShortenSms.ForeColor = Color.FromArgb(255, 255, 255);
                txtDisplayBox.ForeColor = Color.FromArgb(255, 255, 255);
                txtInputBox.ForeColor = Color.FromArgb(255, 255, 255);
                btnNightMode.Text = "OFF";
                flag = 1;
            }
            else // sets colors to light
            {
                pnlDashboard.BackColor = Color.FromArgb(219, 230, 236);
                this.BackColor = Color.FromArgb(255,255,255);
                btnReadOut.BackColor = Color.WhiteSmoke;
                btnAmharic.BackColor = Color.WhiteSmoke;
                btnTranslate.BackColor = Color.FromArgb(0, 180, 216);
                btnShortenSms.BackColor = Color.FromArgb(0, 180, 216);
                txtDisplayBox.BackColor = Color.White;
                txtInputBox.BackColor = Color.White;
                btnReadOut.ForeColor = Color.FromArgb(69, 123, 157);
                btnAmharic.ForeColor = Color.FromArgb(69, 123, 157);
                btnTranslate.ForeColor = Color.WhiteSmoke;
                btnShortenSms.ForeColor = Color.WhiteSmoke;
                txtDisplayBox.ForeColor = Color.Black;
                txtInputBox.ForeColor = Color.Black;
                btnNightMode.Text = "ON";
                flag = 0;
            }
            
        }
    }
}

