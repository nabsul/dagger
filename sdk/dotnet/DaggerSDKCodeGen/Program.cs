using DaggerSDKCodeGen;

if (args[0] == "introspect")
{
    Introspect.RunAsync().Wait();
    return;
}

if (args[0] == "codegen")
{
    CodeGen.RunAsync().Wait();
    return;
}