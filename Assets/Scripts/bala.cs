using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody tiro;
    public float velocidade;
    void Start()
    {
        tiro = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
        tiro.velocity = this.transform.forward*velocidade;
        Destroy(this.gameObject, 1.0f);
    }

    private void OnTriggerEnter(Collider other) {

        if(!other.gameObject.CompareTag("Player")){
            Destroy(this.gameObject);
            if(other.gameObject.CompareTag("parede"))
            {
                other.GetComponent<parede>().vida--;
            }
        }
        
    }
}
