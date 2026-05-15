using UnityEngine;

public class ResourceSystem : MonoBehaviour
{
    public int wood;
    public int food;

    public void AddWood(int amount) { }
    public void AddFood(int amount) { }

    public bool SpendWood(int amount) => true;
}
