using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Enemies Health = "+ currentHealth);
        if(currentHealth <=0)
        {
            Debug.Log("Enemy has Died!");
            Time.timeScale = 0f;
            //Destroy(gameObject,deathDelay);
        }
    }
}