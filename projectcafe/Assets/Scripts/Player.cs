using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool saltando;
    bool gravity;
    enum GravityDirection { Down, Left, Up, Right };
    GravityDirection m_GravityDirection;
    // Start is called before the first frame update
    void Start()
    {
        m_GravityDirection = GravityDirection.Down;   
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A)){
            transform.Translate(new Vector3(-0.05f,0));
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(new Vector3(0.05f,0));
        }
        if(Input.GetKey(KeyCode.Space)){
            if(!saltando){
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 300.0f));
                saltando = true;
            }
        }

        if(Input.GetKey(KeyCode.Q)){
            if(!gravity){
                Physics2D.gravity = Physics2D.gravity * (-1);
                gravity=true;
            }
        }


        
    }

    

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Ground"){
            saltando=false;
            gravity = false;
        }
    }

    

}
