using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform r_Hand;

    private bool r_hand_press = false;
    private bool r_hand_pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("XRI_Right_Trigger") > 0)
        {
            if(!r_hand_press && !r_hand_pressed)
            {
                r_hand_press = true;
            }else
            {
                r_hand_press = false;
            }

            r_hand_pressed = true;
            
        }else
        {
            r_hand_pressed = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Pickable")
        {
            if(r_hand_press)
            {
                other.transform.parent = r_Hand;
                other.transform.GetComponent<Rigidbody>().useGravity = false;

            }else if(!r_hand_pressed)
            {
                other.transform.parent = null;
                other.transform.GetComponent<Rigidbody>().useGravity = true;
            }


        }
    }
}
