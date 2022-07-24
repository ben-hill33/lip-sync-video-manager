using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hill_CourseProject_part1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

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
            // Helper function

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string newLine = "\r\n";

            if (ValidInput())
            {
                // Add title to the songlist
                songList.Items.Add(titleText.Text);

                // Builds output text
                sb.Append(titleText.Text);
                sb.Append(newLine);

                sb.Append(artistText.Text);
                sb.Append(newLine);

                sb.Append(genreText.Text);
                sb.Append(newLine);

                sb.Append(yearText.Text);
                sb.Append(newLine);

                sb.Append(urlText.Text);
                sb.Append(newLine);

                // Adds built text to output display text box
                outputText.Text = sb.ToString();

            }
            
        }

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
            if (SongInList(titleText.Text))
            {
                MessageBox.Show("Song Found!");
            }
            else
            {
                MessageBox.Show("Song not in list!");
            }
        }
    }
}
