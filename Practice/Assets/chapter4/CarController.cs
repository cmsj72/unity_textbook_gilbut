using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    ////4-1
    //float speed = 0;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        this.speed = 0.2f;
    //    }

    //    //Translate
    //    //인수가 현재 좌표 값을 직접 나타내는 것은 아님
    //    //현재 좌표의 상대적인 이동 값을 나타낸다.
    //    //ex)Translate(0, 3, 0) => 0,3,0의 좌표로 이동하는 것이 아닌 현재 지점에서 Y방향으로 3만큼 이동

    //    transform.Translate(this.speed, 0, 0);
    //    this.speed *= 0.98f;
    //}

    //===================================

    //4-2
    //스와이프 길이에 따라 이동 거리 바꾸기
    //마우스 드래그 동작 == 스와이프 동작
    //스와이프 길이(=드래그 길이)에 따라 자동차 이동 거리를 바꾸려면 스와이프 길이를 
    //자동차의 초기 속도로 설정하는 것이 좋다.
    //스와이프의 길이 = 클릭을 시작한 좌표와 클릭이 끝난 좌표의 차이
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);
            Debug.Log(swipeLength);
            
            //스와이프 길이를 처음 속도로 변경
            //수정하면 자동차의 초기 속도가 바뀐다.
            //자동차의 속도나 이동 거리를 바꾸고 싶다면 이 값을 수정
            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
