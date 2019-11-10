using System.Collections.Generic;
using System.Windows;

namespace YouTube_Tutorial
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{

			// Don't use list before it is initialised or it will be null
			InitializeComponent();

			LstPersons.ItemsSource = GetPersonList();
		}


		public List<Person> GetPersonList()
		{
			var personList = new List<Person> ();

			personList.Add(new Person { Name = "Joshua", Email = "j2osh@gmail.com" });
			personList.Add(new Person { Name = "Bob", Email = "bob@gmail.com" });

			return personList;
		}

		private void NewPersonSelected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			var person = LstPersons.SelectedItem as Person;
			TxtName.Text = person.Name;
			TxtEmail.Text = person.Email;
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public string Email { get; set; }
	}

}
