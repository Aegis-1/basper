using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1
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
            List<ImageSource> imagex = GetImagesList();
            for (int i = 0; i < rows; i++)
            {
                for (int i = 0; i < cols; i++)
                {
                    Image backgroundImage = new Image();
                    backgroundImage.Source = new BitmapImage(new Uri("mapjevanimage/image.pn", UriKind.relative));
                    backgroundImage.MouseDown +=new System.Windows.Input.MousebuttonEventHandler(cardclick);
                    backgroundImage.Tag = images.First();
                    Grid.SetColumn(backgroundImage, cols);
                    Grid.SetRow(backgroundImage, rows);
                    grid.Children.Add(backgroundImage);
                }
            }
        }
        private void Cardclick(object senden, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front
        }
        private List<ImageSource> GetImagesList()
        {
            private List<ImageSource> images = new List<ImageSource>();

        for (int i = 0; i<16; i++)
			{
            for ImageNr = if % 8 + 1;
            ImageSource source = new BitMapImage(new Uri("naam van image", UriKind.Relative()));
        Images.Add(Source);
			}
    return Images;

        }
    }
}
