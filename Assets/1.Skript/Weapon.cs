using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamere;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 35f;
    [SerializeField] ParticleSystem muzzleFlash;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        PlayMuzzleFalsh();
        ProcessRacast();
    }

    void PlayMuzzleFalsh()
    {
        muzzleFlash.Play();
    }

    void ProcessRacast()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamere.transform.position, FPCamere.transform.forward, out hit, range))
        {
            Debug.Log("Hit" + hit.transform.name);

            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;

            target.TakeDamage(damage);

        }
        else
        {
            return;
        }
    }
}
