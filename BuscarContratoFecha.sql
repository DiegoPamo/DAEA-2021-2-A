create proc BuscarAņoContratoPerson
	@HireDate nvarchar(50)
as
select * from Person where HireDate like '%'+@HireDate+'%'