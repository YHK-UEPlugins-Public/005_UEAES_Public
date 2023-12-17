// Copyright 2014-2023 YeHaike All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UEAESDemoEditorTarget : TargetRules
{
	public UEAESDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "UEAESDemo" } );
	}
}
