월드 좌표계와 로컬 좌표계

- 월드 좌표계:오브젝트가 게임판 어디에 있는지를 나타냄(지금까지 Inspector창에서 설정한 좌표도 월드 좌표계)
- 로컬 좌표계:게임 오브젝트가 개별적으로 갖는 좌표계
- Translate 메서드를 사용하면 이동 방향은 월드 좌표계가 아니라 로컬 좌표계로 계산
- 오브젝트가 회전하면 방향이 회전한 좌표계로 계산하기 때문에 오브젝트가 회전하면서 동시에 이동할 때는 조심해야함 

------

EventSystem

- 사용자 입력과 UI 부품을 중간에서 이어 주는 오브젝트
- UI를 사용할 때 반드시 필요
- 입력 할당이나 무효화 등 키와 마우스 설정을 변경 가능

------

Rect Transform

- UI에서는 부품의 좌표를 표시하는데 Transform이 아닌 Rect Transform을 사용
- Transform에서는 위치, 회전, 크기를 변경가능
- Rect Transform에서는 위치, 회전, 크기는 물론 피벗과 앵커를 변경 가능
- 피벗
  - 회전 또는 확대나 축소를 할 때 쓰는 중심 좌표

- 앵커
  - UI리소스를 배치할 때 기준이 되는 위치

------

※ 글자를 배치할 때 Rect Transform 항목의 Width와 Height 값이 표시할 문장 크기보다 작으면 글자가 화면에 제대로 표시되지 않는다.



------

컴포넌트(Component)

- 유니티 오브젝트는 GameObject라는 빈 상자에 컴포넌트를 추가해서 기능을 늘릴 수 있다.
- GetComponent<OO>() : 게임 오브젝트에 대해 OO 컴포넌트를 가져오는 메서드
- transform = GetComponent<Transform>()
- 직접 만든 스크립트도 컴포넌트의 일종이므로 GetComponent를 통해 가져올 수 있다.



자신 이외의 오브젝트 컴포넌트에 접근하는 방법

1. Find로 오브젝트를 찾는다.
2. GetComponent로 오브젝트의 컴포넌트를 구한다.
3. 컴포넌트를 가진 데이터에 접근

------

오디오소스(AudioSource)

- Play On Awake : 체크되있을 시 게임을 시작한 시점에 자동으로 소리가 재생

  | 형식                          | 확장자     |
  | ----------------------------- | ---------- |
  | MPEG Layer3                   | .mp3       |
  | Ogg Varbis                    | .ogg       |
  | Microsoft Wave                | .wav       |
  | Audio Interchange File Format | .aiff/.aif |

  

