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
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace SEGCoin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool keys = false;
        public void hillow3(string a,string b)
        {
            StreamWriter sw1 = new StreamWriter(a);
            sw1.Write(b);
            sw1.Close();
        }
        public string hi1(string a)
        {
            StreamReader sw1 = new StreamReader(a);
            string walet = sw1.ReadLine();
            sw1.Close();
            return walet;
        }
        public MainWindow()
        {
            InitializeComponent();
            Uri iconUri = new Uri(".png" , UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
            string a = hi1("Key.DAT");
            if (a == "true")
            {
                keys = true;
            }else if (a == "false")
            {
                keys = false;
            }
            SEGCoinsnum.Text = hi1("Walet.DAT");
            addedtran.Text = hi1("TRAN.DAT");
        }
        private void keys_open(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "";
            dlg.Filter = "Walet files (*.Dat)|*.Dat";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                if (hi1(dlg.FileName) == "segcoin::owrfcednwnddnkcqw:34364")
                {
                    keys = true;
                    hillow3("Key.DAT","true");
                }else
                {
                    keys = false;
                }
            }
        }
        private void TranslateClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1 s$ = 1 SEGCoin","INFO");
            MessageBox.Show("1 $ = 60 s$\n1 € = 72,55014326647564 s$\n1s$ = 1.2215 ₽","INFO");
        }
        private void opendat(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "";
            dlg.Filter = "Walet files (*.Dat)|*.Dat";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                SEGCoinsnum.Text = hi1(dlg.FileName);
            }
        }
        private void viewid(object sender, RoutedEventArgs e)
        {
            // segcoin::15букв:5цифр
            MessageBox.Show("ID : segcoin::owrfcednwnddnkcqw:34364\nURL : owrfcednwnddnkcqw:34364\nWalet : "+SEGCoinsnum.Text,"INFO");
        }
        private void addtran__(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added !!!","INFO");
            addedtran.Text = addedtran.Text + "Name tran : "+nametran.Text+" ; Sum tran : "+sumtran.Text+" ;\n";
            hillow3("TRAN.DAT",addedtran.Text);
        }
        private void setcoin(object sender, RoutedEventArgs e)
        {
            StreamWriter sw2 = new StreamWriter("Walet.DAT");
            sw2.Write(coinstoset.Text);
            SEGCoinsnum.Text = coinstoset.Text;
            sw2.Close();
        }
    }
}