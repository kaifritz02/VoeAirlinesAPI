░█████╗░██╗██████╗░██╗░░░░░██╗███╗░░██╗███████╗░██████╗  ░█████╗░██████╗░██╗
██╔══██╗██║██╔══██╗██║░░░░░██║████╗░██║██╔════╝██╔════╝  ██╔══██╗██╔══██╗██║
███████║██║██████╔╝██║░░░░░██║██╔██╗██║█████╗░░╚█████╗░  ███████║██████╔╝██║
██╔══██║██║██╔══██╗██║░░░░░██║██║╚████║██╔══╝░░░╚═══██╗  ██╔══██║██╔═══╝░██║
██║░░██║██║██║░░██║███████╗██║██║░╚███║███████╗██████╔╝  ██║░░██║██║░░░░░██║
╚═╝░░╚═╝╚═╝╚═╝░░╚═╝╚══════╝╚═╝╚═╝░░╚══╝╚══════╝╚═════╝░  ╚═╝░░╚═╝╚═╝░░░░░╚═╝                            

# ASP.NET Core Web API project for managing VoeAirlines By Embraery

## How to run the project

**Clone the repository**
```
git clone https://github.com/kaifritz02/VoeAirlinesAPI.git
```

**Restore the packages**

Navigate to the cloned project folder and run the following command:

```
dotnet restore
```

**Run the application**

Run the following command or use the Visual Studio u Visual Studio Code Debug tool (usually by pressing F5):
```
dotnet run
```

## How to test the API

**Access the Swagger test interface**
The Swagger UI will be available at the URL https://localhost:[port]/swagger (the port may vary and should be observed in the terminal when running the project).

**Consume endpoints**
Suggested order for testing the application:

1) Create, edit and delete Aeronaves
2) Create, edit, and delete Manutencao
3) Create, edit, and delete Piloto
4) Create, edit, and delete Voo


