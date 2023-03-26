using System;
using UnityEngine;

public class SecondsArrow : ClockArrowScript
{
    public override void SetPosition(DateTime time)
    {
        float angular = 0;
        if (time.Second != 0) angular = time.Second / 60f;
        transform.localRotation = Quaternion.Euler(0, 0, GetRotationByAngular(angular));
    }
}