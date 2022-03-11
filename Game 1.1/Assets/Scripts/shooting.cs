using System.Collections;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public float damage = 21f;
    public float fireRate = 1f;
    public float force = 155f;
    public float range = 15f;   
    public Transform bulletSpawn;
    public GameObject hitEffect;

    public Camera _cam;
    private float nextFire = 0f;


    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        


        RaycastHit hit;

        if (Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range))
        {
            Debug.Log("Вы попали в объект! " + hit.collider);

            GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f);

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }
        }
    }
}