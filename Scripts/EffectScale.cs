using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScale : MonoBehaviour
{
    public Transform tr;
    private float solarScale;
    private float oldScale;

    // Start is called before the first frame update
    void Start()
    {
        tr = GameObject.FindWithTag("Solar").GetComponent<Transform>();
        oldScale = tr.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        solarScale = tr.localScale.x;
        //솔라 오브젝트의 x크기를 받아옴
        if (solarScale > oldScale)
        {
            ScaleUp();
            oldScale = solarScale;
        }
    }

    void ScaleUp()
    {
        //transform.localscale += new Vector3(0.01f, 0.01f, 0.01f);
    }
}
