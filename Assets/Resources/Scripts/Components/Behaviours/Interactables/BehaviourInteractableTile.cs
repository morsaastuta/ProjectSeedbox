using System;
using System.Collections.Generic;
using NaughtyAttributes;
using Resources.Components.Managers;
using Resources.Objects.Items.Materials;
using Resources.Objects.Items.Seeds;
using Resources.Objects.Items.Soils;
using UnityEngine.InputSystem.Controls;
using static Resources.Utils.Enums;

namespace Resources.Components.Behaviours.Interactables {
	public class BehaviourInteractableTile : BehaviourInteractable {
		[Dropdown("Tile")] [ReadOnly] protected bool plowed;
		[Dropdown("Tile")] [ReadOnly] public ItemSoil soil;
		[Dropdown("Tile")] [ReadOnly] public EWater water;
		[Dropdown("Tile")] [ReadOnly] public ESunlight sunlight;
		[Dropdown("Tile")] [ReadOnly] public ETemperature temperature;
		[Dropdown("Tile")] [ReadOnly] public float waterLevel;

		public void Fill(ItemSoil s) {
			soil = s;
		}

		public ItemMaterial[] Dig() {
			return soil.loot;
		}

		public void Plow() {
			plowed = true;
		}

		public void Water() {
			waterLevel = Math.Clamp(waterLevel + 1, 0, 2);
			UpdateWater();
		}

		protected void UpdateWater() {
			switch ((int)waterLevel) {
				case 2: water = EWater.Soggy; break;
				case 1: water = EWater.Moist; break;
				case 0: water = EWater.Dry; break;
			}
		}

		public void Plant(ItemSeed seed) {
			Instantiate(new BehaviourInteractableCrop(seed), ManagerMap.Instance.board.transform, true);
		}

		public void Cycle() {
			waterLevel -= soil.filtering;
			UpdateWater();
		}
	}
}
