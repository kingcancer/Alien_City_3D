using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parede : MonoBehaviour
{
    public float vida = 5;
    
    void Update()
    {
        if(vida <=0)
        {
            Destroy(this.gameObject);
        }
    }
}
