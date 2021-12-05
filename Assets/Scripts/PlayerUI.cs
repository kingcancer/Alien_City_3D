using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    public Slider slider;

    public void setVida(float vida){
        slider.value = vida;
        if(vida <= 0){
            SceneManager.LoadScene("Jogo");
        }
    }

    public void setVidaMax(float vidaMax){
        slider.maxValue = vidaMax;
        slider.value = vidaMax;
    }
}
