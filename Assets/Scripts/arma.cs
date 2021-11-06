using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{
    public GameObject projetil;
    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
           Instantiate(projetil, this.transform.GetChild(0).position, this.transform.GetChild(0).rotation);      
        }
    }
}
