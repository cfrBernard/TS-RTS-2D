using UnityEngine;

public class Building : MonoBehaviour
{
    public int health;

    public enum BuildingType { House, Tower, Barracks, Storage }
    public BuildingType type;

    public void TakeDamage(int dmg) { }
}
