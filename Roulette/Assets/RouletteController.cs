using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;//ȸ�� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� ����
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10 ;
        }
           
        //�� ������ ���� rotSpeed���� ������ ���� ��ŭ ȸ��
        //����� �ð� �ݴ� ����, ������ �ð� �������� ȸ��
        transform.Rotate(0, 0, this.rotSpeed);

        //rotSpeed��0�� ���������. ���� 0�� ���� ������ �ſ� ���� ���� �귿�� ������ �� ó�� ���δ�.
        //���� ũ�⸦ �ٲٰ� �ʹٸ� ���� ����� ����
        this.rotSpeed *= 0.96f;
        
    }
}
