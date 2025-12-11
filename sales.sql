DROP TABLE pos_sales_detail CASCADE CONSTRAINTS PURGE;
/
DROP TABLE pos_sales CASCADE CONSTRAINTS PURGE;
/

CREATE TABLE pos_sales (
    sid            NUMBER PRIMARY KEY,
    sdate          DATE DEFAULT SYSDATE,
    total          NUMBER,
    status         VARCHAR2(20) DEFAULT 'Á¤»ó',
    payment_method VARCHAR2(30)
);
/

CREATE TABLE pos_sales_detail (
    sdid   NUMBER PRIMARY KEY,
    sid    NUMBER REFERENCES pos_sales(sid) ON DELETE CASCADE,
    pid    NUMBER REFERENCES product(pid),
    qty    NUMBER,
    amount NUMBER
);
/

COMMIT;
