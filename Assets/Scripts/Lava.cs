using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public float dano = 1f;
    public float temp =1f;
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
