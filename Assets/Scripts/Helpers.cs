using UnityEngine;

public static class Helpers
{
    public static void DeleteChilds(Transform transform)
    {
        foreach (Transform child in transform) Object.Destroy(child.gameObject);
    }
}
