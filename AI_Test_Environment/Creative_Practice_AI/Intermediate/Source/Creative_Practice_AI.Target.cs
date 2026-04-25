using UnrealBuildTool;

public class Creative_Practice_AITarget : TargetRules
{
	public Creative_Practice_AITarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Creative_Practice_AI");
	}
}
