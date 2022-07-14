using System.Windows;
using System.Windows.Controls;

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Select argument which handling at moment*/
        private enum Arg
        {
            First = 1,
            Second
        }

        /*What is the real arhument*/
        private enum Dot 
        {
            First = 1,
            Second,
            None
        }

        private double arg1, arg2, res;
        //private bool degFlag;
        private Arg arg = Arg.First;    //Firstly working with the first argument
        private Dot dot = Dot.None;

        private void but_del_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void but_result_Click(object sender, RoutedEventArgs e)
        {

        }

        private void but_clr_Click(object sender, RoutedEventArgs e)
        {
            /*Reset all flags and parameters enum*/
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            if(Arg.First == arg)
            {
                /*Filling in the first argument*/
                tb_arg1.Text += ((Button)sender).Content.ToString();
            }
            else tb_arg2.Text += ((Button)sender).Content.ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
