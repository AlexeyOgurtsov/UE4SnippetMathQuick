// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjMathQuickEditor_NoPrecompTarget : ProjMathQuickEditorTarget 
{
	public ProjMathQuickEditor_NoPrecompTarget( TargetInfo Target) : base(Target)
	{
		bUseUnityBuild = false;
		bUsePCHFiles = false;
	}
}
