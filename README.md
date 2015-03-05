#ASP.NET MVC: Basic controller

In an MVC application, a URL translates to the code you wish to execute. For example, the URL `http://example.com/greetings/hello/` maps to the method `Hello()` in the class `GreetingsController`.

The method then returns a string and this is the body of the HTTP response message. So, if `Hello()` says something like `return "Hello!"`, the browser will show the text `Hello!`.

##Exploring the code

The interesting stuff for this example is in `Controllers\GreetingsController.cs`. All the other files are part of the default project template.

If you want to try and implement a basic controller yourself, you can check out the `start`-branch, which is the starting point for this example.