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

namespace ERP.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EmployeeEntry : Window
    {
        public EmployeeEntry()
        {
            InitializeComponent();
        }

        private void IdentityNumberValidation()
        {
            if(IdentityNumberText.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Kimlik numarası boş bırakılamaz.");
            }

            else if (IdentityNumberText.Text.Length < 11)
            {
                MessageBox.Show("Kimlik numarası 11 karakter olmalıdır.");
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"Hello {FirstNameText.Text}");
            IdentityNumberValidation();
        }

        private void FirstNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.A && e.Key <= Key.Z))
            { e.Handled = true; }
        }

        private void BirthDateText_KeyUp(object sender, KeyEventArgs e)
        {
            if (BirthDateText.Text.Length == 8)
            {
                string newDate = BirthDateText.Text.Insert(2, "/").Insert(5, "/");
                try
                {
                    BirthDateText.SelectedDate = DateTime.Parse(newDate);
                }
                catch (Exception ex)
                {
                    BirthDateText.Text = "";
                }
            }    
        }

        private void LastNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.A && e.Key <= Key.Z))
            { 
                e.Handled = true; 
            }
        }

        private void IdentityNumberText_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)))
            {
                e.Handled = true;
            }
        }

        private void BirthDateText_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)))
            {
                e.Handled = true;
            }

        }
    }
}
