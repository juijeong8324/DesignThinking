using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private GameObject go_camera;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
        }

    }
}
