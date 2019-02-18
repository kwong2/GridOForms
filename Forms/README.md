# Grid OForms

For this project, I was able to complete all but the last steps, connecting the SQL database to the .Net application. I try to scaffold my model with this command

```
dotnet ef dbcontext Scaffold "Server=localhost,1401;Initial Catalog=FormDB;Persist Security Info=False;User ID=SA;Password=Fromstack123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -o Models
```

However, each time I get this certificate error.

```
System.Data.SqlClient.SqlException (0x80131904): A connection was successfully established with the server, but then an error occurred during the pre-login handshake. (provider: TCP Provider, error: 35 - An internal exception was caught) ---> System.Security.Authentication.AuthenticationException: The remote certificate is invalid according to the validation procedure.
```

Unfortunately, I am unable to figure out the certificate error. If you have ideas on how to fix this error and proceed, do let me know.
