using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Net.Mime.MediaTypeNames;

namespace Wpf_Training
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
            public MainWindow()
            {
                InitializeComponent();
                foreach (UIElement el in MainRoot.Children)
                {
                    if (el is Button)
                    {
                        ((Button)el).Click += Button_Click;
                    }
                }
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                string str = (string)((Button)e.OriginalSource).Content;
                if (str == "C")
                    TextBox2.Text = "";
               
            else if (str == "=")
                {
                    string value = new DataTable().Compute(TextBox2.Text, null).ToString();
                    TextBox1.Text = value;
                }

            else if(str == "CE")
            {
                TextBox1.Text = "";
            }

            else if (str == "<")
            {

                string value = new DataTable().Compute(TextBox2.Text, null).ToString();
               
                TextBox2.Text = value.Remove(value.Length -1,1);
               


            }

            else
                TextBox2.Text += str;

            

            
        }
        
    }
}
