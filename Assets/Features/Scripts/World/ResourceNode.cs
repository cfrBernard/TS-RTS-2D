using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    public enum ResourceType { Wood, Food }

    public ResourceType type;

    public int amount;

    public int Harvest(int value) => value;
}
