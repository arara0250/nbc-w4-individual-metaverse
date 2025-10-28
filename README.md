# 프로젝트 소개
<img width="271" alt="image" src="https://github.com/user-attachments/assets/931a7da6-c57d-4cd8-8e19-66de93d2ec5c" />
<img width="271" alt="image" src="https://github.com/user-attachments/assets/e159ba4b-0d6f-451e-a3ac-fc10b9a9590b" />
<img width="271" alt="image" src="https://github.com/user-attachments/assets/e6013284-3265-468a-868b-c9f95728645c" />
<p align=center><img width="271" alt="image" src="https://github.com/user-attachments/assets/b38abf3f-5ef6-48c0-b04d-5bbfc4e7551b" /></p>

- **프로젝트 제목 :** MyMetaverse
- **프로젝트 설명 :** 내일배움캠프 Unity 과정 12기 4주차 개인 과제 메타버스 구현 레포지토리 입니다.

---

# 구현 기능
- 도전 기능 구현 X
- 필수 기능

<br>
  
1. **캐릭터 이동 및 탐색**
   - WASD 또는 방향키를 이용해 2D 캐릭터 (`Player`) 를 움직일 수 있습니다.
   
     <img src="https://github.com/user-attachments/assets/9e3b3dce-d106-42bc-bc36-3e863f0f5d7f">

    - Unity `Tilemap` 과 `Tilemap Collider` 를 활용해, `Player` 의 이동 영역을 제한하였습니다.

      <img width="1100" height="422" alt="image" src="https://github.com/user-attachments/assets/60653d94-0844-462e-ac63-104d16a45791" />

<br>     
  
2. **맵 설계 및 상호작용 영역**
   - 타일맵과 게임 오브젝트들을 배치하여, `MainScene` 을 구성하였습니다.
   - `MainScene` 에 위치한 두 개의 울타리에는 상호작용 가능한 닭과 돼지가 각각 한 마리씩 숨어있습니다:)
     
     <img width="270" alt="스크린샷 2025-10-28 144301(1)" src="https://github.com/user-attachments/assets/930c1b53-912d-474c-a51a-d12cfd94ced8" />
     <img width="270" alt="스크린샷 2025-10-28 144404(1)" src="https://github.com/user-attachments/assets/991b7468-1102-45bc-a46d-a8eaf44b269a" />

   - `Player` 가 오브젝트와 상호작용 가능한 범위 이내에 다가가면, 오브젝트의 `Collider` 를 통해 `Trigger` 이벤트가 발생하여, 상호작용할 수 있습니다.
     - 오브젝트 (닭, 돼지) 위에 `스페이스바를 눌러 게임 시작` 이라는 `Text UI` 가 나타납니다.
     - 각각의 오브젝트를 통해, 서로 다른 미니게임을 실행할 수 있습니다.
       - 닭 ⇒ `FlappyChickenScene` 으로 이동 (Flappy Bird 카피 게임)
       - 돼지 ⇒ `StackStrawScene` 으로 이동 (Stack 카피 게임)

<br>
   
3. **미니 게임 실행**
   - 제공된 강의에서 실습하였던 미니 게임 코드를 재활용하여 구현되었습니다.
   - 각각의 미니 게임은 상호작용 오브젝트와 이 프로젝트의 개성을 표현할 수 있는 에셋을 활용하여 변형되었습니다.
     
     <img width="308" height="172" alt="image" src="https://github.com/user-attachments/assets/6b3a8cb9-1f88-4217-ba0e-08513d9e9d1e" />
     <img width="244" height="233" alt="image" src="https://github.com/user-attachments/assets/7e0d9345-2271-40a2-82c7-8edccfa90156" />


   - 각각의 미니 게임에는 첫 화면 (`HomeUI`), 게임 중 점수 표시 (`GameUI`), 게임 종료 시 점수와 최고점수 표시 (`ScoreUI`) UI 가 구현되어 있습니다.
   - 미니 게임 씬 내 `Exit` 버튼을 누르면 `MainScene` 으로 되돌아갑니다.

<br>

4. **점수 시스템**
   - 미니 게임 실행 중에는 점수가 실시간으로 보이도록 구현하였습니다. (각 미니 게임의 `GameUI`)
   - 최고 점수 저장도 `Stack Straw` 에서는 올바르게 작동하는 것 같지만, `Flappy Chicken` 에서는 제대로 작동하지 않는 것 같습니다.

<br>

5. **게임 종료 및 복귀**
   - 미니 게임 종료 후, UI 로 표시되는 `Exit` 버튼을 누르면 `MainScene` 으로 돌아가게끔 구현하였습니다.
   - 단, 이 기능도 `Stack Straw` -> `MainScene` 의 경우에서는 `Player` 가 다시 잘 움직이지만, `Flappy Chicken` 의 경우, 움직이지 않는 오류가 존재합니다.

<br>

6. **카메라 추적 기능**
   - `MainScene` (메인 게임 맵) 과 `FlappyChickenScene` (Flappy Chicken 미니게임) 내에서는 `Main Camera` 가 `Player` 를 따라 움직입니다.

<br>

---

# 트러블 슈팅 TIL
> [[내일배움캠프] Unity 과정 본캠프 20일차 (2025.10.27)](https://velog.io/@arara02/내일배움캠프-Unity-과정-본캠프-20일차-2025.10.27)
<br>[[내일배움캠프] Unity 과정 본캠프 21일차 (2025.10.28)](https://velog.io/@arara02/내일배움캠프-Unity-과정-본캠프-21일차-2025.10.28)

<br>

---

# 과제 수행 중 어려웠던 점 또는 궁금한 점
- **(과제 제출할 때, 시간이 부족해 작성하지 못했던 질문들 남겨봅니다...! 과제 피드백과 함께 답변 주시면 감사드리겠습니다!)**
1. 일단 과제 안내 페이지 (노션) 에 나와 있는 프로세스대로 강의 수강 → 코드 분석 → 스켈레톤 코드 작성 → 과제를 구현하려고 하니, 절대적인 시간이 많이 모자랐던 것 같습니다...
이런 경우, 과감하게 강의를 스킵하고 (또는 필요한 부분만 수강하거나 코드만 분석하고) 기능을 구현하는 방식으로 진행해도 괜찮을까요? (앞으로 캠프를 진행하면서 이번과 비슷한 상황이 발생하면 어떻게 과제를 전략적으로 수행해야 할 지 잘 모르겠습니다...ㅠ)

2. `MainScene` 과 `FlappyChickenScene` (미니게임1) 의 경우, 가로 화면 비율 (16:9) 이고, `StackStrawScene` (미니게임2) 의 경우, 세로 화면 비율 (9:16) 로 고정될 수 있도록, 각각의 씬의 화면 방향? 비율? 을 설정하는 방법은 없을까요? (검색해도 잘 안 나와서...)

3. 각각의 미니 게임에서 사용되는 C# 스크립트가 (특히, UI 관련 스크립트) 일부만 다르게 동작하고, 중복되는 부분이 많은데, (일단 현재는 따로 분리해서 작성해놓긴 하였습니다.) 이걸 좀 더 효율적으로 작성하여 재사용성을 높이는 방법을 알고 싶습니다.

4. 이렇게 실습 자료 (게임을 제작하는 데 필요한 에셋적인 부분) 가 전혀 없는 상태에서는 100% 스스로 만들어 본 프로젝트가 처음이라, 초반에 많이 헤맸던 것 같습니다. 좀 더 통일성 있는, 또는 원하는 에셋을 검색하는 꿀팁같은 것이 있을까요...?

<br>

---

# 앞으로 수정 또는 추가 구현해야 할 사항
1. 미니 게임 실행 시, 첫 화면에 게임 설명 (게임 방법 설명?) UI 추가
2. `Flappy Chicken` 미니 게임에서 `Exit` 버튼을 눌러 `MainScene` 으로 돌아갔을 때, 캐릭터의 직전 위치 기억 + 움직이지 않는 현상 fix
3. `MainScene` 에서 각각의 미니 게임의 기록을 표시하는 UI 추가
4. `Flappy Chicken` 의 점수 기록 (`PlayerPrefs`) 가 잘 동작하는지 확인하고, 오류가 있다면 수정할 것
