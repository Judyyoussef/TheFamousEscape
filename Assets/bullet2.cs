using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bullet2 : MonoBehaviour
{
    //public float life = 10;

    void Awake()
    {
        //Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}