using UnityEngine;

public class CommandSystem : MonoBehaviour
{
    public static CommandSystem Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void MoveSelectedUnits(Vector3 position) { }

    public void AttackMove(Vector3 position) { }
}
