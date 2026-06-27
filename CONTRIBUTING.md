# 1. Git 브랜치 전략
### <Github Flow 기반>
- `main` : 안정적인 배포용 버전 유지
- `feature/기능명` : 새로운 기능 개발용 브랜치
- `fix/버그명` : 버그 수정용 브랜치

---
# 2. 커밋 컨벤션
### 형식) `<type>: <subject>`

| type | 설명 | 예시 |
|------|------|------|
| feat | 새 기능 | feat: 플레이어 이동 기능 구현 |
| fix | 버그 수정 | fix: 충돌 버그 수정 |
| docs | 문서 | docs: README 업데이트 |
| refactor | 리팩토링 | refactor: 코드 구조 개선 |
| chore | 기타 설정 | chore: 패키지 업데이트 |

