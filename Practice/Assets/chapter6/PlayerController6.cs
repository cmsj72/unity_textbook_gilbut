using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController6 : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    //float threshold = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //����
        //�÷��̾��� �ӵ��� Rigidbody2D Ŭ������ velocity ������ ���� �� �ִ�.
        //�÷��̾ ���� �� �϶��� ������ �����Ѱ��� �������� y�� �ӵ��� 0 �϶��� �����ǵ���
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            //if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
            //GetMouseButtonDown(0) ���� �����ϸ� ȭ���� ���ϸ� �����ϵ��� �� �� �ִ�.
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            
        }

        //�¿� �̵�
        //key ���� �̿��� ���� �������� ������ ����
        //������ �ʾ��� ���� 0�� ������ �������� �ʵ��� ��
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //���ӵ� ������ ���� ���� ���� ������ �׿� ���� ������ ����
        /*if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;*/

        //�÷��̾� �ӵ�
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //���ǵ� ����
        //�����Ӹ��� AddForce �޼��带 ����� ���� ����ؼ� ���ϸ� ���� �����ϱ� ������
        //�ӵ������� �д�.
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //�����̴� ���⿡ ���� ����
        //��������Ʈ�� ������Ű���� ��������Ʈ�� x���� ������ -1��� �Ѵ�.
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //�ÿ��̾� �ӵ��� ���� �ִϸ��̼� �ӵ��� �ٲ۴�.
        //�ִϸ��̼� ��� �ӵ��� �÷��̾� �̵� �ӵ��� ����ϵ���
        //�÷��̾� �̵� �ӵ��� 0�̸� �ִϸ��̼� ��� �ӵ��� 0���� �����ϰ�,
        //�̵� �ӵ��� ���������� �ִϸ��̼� �ӵ��� ��������.
        if(this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        //�÷��̾ ȭ�� ������ �����ٸ� ó������
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    //OnTriggerEnter2D �޼��尡 ȣ����� ���� �� üũ�� ����
    //1.�浹 ������ ������Ʈ�� Collider ������Ʈ�� ����Ǿ� �ִ°�?
    //2.Collider ������Ʈ�� Is Trigger�� üũ�Ǿ� �ִ°�?
    //3.��ũ��Ʈ�� OnTriggerEnter2D �޼��尡 �����Ǿ� �ִ°�?
    //4.��ũ��Ʈ�� ����Ǿ� �ִ°�?
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("��");
        SceneManager.LoadScene("ClearScene");
    }
}
