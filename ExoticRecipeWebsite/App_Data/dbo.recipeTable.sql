CREATE TABLE [dbo].[Table]
(
	[recipeNameDB] TEXT NOT NULL , 
    [recipeOrderDB] INT NOT NULL, 
    [recipeDescriptionDB] TEXT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([recipeOrderDB])
)
