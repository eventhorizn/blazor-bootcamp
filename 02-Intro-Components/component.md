# Components

```
wwwroot folder contains all static files (html, css, js)
```

1. The centerpiece of Blazor
1. A component is a resusable piece of user interface
    - May contain logic
    - 'Razor Components'
    - Can be a button, can be a form
    - It's a 'class' as it's compiled to a c# class
1. Componets are .razor files
    - Files in the 'Pages' folder have a @page tag
        - You can hit them with a url route
    - Generally, you will put components in the 'Shared' folder of the client project

## Parameters

1. A component can receive razor code through its parameters
    - Can be data, events, content

## Lifecycle of a Component

1. OnInitialized and OnInitializedAsync
    - When component is created, and only once
1. OnParametersSet (and Async)
    - Called every time params are updated
1. OnAfterRender (and Async)
    - When HTML is displayed
    - Ran each time it is rendered
1. ShouldRender
    - If a component should refresh on render

## Dependency Injection

1. DI is a mechanism that allows us to supply dependicies of a class from another class
1. In components we do DI w/ @inject
1. Centralizes mechanism that configures that dependencies in one place

### 3 Servies To Use Through DI

1. HttpClient
    - Used to make HTTP requests to webserver
1. IJSRuntime
    - Used to work w/ JavaScript
1. NavigationManager
    - Allows us to work w/ user's navigation from our code

3 services don't have to be configured

### Lifecycle of a Service

1. Scoped
    - Lives w/i a context (like during an HTTP request)
1. Singelton
    - Single instance
1. Transient
    - Different instances of the service are created each time the service is requested