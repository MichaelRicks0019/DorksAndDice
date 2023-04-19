CREATE TABLE [dbo].[Dice]
(
	[Dice_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Dice_Name] NVARCHAR(75) NOT NULL, 
    [Dice_Quantity] INT NOT NULL,
    [Dice_Price] DECIMAL(18, 2) NOT NULL,
    [Edge] NVARCHAR(75) NULL, 
    [Color] NVARCHAR(75) NULL, 
    [Material] NVARCHAR(75) NULL, 
    [Style] NVARCHAR(75) NULL, 
    [Type] NVARCHAR(75) NULL, 
    [Size] NVARCHAR(75) NULL
)
