В файле .github/workflows/main.yml описан workflow для автоматического запуска тестов при изменении данных


Ответ на 3 вопрос:

SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
