select country from Customers
--Müşterilerin ülkelerini göster

select distinct country from Customers
--Tekrar eden ülkeleri ele

select count (distinct country)from Customers
--sonucu say

select * from Customers where City='Paris'
--Tüm kolonlarda, Customers Tablosunda
-- şehri Paris olanları bul!

select customerId,City from Customers
--Customers tablosundaki customer id ve city kolonlarını getir

select ProductId from Products where ProductID<=4 or ProductID=30
--Products tablosunda ProductId kolonundaki 4 den küçük ve 30'a eşit olanı göster

select * from Customers where Country='usa' and City= 'butte'
--Customers tablosundaki tüm kolonlarda Country'si USA ve 
--city'si Butte olanları göster

select * from Customers order by City

select * from Customers order by Phone
-- customers tablosudaki tüm kolınların içinden phone kolonunu artan 
--şekilde sırala  (Order by'in default ayarı artan şekilde sıraladır)
select * from Products order by UnitPrice

select * from Products order by ProductID asc
--Aynı şekilde "asc" de artan şekilde sırala demektir

select * from Products order by UnitPrice desc
--Desc ise azalan/düşen şekilde sırla demektir

insert into Customers(CustomerID,CompanyName,Address) 
values ('448','Clockistan','Van')
--Customer tablosundaki CustomerID,CompanyName,Address kolonlarına
--'448','Clockistan','Van' değerlerini ekle


select CompanyName from Customers where Phone is null
--Customers tablosundaki Phone verisi boş olanın CompanyName'ini ver

select CompanyName,CustomerID from Customers where Fax is null -- Örnek

select CompanyName,CustomerID from Customers where Phone is not null

insert into Customers(CustomerID,CompanyName,Phone)
values ('998','Flat Bread in Konya','248-08-83')

update Customers set Phone='03322480883' 
where CustomerID='999'

update Customers set Region='Ic Anadolu', Country='Turkey'
where CustomerID='999'
--Customers tablosundaki Region ve Country kolonlarında CustomerId'si 999'a
--denk gelen hücreleri güncelle

select * from Customers where Country='usa'
--Customers tablosundali tüm kolonlarda Country'si "USA'ya" denk gelen
--satırları sil(kod doğru)

select top 10 CompanyName,CustomerID, Address,Phone from Customers
--Customers tablsoundaki yukarıda belirtiler kolonlardan
--üstten ilk 10 tanesini göster

select min(unitprice) SmallestPriceEnDusukUcret from Products
--Products tablosunda UnitPrice kolonunun en düşük verisini
--SmallestPriceEnDusukUcret adında bas


select max(unitprice) aaa from Products

select COUNT(CustomerID) from Customers
--Customers tabloasundaki CustomerId sayısını ver

select avg(UnitPrice) bbb from Products
--Products tablosundaki unitprice kolonunun ortalmasını al

select sum(unitprice) from Products
--Products tablosundaki unitprice kolonunun toplamını ver

select sum(Quantity) from [Order Details]

select * from Products where UnitPrice like '3%'
select ProductID,ProductName,UnitPrice from Products where UnitPrice like '3%'
--Products tablosunda UnitPrice kolonunda 3 ile başlayanların
--ProductID,ProductName,UnitPrice kolonlarını ver

select * from Products where UnitPrice like '%9'
--Products tablosunda UnitPrice kolonunda 9 ile bitenlerin tüm kolonlarını ver

select * from Customers where CompanyName like '%as'

select * from Customers where CompanyName like '%read%'
--Costomers tablosuda CompanyName kolonunda read bulunan
--verinin tüm kolonlarını bas

select * from Customers where CompanyName like '_t%'
--companyname kolonunda ikinci harfi t ile başlayan veriyi bas

select * from Customers where CompanyName like 'f_____________%' --13 altçigizvar
--companyname kolonunda başı f ile başlayan en az 14 karakterlileri bul

select * from Customers where CompanyName like 'fl_%'

select * from Customers where CompanyName like 'f%b'
--companyname kolonunda başı f ile başlayan b ile biteni bul

select * from Customers where CompanyName like 's%'

select * from Customers where City like '[ert]%'
--Cusotmers tablosunda City kolonunda E veye R veye T ile başlayan 
--müşterileri ver

select * from Customers where City not like '[ert]%'
--Cusotmers tablosunda City kolonunda E veye R veye T ile başlayan 
--müşteriler haricindeki hepsini ver

select * from Customers where City like '[a-h]%'
--Cusotmers tablosunda City kolonunda ilk harfi
--a harfinden h farfine kadar olanları ver

select * from Customers where Country in ('Germany', 'UK' , 'Mexico')

--Cusotmers tablosundaki Ülkesi Almanya, Birleik Karıllık ve Meksika olan 
--müşterileri getir

select * from Customers where Country not in ('Germany', 'UK' , 'Mexico')

--Cusotmers tablosundaki Ülkesi Almanya, Birleik Karıllık ve Meksika olan 
--müşteriler haricindeikileri getir


select * from Customers where Country in (select Country from Suppliers)
--Customers tablosunda ülkesinide tedarikçi bulunanları bas
--Tedarikçisi ile ülkesi aynı olanaları bas

select * from Products where UnitPrice between 5 and 15;
--Products tablosunda unitPrice kolonunda 5 ile 15 arasındakileri ver

select * from Products where UnitPrice not between 5 and 15;
--Products tablosunda unitPrice kolonunda 5 ile 15 arasındakileri harcindekileri ver


select * from Products where UnitPrice between 5
and 15 and CategoryID not in (1,2,3)
--Products tablosunda unitPrice kolonunda 5 ile 15 arasındakileri ver 
--ama categoryid'si 1,2,3 olmasın


select * from Products where ProductName between 'Scottish Longbreads'
 and 'Tunnbröd' order by ProductName
 --Products tablosunda ProductName'de yukardaki iki isim arasını ver
 --ayrıca ProductName'i sırala

 select * from Products where ProductName not between 'Scottish Longbreads'
 and 'Tunnbröd' order by ProductName
 --Products tablosunda ProductName'de yukardaki iki isim arasında kalanlar
 --haricindekileri ver ayrıca ProductName'i sırala

select * from Orders where OrderDate between #20/05/1996# and #25/12/1996#
--veya (yukardaki doğru)

select * from Orders where OrderDate between '1996-5-20' and '1996-12-25'order by OrderDate
--Orders tablosunda OrderDate kolonunda yukardaki tarihler arasındakileri ver

select orders.OrderID, customers.CompanyName, Orders.OrderDate
from orders inner join Customers on Orders.CustomerID=Customers.CustomerID
--Oders ve Customers tablolarını şarta göre birleştir ve yukardaki kolonları bas
--Şart: Oders tablosundaki CustomerId ile Customers tablosundaki customerid 
--kolonlarını eşitle!

select orders.OrderID, customers.CompanyName, Orders.OrderDate, Shippers.CompanyName
from orders inner join Customers on Orders.CustomerID=Customers.CustomerID
inner join Shippers on Shippers.ShipperID=orders.ShipVia
--birlşetirmeye inner join diyerek devam edebiliriz

select * from Customers left join Orders on Customers.CustomerID=Orders.CustomerID
where orders.CustomerID is null
--Left Join sol tabloda (Customers.CustomerID) olup sağ tabloda (Orders.CustomerID)
-- olmayanlars null koyar
-- Biz de şart olarak null /veri olmayanları göster dedik
--Böylece Müşteri olup hiç sipariş vermeyeni bulmuş oluruz

select * from Orders o right join Employees  e on o.EmployeeID=e.EmployeeID
where e.EmployeeID is null

select Customers.CustomerID, orders.CustomerID ,orders.OrderID from Customers
full outer join orders on Customers.CustomerID=orders.CustomerID
order by Customers.CustomerID

--Aslen mantığı iki tabloyu karşılaştırıp yeni bir kolon oluşturmak diyebiliriz
--İnternetteiki sınıf örneği gayet açıklayıcı

select City from Customers union all select City from Employees order by City
--Uninon tek satırda iki defa selct yapabilmek içindir

select city,Country from Customers
where Country='USA'
union 
select city,COUNTry from Suppliers
where Country='USA'
order by City

select count(SupplierID), Country from Suppliers
group by Country
order by count(SupplierID)
--Suppliers tablosunda Country ve SupplierId'yi ver fakat supplierId'nin verisini değil
--sayısını ver ve Country'leri de gurupla 

select count(SupplierID), Country from Suppliers
group by Country
order by Country

select count(CustomerID),Country from customers
group by Country having COUNT(CustomerID)>6
--Customers tablosundaki customerId'yi say, countryr kendi arasında gurupla ve 
--bunlar arasında customerId'si 6 dan büyük olanları bas

select count(CustomerID),Country from customers
group by Country having COUNT(CustomerID)>6 order by COUNT(CustomerID) desc

select Employees.LastName , COUNT(Orders.OrderID) SatisNumarasi
from Orders inner join Employees on Orders.EmployeeID=Employees.EmployeeID
group by LastName having COUNT(Orders.OrderID)>75

--Orders ile Employess'te ki LastName'leri birleştir, Employess'te ki LasrName'i gurupla
-- bu guruba karşılık gelen orders'ta ki orderId'yi say ve OrderID'si 75 den büyük olanları bas

select City,SupplierID from Suppliers
where exists (select City from Customers where Suppliers.City=Customers.City)
-- Suppliers tablosu ile Customers tablosunu karşılşatır City'si aynı olanı bul ve bas

select City from Suppliers
where exists (select City from Customers where Suppliers.City=Customers.City and SupplierID<5)

select City from Suppliers
where exists (select City from Customers where Suppliers.City=Customers.City and SupplierID=18)

select ProductName, ProductID from Products
where ProductID= any (select ProductId from [Order Details] where Quantity = 5)
order by ProductID asc
--Procusts tablosunda productName ve ProductId kolonlarını şarta göre ver
--Şart productId eşit olsun alt sorguya
--alt sorgu orderDetails tablsonda ki prductId'lerden quantity/Miktar'ı 5' eşit olanı ver

select ProductName, ProductID from Products
where ProductID= all (select ProductId from [Order Details] where Quantity = 5)
order by ProductID asc

--any ile all arasında ki fark "ALL'da" yukardaki şarta hepsi uyarsa TRUE 
-- bir tane bile uymazsa FALSE döner

--"ANY'de" ise yukardaki şartta bir tanesi bile uyarsa TRUE eğer hiç biri 
--uymazada FALSE döndürür

select * into products27022021
from Products
--Products tablosunu products27022021 isiminde bir tablo daha oluşturmasını istedik

SELECT * INTO CustomersGermany
FROM Customers
WHERE Country = 'Germany';
--Customers tablosundaki Ülkesi Germany olanları bulmasını ve bunu yeni ismi
--CustomersGermany olan bir tabloya basmasını istedik

select Customers.CompanyName, Orders.OrderID
 into CustoemersNotOrderBackup2021
 from Customers
 left join Orders on Customers.CustomerID=Orders.CustomerID
--Cusotomers'ta ki customerId ile Orders'da ki CustomerId'de sol(c.c) tarafata
--olup sağ(o.c) tarafta olmayanların bilgilierini CustoemersNotOrderBackup2021
--adında bir tasbloya bas

select ProductID, ProductName,UnitsInStock,
case 
	when UnitsInStock=0 then 'Abovvv bitmiş elleam'
	when UnitsInStock<10 then '10nun altında bitiyor'	
	when UnitsInStock>=40 then 'Daha baya var sonuçta 40 tan fazla'

	else '10 ile 40 arasındasın ne olursun ne ölürsün'
end as UnitStockText
from Products
order by ProductName


select ProductName, UnitPrice*(UnitsInStock+isnull(UnitsOnOrder,0)) 
from Products
--Prducts'ta ki PrductName'i ve ve şu işlemin sonucu ver
--İşlem UnitPrice(UnitInStock +UnitsOnOrder) = Eldeki malın değeri
--Isnull ise UnitsOnOrder Null olduğunda cevabın Null olmaması için 
--UnitsOnOrder yerine 0'ı döndür

create procedure AllCustomers as select * from Customers go
--Create Procedure ile aynı Refoctor gibi kodu tekrarlmadan kısayolunu
--oluşturablirsin ve exec kısayolAdi ile de çalıştırabilirisin
--Exec'in çalışması için create procedure... komutunu çalıştırman gerekir


exec AllCustomers

create procedure StokAdedi2 as 
select ProductID, ProductName,UnitsInStock,
case 
	when UnitsInStock=0 then 'Abovvv bitmiş elleam'
	when UnitsInStock<10 then '10nun altında bitiyor'	
	when UnitsInStock>=40 then 'Daha baya var sonuçta 40 tan fazla'

	else '10 ile 40 arasındasın ne olursun ne ölürsün'
end as UnitStockText
from Products
order by ProductName
go

exec StokAdedi

create procedure Tedarikci @city nvarchar(30)/*değişken*/
as
select * from Customers where City=@city 
exec Tedarikci @city='berlin'

select Products.ProductName,
sum ([Order Details].UnitPrice*isnull([Order Details].Quantity,0)) as TotalPrice
from Products inner join [Order Details] on [Order Details].ProductID=Products.ProductID
inner join Orders on [Order Details].OrderID=Orders.OrderID
group by ProductName
order by ProductName
