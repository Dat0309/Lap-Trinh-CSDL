stinCREATE PROCEDURE InsertFood
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
AS
	INSERT INTO Food (Name, Unit, FoodCategoryID, Price,  Notes)
	VALUES ( @Name, @Unit, @FoodCategoryID, @Price,  @Notes)

	SELECT @ID = SCOPE_IDENTITY()

go

CREATE PROCEDURE [aUpdateFood]
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
as
UPDATE [Food] set 
[Name] = @Name,[Unit] = @Unit, [FoodCategoryID] = @FoodCategoryID,[Price]=@Price,[Notes]=@Notes
where ID = @ID

if @@ERROR <> 0
return 0
else
return 1

create procedure Category_Insert
(
	@ID int output,
	@Name nvarchar(1000),
	@Type int
)
as
begin
	if (not exists (select Name from Category where Name = @Name))
		insert into Category (Name, Type) values (@Name, @Type)
		SELECT @ID = SCOPE_IDENTITY()
end
go

--drop procedure Bills_GetByDate
create procedure Bills_GetByDate
@date smalldatetime
as 
begin
	select * from Bills
	where CheckoutDate = @date
end
go

create procedure BillDetail_GetById
@ID int
as 
begin
	select bd.ID,f.Name, bd.Quantity 
	from BillDetails bd, Food f
	where bd.InvoiceID = @ID and f.ID = bd.FoodID
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

create procedure Role_GetByName
@name nvarchar(100)
as 
begin
	select r.RoleName
	from Role r,RoleAccount ra, Account a
	where a.AccountName = ra.AccountName and r.ID = ra.RoleID and a.AccountName = @name
end
go

