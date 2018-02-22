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

namespace stringsDemoProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string myFirstString;//Declare a string variable
        
        public MainWindow()
        {
            myFirstString = "Oh what a beautiful Morning!!!";//Assign a value to the variable
            

            InitializeComponent();
            Console.WriteLine(myFirstString);
            mainWindow.Title = myFirstString;
        }

        private void btnSetName_Click(object sender, RoutedEventArgs e)
        {
            myFirstString = txtFirstName.Text;
            if (myFirstString == "McT") {
                MessageBox.Show("So good to see you " + myFirstString);
            }
            mainWindow.Title = "Hello " + myFirstString;
            btnSetName.Content = myFirstString + " change the title";
            //MessageBox.Show(myFirstString.IndexOf("B").ToString());

            //Use substring to get part of a word
            string strDog = "Golden Retriever";
            string temp = "";
            Console.WriteLine("Length: " + strDog.Length);
            //forwards
            for (int i = 0; i < strDog.Length; i--)
            {
                temp += strDog.Substring(i, 1) + "\n";

            }
            //MessageBox.Show(temp);
            //backwards
            temp = "";
            for (int i = strDog.Length - 1; i >= 0; i--)
            {
                temp += strDog.Substring(i, 1) + "\n";

            }
            //MessageBox.Show(temp);

            //splits - get individual words
            string names = "Couper,Andrew,Suzy";
            string[] strName = names.Split(new char[] { ',' });
            strName[0] = strName[0].Replace("C", "S");
            MessageBox.Show(strName[0].ToLower());
        }
    }
}

