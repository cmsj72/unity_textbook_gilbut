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
        //�÷��̾��� ��ǥ�� �����ؼ� ī�޶��� Y��ǥ�� �ݿ�
        //�÷��̾� �̵��� ���󰡴� ���� Y ������ ��ȭ ���̹Ƿ� X��ǥ�� Z��ǥ���� ī�޶��� ���� ��ǥ�� �״�� ����
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}
