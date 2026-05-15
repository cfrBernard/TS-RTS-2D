using UnityEngine;

public class TimeCycleSystem : MonoBehaviour
{
    public enum DayState { Day, TransitionToNight, Night, TransitionToDay }
    public DayState CurrentState;

    public float dayDuration;
    public float nightDuration;

    public System.Action OnDayStart;
    public System.Action OnNightStart;

    void Update()
    {
        // cycle logic placeholder
    }

    void StartDay() { }
    void StartNight() { }
}
