using UnityEngine;
using NobleMuffins.SpellingKit;
using System.Collections.Generic;
using System.Globalization;

namespace NobleMuffins.SpellingKit.Unity {
	public class Word : ScriptableObject, IWord {

		public AudioClip utterance;
		public SampleSentence[] sampleSentences;
		public Spelling[] spellings;

		public ISpelling GetSpelling(CultureInfo preferredCulture = null)
		{
			return NobleMuffins.SpellingKit.Utilities.GetSpelling (this, preferredCulture);
		}

		public ISampleSentence GetSampleSentence(CultureInfo preferredCulture)
		{
			return NobleMuffins.SpellingKit.Utilities.GetSampleSentence (this, preferredCulture);
		}

		#region IWord implementation
		public IEnumerable<ISampleSentence> SampleSentences {
			get {
				return sampleSentences;
			}
		}

		public IEnumerable<ISpelling> Spellings {
			get {
				return spellings;
			}
		}
		#endregion
		
	}
}
