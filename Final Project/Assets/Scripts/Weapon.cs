using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;

    public AudioSource audioSource;

    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
            audioSource.Play();
        }
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }


}



    



