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
	public partial class FirstPage : ContentPage
	{
        public List<ToDoItems> toDoItems;
		public FirstPage ()
		{
            toDoItems = new List<ToDoItems>();
			InitializeComponent ();
		}
        public void OnSave(object o, EventArgs x)
        {
            toDoItems.Add(new ToDoItems(
                ToDoEntry.Text,
                Priority.Text,
                SetDueDate(
                    Date.Date,
                    Time.Time.Hours,
                    Time.Time.Minutes,
                    Time.Time.Seconds),
                false
                ));
            Clear();
        }

        private DateTime SetDueDate(DateTime date, int hour, int minute, int second)
        {
            DateTime value = new DateTime(date.Year, date.Month, date.Day, hour, minute, second);
            return value;
        }

        private void Clear()
        {
            ToDoEntry.Text = Priority.Text = String.Empty;
            Date.Date = DateTime.Now;
            Time.Time = new TimeSpan(
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second
            );
        }

        public void OnCancel(object o, EventArgs x)
        {

        }
        public void OnReview(object sender, EventArgs x)
        {
            var tempList = toDoItems;
        }
    }
}