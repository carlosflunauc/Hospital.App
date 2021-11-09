# 2026692

Instalación Global del Entity Framework

	dotnet tool install --global dotnet-ef

Actualizar el EF

  	dotnet tool update --global dotnet-ef

Instalacion solucion EF

  	dotnet new sln -o Hospital
  
Instalar las carpetas MVC
                                
	dotnet new classlib -o Hospital.Persistencia 	(Controlador)
                                
  	dotnet new classlib -o Hospital.Dominio 	(Modelo)
                                 
	dotnet new webapp -o Hospital.Frontend 		(Vista)
  
En la carpeta de Persistencia instalamos los paquetes:

	dotnet add package Microsoft.EntityFrameworkCore --version 5.0.11
	dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.11
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.11
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.11

Crear Referencias a otras carpetas:
	dotnet add reference ..\Hospital.Dominio\
	dotent add reference ..\Hospital.Persistencia\

Crear Migraciones:

		Cuando no hay migraciones:
	dotnet ef migrations add P1migracion --startup-project ..\Hospital.Consola\	
		
		cuando ya exite una migracion:
	dotnet ef database update --startup-project ..\Hospital.App.Consola\		
Conexion con la base de datos:

// optionsBuilder.UseSqlServer("Initial Catalog=HospitalSenaData; Data Source=HOMELUNA; Integrated Security=true");
// optionsBuilder.UseSqlServer("Data Source=(localdb)\\Nombre_Servidor; Initial Catalog=HospitalSenaData");
