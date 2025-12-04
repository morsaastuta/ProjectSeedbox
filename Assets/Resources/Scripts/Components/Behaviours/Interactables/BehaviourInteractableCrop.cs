using System.Linq;
using NaughtyAttributes;
using Resources.Components.Managers;
using Resources.Objects.Constructs.Crops;
using Resources.Objects.Items.Seeds;

namespace Resources.Components.Behaviours.Interactables {
	public class BehaviourInteractableCrop : BehaviourInteractable {
		[Dropdown("Crop")] [ReadOnly] public ConstructCrop crop;
		[Dropdown("Crop")] [ReadOnly] public int cycle = 0;
		[Dropdown("Crop")] [ReadOnly] public int withering = 0;
		[Dropdown("Crop")] [ReadOnly] public bool dead = false;

		public BehaviourInteractableCrop(ItemSeed seed) {
			crop = seed.crop;
		}

		public void Cycle() {
			// A dead/null crop does not cycle.
			if (dead || crop == null) return;
			BehaviourInteractableTile tile = ManagerMap.Instance.GetTileByPosition(transform.position);
			// A crop gains 1 wilt for each unmet condition. If today's wp is 0, all previous withering is removed.
			int wilt = 0;
			if (crop.reqWater.Any() && !crop.reqWater.Contains(tile.water)) wilt++;
			if (crop.reqSunlight.Any() && !crop.reqSunlight.Contains(tile.sunlight)) wilt++;
			if (crop.reqTemperature.Any() && !crop.reqTemperature.Contains(tile.temperature)) wilt++;
			if (wilt > 0) withering += wilt;
			else withering = 0;
			// Crops will only grow if they are not withering, and they will die over a certain amount of withering.
			if (withering == 0) cycle++;
			else if (withering > crop.resilience) dead = true;
		}
	}
}
