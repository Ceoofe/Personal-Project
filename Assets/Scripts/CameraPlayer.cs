using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public GameObject bullet;
    public GameObject plr;
    public float speed;
    Quaternion cam;
    int xMin = -10;
    int xMax = 9;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 2.0f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Debug.Log(mousePos.y);


        cam.x += Input.GetAxis("Mouse Y") * speed;
        cam.x = Mathf.Clamp(cam.x, xMin, xMax);

        // transform.localRotation = Quaternion.Euler(cam.x, cam.y, cam.z);
        // plr.transform.localRotation = Quaternion.Euler(cam.x, cam.y, cam.z);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullet, new Vector3(transform.position.x, mousePos.y, transform.position.z + 1), bullet.transform.rotation);
            
            //Debug.Log("Shoot");
        }
    }
}
