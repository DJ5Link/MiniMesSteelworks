# 원자재 재고 관리 시스템

## 개요

제철소의 원자재의 입고, 출고, 주문을 관리하고, 직원 정보를 관리하는 제조업 회사의 재고 관리 기능의 일부를 구현하였습니다.

## 개발기간
2020년 11월 23일 ~ 11월 29일

개발 환경

Microsoft Visual Studio Community 2019 v16.8.2

C# 8.0

.net framework 4.8

## 화면 목록
1. 로그인

2. 직원 관리

3. 재고 관리

4. 발주 관리

5. 창고 관리

6. 원자재 시세



# DB 스키마

<img src="./Document/DB Table.jpg" width="100%">

## 이슈: 입출고 화면에서 기간, 리소스 ID 없이 조회하는 경우 쿼리 결과가 많으므로
조회중에 UI가 멈추는 현상이 발생한다.

페이징 쿼리

데이터가 많아서 한번에 출력할 수가 없어서 row를 나눠서 가져오는 방법으로 처리함

# 특징
MDI 기능을 사용하여 업무 화면을 동시에 여러개 열어 사용할 수 있다.
폼에 데이터를 입력할 때 데이터 형식 검사를 수행하여 잘못된 데이터의 입력오류를 사전에 방지할 수 있다.

# 개선할 점
1. 화면의 폼에 데이터를 입력한 후 엔터키 등의 키 입력 이벤트를 처리하지 않아 사용에 약간 불편한 부분이 있다.