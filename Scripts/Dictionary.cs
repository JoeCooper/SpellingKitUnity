using UnityEngine;
using NobleMuffins.SpellingKit;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit.Unity {
	public class Dictionary : ScriptableObject, IDictionary {

		public Word[] words;

		#region IDictionary implementation
		public IEnumerable<IWord> Words {
			get {
				return words;
			}
		}
		#endregion
		
	}
}
