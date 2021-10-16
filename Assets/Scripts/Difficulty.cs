using UnityEngine;

//Sets difficulty

public static class Difficulty
{
	static float secondsToMaxDifficulty = 60;
	public static float GetDifficulty()
	{ 
		return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
	}
}
