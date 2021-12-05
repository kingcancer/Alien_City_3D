using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chegada : MonoBehaviour
{
    public void fimJogo()
    {
        SceneManager.LoadScene("Fim");
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            fimJogo();
        }
    }
}
