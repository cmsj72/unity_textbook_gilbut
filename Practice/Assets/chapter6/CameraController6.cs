using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController6 : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("cat");    
    }

    // Update is called once per frame
    void Update()
    {
        //플레이어의 좌표를 조사해서 카메라의 Y좌표에 반영
        //플레이어 이동에 따라가는 것은 Y 방향의 변화 뿐이므로 X좌표와 Z좌표에는 카메라의 원래 좌표를 그대로 대입
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}
