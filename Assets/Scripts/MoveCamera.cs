using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject Cam;
    private float speed_move = 3.0f;
    private float dist;
    private Vector3 MouseStart;
    private Vector3 derp;

    // Start is called before the first frame update
    void Start()
    {
        dist = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //moveObjectFunc();
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Cam.GetComponent<Camera>().fieldOfView += 1f;
            Cam.GetComponent<Camera>().orthographicSize += 1f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Cam.GetComponent<Camera>().fieldOfView -= 1f;
            Cam.GetComponent<Camera>().orthographicSize -= 1f;
        }
        if (Input.GetMouseButtonDown(2))
        {
            MouseStart = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            MouseStart = Camera.main.ScreenToWorldPoint(MouseStart);
            MouseStart.z = transform.position.z;

        }
        else if (Input.GetMouseButton(2))
        {
            var MouseMove = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            MouseMove = Camera.main.ScreenToWorldPoint(MouseMove);
            MouseMove.z = transform.position.z;
            transform.position = transform.position - (MouseMove - MouseStart);
        }
    }


    void moveObjectFunc()
    {
        float keyH = Input.GetAxis("Horizontal");
        float keyV = Input.GetAxis("Vertical");
        keyH = keyH * speed_move * Time.deltaTime;
        keyV = keyV * speed_move * Time.deltaTime;
        transform.Translate(Vector3.right * keyH);
        transform.Translate(Vector3.up * keyV);

    }
}
