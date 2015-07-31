using System;
using NobleMuffins.SpellingKit;
using UnityEngine;

namespace NobleMuffins.SpellingKit.Unity
{
	public class SampleSentence: ScriptableObject, ISampleSentence
	{
		public string beforeTheWord, afterTheWord;
		
		public string BeforeTheWord { get { return beforeTheWord; } }
		public string AfterTheWord { get { return afterTheWord; } }
	}
}

