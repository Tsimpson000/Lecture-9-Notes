//Tyler Simpson
//February 21 2023
//Prog 2 Lecture 9 Notes

//Check boxes and radio buttons both return a type of
//Bool

//How what property do you use to get the true / false value from your individual check boxes / radio buttons
//IsChecked.Value

//When using check boxes you need to use a ____ for each check box
//bool and if statement

//When working with radio buttons you need an ____ / _____ / _____ structure
//if else if

//You need to _______ together radio buttons, otherwise they may not work properly
//Container

//You can use a ________ layout to accomplish this
//Canvas

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
            Preload();
        }

        private void btnCheckBoxResults_Click(object sender, RoutedEventArgs e)
        {
            //checkboxname . IsChecked . Value to return results of check box being checked or not
            bool isChecked = ckFirstCheckBox.IsChecked.Value;

            MessageBox.Show(isChecked.ToString());
        }

        private void btnOrderPizza_Click(object sender, RoutedEventArgs e)
        {
            //clears the text to start with customer name inputted in textbox
            runReceipt.Text = "Customer Name - " + txtCustomerName.Text + "\n";

            //create bools for if the checkbox is checked
            bool hasPepperoni = ckPepperoni.IsChecked.Value;
            bool hasJalapeno = ckJalapeno.IsChecked.Value;
            bool hasPineapple = ckPineapple.IsChecked.Value;
            bool hasMushroom = ckMushroom.IsChecked.Value;

            //create bools for if radio button is clicked
            bool smallPizza = rbSmallPizza.IsChecked.Value;
            bool mediumPizza = rbMediumPizza.IsChecked.Value;
            bool largePizza = rbLargePizza.IsChecked.Value;
            bool familyPizza = rbFamilyPizza.IsChecked.Value;

            bool smallDrink = rbSmallDrink.IsChecked.Value;
            bool mediumDrink = rbMediumDrink.IsChecked.Value;
            bool largeDrink = rbLargeDrink.IsChecked.Value;
            bool extraLargeDrink = rbExtraLargeDrink.IsChecked.Value;
            //if else if to run through radio buttons to find which one is selected.
            double total = 0;
            double toppingPrice = 1;
            runReceipt.Text = "Size: ";
            if (smallPizza)
            {
                double pizzaPrice = 8;
                runReceipt.Text += $"Small - ${pizzaPrice}";
                total += pizzaPrice;
            }
            else if (mediumPizza)
            {
                double pizzaPrice = 10;
                runReceipt.Text += $"Medium - ${pizzaPrice}";
                total += pizzaPrice;
            }
            else if (largePizza)
            {
                double pizzaPrice = 12;
                runReceipt.Text += $"Large - ${pizzaPrice}";
                total += pizzaPrice;
            }
            else if (familyPizza)
            {
                double pizzaPrice = 15;
                runReceipt.Text += $"Family Size - ${pizzaPrice}";
                total += pizzaPrice;
            }
            
            //if statements to see which of check boxes have been checked, can be multiple
            runReceipt.Text += "\n\nToppings:\n";
            if (hasPepperoni)
            {
                runReceipt.Text += $"Pepperoni - ${toppingPrice}\n";
                total += toppingPrice;
            }
            if (hasJalapeno)
            {
                runReceipt.Text += $"Jalapeno - ${toppingPrice}\n";
                total += toppingPrice;
            }
            if (hasPineapple)
            {
                runReceipt.Text += $"Pineapple - ${toppingPrice}\n";
                total += toppingPrice;
            }
            if (hasMushroom)
            {
                runReceipt.Text += $"Mushroom - ${toppingPrice}\n";
                total += toppingPrice;
            }

            runReceipt.Text += "\nDrink Size: ";

            if (smallDrink)
            {
                double drinkPrice = 2;
                runReceipt.Text += $"Small - ${drinkPrice}";
                total += drinkPrice;
            }
            else if (mediumDrink)
            {
                double drinkPrice = 3;
                runReceipt.Text += $"Medium - ${drinkPrice}";
                total += drinkPrice;
            }
            else if (largeDrink)
            {
                double drinkPrice = 4;
                runReceipt.Text += $"Large - ${drinkPrice}";
                total += drinkPrice;
            }
            else if (extraLargeDrink)
            {
                double drinkPrice = 5;
                runReceipt.Text += $"Extra Large - ${drinkPrice}";
                total += drinkPrice;
            }
            double tax = .1;
            double transactionTax = tax * total;
            double grandTotal = transactionTax + total;
            runReceipt.Text += $"\n\nSubtotal: ${total}\nTax: ${transactionTax}\nTotal Price: ${grandTotal}";
        }
        private void Preload()
        {
            //preload method to ensure there is always a radio button selected
            rbSmallPizza.IsChecked = true;
            rbSmallDrink.IsChecked = true;
        }
    }
}
