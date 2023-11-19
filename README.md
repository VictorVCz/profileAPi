Primero debemos preparar el backend instalando el SDK de .NET 7 dependiendo de nuestro sistema operativo, descargaremos el adecuado del siguiente link: https://dotnet.microsoft.com/en-us/download/dotnet/7.0

Una vez instalado nos dirijimos a la carpeta 'Backend',

## /profileFrontEnd/Backend

Una vez dentro de directorio del backend realizaremos el siguiente codigo en la terminal.

## 'dotnet run'

una vez compilado obtendra el siguiente extracto: 

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5016
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]

Indicando que la compilación fue un exito.

##Sin cerrar la terminal abriremos otra terminal donde iremos al directorio

## /profileFrontEnd/Frontend

donde debera de instalar las dependencias de paquetes node, ejecutando en la terminal la siguiente linea

## 'npm install'

Una vez instalada las dependencias podremos ejecutar el frontend sin problemas con la siguiente linea

## 'npm run dev'

Se desplegara el siguiente mensaje: 
> profilefrontend@0.0.0 dev
> vite


  VITE v4.5.0  ready in 588 ms

  ➜  Local:   http://localhost:5173/
  ➜  Network: use --host to expose
  ➜  press h to show help

indicando que ya es posible acceder al frontend desde el navegador entrando a la url: http://localhost:5173/
