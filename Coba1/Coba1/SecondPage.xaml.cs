using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coba1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
        public List<ToDoItems> ListToDo { get; set; }
		public SecondPage (List<ToDoItems> items)
		{
            ListToDo = items;
            BindingContext = this;
			InitializeComponent ();
		}

        //private void OnSelected(object sender, ItemTappedEventArgs e)
        //{
        //    var ToDoItems = e.Item as ToDoItems;
        //    DisplayAlert("Choosen!", ToDoItems.TaskName + "was selected!", "OK");
        //}
	}
}