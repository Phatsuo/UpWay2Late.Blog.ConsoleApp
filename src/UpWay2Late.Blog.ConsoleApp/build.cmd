dotnet build -r osx.10.12-x64
dotnet build -r win10-x64
dotnet publish -c release -r osx.10.12-x64
dotnet publish -c release -r win10-x64
robocopy.exe D:\Dev\UpWay2Late\Blog\UpWay2Late.Blog.ConsoleApp\src\UpWay2Late.Blog.ConsoleApp D:\Dev\UpWay2Late\Blog\UpWay2Late.Blog.ConsoleApp\src\UpWay2Late.Blog.ConsoleApp\bin\release\netstandard1.6\osx.10.12-x64\publish appsettings.json /R:1 /W:5
robocopy.exe D:\Dev\UpWay2Late\Blog\UpWay2Late.Blog.ConsoleApp\src\UpWay2Late.Blog.ConsoleApp D:\Dev\UpWay2Late\Blog\UpWay2Late.Blog.ConsoleApp\src\UpWay2Late.Blog.ConsoleApp\bin\release\netstandard1.6\win10-x64\publish appsettings.json /R:1 /W:5
pause