namespace MSBuildChallenge;

public partial class Foo
{
    public override string ToString() => GetOSName();

    private partial string GetOSName();

}
