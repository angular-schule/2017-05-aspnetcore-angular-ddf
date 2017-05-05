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
set ASPNETCORE_ENVIRONMENT=Development
dotnet run
```

Gehe mit deinem Browser auf http://localhost:5000
# Hello, world!

![image](https://cloud.githubusercontent.com/assets/640639/25765846/62854334-31ef-11e7-9e21-6a14ae75a9fb.png)

<hr>

## FAQ

* Warum doch noch kein Angular 4?
  > Wegen [#800](https://github.com/aspnet/JavaScriptServices/issues/800)! 
  
* Wozu die Angular-CLI?
  > Die Angular-CLI verwenden wir später nur, um neue Komponenten zu generieren. Wir müssen dazu eine Datei mit dem Namen [.angular-cli.json](https://github.com/angular-schule/2017-05-aspnetcore-angular-ddf/wiki/.angular-cli.json) in das Hautpverzeichnis legen.

Bei weiteren Fragen wende dich einfach direkt an das Angular-Schule Team:  
team@angular.schule

### &copy; 2017 http://angular.schule, Stand: 05.05.2017
