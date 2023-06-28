using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private void FocusTarget()
    {
        this.transform.position = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        FocusTarget();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FocusTarget();
    }
}
