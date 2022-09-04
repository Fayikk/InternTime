--select * from Products
--select ProductID,ProductName,UnitPrice from Products  (Burada Products tablosundaki ıd,name,unitprice) gibi sürunları manuel olarak çekme işlemi bulundurulur.

--case insensitive

--select * from Products where categoryId=1 or categoryId=3  (where deyimi ile koşul eklendi gerekli şartların sağlandığı durumlar için yazdırma işlemini gerçekleştiriyorlar.)
--select * from Products where UnitsInStock<=10 --(Burada stok addedi 10 ve 10'dan küçük olanları yazdırma işlemini gerçekleştirmek için bir komut yazalım)
---- (UnitsInPrice<>) buradaki ifade farklıdır anlamında gelmektedir.(<>)

--select * from Products order by CategoryID

--select * from Products order by UnitPrice asc 
--select * from Products order by UnitPrice desc

--select * from Products where CategoryID=1 order by UnitPrice desc  (Seçilen koşullar ve belirtimlere göre sıralama işlemleri gerçekleştirilir.)Desc(Descending düşen sıralamayı göz önünde bulundururken)
--select * from Products where CategoryID=1 order by UnitPrice asc   (asc yükselen sırlamayı göz önünde bulundurmaktadır) 

--select count(*) Adet from Products--Burada tablomuzda kaç adet satır bulunduğunu sorgulayan deyimi inceliyoruz.
----Yukarıda alias olarak (Takma isim olarak) "Adet" kullanmaktayız.
--select count(*) from Products where CategoryID=1 -- Burada kategori ıd'si 12 olan sayısını yazdırmak istiyoruz.

--select categoryID,count(*) from products group by CategoryID --her bir grup için arka planda tablo oluşturuluyormuş gibi düşünebiliriz.
----Yukarıdaki deyim için şu söylenebilir:Products tablosu içerisinde 8'e kadar olan categoryId'ler sıralanmıştır.Bunların her birinde farklı adetler bulunmaktadır.
----Öncelikle categoryıd seçimini yaptıktan sonra count ile sayma işlemini yaparız categoryıd'nin adet sayılarını group by operasyonu ile gerçekleştirebiliriz.


--select supplierID,count(*) from products group by SupplierID -- Burada ise öncelikle supplierID için bir group by işlemi yaptık 
--Bu işlem supplierID'nin adet sayısını yazdırdı.
--select * from Products

--Ürün sayısı 10'dan az olan kategorileri listeleme işlemini yapalım?
--select * from Products
--select UnitsInStock,count(*) adet from products where UnitsInStock<10 group by UnitsInStock

--Having ifadesi aslında where deyimi ile aynı anlama gelmektedir.Ancak where deyimini having deyiminden ayıran kıstas ise şudur;
--having deyimi group by ifadesi ile filtrelenen ifadelerden sonra kullanılmalıdırlar.

--select supplierID,count(*) adet from products group by SupplierID 
--having count(*)<=2 --having deyimi kümülatif ifadelerin filtrelenmesi için kullanılırlar.



----Veritabanı tasarımı yapılırken dikkat etmemiz gereken bir koşul ise kendimizi tekrar etmeden tablolarımızı ilişkilendirmemeiz gerekmektedir.-----


--Ürünler ile kategorilerin birleşiminden veri getirmek istiyorum
--select * 
--from Products inner join Categories
--on Products.CategoryID=Categories.CategoryID
----Yukarıdaki deyimin açıklaması ve anlamı şudur;
----Products tablosu ile Categories tablosundaki deyimlerin belli bir ön koşul'u sağlamasına bağlı olarak her iki tabloyuda birleştirip yazdırma olayını gerçekleştirmektedir.

--select Suppliers.Phone supplierphone,Customers.Phone customersphone
--from Suppliers inner join Customers
--on Suppliers.city=Customers.city
--Hemen yukarıdaki tabloda daha önceden de gerçekleştirmiş olduğumuz inner join ifadesi  sayesinde gerçekleştirdiğimzi 
--Filtreleme işleminde bu sefer işimize yaran verileri çekme işlemini gerçekleştirmekteyiz
--E ticaret sistemlerini düşünecek olursak veritabanından bilgi çekme işlemini gerçekleştiriler.

--select * from Suppliers where SupplierID=2




--DTO (data transformation object) anlamına gelmektedir.
--INNER JOIN = 2 tabloda sadece eşleşenleri biraraya getirmektedir.Eşleşmeyenleri bir araya getirmezler.
-----------------------------------------------------------------
--select * from Products p right join [Order Details] od
--on p.ProductID = od.ProductID 
--Yukarıdaki ifadede Products(yani ürün bilgilerini içeren tablo içerisindeki ifadeler) ile
--Order details (sipariş detayları) içeren tabloda ki filtrelemeler göre işlem yapmaktayız.
--Dolayısıyla yazdırma işleminin sonucu ürünlerde olup,satılmayan ürünler olmadığından oreder details kadar satıra sahip olacağımız bir tablo
--İle karşılaşırız.
-----------------------------------------------------------------

--select * from [Order Details]

--Hiç satış yapamadığımız ürünler hangileridir?

--select * from Customers c left join Orders o 
--on c.CustomerID=o.CustomerID  
--where o.OrderID is null --Bu statements ile siapriş vermeyen kullanıcıları listeledik bu kullanıcılar için kampanya vs uygulaması yapılabilir.
--is null (Boş olma anlamına gelmektedir)

--left join (join işleminden önce solda olup sağda olmayan yapılar için kullanılırlar)
--right join (join işleminden sonra sağda olup sağda olmayanlarıda listele anlamına gelmektedir)
--select * from Orders -- 830 sonuç alıyorum

select * from Customers c inner join Orders o
on c.CustomerID=o.CustomerID
inner join Region r
on r.RegionID=c.Region --2 den fazla tablo arasındajoin ilişkisi kurmayı göstermiş olduk.


