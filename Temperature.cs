using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public float Temperaturenow = 36.6f;
    public float normTemp = 36.6f;
    public float critemp = 34f;
    public float FreezeSpeed = 0.05f;
    public int playerDamage = 2;
    public float freezeDamageTimer = 1;
    public float FreezeDamageDelay = 2;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        Temperaturenow -= FreezeSpeed * Time.deltaTime;
        if(Temperaturenow <= critemp) 
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer += FreezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        }
    }
}
