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

namespace Gui_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int lives = 10;
        private int random = 0;
        public MainWindow()
        {
            InitializeComponent();
            Random rand= new Random();
            random= rand.Next() % 100;
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(lives == 0)
            {
                lblFrom.Content = "you";
                lblTo.Content = "lose";
                return;
            }
            if(e.Key == Key.Enter)
            { 
                int userN = Int32.Parse(txtInput.Text);
                lives--;
                if(userN == random)
                {
                    lblFrom.Content = "you";
                    lblTo.Content = "win";
                    return;
                }
                if(userN < random)
                {
                    lblFrom.Content = userN;
                }
                else
                {
                    lblTo.Content = userN;
                }
                lblStatus.Content = "Remaining live: " + lives;
            }
        }
    }
}
