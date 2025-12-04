using System;
using System.Collections.Generic;
using NaughtyAttributes;
using Resources.Components.Managers;
using Resources.Objects.Items.Materials;
using Resources.Objects.Items.Seeds;
using Resources.Objects.Items.Soils;
using Resources.Utils;

namespace Resources.Components.Behaviours.Interactables {
	public class BehaviourInteractableTile : BehaviourInteractable {
		[Dropdown("Tile")] [ReadOnly] protected bool plowed;
		[Dropdown("Tile")] [ReadOnly] public ItemSoil soil;
		[Dropdown("Tile")] [ReadOnly] public Enums.EWater water;
		[Dropdown("Tile")] [ReadOnly] public Enums.ESunlight sunlight;
		[Dropdown("Tile")] [ReadOnly] public Enums.ETemperature temperature;

		public void Fill(ItemSoil s) {
			soil = s;
		}

		public ItemMaterial[] Dig() {
			return soil.loot;
		}

		public void Plow() {
			plowed = true;
		}

		public void Plant(ItemSeed seed) {
			Instantiate(new BehaviourInteractableCrop(seed), ManagerMap.Instance.board.transform, true);
		}
	}
}
