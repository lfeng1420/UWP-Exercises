using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GoNutsPrep
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        String strRoast;
        String strSweet;
        String strCream;


        private void CreamButton_Click(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem oFlyoutItem = sender as MenuFlyoutItem;
            if (oFlyoutItem == null)
            {
                return;
            }

            strCream = oFlyoutItem.Text;
            UpdateCoffeeString();
        }

        private void SweetButton_Click(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem oFlyoutItem = sender as MenuFlyoutItem;
            if (oFlyoutItem == null)
            {
                return;
            }

            strSweet = oFlyoutItem.Text;
            UpdateCoffeeString();
        }

        private void RoastButton_Click(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem oFlyoutItem = sender as MenuFlyoutItem;
            if (oFlyoutItem == null)
            {
                return;
            }

            strRoast = oFlyoutItem.Text;
            UpdateCoffeeString();
        }


        private void UpdateCoffeeString()
        {
            if (String.IsNullOrEmpty(strRoast) || strRoast.Equals("None"))
            {
                CoffeeText.Text = "";
                strCream = null;
                strSweet = null;
                return;
            }

            String strFinal = strRoast;
            if (!String.IsNullOrEmpty(strSweet) && !strSweet.Equals("None"))
            {
                strFinal += " + " + strSweet;
            }

            if (!String.IsNullOrEmpty(strCream) && !strCream.Equals("None"))
            {
                strFinal += " + " + strCream;
            }

            CoffeeText.Text = strFinal;
        }

        
    }
}
