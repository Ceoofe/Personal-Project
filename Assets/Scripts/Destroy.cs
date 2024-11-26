using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    Rigidbody bulletRb;
    // Start is called before the first frame update
    void Awake()
    {
        bulletRb = GetComponent<Rigidbody>();
        bulletRb.AddForce(Vector3.forward * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 0.5) //Clone will delete itself after it goes above the limit z-axis
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Target1")
        {
            Destroy(gameObject); 
            Destroy(other.gameObject.transform.parent.gameObject);
            Debug.Log("1 Point");
        }
        else if (other.gameObject.tag == "Target2")
        {
            Destroy(gameObject);
            Destroy(other.gameObject.transform.parent.gameObject);
            Debug.Log("2 Point");
        }
        else if (other.gameObject.tag == "Target3")
        {
            Destroy(gameObject);
            Destroy(other.gameObject.transform.parent.gameObject);
            Debug.Log("3 Point");
        }
        else if (other.gameObject.tag == "Target4")
        {
            Destroy(gameObject);
            Destroy(other.gameObject.transform.parent.gameObject);
            Debug.Log("5 Point");
        }
        else if (other.gameObject.tag == "Target5")
        {
            Destroy(gameObject);
            Destroy(other.gameObject.transform.parent.gameObject);
            Debug.Log("10 Point");
        }
    }
}
