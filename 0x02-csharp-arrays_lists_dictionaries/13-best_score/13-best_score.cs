using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		string key = null;
		int best = 0;

		foreach (KeyValuePair<string, int> pair in myList)
		{
			if (pair.Value >= best)
			{
				key = pair.Key;
				best = pair.Value;
			}
		}
		return key;
	}
}
