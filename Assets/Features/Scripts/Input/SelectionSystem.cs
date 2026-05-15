using UnityEngine;

public class SelectionSystem : MonoBehaviour
{
    public static SelectionSystem Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void SelectGroup(string unitType) { }

    public void SelectAllArmy() { }

    public void ClearSelection() { }
}
