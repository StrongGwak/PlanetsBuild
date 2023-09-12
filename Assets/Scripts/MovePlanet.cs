using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlanet : MonoBehaviour
{
    public Transform tr;
    public float speed = 56f;
    public StoreItem storeItem;
    public StoreItem solarUp;
    private float scale;
    private float solarScale;
    private float oldScale;
    private float newScale;


    // Use this for initialization
    void Start()
    {
        tr = GameObject.FindWithTag("Solar").GetComponent<Transform>();
        //솔라의 Transform 정보를 받아옴
        storeItem = GameObject.FindWithTag("buy").GetComponent<StoreItem>();
        //스토어의 변수를 받아옴
        solarUp = GameObject.FindWithTag("SolarUp").GetComponent<StoreItem>();
        oldScale = tr.localScale.x;
        //솔라의 크기변화감지를 위한 변수
        if (speed > 0)
        {
            speed -= storeItem.qty * 6.0f;
            //스토어의 qty횟수만큼 속도가 줄어듦
        }
        newScale = storeItem.distance - 3.0f;
        //storeItem의 스크립트에서 distance를 받아옴
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(tr.position, Vector3.forward, speed * Time.deltaTime);
        //솔라 오브젝트의 주위를 돌게함
        transform.Rotate(0, 0, 0.5f);
        //오브젝트를 회전하게함
        solarScale = tr.localScale.x;
        //솔라 오브젝트의 x크기를 받아옴
        if (solarScale > oldScale)
        {
            PlanetPosition();
            oldScale = solarScale;
        }
        //솔라의 크기가 변했을때 행성들의 위치 재구성

        if (Input.GetKeyDown(KeyCode.F5))
        {
            LineUp();
        }

    }

    public void PlanetPosition()
    {
        if (transform.localPosition.x > 0)
        {
            transform.localPosition += new Vector3(0.08f, 0, 0);
        }
        if(transform.localPosition.x < 0)
        {
            transform.localPosition += new Vector3(-0.08f, 0, 0);
        }
        //newScale의 수치만큼 x좌표로 이동
    }

    public void LineUp()
    {
        transform.localPosition = new Vector3(solarUp.qty * 0.08f + newScale, 0, -0.5f);
    }
}
