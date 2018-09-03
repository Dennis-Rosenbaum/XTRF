# XTRF Home Portal API .NET Wrapper
This .NET wrapper for the XTRFT Home Portal API can be used to easily connect to the XTRF API.
API URL: https://simplytranslate.s.xtrf.eu/api/doc/users/introduction.html

## Using the Wrapper
Start of by creating your own implementation of `Xtrf.Interface.IConnection` and add this to the static `XtrfConnection`. 
You can also specify your custom errorlogging.

Should look something like this:
```
var connection = new RexConnection()
{
    AuthenticationToken = "xxxxxxxxxxxxxxxxxx",
    AuthenticationTokenProjectManager = "xxxxxxxxxxxxxxxx",
    RootUrl = "https://simplytranslate.s.xtrf.eu/api"
};

Xtrf.ApiContext.Instance.XtrfConnection = connection;

Xtrf.Error.ErrorLogger.ErrorOccurred = (exception) => Something.ErrorMailHelper.SendError(exception);
```

The AuthenticationToken can be retrieved within XTRF -> My Account -> Access Tokens.
The RootUrl consists of your own XTRF url + /api

## Using the API
Calling an API function goes by using the `ApiContext` that can be called through `Xtrf.ApiContext.Instance`. After that, you should be able to figure it out yourself.
```
// retrieve a single project
var projectInternalId = "KVVV32T34ZC65LB5MXQ3GSFFUY";
var xtrfApi = Xtrf.ApiContext.Instance;
var xtrfProjectResult = await xtrfApi.Project.Get(projectInternalId);
if(xtrfProjectResult.Success)
   Console.Log(xtrfProjectResult.Result.Name);
else
   Console.Log("Error on XTRF API: " + xtrfProjectResult.ErrorMessage);
```

### Macro execute
Added feature: executing macros from your code. 
This one is really fun, executing macros you have defined within XTRF (Settings -> Integrations -> XTRF Macros).
To execute a macro, first find the ID of the macro. This can be found in the URL of the macro. Example: https://simplytranslate.s.xtrf.eu/xtrf/faces/macro/form.seam?id=25&action=display

You can then run the macro with optional ids: 
```
long[] ids = new long[] { 1, 2 };
int macroId = 25;
Xtrf.ApiContext.Instance.Macro.Execute(macroId, ids);
```

## Enjoy!
Don't hesitate to contact me for questions on dennis.rosenbaum@outlook.com
