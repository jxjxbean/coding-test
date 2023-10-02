using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leslie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("I want 100 pancakes.");
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.E))
        {
            transform.Translate(0, 3, 0);
        }
    }
}
