using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 5.0f;
    private float horizontalInput;
    private int xMax = 10;
    private int xMin = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    //Limits from the x-axis 10 to -10
        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
        }
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), bullet.transform.rotation);
            Debug.Log("Shoot");
        }
    }
}
