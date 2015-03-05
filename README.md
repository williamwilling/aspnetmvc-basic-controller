## ASP.NET MVC
#A basic controller

In an MVC application, a URL translates to the code you wish to execute. For example, the URL `http://example.com/greetings/hello/` maps to the method `Hello()` in the class `GreetingsController`.

The method then returns a string and this is the body of the HTTP response message. So, if `Hello()` says something like `return "Hello!"`, the browser will show the text `Hello!`.