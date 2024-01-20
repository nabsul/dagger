using DaggerSDKCodeGen.Models;

namespace DaggerSDKCodeGen;

public class IntrospectionResult
{
    public QueryDirective[] Directives { get; set; } = default!;
    public QueryType[] Types { get; set; } = default!;
}
