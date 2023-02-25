using System;
namespace CRUD_app.Models
{
	public class Task
	{
        public int Id
        {
            get;
             set;
        }
        public string TaskName
        {
            get;
             set;
        }
        public string TaskExplanation { get; set; }

        public Task()
        {

        }

    }
}

