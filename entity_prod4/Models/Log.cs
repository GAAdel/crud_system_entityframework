using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_prod4.Models
{
	public class Log
	{
		public int ID { get; set; }
		public string Date { get; set; }
		public string LoginTime { get; set; }
		public string LogoutTime { get; set; }
		public int TimeSpent { get; set; }
		public bool IsCrash { get; set; }
		public string Reason { get; set; }
		public int UserID { get; set; }

	}
}
