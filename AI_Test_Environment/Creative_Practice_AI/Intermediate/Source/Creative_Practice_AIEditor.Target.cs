using UnrealBuildTool;

public class Creative_Practice_AIEditorTarget : TargetRules
{
	public Creative_Practice_AIEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Creative_Practice_AI");
	}
}
