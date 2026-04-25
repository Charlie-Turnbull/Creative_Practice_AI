using UnrealBuildTool;

public class Creative_Practice_AIServerTarget : TargetRules
{
	public Creative_Practice_AIServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Creative_Practice_AI");
	}
}
