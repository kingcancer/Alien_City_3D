using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadilha : MonoBehaviour
{    public float dano = 5f;
    public float temp =3f;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Player jogador = other.gameObject.GetComponent<Player>();
            if(jogador.coroutineDano == null)
            {
                jogador.coroutineDano = StartCoroutine(jogador.DanoPassivo(dano,temp));
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        {   
            Player jogador = other.gameObject.GetComponent<Player>();
            if(jogador.coroutineDano != null)
            {
                StopCoroutine(jogador.coroutineDano);
                jogador.coroutineDano = null;
            }
        }
    }
    
}
