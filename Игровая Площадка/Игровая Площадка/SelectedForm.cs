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
    public partial class SelectedForm : Form
    {
        public static List<Game> games_selected = new List<Game>();
        public SelectedForm()
        {
            InitializeComponent();
        }
    }
}
