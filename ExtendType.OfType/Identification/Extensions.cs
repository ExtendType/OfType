using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfType.Identification
{
	public static class Extensions
	{
		/// <summary>
		/// Converts the supplied type with optional member and ordinal into an identification key
		/// </summary>
		public static string ToKey(this Type instance, string member = null, string ordinal = null)
		{
			Contract.Requires(instance != null);
			StringBuilder builder= new StringBuilder(instance.FullName);
			if (!String.IsNullOrWhiteSpace(member)) builder.Append('.').Append(member);
			if (!String.IsNullOrWhiteSpace(member) && !String.IsNullOrWhiteSpace(ordinal)) builder.Append('[').Append(ordinal).Append(']');
			return builder.ToString();
		}
	}
}
