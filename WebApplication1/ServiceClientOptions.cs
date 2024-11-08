using FluentBuilder;

namespace FluentBuilderTest;

[AutoGenerateBuilder]
public class ServiceClientOptions
{
    public bool Passthrough { get; set; } = false;
}