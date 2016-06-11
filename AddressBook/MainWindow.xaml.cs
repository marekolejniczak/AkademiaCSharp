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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<NormalContact> TeleBookCollection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            TeleBookCollection = new ObservableCollection<NormalContact>();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            string name = this.NameBox.Text;
            string surname = this.SurnameTextBox.Text;
            uint phoneNumber = uint.Parse(this.NumberBox.Text);
            string street = this.StreetBox.Text;
            
            NormalContact person = new NormalContact(name, surname, street , phoneNumber);
            TeleBookCollection.Add(person);
        }
    }
}
