using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace filemanipulation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File.Create(@"D:\movies\DK.txt");
            MessageBox.Show("File Created");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(@"D:\movies\SM.txt","Hi Welcome All TO Come Here");
            MessageBox.Show("View the File");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            File.Delete(@"D:\movies\DK.txt");
            MessageBox.Show("File Deleted");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Directory.CreateDirectory(@"D:\movies\Dotnet");
            MessageBox.Show("Folder Created");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if(Directory.Exists(@"D:\movies\Dotnet"))
            {
                MessageBox.Show("Already exist");
                Directory.Delete(@"D:\movies\Dotnet");
            }
            else
            {
                Directory.CreateDirectory(@"D:\movies\Dotnet");
                MessageBox.Show("Folder Created");
            }
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string[] list = Directory.GetDirectories(@"C:\Users\HP\OneDrive\Documents\IPL Analysis");
            
            string[] listfile = Directory.GetFiles(list[0]);
            MessageBox.Show(listfile[0]);
            string[] value = File.ReadAllLines(listfile[0]);
            MessageBox.Show(listfile[1]);

        }
    }
}