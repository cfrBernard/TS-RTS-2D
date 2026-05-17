using UnityEngine;

public class TimeCycleSystem : MonoBehaviour
{
    public enum DayState
    {
        Day,
        TransitionToNight,
        Night,
        TransitionToDay
    }

    [Header("Current State")]
    public DayState currentState;

    [Header("Durations")]
    [SerializeField] private float dayDuration = 10f;
    [SerializeField] private float transitionToNightDuration = 5f;
    [SerializeField] private float nightDuration = 10f;
    [SerializeField] private float transitionToDayDuration = 5f;

    private float timer;

    // --------------------
    // PUBLIC GETTERS
    // --------------------

    public float RemainingTime => timer;

    public float StateProgress
    {
        get
        {
            float duration = GetCurrentStateDuration();

            if (duration <= 0f)
                return 1f;

            return 1f - (timer / duration);
        }
    }

    // --------------------
    // UNITY
    // --------------------

    private void Start()
    {
        StartDay();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            AdvanceState();
        }

        // DEBUG
        // Debug.Log($"{currentState} | Remaining: {RemainingTime:F1} | Progress: {StateProgress:F2}");
    }

    // --------------------
    // STATE FLOW
    // --------------------

    private void AdvanceState()
    {
        switch (currentState)
        {
            case DayState.Day:
                StartTransitionToNight();
                break;

            case DayState.TransitionToNight:
                StartNight();
                break;

            case DayState.Night:
                StartTransitionToDay();
                break;

            case DayState.TransitionToDay:
                StartDay();
                break;
        }
    }

    // --------------------
    // STATE STARTS
    // --------------------

    private void StartDay()
    {
        currentState = DayState.Day;
        timer = dayDuration;

        Debug.Log("🌞 DAY START");

        GameEvents.OnDayStart?.Invoke();
    }

    private void StartTransitionToNight()
    {
        currentState = DayState.TransitionToNight;
        timer = transitionToNightDuration;

        Debug.Log("🌆 TRANSITION TO NIGHT");

        GameEvents.OnTransitionToNight?.Invoke();
    }

    private void StartNight()
    {
        currentState = DayState.Night;
        timer = nightDuration;

        Debug.Log("🌙 NIGHT START");

        GameEvents.OnNightStart?.Invoke();
    }

    private void StartTransitionToDay()
    {
        currentState = DayState.TransitionToDay;
        timer = transitionToDayDuration;

        Debug.Log("🌅 TRANSITION TO DAY");

        GameEvents.OnTransitionToDay?.Invoke();
    }

    // --------------------
    // HELPERS
    // --------------------

    private float GetCurrentStateDuration()
    {
        switch (currentState)
        {
            case DayState.Day:
                return dayDuration;

            case DayState.TransitionToNight:
                return transitionToNightDuration;

            case DayState.Night:
                return nightDuration;

            case DayState.TransitionToDay:
                return transitionToDayDuration;
        }

        return 1f;
    }
}