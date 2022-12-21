## How to provide specific implementations for each platform

Your code:

```
Foo\
    Foo.cs
    Foo.Android.cs
    Foo.iOS.cs
```

In `your.csproj`

```xml
  <PropertyGroup>
    ...........
    <!-- change this to iOS -->
    <OS>Android</OS>
  </PropertyGroup>

  <ItemGroup Condition="$(OS) != 'Android'">
      <Compile Remove="**/*.Android.cs" />
      <None Include="**/*.Android.cs" />
  </ItemGroup>

  <ItemGroup Condition="$(OS) != 'iOS'">
      <Compile Remove="**/*.iOS.cs" />
      <None Include="**/*.iOS.cs" />
  </ItemGroup>

```

## References

- https://learn.microsoft.com/en-us/visualstudio/msbuild/walkthrough-using-msbuild?view=vs-2022
