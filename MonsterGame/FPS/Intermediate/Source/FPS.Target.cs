using UnrealBuildTool;

public class FPSTarget : TargetRules
{
	public FPSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FPS");
	}
}
