using Resources.Objects.Items.Materials;
using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Soils {
	public class ItemSoilSiltySoil : ItemSoil {
		public ItemSoilSiltySoil() {
			title = "Silty soil";
			description = "Soil made of mid density dirt";
			recipe = new Item[] { new ItemMaterialSilt(), new ItemMaterialSilt() };
			filtering = 1f;
		}
	}
}
