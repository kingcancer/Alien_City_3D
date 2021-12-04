using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chave : MonoBehaviour
{
     void Update()
    {
        transform.Rotate(new Vector3(0,-25,0)*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Player jogador = other.gameObject.GetComponent<Player>();
            jogador.chaves += 1;
            Destroy(this.gameObject);
        }
    }
}

