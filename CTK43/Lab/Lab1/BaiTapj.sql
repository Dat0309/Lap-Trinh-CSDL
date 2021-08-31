use [RestaurantManagement]
go

--Câu 1.Viết hết thủ tục Insert,Update,Delete
--PROCEDURE CATEGORY
create procedure Category_GetAll
as
begin
	select * from Category
end
go

create procedure Category_GetByID
(
	@ID int
)
as
begin
	select * from Category 
	where ID = @ID
end
go

create procedure Category_Insert
(
	@Name nvarchar(1000),
	@Type int
)
as
begin
	if (not exists (select Name from Category where Name = @Name))
		insert into Category (Name, Type) values (@Name, @Type)
end
go

create procedure Category_Update
(
@ID int,
@Name nvarchar(1000),
@Type int
)
as
begin
	update Category
	set [Name] = @Name , [Type] = @Type
	where ID = @ID
end
go

create procedure Category_Delete
(
@ID int
)
as 
begin
	delete from Category
	where ID = @ID
end
go


--PROCEDURE Account
create procedure Account_GetByID
(
	@AccountName int
)
as
begin
	select * from Account 
	where AccountName = @AccountName
end
go

create procedure Account_Insert
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200),
	@FullName nvarchar(1000),
	@Email nvarchar(1000),
	@Tell nvarchar(200),
	@DateCreated smalldatetime
)
as
begin
	if (not exists (select AccountName from Account where AccountName = @AccountName))
		insert into Account(AccountName,Password, FullName, Email, Tell, DateCreated) values (@AccountName, @Pass, @FullName, @Email, @Tell, @DateCreated)

end
go

create procedure Account_Update
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200),
	@FullName nvarchar(1000),
	@Email nvarchar(1000),
	@Tell nvarchar(200),
	@DateCreated smalldatetime
)
as
begin
	update Account
	set AccountName = @AccountName, Password = @Pass, FullName = @FullName, Email = @Email, Tell = @Tell, DateCreated = @DateCreated
	where AccountName = @AccountName
end
go

create procedure Account_Delete
(
@AccountName int
)
as 
begin
	delete from Account
	where AccountName = @AccountName
end
go

--Procedure BillDetail
create procedure BillDetail_GetById
@ID int
as 
begin
	select * from BillDetails
	where ID = @ID
end
go

create procedure BillDetail_Insert
@InvoiceID int,
@FoodID int,
@Quantity int
as
begin
	insert into BillDetails(InvoiceID, FoodID, Quantity) values (@InvoiceID, @FoodID, @Quantity)
end
go

create procedure BillDetail_Update
@ID int,
@InvoiceID int,
@FoodID int,
@Quantity int
as
begin
	update BillDetails
	set InvoiceID = @InvoiceID, FoodID = @FoodID, Quantity = @Quantity
	where ID = @ID
end
go

create procedure BillDetail_Delete
@ID int
as
begin
	delete from BillDetails
	where ID = @ID
end
go

--procedure Bills
create procedure Bills_GetById
@ID int
as 
begin
	select * from Bills
	where ID = @ID
end
go

create procedure Bills_Insert
@Name nvarchar(200),
@TableID int,
@Amount int,
@Discount float,
@Tax float,
@Status bit,
@CheckoutDate smalldatetime,
@Account nvarchar(100)
as
begin
	insert into Bills(Name, TableID, Amount, Discount, Tax, Status, CheckoutDate, Account) values (@Name, @TableID, @Amount, @Discount, @Tax, @Status,@CheckoutDate, @Account)
end
go

create procedure Bills_Update
@ID int,
@Name nvarchar(200),
@TableID int,
@Amount int,
@Discount float,
@Tax float,
@Status bit,
@CheckoutDate smalldatetime,
@Account nvarchar(100)
as
begin
	update Bills
	set Name = @Name, TableID = @TableID, Amount = @Amount, Discount = @Discount, Tax = @Tax, Status = @Status, CheckoutDate = @CheckoutDate,Account = @Account
	where ID = @ID
end
go

create procedure Bills_Delete
@ID int
as
begin
	delete from Bills
	where ID = @ID
end
go

--procedure Food
create procedure Food_GetById
@ID int
as 
begin
	select * from Food
	where ID = @ID
end
go

create procedure Food_Insert
@Name nvarchar(1000),
@Unit nvarchar(100),
@FoodCategory int,
@Price int,
@Notes nvarchar(3000)
as
begin
	if (not exists (select Name from Food where Name = @Name))
		insert into Food(Name, Unit, FoodCategoryID, Price, Notes) values (@Name, @Unit, @FoodCategory, @Price, @Notes)
end
go

create procedure Food_Update
@ID int,
@Name nvarchar(1000),
@Unit nvarchar(100),
@FoodCategory int,
@Price int,
@Notes nvarchar(3000)
as
begin
	update Food
	set Name = @Name, Unit = @Unit, FoodCategoryID = @FoodCategory, Price = @Price, Notes = @Notes
	where ID = @ID
end
go

create procedure Food_Delete
@ID int
as
begin
	delete from Food
	where ID = @ID
end
go

--recerdure Role
create procedure Role_GetById
@ID int
as 
begin
	select * from Role
	where ID = @ID
end
go

create procedure Role_Insert
@RoleName nvarchar(1000),
@Path nvarchar(3000),
@Notes nvarchar(3000)
as
begin
	if (not exists (select RoleName from Role where RoleName = @RoleName))
		insert into Role(RoleName, Path, Notes) values (@RoleName, @Path, @Notes)
end
go

create procedure Role_Update
@ID int,
@RoleName nvarchar(1000),
@Path nvarchar(3000),
@Notes nvarchar(3000)
as
begin
	update Role
	set RoleName = @RoleName, Path = @Path, Notes = @Notes
	where ID = @ID
end
go

create procedure Role_Delete
@ID int
as
begin
	delete from Role
	where ID = @ID
end
go

-- procedure RoleAccount
create procedure RoleAcc_GetById
@RoleID int
as 
begin
	select * from RoleAccount
	where RoleID = @RoleID
end
go

create procedure RoleAcc_Insert
@RoleID int,
@AccountName nvarchar(100),
@Actived bit,
@Notes nvarchar(3000)
as
begin
	if (exists (select ID from Role where ID = @RoleID))
		begin
			if(exists (select AccountName from Account where AccountName = @AccountName))
				insert into RoleAccount(RoleID,AccountName, Actived, Notes) values (@RoleID, @AccountName, @Actived, @Notes)
			else
				print('Khong ton tai tai khoan')
		end
	else
		print('Khong ton tai RoleID')
end
go

create procedure RoleAcc_Update
@RoleID int,
@AccountName nvarchar(100),
@Actived bit,
@Notes nvarchar(3000)
as
begin
	if(exists (select AccountName from Account where AccountName = @AccountName))
		Update RoleAccount
		set AccountName = @AccountName, Actived = @Actived, Notes = @Notes
		where RoleID = RoleID
	else
		print('Khong ton tai tai khoan')
end
go

create procedure RoleAcc_Delete
@RoleID int
as
begin
	delete from RoleAccount
	where RoleID = @RoleID
end
go

--proc table
create proc Table_GetByID
@ID int
as
begin
	select * from [Table] where ID = @ID
end
go

create proc Table_Insert
@Name nvarchar(1000),
@Status int,
@Capacity int
as
begin
	if(not exists(select Name from [Table] where Name = @Name))
		insert into [Table](Name, Status, Capacity) values(@Name, @Status, @Capacity)
end
go

create proc Table_Update
@ID int,
@Name nvarchar(1000),
@Status int,
@Capacity int
as
begin
	if(not exists(select Name from [Table] where Name = @Name))
		update [Table]
		set Name = @Name, Status = @Status, Capacity = @Capacity
		where ID = @ID
end
go

--2.Viêt thủ tục lấy dữ liệu của tất cả các bảng
--Thu tuc GetAll cho tata ca cac bang
create procedure [dbo].[_GetAll]
@TableName nvarchar(200)
as
begin
	declare @Sql nvarchar(1000)
	set @Sql = 'Select * from ' + @TableName
	exec (@Sql) 
end

exec dbo._GetAll 'Category'

--3.Viết một thủ tục _GetByID để lấy dữ liệu của tất cả các bảng có id là kiểu int( role, billDetail, food, bills, table, category)
create proc [dbo].[_GetByIDAll]
@ID nvarchar(1000),
@TableName nvarchar(1000)
as
begin
	if(@TableName in ('Role','BillDetails','Food', 'Table','Category', 'Bills'))
	begin
		declare @Sql nvarchar(1000)
		set @Sql = 'Select * from ' + @TableName+' where ID = ' +@ID
		exec (@Sql)
	end
	else
		print('Khong ton tai bang hoac bang khong co ID')
end
go

--drop proc [dbo].[_GetByIDAll]
exec dbo._GetByIDAll 1,'Role'
exec dbo._GetByIDAll 1,'Roles'
