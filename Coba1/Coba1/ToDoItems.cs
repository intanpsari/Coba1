using System;
using System.Collections.Generic;
using System.Text;

namespace Coba1
{
    public class ToDoItems
    {
        public string TaskName { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDeleted { get; set; }

        public ToDoItems(string taskName, string priority, DateTime dueDate, bool isDeleted)
        {
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            IsDeleted = IsDeleted;
        }
    }
}
