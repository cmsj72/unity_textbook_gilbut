using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;//회전 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10 ;
        }
           
        //한 프레임 마다 rotSpeed에서 설정한 각도 만큼 회전
        //양수면 시계 반대 방향, 음수면 시계 방향으로 회전
        transform.Rotate(0, 0, this.rotSpeed);

        //rotSpeed는0에 가까워진다. 결코 0이 되지 않지만 매우 작은 수라 룰렛이 정지한 것 처럼 보인다.
        //감속 크기를 바꾸고 싶다면 감쇠 계수를 변경
        this.rotSpeed *= 0.96f;
        
    }
}
