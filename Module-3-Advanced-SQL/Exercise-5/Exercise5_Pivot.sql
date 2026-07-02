CREATE TABLE Sales_Pivot (
    ProductName VARCHAR2(50),
    Category VARCHAR2(30),
    Amount NUMBER
);

INSERT INTO Sales_Pivot VALUES ('Laptop','Electronics',75000);
INSERT INTO Sales_Pivot VALUES ('Mobile','Electronics',45000);
INSERT INTO Sales_Pivot VALUES ('Shirt','Clothing',2000);
INSERT INTO Sales_Pivot VALUES ('Jeans','Clothing',3500);

COMMIT;
SELECT *
FROM (
    SELECT Category, Amount
    FROM Sales_Pivot
)
PIVOT (
    SUM(Amount)
    FOR Category IN (
        'Electronics' AS Electronics,
        'Clothing' AS Clothing
    )
);