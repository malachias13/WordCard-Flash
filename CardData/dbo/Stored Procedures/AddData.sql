CREATE PROCEDURE [dbo].AddData
	@word nvarchar(20),
	@definition nvarchar(max)
AS
	begin
		insert into CardTables
		values(@word,@definition);
	end
RETURN 0