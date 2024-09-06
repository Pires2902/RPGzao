using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meleca : MonoBehaviour
{
    [SerializeField]
    Transform pegar;
    [SerializeField]
    int speed=3;
     
    public float entreNos;
    bool euVi=false;

    public GameController controle;

    void Update()
    {
        entreNos=Vector2.Distance(transform.position,pegar.position);
        if(entreNos < 4)
        {
          euVi=true;
        }else if(entreNos > 8)
        {
            euVi=false;
        }
        seguir();
    }

    void seguir()
    {
        if(euVi)
        {
        transform.position=Vector2.MoveTowards(transform.position, pegar.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            controle.dano(10);
        }
    } 
}
