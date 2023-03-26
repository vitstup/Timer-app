using System;
using UnityEngine;

public class MinutesArrow : ClockArrowScript
{
    public override void SetPosition(DateTime time)
    {
        float angular = 0;
        if (time.Minute != 0) angular = time.Minute / 60f;
        transform.localRotation = Quaternion.Euler(0, 0, GetRotationByAngular(angular));
    }
}