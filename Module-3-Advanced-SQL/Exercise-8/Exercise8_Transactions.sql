CREATE TABLE Bank_Accounts (
    AccountID NUMBER PRIMARY KEY,
    AccountHolder VARCHAR2(50),
    Balance NUMBER
);

INSERT INTO Bank_Accounts VALUES (1,'Ayan',10000);
INSERT INTO Bank_Accounts VALUES (2,'Rahul',5000);

COMMIT;
UPDATE Bank_Accounts
SET Balance = Balance - 2000
WHERE AccountID = 1;

SAVEPOINT Transfer_Point;

UPDATE Bank_Accounts
SET Balance = Balance + 2000
WHERE AccountID = 2;

SELECT * FROM Bank_Accounts;
ROLLBACK TO Transfer_Point;

SELECT * FROM Bank_Accounts;
COMMIT;