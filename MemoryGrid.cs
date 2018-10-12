using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Media;

namespace Memorygame
{
    public class MemoryGrid
    {
        private Grid grid;
        private int rows, cols;

        public object MEssagebox { get; private set; }

        public MemoryGrid(Grid grid, int rows, int cols)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;

            InitializeGrid();
            AddImage();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < cols; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void AddImage()
        {
            List<ImageSource> images = GetImagesList();
            for (int row  = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    Image backgroundImage = new Image();
                    backgroundImage.Source = new BitmapImage(new Uri("crusader.png", UriKind.Relative));
                    backgroundImage.MouseDown += new MouseButtonEventHandler(CardClick);
                    backgroundImage.Tag = images.First();
                    images.RemoveAt(0);
                    Grid.SetColumn(backgroundImage, cols);
                    Grid.SetRow(backgroundImage, rows);
                    grid.Children.Add(backgroundImage);
                }
            }
        }
        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
        }
        private List<ImageSource> GetImagesList()
        {
             List<ImageSource> images = new List<ImageSource>();

        for (int i = 0; i< 16; i++)
			{
            int imageNr = i % 8 + 1;
            ImageSource source = new BitmapImage(new Uri("Isaac/" + imageNr + ".png", UriKind.Relative));
                images.Add(source);
        
			}
            //RADOMIZE VOLGORDE
            
            return images;

        }
    }

}