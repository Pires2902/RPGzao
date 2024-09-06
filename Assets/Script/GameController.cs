using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

    public Slider barraVida;
    public int vidaAtual, vidaMax;



    void Start()
    {
        vidaAtual = vidaMax;
        barraVida.maxValue = vidaMax;
        barraVida.value = vidaAtual;


    }

    public void dano(int dano)
    {
        vidaAtual -= dano;
        barraVida.value = vidaAtual;
    }
}
