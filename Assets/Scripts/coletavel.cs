using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coletavel : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0,0,25)*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Player jogador = other.gameObject.GetComponent<Player>();
            jogador.pont += 1;
            Destroy(this.gameObject);
        }
    }
}
