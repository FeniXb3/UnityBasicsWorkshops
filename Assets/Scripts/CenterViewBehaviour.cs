using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterViewBehaviour : MonoBehaviour
{

    public GameObject followedObject;
    public Vector3 distance = new Vector3(0, -3.0f, 5.0f);
    public Vector3 rotation = new Vector3(3.0f, 0, 0);

    public bool isLocked = false;
    public const string activatorButton = "space";

    // Use this for initialization
    void Start()
    {
        transform.localRotation = new Quaternion(0, 0, 0, 0);
        transform.Rotate(rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(activatorButton))
        {
            isLocked = !isLocked;
        }

        if (isLocked)
        {
            transform.localPosition = followedObject.transform.position - distance;
        }

    }
}
