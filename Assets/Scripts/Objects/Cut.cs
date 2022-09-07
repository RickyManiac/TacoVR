using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> steps;
    [SerializeField]
    private int step = 0;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            steps.Add(transform.GetChild(i).gameObject);
        }

        step = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Knife")
        {
            if(step < transform.childCount - 1)
            {
                steps[step].SetActive(false);
                step++;
                steps[step].SetActive(true);
            }
            

        }
    }
}
