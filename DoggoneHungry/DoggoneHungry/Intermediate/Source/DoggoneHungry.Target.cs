using UnrealBuildTool;

public class DoggoneHungryTarget : TargetRules
{
	public DoggoneHungryTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DoggoneHungry");
	}
}
