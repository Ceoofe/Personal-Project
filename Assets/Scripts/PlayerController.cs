using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput;
    private int xMax = 10;
    private int xMin = -10;
    public int points;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Clone.points.ToString();

        if(Clone.points < 0)
        {
            Debug.Log("Game Over!");
            
        }

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
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(180);
        Debug.Log("Time's Over!");
    }
}
// Set a timer abt 10 seconds for each targets and if the player doesnt hit them in time they lose 1 point
// Make sure bullet spawn directly at the camera

// Add sounds and music
// Once the game ends, show end screen