//Tyler Simpson
//February 21 2023
//Prog 2 Lecture 9 Notes

//Check boxes and radio buttons both return a type of
//Bool

//How what property do you use to get the true / false value from your individual check boxes / radio buttons
//IsChecked.Value

//When using check boxes you need to use a ____ for each check box
//

//When working with radio buttons you need an ____ / _____ / _____ structure
//

//You need to _______ together radio buttons, otherwise they may not work properly
//

//You can use a ________ layout to accomplish this
//

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

namespace Lecture_9_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheckBoxResults_Click(object sender, RoutedEventArgs e)
        {
            //checkboxname . IsChecked . Value to return results of check box being checked or not
            bool isChecked = ckFirstCheckBox.IsChecked.Value;

            MessageBox.Show(isChecked.ToString());
        }

        private void btnOrderPizza_Click(object sender, RoutedEventArgs e)
        {
            //clears the text
            runReceipt.Text = "";

            //create bools for if the checkbox is checked
            bool hasPepperoni = ckPepperoni.IsChecked.Value;
            bool hasJalapeno = ckJalapeno.IsChecked.Value;
            bool hasPineapple = ckPineapple.IsChecked.Value;
            bool hasMushroom = ckMushroom.IsChecked.Value;
            runReceipt.Text = "Toppings:\n";
            if (hasPepperoni)
            {
                runReceipt.Text += "Pepperoni\n";
            }
            if (hasJalapeno)
            {
                runReceipt.Text += "Jalapeno\n";
            }
            if (hasPineapple)
            {
                runReceipt.Text += "Pineapple\n";
            }
            if (hasMushroom)
            {
                runReceipt.Text += "Mushroom\n";
            }

        }
    }
}
