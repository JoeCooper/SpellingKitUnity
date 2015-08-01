using System;
using NobleMuffins.SpellingKit;
using UnityEngine;
using System.Collections.Generic;
using System.Globalization;

namespace NobleMuffins.SpellingKit.Unity
{
	public class SampleSentence: ScriptableObject, ISampleSentence
	{
		public string beforeTheWord, afterTheWord;
		public string[] locales;
		
		public string BeforeTheWord { get { return beforeTheWord; } }
		public string AfterTheWord { get { return afterTheWord; } }

		private IEnumerable<CultureInfo> localesCache;
		public IEnumerable<CultureInfo> Locales {
			get {
				localesCache = localesCache ?? NobleMuffins.SpellingKitUnity.Utilities.GetCultureInfosFromLocales (name + " (Spelling)", locales);
				return localesCache;
			}
		}
	}
}

