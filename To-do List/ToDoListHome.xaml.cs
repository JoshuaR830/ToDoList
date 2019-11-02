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

namespace To_do_List
{
	/// <summary>
	/// Interaction logic for ToDoListHome.xaml
	/// </summary>
	public partial class ToDoListHome : Page
	{
		public ToDoListHome()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ToDoListReportPage toDoListReportPage = new ToDoListReportPage(this.peopleListBox.SelectedItem);
			this.NavigationService.Navigate(toDoListReportPage);
		}
	}
}
