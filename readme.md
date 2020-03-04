# CreativeMinds CQS Templates

Command and Query templates for the CreativeMinds CQS library.

To install the templates:

```
dotnet new -i CreativeMinds.CQS.Templates
```

Navigate to the path where you want to create a command/query.

To create a new command:

```
dotnet new cqscommand --namespace <NamespaceForCommand> --name DoSomeDatabaseWorkCommand
```

To create a new query

```
dotnet new cqsquery --namespace <NamespaceForQuery> --name GetSomeDataFromTheDatabaseQuery
```


To uninstall the templates again:

```
dotnet new -i CreativeMinds.CQS.Templates
```
