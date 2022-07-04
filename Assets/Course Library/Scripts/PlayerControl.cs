using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f, xRange = 10;
    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //read horizontal values (a or d or left - right arrows)
        horizontalInput = Input.GetAxis("Horizontal");
        //Make character not fall
        if (transform.position.x < - xRange)
        {
            transform.position = new Vector3(- xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch food from player
            Instantiate(food, transform.position, food.transform.rotation);
        }
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
    }
}
