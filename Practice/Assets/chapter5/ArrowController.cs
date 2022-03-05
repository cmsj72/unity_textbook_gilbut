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
        //�����Ӹ��� ������� ����(������ �ӵ�)
        transform.Translate(0, -0.1f, 0);

        //ȭ�� ������ ������ ������Ʈ�� �Ҹ�
        //ȭ���� ������ �ʴ� ������ ��� �������� ��ǻ�� ���� ��� ����� �ؾ��ϹǷ� �޸𸮰� ����ȴ�.
        if(transform.position.y < -5.0f)
        {
            //gameObject�� �ڱ��ڽ��� ����Ų��.
            Destroy(gameObject);
        }


        //�浹 ����
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;                        //dir ������ ����
        float r1 = 0.5f;                                //ȭ��ݰ�
        float r2 = 1.0f;                                //�÷��̾� �ݰ�

        if(d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector5");
            director.GetComponent<GameDirector5>().DecreaseHp();

            //�浹�� ��� ȭ���� �����.
            Destroy(gameObject);
        }
    }
}
