using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnableManager : MonoBehaviour
{
    // Start is called before the first frame update



    public Transform arCamera;
    public GameObject projectile;
    Camera arCam;


    public float shootforce = 100.0f;
    // Update is called once per frame
    private void Start()
    {
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
    }
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward * shootforce);
 

            
        }
    }
}
