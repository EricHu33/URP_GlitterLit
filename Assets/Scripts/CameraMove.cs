using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var Forward = Input.GetAxisRaw("Vertical");
        var Right = Input.GetAxisRaw("Horizontal");
        var up = Input.GetKey(KeyCode.Space);
        var down = Input.GetKey(KeyCode.LeftControl);
        var Upper = 0f;
        if (up)
        {
            Upper += 1f;
        }
        if (down)
        {
            Upper -= 1f;
        }
        var Movement = new Vector3(Right, Upper, Forward);
        transform.position += Quaternion.LookRotation(transform.forward, Vector3.up) * Movement * 2 * Time.deltaTime;
    }
}
