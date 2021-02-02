--Select
--Select ContactName Ad, CompanyName Sirketadi, City Sehir from Customers --bellekte liste oluşturup getiriyor

--Select * from Customers where City = 'London'

--case insensitive
--seLeCt * from Products where CategoryID=1 or CategoryID = 3

--seLeCt * from Products where CategoryID=1 and UnitPrice>=10


--select * from Products order by CategoryID, ProductName

--select * from Products where CategoryID=1 order by UnitPrice desc --ascending - descending

--select count(*) Adet from Products where CategoryID=2

--select CategoryID, count(*) from Products group by CategoryID 

--select CategoryID, count(*) from Products where UnitPrice>20 
--group by CategoryID having count(*)<10



--select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
--from Products inner join Categories --ikisini birleştirdim
--on Products.CategoryID = Categories.CategoryID --bunlar eşitse bir araya getir
--where Products.UnitPrice>10


--select * from Products p inner join [Order Details] od
--on p.ProductID = od.ProductID
--inner join Orders o
--on o.OrderID = od.OrderID --bir join daha eklemek istersek böyle kullanırız.


select * from Customers c left join Orders o --solda olup sağda olmayanları da getir diyorum 
on c.CustomerID = o.CustomerID
where o.CustomerID is null