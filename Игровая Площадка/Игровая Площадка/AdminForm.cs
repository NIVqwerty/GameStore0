using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Игровая_Площадка
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            for(int i = 0;i<MainForm.games.Count;i++)
            {
                DelComboBox.Items.Add(MainForm.games[i].name);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(SearchTextBox.Text == "" || GenreComboBox.Text == ""|| 
                PlatforComboBox.Text == ""|| RegimComboBox.Text == ""||
                DevelopComboBox.Text == "")
            {
                MessageBox.Show("Поля с * обязательны для заполнения");      
            }


            File.AppendAllText("../../files/games.txt", SearchTextBox.Text + ", " + 
                                                                  GenreComboBox.Text + ", " +
                                                                  PlatforComboBox.Text + ", " +
                                                                  RegimComboBox.Text + ", " +
                                                                  DevelopComboBox.Text + 
                                                                  Environment.NewLine);
            if(FileName !="")
            {
                File.Copy(FileName, "../../files/" + SearchTextBox.Text + ".jpg");
            }

            File.AppendAllText("../../files/" + SearchTextBox.Text + ".txt", OpisTextBox.Text);

            MessageBox.Show("Создано");

            var result = MessageBox.Show("ВЫ хотите продолжить добавление объектов?", "Следующий шаг", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SearchTextBox.Text = "";
                GenreComboBox.Text = "";
                PlatforComboBox.Text = "";
                RegimComboBox.Text = "";
                DevelopComboBox.Text = "";
            }
            else 
            {
                Close();  
            }
        }

        string FileName = "";
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK);
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("ВЫ действительно хотите удалить выбранный объект?", "Удаление Объекта", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.Delete("../../files/games.txt");
                for(int i = 0; i < MainForm.games.Count; i++)
                {
                    if(DelTextBox.Text == MainForm.games[i].name)
                    {

                    }
                    else
                    {
                        File.AppendAllText("../../files/games.txt", MainForm.games[i].name + ", " +
                                                                  MainForm.games[i].genre + ", " +
                                                                  MainForm.games[i].platform + ", " +
                                                                  MainForm.games[i].gamemod + ", " +
                                                                  MainForm.games[i].creator + 
                                                                  Environment.NewLine);
                    }
                }
                MessageBox.Show("Объект удален");
            }    
        }

        private void DelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelTextBox.Text = DelComboBox.Text;
        }
    }
}
