using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Slider slider;

    public void setVida(float vida){
        slider.value = vida;
    }

    public void setVidaMax(float vidaMax){
        slider.maxValue = vidaMax;
        slider.value = vidaMax;
    }
}
