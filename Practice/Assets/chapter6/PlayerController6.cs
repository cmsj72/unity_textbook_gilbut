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
        //점프
        //플레이어의 속도는 Rigidbody2D 클래스의 velocity 변수로 구할 수 있다.
        //플레이어가 점프 중 일때도 점프가 가능한것을 막기위해 y축 속도가 0 일때만 점프되도록
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            //if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
            //GetMouseButtonDown(0) 으로 변경하면 화면을 탭하면 점프하도록 할 수 있다.
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            
        }

        //좌우 이동
        //key 값을 이용해 힘이 가해지는 방향을 제어
        //눌리지 않았을 때는 0을 대입해 움직이지 않도록 함
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //가속도 센서의 값이 일정 값을 넘으면 그에 따른 방향을 제어
        /*if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;*/

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

        //플에이어 속도에 맞춰 애니메이션 속도를 바꾼다.
        //애니메이션 재생 속도가 플레이어 이동 속도에 비례하도록
        //플레이어 이동 속도가 0이면 애니메이션 재생 속도도 0에서 정지하고,
        //이동 속도가 빨라질수록 애니메이션 속도도 빨라진다.
        if(this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        //플레이어가 화면 밖으로 나갔다면 처음부터
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    //OnTriggerEnter2D 메서드가 호출되지 않을 때 체크할 사항
    //1.충돌 판정할 오브젝트에 Collider 컴포넌트가 적용되어 있는가?
    //2.Collider 컴포넌트의 Is Trigger가 체크되어 있는가?
    //3.스크립트에 OnTriggerEnter2D 메서드가 구현되어 있는가?
    //4.스크립트가 적용되어 있는가?
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("골");
        SceneManager.LoadScene("ClearScene");
    }
}
