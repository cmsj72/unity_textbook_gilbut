using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하(일정한 속도)
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나오면 오브젝트를 소멸
        //화살이 보이지 않는 곳에서 계속 떨어지면 컴퓨터 역시 계속 계산을 해야하므로 메모리가 낭비된다.
        if(transform.position.y < -5.0f)
        {
            //gameObject는 자기자신을 가리킨다.
            Destroy(gameObject);
        }


        //충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;                        //dir 벡터의 길이
        float r1 = 0.5f;                                //화살반경
        float r2 = 1.0f;                                //플레이어 반경

        if(d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector5");
            director.GetComponent<GameDirector5>().DecreaseHp();

            //충돌한 경우 화살을 지운다.
            Destroy(gameObject);
        }
    }
}
