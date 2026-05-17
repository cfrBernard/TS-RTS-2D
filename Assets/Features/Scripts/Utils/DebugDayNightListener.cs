using UnityEngine;

public class DebugDayNightListener : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnDayStart += HandleDayStart;
        GameEvents.OnNightStart += HandleNightStart;
        GameEvents.OnTransitionToNight += HandleTransitionToNight;
        GameEvents.OnTransitionToDay += HandleTransitionToDay;
    }

    private void OnDisable()
    {
        GameEvents.OnDayStart -= HandleDayStart;
        GameEvents.OnNightStart -= HandleNightStart;
        GameEvents.OnTransitionToNight -= HandleTransitionToNight;
        GameEvents.OnTransitionToDay -= HandleTransitionToDay;
    }

    private void HandleDayStart()
    {
        Debug.Log("Listener -> DAY received");
    }

    private void HandleNightStart()
    {
        Debug.Log("Listener -> NIGHT received");
    }

    private void HandleTransitionToNight()
    {
        Debug.Log("Listener -> TRANSITION TO NIGHT received");
    }

    private void HandleTransitionToDay()
    {
        Debug.Log("Listener -> TRANSITION TO DAY received");
    }
}