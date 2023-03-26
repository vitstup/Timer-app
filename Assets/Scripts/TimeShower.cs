using System;
using System.Collections;
using UnityEngine;

public class TimeShower : MonoBehaviour
{
    [SerializeField] private ClockArrowScript HourArrow;
    [SerializeField] private ClockArrowScript MinutesArrow;
    [SerializeField] private ClockArrowScript SecondsArrow;

    private void Start()
    {
        StartCoroutine(SecondsUpdate());
    }

    private void SetArrowsPosition(DateTime time)
    {
        HourArrow.SetPosition(time);
        MinutesArrow.SetPosition(time);
        SecondsArrow.SetPosition(time);
    }

    private void ShowTime()
    {
        DateTime time = TimeGetter.instance.GetCurrentTime();

        SetArrowsPosition(time);
        TimerUI.instance.SetTimerText(time);
        AlarmScript.instance.CheckAlarm(time);
    }

    private IEnumerator SecondsUpdate()
    {
        ShowTime();
        yield return new WaitForSecondsRealtime(1f);
        StartCoroutine(SecondsUpdate());
    }
}