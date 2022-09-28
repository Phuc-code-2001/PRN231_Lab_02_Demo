# PRN231_Lab_02_Demo

## Introduction
Imagine you're a librarian of an university, your leader has asked you to develop an application for book management especially support the querying data in many options. The book information includes id, ISBN, title, author, price, press information and address information. The press information includes press id, press name, the press information also has category information such as book, ebook, magazine. The address information will have city and country. The application has to support adding, viewing, modifying, and removing books - a standardized usage action verbs better known as Create, Read, Update, Delete (CRUD).
OData is an open protocol for operating data over HTTP. It also follows REST architecture. Currently OData is widely used for exposing data, so this is the suitable method to implement Book Management application. This lab explores creating an application using OData to create service, and ASP.NET Core Web Application with Model-View-Controller. An In-Memory Database will be created to persist the book data that will be used for reading and managing book data by Entity Framework Core.

## Lab Objectives
In this lab, you will:
+	Use the Visual Studio.NET to create OData Service using ASP.NET Core Web Web API Project.
+	Develop Web application using MVC Pattern.
+	Use Entity Framework Core to create a In-Memory database 
+	Develop Entity classes, DBContext class, DataSource class to perform CRUD actions using Entity Framework Core 
+	Run the project and test the services using Postman.
+	Run the project and test the application actions.
