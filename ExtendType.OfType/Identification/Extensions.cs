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
		/// Creates a standard syntax for generating a unique key based on type and other provided information
		/// </summary>
		/// <remarks>
		/// The value provided from this method can be used in a cache, session or other dictionary collection
		/// </remarks>
		/// <param name="instance">Type used to create key</param>
		/// <param name="name">Name of member or other distinguishing variation on type</param>
		/// <param name="ordinal">Ordinal key on member that may be required to make key unique</param>
		/// <returns>
		/// Returns a unqiue string based on type, name and ordinal information
		/// Example: MyAssembly.MyType.MyName[MyOrdinal]
		/// </returns>
		public static string KeyOn(this Type instance, string name = null, string ordinal = null)
		{
			Contract.Requires<ArgumentNullException>(instance != null);
			StringBuilder builder = new StringBuilder(instance.FullName);
			if (!String.IsNullOrWhiteSpace(name)) builder.Append('.').Append(name);
			if (!String.IsNullOrWhiteSpace(name)) builder.Append('[').Append(ordinal).Append(']');
			return builder.ToString();
		}
	}
}
