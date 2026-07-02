WITH HighPricedProducts AS (
    SELECT ProductID, ProductName, Category, Price
    FROM Products
    WHERE Price > 10000
)
SELECT *
FROM HighPricedProducts;
WITH AvgPrice AS (
    SELECT AVG(Price) AS Avg_Price
    FROM Products
)
SELECT
    ProductID,
    ProductName,
    Price
FROM Products
WHERE Price > (SELECT Avg_Price FROM AvgPrice);
WITH CategoryTotals AS (
    SELECT
        Category,
        SUM(Price) AS Total_Price
    FROM Products
    GROUP BY Category
)
SELECT *
FROM CategoryTotals;