using UnityEngine;
using NobleMuffins.SpellingKit;
using System.Globalization;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit.Unity {
	public class Spelling : ScriptableObject, ISpelling
	{
		private readonly static CultureInfo[] EmptyLocales = new CultureInfo[0];

		public string text;
		public string[] locales;

		#region ISpelling implementation
		public string Text {
			get {
				return text;
			}
		}

		public IEnumerable<CultureInfo> Locales {
			get {
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
							Debug.LogErrorFormat("Spelling '{0}' has invalid locale '{1}'", name, locale);
						}
						catch(System.Exception ex) {
							Debug.LogException(ex);
						}
					}
				}
				return cultureInfos;
			}
		}
		#endregion


	}
}
