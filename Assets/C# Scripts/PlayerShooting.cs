using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerShooting : MonoBehaviour
{
    public Transform barrel;
    public GameObject bulletSprite;
    public float bulletSpeed;
    public int ammo = 6;

    public TMP_Text ammoAmount;

    public ParticleSystem muzzleFlash;
    public AudioSource gunshot, outOfAmmo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
            ammo--;
            if(ammo > 0)
            {
                ammoAmount.text = ammo.ToString() + "/6";
            }
            else
            {
                ammoAmount.text = "0/6";
            }
        }
    }

    public void fire()
    {
        if (ammo <= 0)
        {
            outOfAmmo.Play();
        }
        else
        {
            GameObject bullet = Instantiate(bulletSprite, barrel.position, barrel.rotation);
            Rigidbody2D bulletRigidBody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidBody.AddForce(barrel.right * bulletSpeed, ForceMode2D.Impulse);

            muzzleFlash.Play();
            gunshot.Play();

            Destroy(bullet, 5F);
        }
    }
}
