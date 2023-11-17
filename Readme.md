# Crud MVC Aspnet

 Sistema básico con operaciones CRUD hecho en MVC ASP.Net 4.5 y Entity Framework listo 
 para ejecutarse en un host.

## ¿De qué trata esta aplicación?

Este proyecto consiste en un pequeño sistema de inventario con una base de datos 
lista para usar y lógica de negocio mínima. 
Todos los componentes usados en mayor o menos medida se listan a continuación

  - [Entity Framework 6.0](https://www.nuget.org/packages/EntityFramework/6.0.0) (back-end)
  - [datatables 1.13.3](https://datatables.net/) (front-end)

## ¿Cómo pruebo esto?

Para poder ejecutar la aplicación se necesita tener previamente instalado los siquientes 
programas

  - [SQL Server Express LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16)
  - IIS Express 10
  - [.Net Framewort 4.5 runtime](https://www.microsoft.com/es-ar/download/details.aspx?id=30653)

## Arquitectura de la aplicación

La aplicación cuenta con una estructura tipo MVC (Modelo-Vista-Controlador). Además implementa 
una capa de servicios para el acceso a datos. **Todo esto en un mismo proyecto**. 
Para una vista general, se presenta el diagrama de clases (archivo `ClassDiagram.cd`)

![](Resources/Images/ClassDiagram.png)

## Capturas

Pagina de lista de artículos.

<p align="center">
  <img src="Resources/Images/articles-list_details-responsive.png" width="650px" height="1236px">
</p>

Página de detalles de un artículo.

<p align="center">
  <img src="Resources/Images/article-details.png" width="630px" height="662px">
</p>

## Demostración

https://user-images.githubusercontent.com/88981972/233879807-b1d2f422-6fdb-4d00-b366-6c6c44391dc6.mp4
 