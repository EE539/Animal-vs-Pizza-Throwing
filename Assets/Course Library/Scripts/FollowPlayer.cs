using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Canvas healthbar;
    public GameObject player;
    private Vector3 offset = new Vector3(-11.93f, 1.83f, 0);
    private int change = 0;
    private Vector3 rotateValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
