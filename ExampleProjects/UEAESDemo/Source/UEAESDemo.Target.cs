// Copyright 2014-2023 YeHaike All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UEAESDemoTarget : TargetRules
{
	public UEAESDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "UEAESDemo" } );
	}
}
