using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
        void OnCollisionEnter2D(Collision2D collisionInfo)
        {
            if(collisionInfo.gameObject.CompareTag("Ally")){
                Debug.Log("impacto bueno");
            }
            if(collisionInfo.gameObject.CompareTag("Enemy")){
                Debug.Log("impacto malo");
                Destroy(collisionInfo.gameObject);
            }
        }
    
}
