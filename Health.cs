using UnityEngine;

public class Health : MonoBehaviour
{

    private int health = 10;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:" + health);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
