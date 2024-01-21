using DaggerSDKCodeGen;

if (args[0] == "introspect")
{
    Introspect.RunAsync().Wait();
    return;
}

if (args[0] == "codegen")
{
    await CodeGen.RunAsync();
    return;
}

Console.WriteLine("Unknown command");
