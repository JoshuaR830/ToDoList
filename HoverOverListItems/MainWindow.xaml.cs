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
		public int Id { get; set; }
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

            items.Add(new Item { Name = "1", Id = 0 });
            items.Add(new Item { Name = "2", Id = 1 });
            items.Add(new Item { Name = "3", Id = 2 });

            listBox.DataContext = items;
        }

		//private void MouseDownButton(object sender, System.Windows.Input.MouseEventArgs e)
		//{
		//	items.Add(new Item { Name = "4" });
		//	listBox.DataContext = items;
		//}

		private void MouseOverButton(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Button1.Content = "Hover";
		}

		private void MouseDownButton(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			
		}

		private void MouseClicked(object sender, RoutedEventArgs e)
		{
			items.Add(new Item { Name = "Left Click" });
			listBox.DataContext = items;
		}

		private void MiddleClick(object sender, System.Windows.Input.MouseWheelEventArgs e)
		{
			items.Add(new Item { Name = "Middle Click" });
			listBox.DataContext = items;
		}

		private void TextClicked(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			items[1].Name = "Clicked text";
			listBox.DataContext = items;
		}

		private void ItemChanged(object sender, SelectionChangedEventArgs e)
		{
			var item = listBox.SelectedItem as Item;
			items[item.Id].Name = "Renamed";
			listBox.DataContext = items;

		}
	}
}
