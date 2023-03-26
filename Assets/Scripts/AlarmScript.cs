using System;
using UnityEngine;

public class AlarmScript : MonoBehaviour
{
    public static AlarmScript instance;

    public DateTime alarm { get; private set; }
    public bool haveAlarm { get; private set; }

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void SetAlarm(DateTime time)
    {
        haveAlarm = true;
        alarm = time;
    }

    public void CheckAlarm(DateTime time)
    {
        if (!haveAlarm) return;

        if (alarm.Hour == time.Hour && alarm.Minute == time.Minute)
        {
            haveAlarm = false;

            Debug.Log("Alarm");
        }
    }
}