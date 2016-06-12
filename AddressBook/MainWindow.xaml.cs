using System;
using System.Collections.ObjectModel;
using System.IO;

using System.Windows;

using System.Xml.Serialization;

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
            this.NameBox.Text = "";
            string surname = this.SurnameTextBox.Text;
            this.SurnameTextBox.Text = "";

            BookTypeEnum SelectedBook = (BookTypeEnum)Enum.Parse(typeof(BookTypeEnum), this.KindOfBookComboBox.Text);
            if (SelectedBook == BookTypeEnum.NetBook)
            {
                try
                {
                    string email = this.NumberBox.Text;
                    InternetContact personNet = new InternetContact(name, surname, email);
                    NetBookCollection.Add(personNet);
                    this.NumberBox.Text = "";
                }
                catch
                {
                    MessageBox.Show("Put correct e-mail.", "Incorrect email");
                }

            }
            if (SelectedBook == BookTypeEnum.PhoneBook)
            {
                try
                {
                    uint phoneNumber = uint.Parse(this.NumberBox.Text);
                    NormalContact person = new NormalContact(name, surname, phoneNumber);
                    TeleBookCollection.Add(person);
                    this.NumberBox.Text = "";
                }
                catch
                {
                    MessageBox.Show("Put correct phone number.", "Incorrect phone number");
                }
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

        private void SaveTeleBookButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "TeleBook"; // Default file name
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filePath = dlg.FileName;

                TeleBookToXmlFile(filePath);
            }
        }

        private void TeleBookToXmlFile(string filePath)
        {
            using (var stream = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<NormalContact>));
                serializer.Serialize(stream , TeleBookCollection);
            }
        }

        private void SaveNetBookButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "NetBook"; // Default file name
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filePath = dlg.FileName;

                NetBookToXmlFile(filePath);
            }
        }

        private void NetBookToXmlFile(string filePath)
        {
            using (var stream = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<InternetContact>));
                serializer.Serialize(stream, NetBookCollection);
            }
        }

        private void KindOfBookComboBox_DropDownClosed(object sender, EventArgs e)
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
