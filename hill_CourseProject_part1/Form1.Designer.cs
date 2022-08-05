namespace hill_CourseProject_part1
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.artist = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.ClearSong = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(30, 89);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(53, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // artist
            // 
            this.artist.AutoSize = true;
            this.artist.Location = new System.Drawing.Point(30, 139);
            this.artist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(61, 25);
            this.artist.TabIndex = 1;
            this.artist.Text = "Artist";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(30, 191);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(71, 25);
            this.genre.TabIndex = 2;
            this.genre.Text = "Genre";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(30, 247);
            this.year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(58, 25);
            this.year.TabIndex = 3;
            this.year.Text = "Year";
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(30, 303);
            this.url.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(54, 25);
            this.url.TabIndex = 4;
            this.url.Text = "URL";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(144, 81);
            this.titleText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(262, 31);
            this.titleText.TabIndex = 5;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(144, 191);
            this.genreText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(262, 31);
            this.genreText.TabIndex = 6;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(144, 131);
            this.artistText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(262, 31);
            this.artistText.TabIndex = 7;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(144, 303);
            this.urlText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(262, 31);
            this.urlText.TabIndex = 8;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(144, 247);
            this.yearText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(262, 31);
            this.yearText.TabIndex = 9;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(537, 462);
            this.outputText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(483, 301);
            this.outputText.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(144, 365);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(264, 89);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 25;
            this.songList.Location = new System.Drawing.Point(537, 83);
            this.songList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(483, 279);
            this.songList.TabIndex = 12;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // allSongsButton
            // 
            this.allSongsButton.Location = new System.Drawing.Point(144, 462);
            this.allSongsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(264, 94);
            this.allSongsButton.TabIndex = 13;
            this.allSongsButton.Text = "Show All Songs";
            this.allSongsButton.UseVisualStyleBackColor = true;
            this.allSongsButton.Click += new System.EventHandler(this.AllSongsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "SONG LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 397);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "DETAILS";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(144, 564);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(264, 92);
            this.FindButton.TabIndex = 16;
            this.FindButton.Text = "Find Song";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click_1);
            // 
            // ClearSong
            // 
            this.ClearSong.Location = new System.Drawing.Point(144, 662);
            this.ClearSong.Name = "ClearSong";
            this.ClearSong.Size = new System.Drawing.Size(264, 101);
            this.ClearSong.TabIndex = 17;
            this.ClearSong.Text = "Clear Song";
            this.ClearSong.UseVisualStyleBackColor = true;
            this.ClearSong.Click += new System.EventHandler(this.ClearSong_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(1047, 81);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(538, 475);
            this.webViewDisplay.TabIndex = 18;
            this.webViewDisplay.ZoomFactor = 1D;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(1185, 618);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(268, 90);
            this.playButton.TabIndex = 19;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 831);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.ClearSong);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.url);
            this.Controls.Add(this.year);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainForm";
            this.Text = "Music Video Manager";
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label artist;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ClearSong;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button playButton;
    }
}

