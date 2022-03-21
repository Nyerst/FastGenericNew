﻿namespace FastGenericNew.SourceGenerator;

public readonly record struct GeneratorOptions
{
    public int MaxParameterCount { get; }

    public bool PublicFastNewCore { get; }

    public bool GenerateTryCreateInstance { get; }

    //public bool GenerateTypeTryCreateInstance { get; }

    public bool GenerateCreateInstance { get; }

    public bool GenerateTypeCreateInstance { get; }

    public bool PublicCompiledDelegate { get; }

    public bool NonPublicConstructorSupport { get; }

    public string Namespace { get; }

    public bool ForceFastNewDelegate { get; }

    public bool AlertGeneratedFile { get; }

    public bool DisableGeneratorCache { get; }

    public bool Trimmable { get; }

    public bool PrettyOutput { get; }

    public bool MultiThreadedGeneration { get; }

    public bool OutputGenerationInfo { get; }

    public bool AllowUnsafeImplementation { get; }

    public GeneratorOptions(AnalyzerConfigOptionsProvider? provider)
    {
        var options = provider?.GlobalOptions;
        MaxParameterCount = options.GetOrDefault(nameof(MaxParameterCount), 16);
        PublicFastNewCore = options.GetOrDefault(nameof(PublicFastNewCore), false);
        GenerateTryCreateInstance = options.GetOrDefault(nameof(GenerateTryCreateInstance), true);
        GenerateCreateInstance = options.GetOrDefault(nameof(GenerateCreateInstance), true);

        PublicCompiledDelegate = options.GetOrDefault(nameof(PublicCompiledDelegate), true);
        NonPublicConstructorSupport = options.GetOrDefault(nameof(NonPublicConstructorSupport), true);
        Namespace = options.GetOrDefault(nameof(Namespace), "FastGenericNew");
        ForceFastNewDelegate = options.GetOrDefault(nameof(ForceFastNewDelegate), false);
        Trimmable = options.GetOrDefault(nameof(Trimmable), true);

        AlertGeneratedFile = options.GetOrDefault(nameof(AlertGeneratedFile), true);
        DisableGeneratorCache = options.GetOrDefault(nameof(DisableGeneratorCache), false);
        PrettyOutput = options.GetOrDefault(nameof(PrettyOutput), false);
        MultiThreadedGeneration = options.GetOrDefault(nameof(MultiThreadedGeneration), true);
        OutputGenerationInfo = options.GetOrDefault(nameof(OutputGenerationInfo), false);

        GenerateTypeCreateInstance = options.GetOrDefault(nameof(GenerateTypeCreateInstance), true);
        AllowUnsafeImplementation = options.GetOrDefault(nameof(AllowUnsafeImplementation), false);
    }

    public string GlobalNSDot() => string.IsNullOrWhiteSpace(Namespace)
        ? "global::@"
        : $"global::@{Namespace}.";

    public string DynamicallyAccessedMembers(int argumentCount)
    {
        bool noArguments = argumentCount == 0;
        return NonPublicConstructorSupport
            ? noArguments
                ? "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.NonPublicConstructors)]"
                : "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]"
            : noArguments
                ? "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]"
                : "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]";
    }
}
