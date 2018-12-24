using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AxWMPLib;
using Microsoft.VisualBasic;

namespace VideoArchiveForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog category = new OpenFileDialog();
        OpenFileDialog addfilm = new OpenFileDialog();
        int categoriesselectedindex,filmsselectedindex;
        string filmstext,url;
        string line = null;
        string categoriespath;

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriesselectedindex = categories.SelectedIndex;
            switch (categoriesselectedindex)
            {
                case 0:
                    categoriespath = @"\Action\actionfilmnames.txt";
                    readfile(categoriespath);
                    break;

                case 1:
                    categoriespath = @"\Comedy\comedyfilmnames.txt";
                    readfile(categoriespath);
                    break;

                case 2:
                    categoriespath = @"\Horror\horrorfilmnames.txt";
                    readfile(categoriespath);
                    break;

                case 3:
                    categoriespath = @"\Romantic\romanticfilmnames.txt";
                    readfile(categoriespath);
                    break;
                default:
                    break;
            }
        }

        private void films_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsselectedindex = films.SelectedIndex;
        }

        private void playbt_Click(object sender, EventArgs e)
        {
            string path;
            switch (categoriesselectedindex)
            {
                case 0:
                    path = @"\Action\actionfilms.txt";
                    openfile(path);
                    break;
                case 1:
                    path = @"\Comedy\comedyfilms.txt";
                    openfile(path);
                    break;
                case 2:
                    path = @"\Horror\horrorfilms.txt";
                    openfile(path);
                    break;
                case 3:
                    path = @"\Romantic\romanticfilms.txt";
                    openfile(path);
                    break;
                default:
                    break;
            }
            axWindowsMediaPlayer1.URL = filmstext;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pausebt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void stopbt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void addbt_Click(object sender, EventArgs e)
        {
            string path;
            addfilm.Filter = "Film|*.mp4";
            addfilm.Title = "Add Film";
            if (addfilm.ShowDialog() == DialogResult.OK)
            {
                FileInfo mp4url = new FileInfo(addfilm.FileName);
                url = mp4url.FullName;
            }
            switch (categoriesselectedindex)
            {
                case 0:
                    path = @"\Action\actionfilms.txt";
                    fileurlsw(path, url);
                    path = @"\Action\actionfilmnames.txt";
                    filenamesw(path);
                    
                    break;
                case 1:
                    path = @"\Comedy\comedyfilms.txt";
                    fileurlsw(path, url);
                    path = @"\Comedy\comedyfilmnames.txt";
                    filenamesw(path);
                    break;
                case 2:
                    path = @"\Horror\horrorfilms.txt";
                    fileurlsw(path, url);
                    path = @"\Horror\horrorfilmnames.txt";
                    filenamesw(path);
                    break;
                case 3:
                    path = @"\Romantic\romanticfilms.txt";
                    fileurlsw(path, url);
                    path = @"\Romantic\romanticfilmnames.txt";
                    filenamesw(path);
                    break;
                default:
                    break;
            }
            readfile(categoriespath);
        }

        public void readfile(string categoriespath)
        {
            films.Items.Clear();
            films.Text = null;
            try
            {
                StreamReader readfilesr = new StreamReader(Application.StartupPath + categoriespath);
                line = readfilesr.ReadLine();
                while (line != null)
                {
                    films.Items.Add(line);
                    line = readfilesr.ReadLine();
                }
                readfilesr.Close();
            }
            catch
            {
                MessageBox.Show("Please choose category");
            }
        }

        public void openfile(string path)
        {
            int t = films.SelectedIndex;
            StreamReader openfilesr = new StreamReader(Application.StartupPath + path);
            for (int i = 0; i <= t; i++)
            {
                line = openfilesr.ReadLine();
            }
            filmstext = line;
            openfilesr.Close();
        }

        public void fileurlsw(string path , string url)
        {
            StreamWriter filesw = new StreamWriter(Application.StartupPath + path, true);
            filesw.WriteLine(url);
            filesw.Close();
        }

        public void filenamesw(string path)
        {
            string filefilmsname = "";
            StreamWriter filenamesw = new StreamWriter(Application.StartupPath + path, true);
            filefilmsname = Interaction.InputBox("", "Film Name", "Example : Lord of The Rings", 10, 10);
            if (filefilmsname != "" && filefilmsname != "Example : Lord of The Rings")
            {
                filenamesw.WriteLine(filefilmsname);
            }
            else
            {
                MessageBox.Show("Cannot enter null value !!!");
            }
            filenamesw.Close();
        }
    }
}
