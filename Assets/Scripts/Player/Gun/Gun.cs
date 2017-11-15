using UnityEngine;

public class Gun : MonoBehaviour {

    public Camera cam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);

            GameObject impactObject = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactObject, 1f);
        }
    }
  }
		
	

