using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmenet : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.S))
        {
            direction.z = -1 * speed;
        } else if (Input.GetKey(KeyCode.W))
        {
            direction.z = 1 * speed;
        } 
        
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1 * speed;
        } else if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1 * speed;
        }

        controller.SimpleMove(direction);
    }
}
