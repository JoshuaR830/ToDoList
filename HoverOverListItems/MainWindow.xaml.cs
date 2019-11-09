using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace HoverOverListItems
{
    public class HoverOverItemsInList<T> : ListBox
        where T : class
    {
        public HoverOverItemsInList()
        {

        }
    }
    public class HoverList : HoverOverItemsInList<Item> { }

    public class Item
    {
        public string Name { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public IList<Item> items = new ObservableCollection<Item>();
        public MainWindow()
        {
            InitializeComponent();

            items.Add(new Item { Name = "1" });
            items.Add(new Item { Name = "2" });
            items.Add(new Item { Name = "3" });

            listBox.DataContext = items;
        }
    }
}
