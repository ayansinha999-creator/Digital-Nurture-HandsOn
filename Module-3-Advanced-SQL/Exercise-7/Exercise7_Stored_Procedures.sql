CREATE OR REPLACE PROCEDURE Get_All_Products
AS
BEGIN
    FOR rec IN (
        SELECT ProductID, ProductName, Category, Price
        FROM Products
        ORDER BY ProductID
    )
    LOOP
        DBMS_OUTPUT.PUT_LINE(
            rec.ProductID || ' | ' ||
            rec.ProductName || ' | ' ||
            rec.Category || ' | ' ||
            rec.Price
        );
    END LOOP;
END;
/
SET SERVEROUTPUT ON;

EXEC Get_All_Products;