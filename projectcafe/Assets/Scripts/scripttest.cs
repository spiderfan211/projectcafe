using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripttest : MonoBehaviour
{

    public int numero;
    public float peso;
    public string nombre;
    public Transform untransform;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            Destroy(collision.gameObject);
            Debug.Log("enemy touched ground");
        }
        if(collision.gameObject.CompareTag("Ally")){
            Debug.Log("ally touched ground: " + collision.gameObject.name);
        }
    }
}
