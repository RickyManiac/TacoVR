using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public GameObject TortillaEmpty, MeetEmpty, OnionEmpty, CilantroEmpty, SalsaEmpty;
    private bool EmptyPlate, TortillaInPlate, MeetInPlate, CilantroInPlate, OnionInPlate,SalsaInPlate ;
    // Start is called before the first frame update
    void Start()
    {
        EmptyPlate = false;
        TortillaInPlate = false;
        MeetInPlate = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Toritillllaaaaaaaaaaaa!!!!!!!!1");
        if (!EmptyPlate && other.tag == ("Tortilla"))
        {

            other.transform.parent = TortillaEmpty.transform;
            EmptyPlate = true;
            TortillaInPlate = true;
            other.transform.localPosition = Vector3.zero;

        }
        else if (TortillaInPlate && other.tag == ("Meat"))
        {
            other.transform.parent = MeetEmpty.transform;
            MeetInPlate = true;
            other.transform.position = Vector3.zero;

        }
        else if (MeetInPlate && other.tag == ("Cilantro"))
        {
            other.transform.parent = CilantroEmpty.transform;
            other.transform.position = Vector3.zero;

        }
        else if(MeetInPlate && other.tag == ("Onion"))
        {
            other.transform.parent = OnionEmpty.transform;
            other.transform.position = Vector3.zero;

        }
        else if (MeetInPlate && other.tag == ("Salsa"))
        {
            other.transform.parent = SalsaEmpty.transform;
            other.transform.position = Vector3.zero;

        }

    }
}
