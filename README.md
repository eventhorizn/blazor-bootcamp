# Blazor

ISN'T SUPPORTED IN IE

## What is it?

A framework that allows us to create interactive apps in c# what will be used, mainly, through a web browser

1. Takes adavantage of .net ecosystem for front end
1. Can use c# (linq and async programming)
1. Share code b/t front and back-end
1. Work w/ components

## 2 Hosting Models

### Blazor Web Assembly

We use WebAssembly to execute .net apps in a web browser

2 options

1. Blazor (client-side)
1. Blazor hosted in .net core
    - Client-side + ASP.net Core

**Does all the code go to the browser?**

No, just front end code

### Blazor Server-Side

1. Blazor app runs on server, and user interacts w/ it through SignalR connection
    - Doesn't need to download .net runtime
1. **Advantage:** Devices w/ less resources should be able to run the app w/o problems
1. Blazor server-side limitations relate to the server

## Identity Server 4

**Blazor WebAssembly has pre-configured Templates for IS4**

1. Identity Server is a framework that uses OpenId Connect and OAuth 2.0
1. OAuth 2.0 is a standard authorization protocol
1. OpenId Connect has function
1. Centralizes authentication logic
1. Single-Sign On
1. External Identity Providers

# TODO

1. Create MongodDB implementation
1. Re-do some of the db design...its' very self referential
1. Roles page update: List roles for a person on Edit User
1. Better 'bad password' handling. Just throws an error right now
