Ejecutar el siguiente comando:

dotnet ef migrations add "Nombre de la migracion" --project AccesoDatos --startup-project AccesoDatos

Luego el siguiente :

dotnet ef database update --project AccesoDatos --startup-project AccesoDatos