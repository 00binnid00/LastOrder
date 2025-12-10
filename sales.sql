DROP TABLE pos_sales_detail CASCADE CONSTRAINTS PURGE;
/
DROP TABLE pos_sales CASCADE CONSTRAINTS PURGE;
/
CREATE TABLE pos_sales (
    sid            NUMBER PRIMARY KEY,
    sdate          DATE DEFAULT SYSDATE,
    total          NUMBER,
    status         VARCHAR2(20) DEFAULT '정상',  -- 정상 / 환불 
    payment_method VARCHAR2(30)                 -- 현금 / 카드 / 쿠폰 / 분할결제 등
);
/
CREATE TABLE pos_sales_detail (
    sdid   NUMBER PRIMARY KEY,
    sid    NUMBER REFERENCES pos_sales(sid),
    pid    NUMBER REFERENCES product(pid),
    qty    NUMBER,
    amount NUMBER
);
/
COMMIT;
/
