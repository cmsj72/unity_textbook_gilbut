using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime은 앞프레임과 현재 프레임 사이의 시간차이
        this.delta += Time.deltaTime;

        //화살을 1초마다 한 개씩 생성
        //누적 1초가 넘으면 생성하고 초기화
        //span 값을 바꾸면 화살의 생성 간격을 바꿀 수 있다.
        if (this.delta > this.span)
        {
            this.delta = 0;
            //Instantiate는 매개변수로 프리팹을 전달하면 반환값으로 프리팹 인스턴스를 반환
            //Instantiate는 가장 기본적인 Object형을 반환, as GameObject(캐스트)로 GameObject형으로 반환
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            
            //-6이상 7미만의 정수를 반환
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
