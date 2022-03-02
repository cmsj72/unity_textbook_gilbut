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
        //Time.deltaTime�� �������Ӱ� ���� ������ ������ �ð�����
        this.delta += Time.deltaTime;

        //ȭ���� 1�ʸ��� �� ���� ����
        //���� 1�ʰ� ������ �����ϰ� �ʱ�ȭ
        //span ���� �ٲٸ� ȭ���� ���� ������ �ٲ� �� �ִ�.
        if (this.delta > this.span)
        {
            this.delta = 0;
            //Instantiate�� �Ű������� �������� �����ϸ� ��ȯ������ ������ �ν��Ͻ��� ��ȯ
            //Instantiate�� ���� �⺻���� Object���� ��ȯ, as GameObject(ĳ��Ʈ)�� GameObject������ ��ȯ
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            
            //-6�̻� 7�̸��� ������ ��ȯ
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
