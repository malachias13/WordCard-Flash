CREATE PROCEDURE [dbo].RemoveData
	@Id int
AS
	begin
		delete from CardTables
		where Id = @Id;
	end 
RETURN 0