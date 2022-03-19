using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController6 : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //좌우 이동
        //key 값을 이용해 힘이 가해지는 방향을 제어
        //눌리지 않았을 때는 0을 대입해 움직이지 않도록 함
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //스피드 제한
        //프레임마다 AddForce 메서드를 사용해 힘을 계속해서 가하면 점점 가속하기 때문에
        //속도제한을 둔다.
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //움직이는 방향에 따라 반전
        //스프라이트를 반전시키려면 스프라이트의 x방향 배율을 -1배로 한다.
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
