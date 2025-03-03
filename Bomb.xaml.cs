using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StarWars
{
    /// <summary>
    /// Логика взаимодействия для Bomb.xaml
    /// </summary>
    public partial class Bomb : UserControl
    {
        public bool IsBam = false;


        public Bomb()
        {
            InitializeComponent();
        }

        public bool IsHit(Rectangle Gun)
        {
            double bombLeft = Canvas.GetLeft(this);
            double bombTop = Canvas.GetTop(this);

            double gunLeft = Canvas.GetLeft(Gun);
            double gunTop = Canvas.GetTop(Gun);

            bool overlapX = bombLeft < gunLeft + Gun.Width && bombLeft + Width > gunLeft;

            bool overlapY = bombTop < gunTop + Gun.Height && bombTop + Height > gunTop;

            return overlapX && overlapY;
        }
    }
}
