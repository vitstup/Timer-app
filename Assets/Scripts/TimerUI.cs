using System;
using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public static TimerUI instance;

    [SerializeField] private TextMeshProUGUI TimerText;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void SetTimerText(DateTime time)
    {
        TimerText.text = time.ToString("T");
    }

}