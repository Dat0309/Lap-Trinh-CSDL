CREATE PROCEDURE InsertFood
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
