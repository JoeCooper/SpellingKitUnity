using UnityEngine;
using NobleMuffins.SpellingKit;
using System.Globalization;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit.Unity {
	public class Spelling : ScriptableObject, ISpelling
	{
		public string text;
		public string[] locales;

		#region ISpelling implementation
		public string Text {
			get {
				return text;
			}
		}

		private IEnumerable<CultureInfo> localesCache;
		public IEnumerable<CultureInfo> Locales {
			get {
				localesCache = localesCache ?? NobleMuffins.SpellingKitUnity.Utilities.GetCultureInfosFromLocales (name + " (Spelling)", locales);
				return localesCache;
			}
		}
		#endregion


	}
}
