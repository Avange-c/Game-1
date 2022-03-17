using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShootUp : MonoBehaviour
{
    public float FireRate = 1f;
    public float FireRange = 15f;
    public float force = 155f;
    private float NextFire = 0f;

    private int hittingTheFirstTarget = 0;
    private int hittingTheSecondTarget = 0;
    private int hittingTheThirdTarget = 0;

    public Transform bulletSpawn;
    public GameObject hitEffect;
    public Camera _camera;
    public Text _winText;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > NextFire)
        {
            NextFire = Time.time + 1f / FireRate;
            Shoot();
        }

    }

    private void Shoot()
    {

        RaycastHit hit;

        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, FireRange))
        {
            Debug.Log("Вы попали в объект! " + hit.collider.name);

            GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
            //Destroy(impact, 2f);

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }


                if (hit.collider.name == "target(1)")
                {
                    hittingTheFirstTarget = hittingTheFirstTarget + 1;
                    Debug.Log("Первая мишень уничтожена!!!");
                }
                if (hit.collider.name == "target(2)")
                {
                    hittingTheSecondTarget = hittingTheSecondTarget + 1;
                    Debug.Log("Вторая мишень уничтожена!!!");
                }
                if (hit.collider.name == "target(3)")
                {
                    hittingTheThirdTarget = hittingTheThirdTarget + 1;
                    Debug.Log("Третья мишень уничтожена!!!");
                }
                if (hittingTheFirstTarget >= 1 && hittingTheSecondTarget >= 1 && hittingTheThirdTarget >= 1)
                {
                    Debug.Log("Победа!!!");
                    _winText.text = "Победа!!!";
            }
            }
        }
    }