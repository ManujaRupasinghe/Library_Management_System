CREATE TABLE [dbo].[Book]
(
	[book_id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NOT NULL, 
    [category] VARCHAR(50) NOT NULL, 
    [pages] INT NOT NULL, 
    [author] VARCHAR(50) NOT NULL
)
