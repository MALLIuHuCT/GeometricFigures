SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductsCategories pc
    ON p.Id = pc.ProductId