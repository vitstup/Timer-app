using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlarmUI : MonoBehaviour
{
    [SerializeField] private GameObject StandartPanel;
    [SerializeField] private GameObject AlarmPanel;

    [SerializeField] private TMP_InputField AlarmInput;

    private void TrySetAlarm(string value)
    {
        if (!DateTime.TryParse(value, out DateTime dateTime)) { Debug.LogWarning("Alarm not setted, try again"); return; }

        AlarmScript.instance.SetAlarm(dateTime);
        Debug.Log("Alarm setted to: " + AlarmScript.instance.alarm.ToString("T"));
    }

    public void OpenAlarmUI()
    {
        if (AlarmScript.instance.haveAlarm) return;
        StandartPanel.SetActive(false);
        AlarmPanel.SetActive(true);

        var inputTime = TimeGetter.instance.GetCurrentTime().AddHours(1);
        AlarmInput.text = inputTime.ToString("t");
    }

    private void CloseAlarmUI()
    {
        StandartPanel.SetActive(true);
        AlarmPanel.SetActive(false);
    }

    public void Done()
    {
        TrySetAlarm(AlarmInput.text);

        CloseAlarmUI();
    }
}