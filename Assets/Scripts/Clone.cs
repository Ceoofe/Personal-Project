using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    GameObject[] targets;
    public GameObject targetPrefab;
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("MainTarget");

       
    }

    // Update is called once per frame
    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("MainTarget");
         
        if(targets.Length < 21)
        {
            StartCoroutine("SpawnTarget");
            //clone another in any x and y axis
        }
    }

    IEnumerator SpawnTarget()
    {
        yield return new WaitForSeconds(3);
        var theTargets = GameObject.Find("The Targets");
            Debug.Log(targets.Length);
            Debug.Log("Cloned");
            var tmp = Instantiate(targetPrefab, new Vector3(Random.Range(-19, -2), transform.position.y, Random.Range(-5, 6)), targetPrefab.transform.rotation);
            tmp.transform.SetParent(theTargets.transform);
    }
}
