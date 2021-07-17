using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		string key = null;
		int best = 0;

		if (myList == null || myList.Count == 0)
			return "None";
		else if (myList.Count == 1)
		{
			foreach (var item in myList)
			{
				if (item.Value == 0)
				{
					return "None";
				}
			}
		}

		foreach (KeyValuePair<string, int> pair in myList)
		{
			if (pair.Value > best && pair.Value != 0)
			{
				key = pair.Key;
				best = pair.Value;
			}
		}
		return key;
	}
}
