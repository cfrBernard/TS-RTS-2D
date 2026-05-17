using UnityEngine;
using System;

public static class GameEvents
{
    public static Action OnDayStart;
    public static Action OnNightStart;
    public static Action OnTransitionToNight;
    public static Action OnTransitionToDay;

    public static Action OnWaveStart;

    public static Action OnUnitSelected;
}
