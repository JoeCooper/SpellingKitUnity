using UnityEngine;
using NobleMuffins.SpellingKit;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit.Unity {
	public class Word : ScriptableObject, IWord {

		public AudioClip utterance;
		public Spelling[] spellings;

		#region IWord implementation
		public IEnumerable<ISpelling> Spellings {
			get {
				return spellings;
			}
		}
		#endregion
		
	}
}
