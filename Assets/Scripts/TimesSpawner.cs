using TMPro;
using UnityEngine;

public class TimesSpawner : MonoBehaviour
{
    [SerializeField] private Transform ClockFace;

    [SerializeField] private TextMeshPro ClockNumberPrefab;

    [SerializeField] private float DistanceFromClockFace = 3f;

    private const int ClockFaceNumbersCount = 12;

    [ContextMenu("Initialize clock numbers")]
    private void InitializeClockNumbers()
    {
        // Helpers.DeleteChilds(ClockFace); // won't work from edit mode

        for (int i = 0; i < ClockFaceNumbersCount; i++)
        {
            var currentNum = Instantiate(ClockNumberPrefab, ClockFace, false);
            float angular = (360f / ClockFaceNumbersCount) * i;
            currentNum.transform.localPosition = GetAngularPosition(angular, DistanceFromClockFace);
            if (i == 0) { currentNum.text = ClockFaceNumbersCount.ToString(); continue; }
            currentNum.text = i.ToString();
        }

    }

    private Vector2 GetAngularPosition(float angular, float radius)
    {
        float x = radius * Mathf.Sin(angular * Mathf.Deg2Rad);
        float y = radius * Mathf.Cos(angular * Mathf.Deg2Rad);
        return new Vector2(x, y);
    }
}