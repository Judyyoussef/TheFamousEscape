using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletInstantiationLocaation;
    public float bulletSpeed = 600;
    public float coolDownTime = 0.5f;

    private bool _coolDown = false;
    private float _timer;

    // Update is called once per frame
    void Update()
    {
        if (_coolDown)
        {
            _timer += Time.deltaTime;
            if (_timer >= coolDownTime)
            {
                _coolDown = false;
            }
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
         Shoot();
         _timer = 0;
       } 
    }
    public void Shoot()
    {
        Debug.Log("shoot!");
        GameObject Bullet = Instantiate(bulletPrefab, bulletInstantiationLocaation.transform.position, bulletInstantiationLocaation.transform.rotation);
        Bullet.GetComponent<Rigidbody>().AddForce(Bullet.transform.forward * bulletSpeed);
        _coolDown = true;
    
    }
}
