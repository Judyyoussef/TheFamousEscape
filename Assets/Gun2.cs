using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Gun2 : MonoBehaviour
{
    public float speed = 40;
    public GameObject Bullet2;
    public Transform barrel;
    public AudioSource audioSource; 
    public AudioClip audioClip;

        public void Fire()
    {
        GameObject spawnedBullet = Instantiate(Bullet2, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnedBullet, 2 );
    }

}
