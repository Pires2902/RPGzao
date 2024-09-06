using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeuJoystick : MonoBehaviour
{
    public int vertical=0,horizontal=0;

    public void esquerda(){
        horizontal= -1;
    }

    public void direita(){
        horizontal= 1;
    }

    public void cima(){
        vertical= 1;
    }
    public void baixo(){
        vertical= -1;
    }

    public void diagesqcima(){
        vertical= 1;
        horizontal = -1;
    }

    public void parar(){
        vertical=horizontal=0;
    }
}
