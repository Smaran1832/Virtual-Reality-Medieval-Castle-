using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agent : MonoBehaviour
{
    public bool interacted;
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ToggleInteracted()
    {
        if (!ani.GetBool("interacted"))
            ani.SetBool("interacted", true);
        else
            ani.SetBool("interacted", false);
    }
}
