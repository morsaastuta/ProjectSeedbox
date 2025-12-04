using Resources.Objects.Items.Materials;
using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Soils {
	public class ItemSoilSandySoil : ItemSoil {
		public ItemSoilSandySoil() {
			title = "Sandy soil";
			description = "Soil made of low density dirt";
			recipe = new Item[] { new ItemMaterialSand(), new ItemMaterialSand() };
		}
	}
}
