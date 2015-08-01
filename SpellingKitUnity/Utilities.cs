using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace NobleMuffins.SpellingKitUnity
{
	internal static class Utilities
	{
		private readonly static CultureInfo[] EmptyLocales = new CultureInfo[0];

		public static IEnumerable<CultureInfo> GetCultureInfosFromLocales(string sourceName, string[] locales)
		{
			ICollection<CultureInfo> cultureInfos;
			if(locales == null || locales.Length == 0) {
				cultureInfos = EmptyLocales;
			} else {
				cultureInfos = new List<CultureInfo>(locales.Length);
				foreach(var locale in locales) {
					try {
						var cultureInfo = CultureInfo.GetCultureInfo(locale);
						cultureInfos.Add(cultureInfo);
					}
					catch(System.ArgumentException) {
						Debug.LogErrorFormat("Item '{0}' has invalid locale '{1}'", sourceName, locale);
					}
					catch(System.Exception ex) {
						Debug.LogException(ex);
					}
				}
			}
			return cultureInfos;
		}
	}
}

