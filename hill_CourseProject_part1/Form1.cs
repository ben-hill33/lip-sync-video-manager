using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace hill_CourseProject_part1
{
    public partial class mainForm : Form
    {
        // Makes reuse more efficient for each array.
        const int SONG_LIMIT = 5;

        // Declare data arrays
        string[] titleArray = new string[SONG_LIMIT];
        string[] artistArray = new string[SONG_LIMIT];
        string[] genreArray = new string[SONG_LIMIT];
        int[] yearArray = new int[SONG_LIMIT];
        string[] urlArray = new string[SONG_LIMIT];

        // initialize song count
        int songCount = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        #region HELPER Functions

        private bool ValidInput()
        {
            // Returns true if title, artist, genre, year, and URL are not empty. Otherwise false.
            bool isValid = true;

            if (string.IsNullOrEmpty(titleText.Text))
            {
                MessageBox.Show("You must enter a song title to continue!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("You must enter an artist to continue!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                MessageBox.Show("You must enter a genre to continue!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("You must enter a year to continue!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("You must enter a URL to continue!");
                isValid = false;
            }
            return isValid;
        }

        private bool SongInList(string songTitle)
        {
            bool inList = false;

            foreach (var item in songList.Items)
            {
                string currentSong = item as string;

                if (songTitle == currentSong)
                {
                    // Returns true if songTitle is in the list of all songs.
                    inList = true;
                }
            }
            return inList;
        }

        private int GetSongIndex(string songTitle)
        {
            int songIdx = 0;
            songIdx = songList.Items.IndexOf(songTitle);
            return songIdx;
        }

        #endregion

        #region EVENT Functions

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (songCount == SONG_LIMIT)
            {
                MessageBox.Show($"You reached song limit of {SONG_LIMIT}");
            }
            else
            {
                if (ValidInput())
                {
                    StringBuilder sbOutput = new StringBuilder(string.Empty);
                    string newLine = Environment.NewLine;

                    // Builds output text
                    sbOutput.Append(titleText.Text + newLine);
                    sbOutput.Append(artistText.Text + newLine);
                    sbOutput.Append(genreText.Text + newLine);
                    sbOutput.Append(yearText.Text + newLine);
                    sbOutput.Append(urlText.Text + newLine);

                    // Adds built text to output display text box
                    outputText.Text = sbOutput.ToString();

                    // add user inputs to arrays
                    songList.Items.Add(titleText.Text);

                    titleArray[songCount] = titleText.Text;
                    artistArray[songCount] = artistText.Text;
                    genreArray[songCount] = genreText.Text;
                    yearArray[songCount] = int.Parse(yearText.Text);
                    urlArray[songCount] = urlText.Text;

                    // increment songCount
                    songCount++;
                }
            }
        } // End function AddButton_Click



        private void AllSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(String.Empty);
            string newLine = "\r\n";

            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(newLine);
            }

            // Clear contents of outputText textbox so previous operation content don't show.
            outputText.Clear();

            // Display output text into output textbox
            outputText.Text = sb.ToString();
        }

        private void ClearSong_Click(object sender, EventArgs e)
        {
            titleText.Text = "";
            artistText.Text = "";
            genreText.Text = "";
            yearText.Text = "";
            urlText.Text = "";
        }

        private void FindButton_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string newLine = "\r\n";

            int songIdx = 0;

            if (SongInList(titleText.Text))
            {
                songIdx = GetSongIndex(titleText.Text);
                sb.Append(titleText.Text);
                sb.Append(newLine);

                sb.Append(artistArray[songIdx]);
                sb.Append(newLine);

                sb.Append(genreArray[songIdx]);
                sb.Append(newLine);

                sb.Append(yearArray[songIdx]);
                sb.Append(newLine);

                sb.Append(urlArray[songIdx]);
                sb.Append(newLine);

                outputText.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Song not in list!");
            }
        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string newLine = "\r\n";
            int songIdx = -1;
            songIdx = songList.SelectedIndex;

            sb.Append(titleArray[songIdx]);
            sb.Append(newLine);

            sb.Append(artistArray[songIdx]);
            sb.Append(newLine);

            sb.Append(genreArray[songIdx]);
            sb.Append(newLine);

            sb.Append(yearArray[songIdx].ToString());
            sb.Append(newLine);

            sb.Append(urlArray[songIdx]);
            sb.Append(newLine);

            // display in output text
            outputText.Text = sb.ToString();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int songIdx = 0;
            songIdx = songList.SelectedIndex;
            try
            {
                webViewDisplay.CoreWebView2.Navigate(urlArray[songIdx]);
            }
            catch
            {
                MessageBox.Show($"This should go to the following URL: {urlArray[songIdx]}");
            }
        }

        #endregion EVENT Functions

    }
}
