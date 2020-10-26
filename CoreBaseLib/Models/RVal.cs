using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBaseLib.Models
{
	public class RVal 
	{
		/// <summary>
		/// 回傳狀態
		/// </summary>
		public bool RStatus { get; set; }
		
		/// <summary>
		/// 回傳訊息
		/// </summary>
		public string RMsg { get; set; }

		/// <summary>
		/// 回傳的動態物件
		/// </summary>
		public dynamic DVal { get; set; }
	}
}
