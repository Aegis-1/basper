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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        const int Nr_Of_Rows = 4;
        const int Nr_Of_Cols = 4;
        MemoryGrid grid;
        public MainWindow()
        {
            InitializeComponent();
            grid = new MemoryGrid(GameGrid, Nr_Of_Rows, Nr_Of_Cols);    
        }
    }
}
