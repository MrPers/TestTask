# Rickandmorty - ASP.NET Web API

# Database (SQL Server) :
	-- Список квитків з даними клієнта

	SELECT [tickets].[id]
		,[tickets].[seat_no] AS 'seat number'
		,[tickets].[time_sale] AS 'time sale'
		,[persons].[first_name] AS 'first name'	
		,[persons].[last_name] AS 'last name'
		,[persons].[phone]
		,[tickets].[flights_id] AS 'flights id'
	FROM [AirTransportation].[dbo].[tickets]
	INNER JOIN [AirTransportation].[dbo].[persons] ON [persons].[id] = [tickets].[person_id];

	-- Останні 5 проданих квитків
	
SELECT TOP (5) [id]
      ,[seat_no]
      ,[time_sale]
      ,[person_id]
      ,[flights_id]
  FROM [AirTransportation].[dbo].[tickets]
  ORDER BY [time_sale] DESC

	-- Топ 3 клієнтів за частотою польотів

WITH totals AS (
	SELECT TOP(3) [persons].[id]
		,[persons].[first_name]
		,[persons].[last_name]
		,[persons].[phone]
       ,(SELECT COUNT(*) FROM [AirTransportation].[dbo].[tickets] WHERE [persons].[id] = [tickets].[person_id]) AS Customer
       FROM [AirTransportation].[dbo].[persons]
       ORDER BY Customer DESC  
)
SELECT TOP(3)
	[persons].[id] AS 'id'
	,[persons].[first_name] AS 'seat number'
	,[persons].[last_name] AS 'last name'
	,[persons].[phone] AS 'phone'
FROM
[AirTransportation].[dbo].[persons]
