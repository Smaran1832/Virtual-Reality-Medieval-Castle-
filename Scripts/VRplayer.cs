using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;  //Local Raycast (laser) variable and the results will be stored in hit


        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {

                Debug.Log("You have hit" + hit.transform.name);
                if (hit.transform.tag == "Enter")
                {
                    hit.transform.GetComponent<DoorButton>().LookAtOpen();
                }
                else if (hit.transform.tag == "Exit")
                {
                    hit.transform.GetComponent<DoorButton>().LookAtExit();
                }
                else if (hit.transform.tag == "Teleport")
                {                                                                       //  See if anything was hit with the tag "Teleport"
                    hit.transform.GetComponent<Teleporter>().Teleport();                // Activate the Teleport method inside the Teleporter script
                }
                else if(hit.transform.tag=="Interactable")
                {
                    hit.transform.GetComponent<agent>().ToggleInteracted();
                }
                //Destroy(hit.transform.gameObject);
            }
        }
    }
}
