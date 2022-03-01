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
    //    //�μ��� ���� ��ǥ ���� ���� ��Ÿ���� ���� �ƴ�
    //    //���� ��ǥ�� ������� �̵� ���� ��Ÿ����.
    //    //ex)Translate(0, 3, 0) => 0,3,0�� ��ǥ�� �̵��ϴ� ���� �ƴ� ���� �������� Y�������� 3��ŭ �̵�

    //    transform.Translate(this.speed, 0, 0);
    //    this.speed *= 0.98f;
    //}

    //===================================

    //4-2
    //�������� ���̿� ���� �̵� �Ÿ� �ٲٱ�
    //���콺 �巡�� ���� == �������� ����
    //�������� ����(=�巡�� ����)�� ���� �ڵ��� �̵� �Ÿ��� �ٲٷ��� �������� ���̸� 
    //�ڵ����� �ʱ� �ӵ��� �����ϴ� ���� ����.
    //���������� ���� = Ŭ���� ������ ��ǥ�� Ŭ���� ���� ��ǥ�� ����
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
            
            //�������� ���̸� ó�� �ӵ��� ����
            //�����ϸ� �ڵ����� �ʱ� �ӵ��� �ٲ��.
            //�ڵ����� �ӵ��� �̵� �Ÿ��� �ٲٰ� �ʹٸ� �� ���� ����
            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
