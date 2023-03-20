CREATE TABLE [dbo].[Dice]
(
	[Dice_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product_Id] INT NOT NULL, 
    [Edge] NVARCHAR(75) NULL, 
    [Color] NVARCHAR(75) NULL, 
    [Material] NVARCHAR(75) NULL, 
    [Style] NVARCHAR(75) NULL, 
    [Type] NVARCHAR(75) NULL, 
    [Size] NVARCHAR(75) NULL
)
