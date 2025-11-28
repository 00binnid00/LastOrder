drop table product purge
/
create table product ( pid number primary key, pname varchar2(50), price number, stock number, category varchar2(20));
/
insert into product values (1001, '코카콜라 500ml', 1800, 30, 'DRINK');
/
insert into product values (1002, '사이다 500ml', 1700, 25, 'DRINK');
/
insert into product values (1003, '초코바', 1200, 40, 'SNACK');
/
insert into product values (1004, '포카칩', 1500, 20, 'SNACK');
/
insert into product values (1005, '삼각김밥 참치', 1500, 15, 'COLD');
/
insert into product values (1006, '샌드위치 햄치즈', 3500, 10, 'COLD');
/
insert into product values (1007, '건전지 AA', 3000, 50, 'ETC');
/
insert into product values (1008, '종량제 봉투(20L)', 700, 100, 'ETC');
/
