using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AddressBook
{
    public enum BookTypeEnum
    {
        NetBook,
        PhoneBook
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<NormalContact> TeleBookCollection { get; set; }
        public ObservableCollection<InternetContact> NetBookCollection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            TeleBookCollection = new ObservableCollection<NormalContact>();
            NetBookCollection = new ObservableCollection<InternetContact>();

            this.KindOfBookComboBox.ItemsSource = Enum.GetValues(typeof(BookTypeEnum));
            this.KindOfBookComboBox.SelectedIndex = 0;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            string name = this.NameBox.Text;
            string surname = this.SurnameTextBox.Text;
            
            BookTypeEnum SelectedBook = (BookTypeEnum)Enum.Parse(typeof(BookTypeEnum), this.KindOfBookComboBox.Text);
            if (SelectedBook == BookTypeEnum.NetBook)
            {
                string email = this.NumberBox.Text;
                InternetContact personNet = new InternetContact(name, surname, email);
                NetBookCollection.Add(personNet);
            }
            if (SelectedBook == BookTypeEnum.PhoneBook)
            {
                uint phoneNumber = uint.Parse(this.NumberBox.Text);
                NormalContact person = new NormalContact(name, surname, phoneNumber);
                TeleBookCollection.Add(person);
            }           
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.TeleBookCollection.RemoveAt(this.AddressBookList.SelectedIndex);            
            }
            catch (System.ArgumentOutOfRangeException)
            {
                try
                {
                    this.NetBookCollection.RemoveAt(this.NetBookList.SelectedIndex);
                }
                catch(System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Select item to delete.", "Delete item");
                }              
            }
        }

        private void KindOfBookComboBox_MouseMove(object sender, MouseEventArgs e)
        {
            BookTypeEnum SelectedBook = (BookTypeEnum)Enum.Parse(typeof(BookTypeEnum), this.KindOfBookComboBox.Text);
            if (SelectedBook == BookTypeEnum.NetBook)
            {
                this.Email_Telephone.Content = "Email";
            }
            else
            {
                this.Email_Telephone.Content = "PhoneNumber";
            }
        }
    }
}
