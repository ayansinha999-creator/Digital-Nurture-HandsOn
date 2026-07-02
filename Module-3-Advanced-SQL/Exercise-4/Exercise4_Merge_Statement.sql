CREATE TABLE Products_New (
    ProductID NUMBER PRIMARY KEY,
    ProductName VARCHAR2(100),
    Category VARCHAR2(50),
    Price NUMBER(10,2)
);

INSERT INTO Products_New VALUES (2,'Mobile','Electronics',47000);
INSERT INTO Products_New VALUES (9,'Smart Watch','Electronics',12000);
INSERT INTO Products_New VALUES (10,'T-Shirt','Clothing',1500);

COMMIT;
MERGE INTO Products p
USING Products_New pn
ON (p.ProductID = pn.ProductID)
WHEN MATCHED THEN
    UPDATE SET
        p.ProductName = pn.ProductName,
        p.Category = pn.Category,
        p.Price = pn.Price
WHEN NOT MATCHED THEN
    INSERT (ProductID, ProductName, Category, Price)
    VALUES (pn.ProductID, pn.ProductName, pn.Category, pn.Price);
SELECT *
FROM Products
ORDER BY ProductID;