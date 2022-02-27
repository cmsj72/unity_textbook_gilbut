using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UI 오브젝트를 스크립트에서 사용하려면 UnityEngine.UI 를 임포트 해야한다.
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        //Find : 오브젝트명을 인수로 전달, 인수명이 게임 씬 안에 있으면 해당 오브젝트를 반환
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        //자동차와 깃발의 위치를 조사하고 둘 사이의 거리를 계산한 후 UI에 표시
        //게임 오브젝트의 좌표는 게임오브젝트명.transform.position 으로 구할 수 있다.

        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if(length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지" + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임 오버";
        }
        

        //ToString : 값을 문자열로 변환하는 메소드, 인수에는 값을 표시할 형식을 지정할 수 있다.
        //정수형 D[자릿수] : 정수를 표시할 때 사용, 지정한 자릿수를 채우지 않으면 왼쪽에 0이 삽입
        //ex)(456).ToString("D5") -> 00456
        //고정 소수점형 F[자릿수] : 소수를 표시할 때 소수점 이하 자릿수를 조정
        //ex)(12.3456).ToString("F3") -> 12.345
    }
}
