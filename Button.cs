using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public Animator button;
    public Animator toOpen;
    // Start is called before the first frame update
    void Start()
    {
        button.enabled = false; 
    }
    private void OnTriggerEnter(Colider.other)
    {
        button.enabled = true;
        toOpen.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
