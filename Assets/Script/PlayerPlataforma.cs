using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlataforma : MonoBehaviour
{

    Rigidbody2D rig;
    [SerializeField]
     float velocidade=3f;
    // Start is called before the first frame update
    void Start()
    {
        rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mover();
    }

    void mover(){
        float horizontal=Input.GetAxis("Horizontal");
        rig.velocity=new Vector2(horizontal * velocidade , rig.velocity.y);
    }


}
