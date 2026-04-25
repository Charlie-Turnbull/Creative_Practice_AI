using UnrealBuildTool;

public class Creative_Practice_AIClientTarget : TargetRules
{
	public Creative_Practice_AIClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Creative_Practice_AI");
	}
}
