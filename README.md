# RecipeManagement
Recipe Management is, as the name suggests, a tool for managing recipes. Upon creation of account, user's can create new recipes, or search for and save recipes already in the database. User's have the ability to edit recipes they have created, or add notes for themselves on recipes that they have saved.

## Set Up Instructions
- Clone down this repository, open in Visual Studio.
- Enable UserSecrets
- In UserSecrets copy and paste this code:
```
{
  "ConnectionStrings": {
    "RecipeLocalConnection": "Server=(localdb)\\MSSQLLocalDB;Database=<Recipe Database Name >;Trusted_Connection=True;MultipleActiveResultSets=true",
    "IdentityDefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=< User Database Name >;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```
- Replace <Recipe Database Name> with the your desired database name. Replace <User Database Name> with your desire User Database Name
- Open Package Manager Console. Run the following commands
-- Add-Migration -context ApplicationDbContext userSetUp
-- Add-Migration -context RecipeDbContext recipeSetUp
-- Update-Database -context ApplicationDbContext
-- Update-Database -context RecipeDbContext
- Hit Run.

## Tools and Technologies
### Languages
- C#
- HTLM5
- CSS
### Libraries
- ASP.NET Core
- Entity Framework
- ASP.NET Core Identity
### Tools
- Visual Studio
- Microsoft SQL Server Manager

## Change Log
1.0.0 
- Intitial Database Creation.
- Add ability for users to create account and sign in.
- Add ability for users to create, view, and edit recipes.
- Add ability for users to save recipes.
- Initial styling

## Contributions
If you would like to contribute, follow the set up instruction above, find an issue, and submit a pull request. 