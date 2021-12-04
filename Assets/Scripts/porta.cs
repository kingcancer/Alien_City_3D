using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{
    Animator anim;

    private void Start() {
        GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Player jogador = other.gameObject.GetComponent<Player>();
            if(jogador.chaves == 2)
            {
                anim = GetComponentInParent<Animator>();
                anim.SetBool("podeAbrir", true);
            }
        }
    }
}
