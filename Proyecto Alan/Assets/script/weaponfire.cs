using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponfire : MonoBehaviour
{
   public float damageAmount = 1f;
   public float range = 150;
   public Camera PlayerCam;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(PlayerCam.transform.position, PlayerCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            target target = hit.transform.GetComponent<target>();
            if (target != null)
            {
                target.DamageReceived(damageAmount);
            }
        }
    }
}
