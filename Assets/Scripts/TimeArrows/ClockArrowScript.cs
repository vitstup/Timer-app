using System;
using UnityEngine;

public abstract class ClockArrowScript : MonoBehaviour
{
    protected float GetRotationByAngular(float angular)
    {
        return angular * -360f;
    }

    public abstract void SetPosition(DateTime time);
}