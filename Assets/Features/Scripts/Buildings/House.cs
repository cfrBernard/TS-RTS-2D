using UnityEngine;

public class House : MonoBehaviour
{
    public enum JobType { Wood, Food, Repair }
    public JobType jobPriority;

    public GameObject pawn;
}
