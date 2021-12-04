using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    float vidaMax = 100f;
    public float vida;
    public float pont = 0;

    public float chaves = 0;

    public TextMeshProUGUI placar;

    public PlayerUI uiJogador; 
    public Coroutine coroutineDano;
    void Start()
    {
       vida = vidaMax;
       uiJogador.setVidaMax(vidaMax);
    }

    private void Update() {
        placar.text = pont.ToString();
    }

    public void Dano(float dmg){
        vida -= dmg;
        uiJogador.setVida(vida);
    }

    public IEnumerator DanoPassivo(float dmg, float temp){
        while(true){
            vida -= dmg; 
            uiJogador.setVida(vida);
            yield return new WaitForSeconds(temp);
        }
        
    }

}
