using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject planet;
    private Sprite spr;

    
    // Start is called before the first frame update
    void Start()
    {
        createPlanets();
        spr = (Sprite)Resources.Load("mars",typeof(Sprite));
        //리소스폴더의 파일을 불러옴 sprite타입의 mars

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changePlanet();
        }
    }

    public void createPlanets()
    {
        GameObject pla = Instantiate(planet) as GameObject;
        //planet이라는 프리펩을 생성
        pla.transform.localPosition = new Vector3(2f, 2f, -1f);
        pla.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    void changePlanet()
    {
        transform.GetComponent<SpriteRenderer>().sprite = spr;
        //SpriteRenderer의 sprite속성을 spr로 바꿈
    }
}
