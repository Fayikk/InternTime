----Kodlarımız Northwind üzerinden gerçekleştirilmektedir.

--Çalışamların sayısını listeleyim.
select count(*) calisansayisi from Employees
--Çalışanların adını ve soyadını listeleyelim
select FirstName,LastName from Employees
--Patronu ve çalışan kadınları listeleyelim
select Title,TitleOfCourtesy from Employees where TitleOfCourtesy='Dr.' or TitleOfCourtesy='Mrs.'
--Çalışan erkekleri listeleyelim
select FirstName,LastName,TitleOfCourtesy from Employees where TitleOfCourtesy='Mr.' 
--Çalışan erkek ve kadın sayılarını bulalım
select TitleOfCourtesy ,count(*) from Employees group by TitleOfCourtesy 
--Çalışanlar kaç farklı şehirde çalışıyorlar
select city,count(*) from Employees group by City
--Doğum tarihi 1960-05-29 dan büyük olanları bulalım
select BirthDate from Employees where BirthDate>='1960-05-29'
--Adresinin içerisinde house geçenleri listeleyelim
select FirstName,LastName from Employees where [Address] LIKE '%House%';--Lıke komutu içerisinde varmı şeklindeki sorgularda kullanılırlar
--Extension kolonu  3 haneli olanları listeleyelim
select firstName,Extension from Employees where Extension>=100 and Extension<=999
select FirstName from Employees where len(Extension)=3--Bu şekilde de kullanımı mevcuttur.
--Çalışanların yaşlarını bulalım (Toplamını hesaplayalım)
--select FirsName,LastName,sum(BirthDate-HireDate)  from Employees group by Age


--Region kolonu NULL olanları listeleyelim
select FirstName,LastName,region from Employees where region is null
--Çalışanların adlarını a'dan z'ye doğru listeleyelim
select FirstName from Employees Order by FirstName asc
--Çalışanların adlarının baş harflerini z'den a'ya doğru listeleyelim
select FirstName from Employees order by FirstName desc
--Çalışanların adlarının baş harflerini z'den a'ya doğru listeleyelim,soyadlarını ise Z'den A'ya doğru listeleyelim
select  FirstName,LastName from Employees order by FirstName asc,LastName desc 
--Müşteri adı "A" ile başlayan şirketler hangileridir.
select ContactName,CompanyName from Customers  where ContactName LIKE 'a%'
--Fax ve region bölgeleri null olan müşteriler kimlerdir.
select ContactName,Fax,Region from Customers where fax is null and Region is null
--Customer ID'si AA ile biten müşterileri listeleyelim.
select ContactName,CustomerId from Customers where CustomerID LIKE '%AA'
--Ürün adlarını büyüterek getir
select UPPER(ProductName) ürünadi from Products 
--Stoğu olmayan ürünler kaç tanedir
select UnitsInStock,count(*) Adet from Products where UnitsInStock=0 group by UnitsInStock
--Stok adedi 20 ile 50 arasındaki ürünleri getirin.
select UnitsInStock from Products where UnitsInStock BETWEEN 20 AND 50;
--En pahalı ürünün fiyatını getirin
select TOP 1 UnitPrice from Products order by UnitPrice desc
--Kaç çeşit ürün vardır.
select count(ProductID) from Products
--En pahalı ürünün adı nedir?
 select TOP 1 ProductName,UnitPrice from Products order by UnitPrice desc
 --Müşterilerin ülkelere göre sayılarını veren sorguyu yazalım
 select Country,count(Country) ülkeleregöredağılım from Customers group by Country
 --Her kategoriden kaç ürün vardır?
 select CategoryID,count(CategoryID) ID from Products group by CategoryID

 ----30 örnek


