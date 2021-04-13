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
using WpfLesson5.Models;

namespace WpfLesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Width { get; set; }
        public Brush Color { get; set; } = Brushes.LightGoldenrodYellow;
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book
            {
                Id=1,
                Author="Richter",
                Genre="Fun",
                Pages=1100,
                Publisher="Baku INC",
                Title="C# via CLR",
                ImagePath="book1.jpg"
            },
            new Book
            {
                Id=2,
                Author="Exupery",
                Genre="Not so Fun",
                Pages=650,
                Publisher="Baku INC",
                Title="Little Prince",
                ImagePath="book2.jpg"
            },
            new Book
            {
                Id=3,
                Author="GOF",
                Genre="Very Fun",
                Pages=700,
                Publisher="Baku INC",
                Title="Design Patterns Principles",
                ImagePath="book3.jpg"
            },
        };
        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
            //listView.ItemsSource = Books;

            Width = 800;

            //listbox.ItemsSource = Books;
        }
    }
}
