using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hayman.Lighthouse.ViewModels
{
	public class ItemInfo
	{
		public ItemInfo(int id)
		{
			Id = id;
		}

		public int Id { get; protected set; }
		public string Label { get; set; }
		public string MetaItem { get; set; }
	}
}