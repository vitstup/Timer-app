using System;
using UnityEngine;

public class HoursArrow : ClockArrowScript
{
    public override void SetPosition(DateTime time)
    {
        float angular = 0;
        if (time.Hour != 0) angular = time.Hour / 12f;
        transform.localRotation = Quaternion.Euler(0, 0, GetRotationByAngular(angular));
    }

}