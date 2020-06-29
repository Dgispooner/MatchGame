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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();

        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🎈","🎈",
                "🍕","🍕",
                "🚗","🚗",
                "❤","❤",
                "🧲","🧲",
                "🐧","🐧",
                "🐱‍🏍","🐱‍🏍",
                "🌹","🌹",
            };
            Random random = new Random();                                               // Create a random Number genertator

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())       // Cycle through ever textbox in the grid "mainGrid"
            {
                int index = random.Next(animalEmoji.Count);                             //Get a random number between 0 and the length fo the list (remaining emji)
                string nextEmoji = animalEmoji[index];                                  // Select emoji from list using the random numbner
                textBlock.Text = nextEmoji;                                             // add randomly selected emoji to the textbox
                animalEmoji.RemoveAt(index);                                            // delete emoji from the list
            }
        }
    }
}
