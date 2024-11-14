using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
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
}