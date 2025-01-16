using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    GameObject[] targets;
    public GameObject targetPrefab;
    bool canSpawn;
    public static int points;
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("MainTarget");
        InvokeRepeating("CheckTargets", 1, .5f);
    }

    // Update is called once per frame
    void Update()
    {
         
        if(targets.Length < 21)
        {
            canSpawn = true;
            //clone another in any x and y axis
            PlayerController playerController = FindObjectOfType<PlayerController>();
            if (playerController != null)
            {
                // Debug.Log("Points:" + points);
               // playerController.points

            }
        }
        if (canSpawn)
        {
            targets = GameObject.FindGameObjectsWithTag("MainTarget");
            if(targets.Length > 21)
            {
                canSpawn = false;
                return;
            }
            var theTargets = GameObject.Find("The Targets");
            Debug.Log(targets.Length);
            Debug.Log("Cloned");
            var tmp = Instantiate(targetPrefab, new Vector3(Random.Range(-10, 10), Random.Range(1.2f, 2), Random.Range(0, -15)), targetPrefab.transform.rotation);
            tmp.transform.SetParent(theTargets.transform);

        }


    }

    void CheckTargets()
    {
        targets = GameObject.FindGameObjectsWithTag("MainTarget");
    }
}
