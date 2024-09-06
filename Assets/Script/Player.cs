using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rig;
    [SerializeField]
    int velocidade;
    [SerializeField]
    Animator anima;
     public MeuJoystick joy; //o que a gente feiz
     public Joystick joystick; //essa bagaça é o da Unity
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mover();
    }
   void mover(){
        float vertical=Input.GetAxis("Vertical") + joy.vertical + joystick.Vertical;
        float horizontal=Input.GetAxis("Horizontal") + joy.horizontal + joystick.Horizontal;

      rig.velocity=new Vector2( horizontal * velocidade,vertical* velocidade);

       anima.SetFloat("horizontal",horizontal);
        anima.SetFloat("vertical",vertical);
        
        if(rig.velocity.magnitude != 0){
            anima.SetBool("mover",true);
        }else{
              anima.SetBool("mover",false);
        }
    
    }
}
