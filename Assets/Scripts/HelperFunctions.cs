using System.Collections.Generic;
using UnityEngine;

public static class HelperFunctions
{
    public static float Random(this Vector2 vector)
    {
        return UnityEngine.Random.Range(vector.x, vector.y);
    }

    public static Vector2 Random(this Vector4 vector)
    {
        float x = new Vector2(vector.x, vector.y).Random();
        float y = new Vector2(vector.z, vector.w).Random();
        return new Vector2(x, y);
    }

    public static T GetRandom<T>(this List<T> list)
    {
        int chosenIndex = UnityEngine.Random.Range(0, list.Count);
        return list[chosenIndex];
    }

    public static void Randomize<T>(this List<T> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            int chosenIndex = UnityEngine.Random.Range(0, list.Count);
            var temp = list[chosenIndex];
            list[chosenIndex] = list[i];
            list[i] = temp;
        }
    }
}
