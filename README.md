# 원자재 재고 관리 시스템

## 개요

제철소의 원자재의 입고, 출고, 주문을 관리하고, 직원 정보를 관리하는 제조업 회사의 재고 관리 기능의 일부를 구현하였습니다.

- 개발 환경
Microsoft Visual Studio Community 2019 v16.8.2
C# 8.0
.net framework 4.8


# DB 스키마

<img src="./Document/DB 스키마.png" width="45%">

## 이슈: 입출고 화면에서 기간, 리소스 ID 없이 조회하는 경우 쿼리 결과가 많으므로
조회중에 UI가 멈추는 현상이 발생한다.

페이징 쿼리

데이터가 많아서 한번에 출력할 수가 없어서 row를 나눠서 가져오는 방법으로 처리함

