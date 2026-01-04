using System;
using System.Collections.Generic;
using NaughtyAttributes;
using Resources.Components.Managers;
using Resources.Objects.Items.Materials;
using Resources.Objects.Items.Seeds;
using Resources.Objects.Items.Soils;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using static Resources.Utils.Enums;

namespace Resources.Components.Behaviours.Interactables {
	public class BehaviourInteractableTile : BehaviourInteractable {
		[SerializeField] [Foldout("Tile")] [ReadOnly] public ItemSoil soil;
		[SerializeField] [Foldout("Tile")] [ReadOnly] public EWater water;
		[SerializeField] [Foldout("Tile")] [ReadOnly] public ESunlight sunlight;
		[SerializeField] [Foldout("Tile")] [ReadOnly] public ETemperature temperature;
		[SerializeField] [Foldout("Tile")] [ReadOnly] protected bool plowed;
		[SerializeField] [Foldout("Tile")] [ReadOnly] public float waterLevel;

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
			if (waterLevel == 0) water = EWater.Dry;
			else if (waterLevel is > 0 and <= 1) water = EWater.Moist;
			else water = EWater.Soggy;
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
