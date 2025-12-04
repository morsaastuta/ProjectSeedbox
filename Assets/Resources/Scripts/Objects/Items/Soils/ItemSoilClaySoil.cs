using Resources.Objects.Items.Materials;
using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Soils {
	public class ItemSoilClaySoil : ItemSoil {
		public ItemSoilClaySoil() {
			title = "Clay soil";
			description = "Soil made of high-density dirt";
			recipe = new Item[] { new ItemMaterialClay(), new ItemMaterialClay() };
			filtering = 0.5f;
		}
	}
}
