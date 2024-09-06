using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPc : MonoBehaviour
{
    public ControleDialogo dialogo;
    public Falas fala;

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag=="Player"){
            dialogo.iniciarFalas(fala);
        }
    }

}
