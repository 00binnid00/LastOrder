DROP TABLE event CASCADE CONSTRAINTS PURGE;
/

CREATE TABLE event_info (
    eid NUMBER PRIMARY KEY,
    pid NUMBER REFERENCES product(pid),
    event_name VARCHAR2(50),
    discount_type VARCHAR2(20),
    discount_value NUMBER,
    bundle_buy NUMBER,
    bundle_free NUMBER,
    description VARCHAR2(200),
    start_date DATE,
    end_date DATE
);
/
COMMIT;
