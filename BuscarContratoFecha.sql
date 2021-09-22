create proc BuscarAñoContratoPerson
	@HireDate nvarchar(50)
as
select * from Person where HireDate like '%'+@HireDate+'%'