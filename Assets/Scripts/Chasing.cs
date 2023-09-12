using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasing : MonoBehaviour
{
    public GameObject Player;
    private GameObject Target;
    public float CameraZ = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
        if(Target != null)
        {
            Vector3 TargetPos = new Vector3(Target.transform.position.x, Target.transform.position.y, CameraZ);
            transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * 5f);
        }
        
    }

    void CastRay() // 유닛 히트처리 부분.  레이를 쏴서 처리합니다. 

    {

        Target = null;

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);



        if (hit.collider != null)
        { //히트되었다면 여기서 실행

            Debug.Log (hit.collider.name);  //이 부분을 활성화 하면, 선택된 오브젝트의 이름이 찍혀 나옵니다. 

            Target = hit.collider.gameObject;  //히트 된 게임 오브젝트를 타겟으로 지정
            
        }

    }
    
}
