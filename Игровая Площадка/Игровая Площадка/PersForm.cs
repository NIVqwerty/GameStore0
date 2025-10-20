using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Игровая_Площадка
{
    public partial class PersForm : Form
    {
        Game game;
        public PersForm(Game _game)
        {
            InitializeComponent();

            game = _game;

            Text = game.name;
            label1.Text = game.name;
            label2.Text = game.genre;
            label3.Text = game.platform;
            label4.Text = game.gamemod;
            label5.Text = game.creator;
            ImagePictureBox.Image = game.pic.Image;
            try
            {
                textBox1.Text = System.IO.File.ReadAllText("../../files/"+ game.name +".txt");
            }
            catch(Exception)  { }
            SelectedButton.Visible = false;
            if (MainForm.nameUser != "")
            {
                SelectedButton.Visible = true;
            }
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            SelectedForm.games_selected.Add(game);
        }
    }
}
