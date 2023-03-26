using System;
using System.Collections;
using UnityEngine;

public class TimeGetter : MonoBehaviour
{
    public static TimeGetter instance;

    private TimeParser[] parsers;

    // difference beetwen time in parser and device
    private double SecondsDiff;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        parsers = new TimeParser[] { new Parser1(), new Parser2() };

        StartCoroutine(HourCheck());
    }

    public DateTime GetCurrentTime()
    {
        var curTime = DateTime.Now;
        curTime = curTime.AddSeconds(SecondsDiff);
        return curTime;
    }

    private IEnumerator HourCheck()
    {
        var deviceTime = DateTime.Now;

        var parserTime = parsers[UnityEngine.Random.Range(0, parsers.Length)].GetTime();

        SecondsDiff = (parserTime - deviceTime).TotalSeconds;

        Debug.Log("Secons difference beetwen parsed value and device: " + SecondsDiff);

        yield return new WaitForSecondsRealtime(3600f);

        StartCoroutine(HourCheck());
    }
}