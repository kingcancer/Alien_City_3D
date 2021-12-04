using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaveUI : MonoBehaviour
{
    
    public Player jogador;
 

    private void Update() {
        if(jogador.chaves == 1){
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            if(jogador.chaves == 2)
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
    
}
