<img src="https://cdn.rawgit.com/angular-schule/2017-05-aspnetcore-angular-ddf/0ca0c016/ddf-logo.svg" width="30%" align="left">

# Dreamteam:<br>ASP.NET Core mit Web API & Angular

__Workshoptag - 12. Mai__  
__9:00 Uhr - 17:00 Uhr__ 

mit [Johannes Hoppe](https://dotnet-day-franken.de/en/speakers/item/9-johannes-hoppe) und [Ferdinand Malcher](https://www.dotnet-day-franken.de/component/k2/item/49-ferdinand-malcher) von der [angular.schule](https://angular.schule/).

ASP.NET Core und Angular. Die Kombination dieser zwei Technologien ist das Dreamteam, wenn es um Webanwendungen geht. Den Start erleichtert uns Microsoft mit den ASP.NET Core JavaScript Services. Die Sammlung von Technologien rund um ASP.NET Core wird Thema dieses Workshops sein.

Wir entwickeln ein Backend mit der Web API von ASP.NET Core 1. Der Zugriff auf die Datenbank geschieht natürlich über das neue Entity Framework (oder In-Memory, falls kein MS SQL Server vorhanden). Zusätzlich stellen wir wir ein vollständiges Beispiel für Angular vor. Du lernst im Laufe des Workshops alle Bestandteile kennen, die für das Zusammenspiel von Client & Server notwendig sind.

Zum Ende kannst du die Begriffe NuGet, NPM, Yeoman, Middlewares, Webpack, HMR uvm. einordnen. Du wirst in der Lage sein, eine erste Angular-App unter .NET Core mit der Web API sowie dem Entity Framework selbst aufzusetzen. 

## Benötigte Software

Egal ob Windows, Mac oder Linux. Bei diesem Workshop kann jeder mitmachen.  
Bitte installiere dazu zunächst folgende Software:

* [.NET Core SDK 1.03](https://www.microsoft.com/net/download/core#/sdk)
* [Node.js 6.9 oder höher](https://nodejs.org/en/download/)
* [Visual Studio Code 1.10 oder höher](https://code.visualstudio.com/#alt-downloads) - ACHTUNG: __nicht__ das große Visual Studio 2017!
* [Chrome](https://www.google.com/chrome/)

Sicher ist sicher. Bitte anschließend die Versionen überprüfen:

```
dotnet --version
> Erwartet: 1.0.3 oder höher

node -v
> Erwartet: v6.9.x oder höher
```
 
## Pakete installieren und Startprojekt anlegen

Bekanntermaßen ist das Internet auf Konferenzen immer knapp bemessen.  
Bitte mache daher deinen Laptop rechtzeitig lauffähig!

Alle __Windows-User__ sollten vor Beginn des Kurses die `windows-build-tools` installieren.  
Warnungen von NPM können ignoriert werden.  
Nach der Installation musst du eine neue Konsole starten!

```
npm install -g windows-build-tools
```

Danach bitte folgenden Befehl ausführen.  
Warnungen von NPM können ignoriert werden. 

```
npm install -g yo generator-aspnetcore-spa
npm install -g @angular/cli
```

Damit haben wir Yeoman an Board.  
Mit Yeoman kann man besonders leicht neue Projekte erzeugen:

```
mkdir book-rating
cd book-rating
yo aspnetcore-spa
```

Du entscheidest dich natürlich für Angular!

![yo_angular](https://cloud.githubusercontent.com/assets/640639/25765553/e6705604-31ed-11e7-9fc4-ba6fd6626795.png)

Führe auch noch diese Installation durch:
```
npm i --save-dev @angular/cli@1.0.2
```

Und nun kannst du das Projekt bereits starten:

```
# Windows:
set ASPNETCORE_ENVIRONMENT=Development

# macOS / Linux:
export ASPNETCORE_ENVIRONMENT=Development


dotnet run
```

Gehe mit deinem Browser auf http://localhost:5000
# Hello, world!

![image](https://cloud.githubusercontent.com/assets/640639/25765846/62854334-31ef-11e7-9e21-6a14ae75a9fb.png)

<hr>

## NEU: Extensions

Ohne folgende VSCode-Erweiterungen ist der Entwicklungs-Workflow doch recht rustikal.

[<img src="https://cloud.githubusercontent.com/assets/640639/25972125/0835c6ce-369f-11e7-8c0e-43676dd41a02.png" width="100">](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) 
[<img src="https://cloud.githubusercontent.com/assets/640639/25972140/158d6a34-369f-11e7-812c-18fd2c5e3a02.png" width="100">](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions) 
[<img src="https://cloud.githubusercontent.com/assets/640639/25972150/1be2b6fa-369f-11e7-82e8-af1df91c452f.png" width="100">](https://marketplace.visualstudio.com/items?itemName=eg2.tslint) 
[<img src="https://cloud.githubusercontent.com/assets/640639/25972160/239f66d6-369f-11e7-94df-697457951f8e.png" width="100">](https://marketplace.visualstudio.com/items?itemName=Angular.ng-template) 
[<img src="https://cloud.githubusercontent.com/assets/640639/25972172/29d886fe-369f-11e7-8236-272e06f497de.png" width="100">](https://marketplace.visualstudio.com/items?itemName=steoates.autoimport) 
[<img src="https://cloud.githubusercontent.com/assets/640639/25972176/2e394148-369f-11e7-95dc-5074e0789bd9.png" width="100">](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig) 
[<img src="https://cloud.githubusercontent.com/assets/640639/25972179/3397e6b2-369f-11e7-89dc-06c3f8c8d020.png" width="100">](https://marketplace.visualstudio.com/items?itemName=robertohuertasm.vscode-icons) 

* [`ext install csharp`](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
* [`ext install csharpextensions`](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)
* [`ext install tslint`](https://marketplace.visualstudio.com/items?itemName=eg2.tslint)
* [`ext install ng-template`](https://marketplace.visualstudio.com/items?itemName=Angular.ng-template)
* [`ext install autoimport`](https://marketplace.visualstudio.com/items?itemName=steoates.autoimport)
* [`ext install EditorConfig`](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)
* [`ext install vscode-icons`](https://marketplace.visualstudio.com/items?itemName=robertohuertasm.vscode-icons)

<hr>

## FAQ

* Warum doch noch kein Angular 4?
  > Wegen [#800](https://github.com/aspnet/JavaScriptServices/issues/800)! 
  
* Wozu die Angular-CLI?
  > Die Angular-CLI verwenden wir später nur, um neue Komponenten zu generieren. Wir müssen dazu eine Datei mit dem Namen [.angular-cli.json](https://github.com/angular-schule/2017-05-aspnetcore-angular-ddf/wiki/.angular-cli.json) in das Hautpverzeichnis legen.
  
* Wie integriere ich TSLint und Codelyzer in das Projekt?
  > TSLint ist ein nützliches Werkzeug, um Fehler im TypeScript-Code schon bei der Entwicklung zu erkennen. Codelyzer bringt eine Reihe von Regeln mit, die dem Angular-Styleguide folgen. Dazu müssen wir die TSLint-Extension und Codelyzer installieren und die Datei [.tslint.json](https://github.com/angular-schule/2017-05-aspnetcore-angular-ddf/wiki/tslint.json) im Projektordner anlegen.

<!--* Fertiges Projekt von GitHub zum Laufen bringen?
  > `git clone https://github.com/angular-schule/2017-05-aspnetcore-angular-ddf.git`
  > `npm install` oder `yarn install`
  > `dotnet restore`
-->
Bei weiteren Fragen wende dich einfach direkt an das Angular-Schule-Team:  
team@angular.schule

### &copy; 2017 http://angular.schule, Stand: 11.05.2017
