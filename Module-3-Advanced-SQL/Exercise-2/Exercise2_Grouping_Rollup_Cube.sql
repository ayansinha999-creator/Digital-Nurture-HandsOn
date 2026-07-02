SELECT * FROM PRODUCTS;
SELECT
    Category,
    SUM(Price) AS Total_Price
FROM Products
GROUP BY ROLLUP(Category);
SELECT
    Category,
    SUM(Price) AS Total_Price
FROM Products
GROUP BY CUBE(Category);
SELECT
    Category,
    SUM(Price) AS Total_Price
FROM Products
GROUP BY GROUPING SETS (
    (Category),
    ()
);