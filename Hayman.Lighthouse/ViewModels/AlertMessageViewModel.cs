using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hayman.Lighthouse.ViewModels
{
	public class AlertMessageViewModel
	{
		/// <summary>
		/// The content of the message
		/// </summary>
		public string Content { get; set; }
		
		/// <summary>
		/// Indicates the type of the Alert Message
		/// </summary>
		public MessageType Type { get; set; }

		/// <summary>
		/// Indicates whether the alert message should be closable
		/// </summary>
		public bool Closable { get; set; }
	}
}