using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игровая_Площадка
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (PassTextBox.Text == RePassTextBox.Text)
            {
                System.IO.File.AppendAllText("users.txt",
                                         NameTextBox.Text + ", " +
                                         LoginTextBox.Text + ", " +
                                         PassTextBox.Text + ", 0"+ Environment.NewLine);
                MessageBox.Show("Вы зарегитрировались");
                Close();
            }
            else MessageBox.Show("Пароли не совпадают");
        }
    }
}
