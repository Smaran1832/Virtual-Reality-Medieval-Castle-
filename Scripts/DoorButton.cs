using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public Door door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LookAtOpen()
    {
        door.LowerDoor();
    }
    public void LookAtExit()
    {
        door.ClosedDoor();
    }
}
