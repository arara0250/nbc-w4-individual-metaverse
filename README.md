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
   
3. 미니 게임 실행 
 - 미니게임 첫 화면 (HomeUI), 게임 중 점수 표시 (GameUI), 게임 종료 시 점수와 최고점수 표시 (ScoreUI) 구현하였습니다.
 - 미니게임 실행 시, 게임 설명 UI 는 구현하지 못하였습니다.
 - 미니게임 씬 내 Exit 버튼을 누르면 MainScene 으로 돌아오기는 하나, FlappyBird 의 경우, 돌아온 뒤 캐릭터가 움직이지 않는 문제가 존재합니다.

4. 점수 시스템
 - 미니 게임 실행 중에는 점수가 실시간으로 보이도록 구현하였습니다. (각각의 GameUI)
 - 다만, 이후 MainScene 으로 돌아왔을 때, 표시되는 UI 는 구현하지 못하였습니다.
 - 최고 점수 저장도 Stack 은 올바르게 작동하는 것 같지만, Flappy 는 제대로 작동하지 않는 것 같습니다.

5. 게임 종료 및 복귀
 - 미니 게임 종료 후, UI 로 표시되는 Exit 버튼을 누르면 MainScene 으로 돌아가게끔 구현하였습니다.
 - 단, 이 기능의 경우에도 Stack 은 MainScene 에서 Player 가 다시 잘 움직이지만, Flappy 의 경우, 움직이지 않는 오류가 존재합니다.

6. 카메라 추적 기능
   - MainScene (메인 게임 맵) 과 FlappyChickenScene (Flappy Chicken 미니게임) 에서는 Main Camera 가 Player 를 따라 움직입니다.

---

# 
