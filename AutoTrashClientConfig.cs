﻿using Microsoft.Xna.Framework;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace AutoTrash
{
	class AutoTrashClientConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[DefaultValue(8)]
		[Label("AutoTrash Slot Icon Position X")]
		[Tooltip("Customize the position of the AutoTrash slot measured left to right from the 1st hotbar")]
		[Range(0, 10)]
		public int SlotPositionX;

		[DefaultValue(5)]
		[Label("AutoTrash Slot Icon Position Y")]
		[Tooltip("Customize the position of the AutoTrash slot measured top to bottom from the top hotbar")]
		[Range(0, 10)]
		public int SlotPositionY;
	}
}