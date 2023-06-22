using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace crm_project.Models
{
	public class CustomersModel
	{
		public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string address { get; set; }

        public string company { get; set; }

        public DateTime created_at { get; set; }
    }
}

