using System;
using System.Collections;
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

namespace HashMap_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(inputKey.Text,inputValue.Text);
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(inputKey.Text);
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            foreach(string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }

        private void InputKey_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void InputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
