#### Physics

- 유니티에 표준으로 속해 있는 물리 엔진
- 물리 엔진은 오브젝트를 물리 동작(낙하, 충돌 등)에 맞춰 움직임을 구현하는 시뮬레이션용 라이브러리
- 물리 엔진을 사용하면 오브젝트의 질량, 마찰 계수, 중력 등을 고려해 움직임을 계산하므로 사실적인 동작을 쉽게 구현 할 수 있다.
- Physics는 Rigidbody 컴포넌트와 Collider 컴포넌트로 구성
  - Rigidbody : 힘 계산(물체에 작용하는 중력이나 마찰 등의 힘 계산)을 담당
  - Collider : 물체의 충돌 판정을 담당
- 무대 위를 플레이어가 자유롭게 이동하는 액션 게임이나 복잡한 충돌 판정이 필요한 슈팅 게임에 이상적
- Physics를 사용하지 않는다고 해서 게임을 만들 수 없는 것은 아니다. 다만 Physics를 사용하면 게임을 간단히 만들 수 있다.

| 이름                | 모양                                                         |
| ------------------- | ------------------------------------------------------------ |
| Circle Collider 2D  | 원형 콜라이더                                                |
| Box Collider 2D     | 사각형 콜라이더                                              |
| Edge Collider 2D    | 선형 콜라이더, 오브젝트 일부를 충돌 판정할 때 사용한다.      |
| Polygon Collider 2D | 다각형 콜라이더, 오브젝트에 정확히 맞도록 충돌 판정할 때 사용한다. |

- Rigidbody 2D의 Body Type → Kinematic 을 선택하면 중력과 물리 연산의 영향을 무시한다.
- 이동하는 플레이어는 캡슐형 Collider를 사용하는 것이 좋다. 닿는 부분의 모양이 원형이므로 지면에 걸리는 상황도 줄일 수 있고 플레이어 이동도 매끄럽다.
- 콜라이더의 위치와 크기는 Inspector 창에서 변경할 수 있다.
- Rigidbody 2D → Constraints → Freeze Rotation 은  지정한 축의 회전을 방지하는 항목