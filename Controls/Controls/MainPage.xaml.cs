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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Controls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string[] arrString = { "microsoft", "documented", "template", "windows", "with" };

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void myCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBoxState.Text = myCheckBox.IsChecked.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            String strResult = YesRadioBtn.IsChecked.ToString().ToLower();
            RadioBtnState.Text = strResult.Equals("true") ? "YesRadioBtn" : "NoRadioBtn";
        }

        private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = myComboBox.SelectedItem as ComboBoxItem;
            ComboBoxState.Text = selectedItem.Content.ToString();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxState == null)
            {
                return;
            }

            //ListBoxItem item = myListBox.SelectedItem as ListBoxItem;
            //ListBoxState.Text = item.Content.ToString();

            var selectedListBoxArray = myListBox.SelectedItems.Cast<ListBoxItem>().Select(p => p.Content.ToString());
            ListBoxState.Text = string.Join(", ", selectedListBoxArray);
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButtonState.Text = myToggleButton.IsChecked.ToString();
        }

        private void myToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitchState.Text = myToggleSwitch.IsOn ? "true" : "false";
        }

        private void TimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            TimePickerState.Text = myTimePicker.Time.ToString();
        }

        private void DatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            DatePickerState.Text = myDatePicker.Date.ToString();
        }

        private void myCalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            CalendarDatePickerState.Text = myCalendarDatePicker.Date.ToString();
        }

        private void myCalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectedDateArray = myCalendarView.SelectedDates.Cast<DateTimeOffset>().Select(p => p.LocalDateTime.ToString());
            CalendarViewState.Text = string.Join(", ", selectedDateArray);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myFlyout.Hide();
        }

        private void myToggleMenuFlyout_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myToggleMenuFlyout.IsChecked)
            {
                myFlyout.Hide();
            }
        }

        private void myAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            myAutoSuggestBox.ItemsSource = arrString.Where(p => p.StartsWith(myAutoSuggestBox.Text)).ToArray();
        }
    }
}
