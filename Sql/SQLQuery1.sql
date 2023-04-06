
--Catagory Procedures

--to Getcatagorydata
Create procedure GetCatagory
as
select * from Catagories
go


--GetCatagorydataById
create procedure GetByIdCatagory @CId int
as
select * from Catagories where CId=@CId
go

--AddCatagorydata
create procedure AddCatagory @CatagoryName varchar(200)
as
insert into Catagories values(@CatagoryName)
go

exec AddCatagory 'Electrication'

--UpdateCatagorydata
create procedure UpdateCatagory (@CatagoryName varchar(100),@CID int)
as
update Catagories set CatagoryName=@CatagoryName where CId=@CID
go

--DeleteCatagorydata

create procedure DeleteCatagory @CId int
as
delete from Catagories where CId=@CId
go



--ProductProcedures

--GetProductdata
create procedure GetProduct 
as
select * from Products  inner join Catagories  on  Products.Catagory_CId=Catagories.CId
go

--Get Product data Instead of CatagoryId it Will Come CatagoryName
--used alias name for easy to understand
create procedure Productdata
as
select p.PId,p.ProductName,c.CatagoryName from Products as p
inner join Catagories as c on p.Catagory_CId=c.CId
go

exec Productdata
--GetProductdataById

create procedure GetProductdataById @PId int
as
select * from Products where PId=@PId
go

--AddProductdat
create procedure AddProductdata @ProductName varchar(200) ,@Catagory_CId int
as
insert into Products values (@ProductName,@Catagory_CId)
go

--select * from Products p join Catagories c on p.Catagory_CId=c.CId

--insert into Products values('Mobile',1)


--Updateproductdata
create procedure UpdateProductdata @ProductName varchar(200) ,@Catagory_CId int ,@PId int
as
update Products set ProductName=@ProductName,Catagory_CId=@Catagory_CId where PId=@PId
go


--DeleteProductdata
create procedure DeleteProductdata @PId int
as
delete from Products where PId=@PId
go




