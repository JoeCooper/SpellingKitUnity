using UnityEngine;
using NobleMuffins.SpellingKit;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit.Unity {
	public class Word : ScriptableObject, IWord {

		public AudioClip utterance;
		public SampleSentence[] sampleSentences;
		public Spelling[] spellings;

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
