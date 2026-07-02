CREATE TABLE Products (
    ProductID NUMBER PRIMARY KEY,
    ProductName VARCHAR2(100),
    Category VARCHAR2(50),
    Price NUMBER(10,2)
);

INSERT INTO Products VALUES (1,'Laptop','Electronics',75000);
INSERT INTO Products VALUES (2,'Mobile','Electronics',45000);
INSERT INTO Products VALUES (3,'Tablet','Electronics',30000);
INSERT INTO Products VALUES (4,'Headphones','Electronics',5000);

INSERT INTO Products VALUES (5,'Shirt','Clothing',2000);
INSERT INTO Products VALUES (6,'Jeans','Clothing',3500);
INSERT INTO Products VALUES (7,'Jacket','Clothing',6000);
INSERT INTO Products VALUES (8,'Shoes','Clothing',4500);

COMMIT;

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER(PARTITION BY Category ORDER BY Price DESC) AS Row_Number,
    RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS Rank_Number,
    DENSE_RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS Dense_Rank_Number
FROM Products;