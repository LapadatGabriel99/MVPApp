/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[Name]
      ,[Url]
      ,[PhoneNumber]
      ,[Email]
      ,[CityLocation]
      ,[StateLocation]
  FROM [DemoAppRepository].[dbo].[DepartmentModels]