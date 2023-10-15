using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Quaternion targetRotation;
    public Quaternion loweredRotation;
    private Quaternion closedRotation;

    public float speed=1.5f;
    // Start is called before the first frame update
    void Start()
    {
        targetRotation = transform.rotation;
        closedRotation = targetRotation;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void LowerDoor()
    {
        transform.Rotate(98.09601f, -1.525879e-05f, -1.525879e-05f, Space.Self);
    }

    public void ClosedDoor()
    {
        targetRotation = closedRotation;
    }
}
