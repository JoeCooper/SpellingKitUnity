using UnityEngine;
using UnityEditor;
using System.IO;

namespace NobleMuffins.SpellingKit.Unity {
	public static class Utilities {
		[MenuItem("Assets/Create/Spelling")]
		public static void CreateSpellingInstance()
		{
			CreateAsset<Spelling>("Spelling");
		}
		
		[MenuItem("Assets/Create/Word")]
		public static void CreateWordInstance()
		{
			CreateAsset<Word>("Word");
		}
		
		[MenuItem("Assets/Create/Dictionary")]
		public static void CreateDictionaryInstance()
		{
			CreateAsset<Dictionary>("Dictionary");
		}

		
		private static void CreateAsset<T> (string typeName = null) where T : ScriptableObject
		{
			T asset = ScriptableObject.CreateInstance<T> ();
			
			string path = AssetDatabase.GetAssetPath (Selection.activeObject);
			if (path == "") 
			{
				path = "Assets";
			} 
			else if (Path.GetExtension (path) != "") 
			{
				path = path.Replace (Path.GetFileName (AssetDatabase.GetAssetPath (Selection.activeObject)), "");
			}
			
			string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath (path + "/New " + (typeName ?? typeof(T).ToString()) + ".asset");
			
			AssetDatabase.CreateAsset (asset, assetPathAndName);
			
			AssetDatabase.SaveAssets ();
			EditorUtility.FocusProjectWindow ();
			Selection.activeObject = asset;
		}
	}
}