using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UI ������Ʈ�� ��ũ��Ʈ���� ����Ϸ��� UnityEngine.UI �� ����Ʈ �ؾ��Ѵ�.
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        //Find : ������Ʈ���� �μ��� ����, �μ����� ���� �� �ȿ� ������ �ش� ������Ʈ�� ��ȯ
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        //�ڵ����� ����� ��ġ�� �����ϰ� �� ������ �Ÿ��� ����� �� UI�� ǥ��
        //���� ������Ʈ�� ��ǥ�� ���ӿ�����Ʈ��.transform.position ���� ���� �� �ִ�.

        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if(length >= 0)
        {
            this.distance.GetComponent<Text>().text = "��ǥ ��������" + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "���� ����";
        }
        

        //ToString : ���� ���ڿ��� ��ȯ�ϴ� �޼ҵ�, �μ����� ���� ǥ���� ������ ������ �� �ִ�.
        //������ D[�ڸ���] : ������ ǥ���� �� ���, ������ �ڸ����� ä���� ������ ���ʿ� 0�� ����
        //ex)(456).ToString("D5") -> 00456
        //���� �Ҽ����� F[�ڸ���] : �Ҽ��� ǥ���� �� �Ҽ��� ���� �ڸ����� ����
        //ex)(12.3456).ToString("F3") -> 12.345
    }
}
