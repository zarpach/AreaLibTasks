SELECT 
    p.ProductName, 
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
/* 
Предполагается, что есть отдельная таблица для хранения связей между товарами и категориями. 
Внешнее соединение дает гарантию что все продукты будут включены. */
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;