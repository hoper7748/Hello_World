# git & source tree Help 

## git 명령어 요약

- clone: 원격 저장소 복사
- Add : 스테이지 영역에 작업 파일 추가
- Commit : 세이브, 스테이지 영역의 파일들을 가지고 커밋을 만들 수 있음
- Push : 원격 저장소에 커밋한 내용을 업로드 하는 것.
- 코드 뭉치 버리기 - 이전 내용으로 돌아가기(마지막 저장 내역으로)

## 브렌치 변경하기

- 브랜치? : 기존 내용을 유지한 채 새로운 내용을 추가하고 싶을 때 사용하는 기능.
- 체크아웃 : 특정 브렌치(혹은 커밋) 으로 돌아가고 싶을 때 사용
- 소스트리의 체크아웃 : 브렌치 이름을 더블 클릭한 것만으로 체크아웃 가능


hello world

commit system

# 병합하기 1
- 헤드 브랜치에 변경사항이 없고
- 병합 대상 브랜치가 헤드로부터 시작된 경우
- 아주 쉽게 병합 가능 = Fast Forward


# 병합하기 2
- 헤드 브랜치에 추가적인 커밋이 생기는 경우
- 진짜 병합이 필요해 진다.
- 충돌이 안 나면 좋은데, 충돌이 나도 겁내지 않기.

## 충돌 해결하기

- 제일 중요한 점 : 겁내지 않기

## 커밋 되돌리기


### reset 사용하기

- 장점: 쉽다. 
- 단점: 커밋이 날아간다. 그리고 강제 푸시가 필요하다.
## reset

- 쉽지만 커밋이 날아간다.
- 강제 푸시가 필요하다.

