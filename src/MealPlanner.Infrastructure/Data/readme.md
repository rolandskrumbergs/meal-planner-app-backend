https://docs.microsoft.com/en-us/ef/core/cli/powershell

Set Operations as the startup project of the solution.
Choose Infrastructure as the default project in package manager console.

[Drop the database]							Drop-Database 

[Scaffold a new migration]					Add-Migration InitialCreate -OutputDir Data/Migrations

[Remove the last migration]					Remove-Migration

[Update the database to last migration]		Update-Database

[Update the database to specific migration]	Update-Database 20210701095106_MirgationName