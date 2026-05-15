using System.Collections.Generic;
using UnityEngine;

public class Squad : MonoBehaviour
{
    public List<Unit> units = new List<Unit>();

    public Vector3 targetPosition;

    public enum SquadState { Idle, Moving, Defending }
    public SquadState state;

    public void SetTarget(Vector3 pos)
    {
        targetPosition = pos;
    }

    public void AddUnit(Unit u)
    {
        units.Add(u);
    }
}