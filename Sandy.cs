using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandy : MonoBehaviour
{
    float horiMovement;
    float verMovement;
    float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        horiMovement = Input.GetAxis("Horizontal");
        verMovement = Input.GetAxis("Vertical");
        transform.Translate(horiMovement * Time.deltaTime * movementSpeed,0,0);
        transform.Translate(0, 0, verMovement * Time.deltaTime * movementSpeed);
    }
}
