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
        tiro.transform.Translate(Vector3.forward*velocidade*Time.deltaTime);
       
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("parede")){
            
            Destroy(this.gameObject);
        }
        if(!other.gameObject.CompareTag("Player")){
            Destroy(this.gameObject);
        }
        
    }
}
