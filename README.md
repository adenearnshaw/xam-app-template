# .Net App Template

A template for .Net App solutions. Built with Xamarin, but architected in a way that other .Net front-end frameworks (WPF, WinForms, UWP, Blazor, Uno) could be used.

## Features

- C# 9 in netStandard Projects
- Separation of Business & Presentation Layer
- MVVM pattern with MvvmHelpers
- WeakEvent pattern with AsyncBestPractices
- IoC with Shiny, with a familiar feel to AspNet Core Projects
- HttpClientFactory to provide safely managed HttpMessageHandler
- XamlStyler config for consistent formatting
- Unit Tests

## Dependencies

- Xamarin Forms
- Xamarin Essentials
- Xamarin Community Toolkit
- Shiny
- MvvmHelpers
- AsyncBestPractices
- xUnit
- Moq

## Conventions

- Use american english for all variables, methods, properties. This is for accessibilty of other devs where English maybe a 2nd language.
- Tabs over spaces. Again, the is for dev accessibility, as people can adjust the size of their tabs if they feel it easier to visualise.

## Folder structure

- .azuredevops: templates used by AzDO for Pull Requests & Admin
- build: build & release templates & pipelines
- doc: any documentation relating to the project, relase notes, etc.
- src: source code for the app
  - Business Layer : Houses business logic only, should not reference Xamarin
  - Presentation Layer: For App head-projects
  - Tests: Unit Tests

## Project structure

- Core
  - Api/Data/Repositories: Fetch and Retrieve data from Remote/Local storage
  - Managers: Process data from Api/Repositories & convert into Models for ViewModel. The majority of business rules should usually be here and should be the most unit tested area.
  - Models: POCO objects that can be passed from Manager -> ViewModel -> View
  - Services: In Core, this is usually Interfaces for services which need to be implemented at the platform level
  - ViewModels: Provide a 2-way interface to the Presentation layer allowing the Business layer to control the data flow of the App. All public items should be properties, invocation of methods should be done via ICommand interface.
  - CoreBootstrapper: Splits away the registration any Core-Only dependencies, then if we ever decide to add additional Front-ends (WPF/WinForms), most dependencies won't have to be maintained in 2 Startups.
  - CoreServiceLocator: Can allow resolution of services registered in container without the need for DI.
- Forms
  - Behaviors: Any Behaviors or AttachedProperties 
  - Converters: Any binding converters
  - Services: Cross-Platform implementations of Core.Services, to expose platform specific implementation to the Business Layer. Use Xamarin.Essentials where possible, only create platform implementations (Android/iOS), if there's no abstraction already created.
  - Views: Place all pages & views here, use sub-folders where appropriate
  - Startup: Front-end service bootstrapper. Register any X-platform service implementations here.
