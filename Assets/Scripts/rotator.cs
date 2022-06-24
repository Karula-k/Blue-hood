using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{

    [SerializeField] private float speed; 
    // Update is called once per frame
    void Update()
    {
        /*   transform.Rotate(0, 0, speed );*/
        this.transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 1f), 90f * Time.deltaTime);
    }
}
