using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {

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
            //target.SetActive(false);
            Debug.Log("1 Point");
        }
        else if (other.gameObject.tag == "Target2")
        {
            Destroy(gameObject);
            Debug.Log("2 Point");
        }
        else if (other.gameObject.tag == "Target3")
        {
            Destroy(gameObject);
            Debug.Log("3 Point");
        }
        else if (other.gameObject.tag == "Target4")
        {
            Destroy(gameObject);
            Debug.Log("5 Point");
        }
        else if (other.gameObject.tag == "Target5")
        {
            Destroy(gameObject);
            Debug.Log("10 Point");
        }
    }
}
