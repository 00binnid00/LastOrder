DROP TABLE pos_event_detail CASCADE CONSTRAINTS PURGE;
/
DROP TABLE pos_event CASCADE CONSTRAINTS PURGE;
/
CREATE TABLE pos_event (
    eid            NUMBER PRIMARY KEY,
    pid            NUMBER REFERENCES product(pid),
    ename          VARCHAR2(100),
    etype          VARCHAR2(20),
    discount_value NUMBER,
    buy_qty        NUMBER,
    free_qty       NUMBER,
    sdate          DATE,
    edate          DATE,
    description    VARCHAR2(300)
);
/
ALTER TABLE pos_event ADD CONSTRAINT uq_event_pid UNIQUE (pid);
/
CREATE TABLE pos_event_detail (
    edid NUMBER PRIMARY KEY,
    eid  NUMBER REFERENCES pos_event(eid),
    pid  NUMBER REFERENCES product(pid)
);
/
DROP SEQUENCE seq_event_id;
/
CREATE SEQUENCE seq_event_id START WITH 1 INCREMENT BY 1 NOCACHE;
/
DROP SEQUENCE seq_event_detail_id;
/
CREATE SEQUENCE seq_event_detail_id START WITH 1 INCREMENT BY 1 NOCACHE;
/
COMMIT;
