using UnityEngine;

public class Unit : MonoBehaviour
{
    public enum UnitType { Warrior, Archer, Lancer, Monk }

    public UnitType type;

    public int health;

    public void Move(Vector3 pos) { }

    public void Attack(GameObject target) { }

    public void TakeDamage(int dmg) { }
}