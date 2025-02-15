using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{

    public float lifeTime = 10;
    public float HeatPower = 0.01f;

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
