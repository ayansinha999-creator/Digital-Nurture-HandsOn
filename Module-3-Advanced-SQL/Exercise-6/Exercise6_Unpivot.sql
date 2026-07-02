SELECT *
FROM (
    SELECT
        SUM(CASE WHEN Category = 'Electronics' THEN Amount END) AS Electronics,
        SUM(CASE WHEN Category = 'Clothing' THEN Amount END) AS Clothing
    FROM Sales_Pivot
)
UNPIVOT (
    Total_Amount
    FOR Category IN (
        Electronics AS 'Electronics',
        Clothing AS 'Clothing'
    )
);