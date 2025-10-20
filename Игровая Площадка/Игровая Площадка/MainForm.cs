using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Игровая_Площадка.Properties;
using System.IO;

namespace Игровая_Площадка
{
    public struct Game
    {
        public string name;
        public string genre;
        public string platform;
        public string gamemod;
        public string creator;
        
        public PictureBox pic;
        public Label lbl;

        public Game(string _name, string _genre,string _platform, string _gamemod, string _creator)
        { 
            name = _name;
            genre = _genre;
            platform = _platform;
            gamemod = _gamemod;
            creator = _creator;
            pic = new PictureBox();
            pic.Tag = name;

            try
            {
                pic.Load("../../files/" + name + ".jpg");
            }
            catch (Exception) { }
            lbl = new Label();
            lbl.Text = name;
        }
    }
    public partial class MainForm : Form
    {
        public static List<Game> games = new List<Game>();

        public static string nameUser = "";
        bool isAdmin = false;

        public MainForm()
        {
            InitializeComponent();

           SearchPanel.Height = HideButton.Height;
            
            HelloLabel.Visible = false;
            AdminPanelButton.Visible = false;
            SelectedButton.Visible = false;

           ReRead();

        }

        

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (SearchPanel.Height == HideButton.Height)
            {
                SearchPanel.Height = 150;
                HideButton.Text = "Свернуть";
            }
            else
            {
                SearchPanel.Height = HideButton.Height;
                HideButton.Text = "Развернуть";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (((PictureBox)sender).Tag == games[i].pic.Tag)
                {
                    PersForm pers = new PersForm(games[i]);
                    pers.ShowDialog();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int x = 60;
            int y = 40;

            for (int i = 0; i < games.Count; i++)
            {
                games[i].pic.Location = new Point(x, y);
                games[i].pic.Size = new Size(260, 150);
                games[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                games[i].pic.Click += new EventHandler(pictureBox1_Click);
                InfoPanel.Controls.Add(games[i].pic);

                games[i].lbl.Location = new Point(x, y + 160);
                games[i].lbl.Size = new Size(260, 30);
                games[i].lbl.TextAlign = ContentAlignment.MiddleCenter;
                InfoPanel.Controls.Add(games[i].lbl);

                x += 300;
                if (x + 260 > InfoPanel.Width)
                {
                    x = 60;
                    y += 200;
                }
          

            } 
        }

        void ReDraw()
        {
            int x = 60;
            int y = 40;
            
            for (int i = 0; i < games.Count; i++)
            {
                games[i].pic.Location = new Point(x, y);
                games[i].pic.Size = new Size(260, 150);
                games[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                games[i].pic.Click += new EventHandler(pictureBox1_Click);
                InfoPanel.Controls.Add(games[i].pic);

                games[i].lbl.Location = new Point(x, y + 160);
                games[i].lbl.Size = new Size(260, 30);
                games[i].lbl.TextAlign = ContentAlignment.MiddleCenter;
                InfoPanel.Controls.Add(games[i].lbl);

                x += 300;
                if (x + 260 > InfoPanel.Width)
                {
                    x = 60;
                    y += 200;
                }

            }
        }

        void ReRead()
        {
            games.Clear();
            string[] strs = File.ReadAllLines("../../Files/games.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                Game game = new Game(parts[0], parts[1], parts[2], parts[3], parts[4]);
                games.Add(game);
            }

            ReDraw();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 60;
            int y = 40;
            for (int i = 0; i < games.Count; i++)
            {
                games[i].pic.Visible = true;
                games[i].lbl.Visible = true;
                if(SearchTextBox.Text != "" && !games[i].name.Contains(SearchTextBox.Text))
                {
                    games[i].pic.Visible = false;
                    games[i].lbl.Visible = false;
                }
                if (GenreComboBox.Text != "" && GenreComboBox.Text != games[i].genre)
                {
                    games[i].pic.Visible = false;
                    games[i].lbl.Visible = false;
                }
                if (RegimComboBox.Text != "" && RegimComboBox.Text != games[i].gamemod)
                {
                    games[i].pic.Visible = false;
                    games[i].lbl.Visible = false;
                }
                if (PlatforComboBox.Text != "" && PlatforComboBox.Text != games[i].platform)
                {
                    games[i].pic.Visible = false;
                    games[i].lbl.Visible = false;
                }
                if (DevelopComboBox.Text != "" && DevelopComboBox.Text != games[i].creator)
                {
                    games[i].pic.Visible = false;
                    games[i].lbl.Visible = false;
                }

                if (games[i].lbl.Visible)
                {
                    games[i].pic.Location = new Point(x, y);
                    games[i].lbl.Location = new Point(x,y+160);
                    x += 300;
                    if (x + 260 > InfoPanel.Width)
                    {
                        x = 60;
                        y += 200;
                    }

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        public void EnterButton_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                if (LoginTextBox.Text == parts[1] && PassTextBox.Text == parts[2])
                {
                    nameUser = parts[0];
                    isAdmin = (parts[3] == "1");
                    break;
                }

            }
            if (EnterButton.Text == "Выйти")
            {
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(HelloLabel);
                AuthPanel.Controls.Add(label7);
                AuthPanel.Controls.Add(label5);
                AuthPanel.Controls.Add(LoginTextBox);
                AuthPanel.Controls.Add(PassTextBox);
                AuthPanel.Controls.Add(RegButton);
                AuthPanel.Controls.Add(EnterButton);
                HelloLabel.Visible = false;
                AdminPanelButton.Visible = false;
                EnterButton.Text = "Войти";
                LoginTextBox.Text = "";
                PassTextBox.Text = "";
                nameUser = "";
                isAdmin = false;


            }
            else
            {
            if (nameUser != "")
                    {
                    AuthPanel.Controls.Clear();
                    AuthPanel.Controls.Add(HelloLabel);
                    AuthPanel.Controls.Add(EnterButton);
                    AuthPanel.Controls.Add(AdminPanelButton);
                    AuthPanel.Controls.Add(SelectedButton);
                    AdminPanelButton.Visible = isAdmin;
                    HelloLabel.Text = "Добро Пожаловать, "+nameUser;
                    HelloLabel.Visible = true;
                    SelectedButton.Visible = true;
                    EnterButton.Text = "Выйти";

                    }
            else
                  {
                      MessageBox.Show("Неверный Логин/Пароль");
                  }
            }
            
        }

        public void AuthPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.ShowDialog();
            ReRead();
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            SelectedForm selectedForm = new SelectedForm();
            selectedForm.Show();
            ReRead();
        }

        private void InfoPanel_Resize(object sender, EventArgs e)
        {
            ReDraw();

        }
    }
}
