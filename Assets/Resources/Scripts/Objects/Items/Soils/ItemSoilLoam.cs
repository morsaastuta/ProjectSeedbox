using Resources.Objects.Items.Materials;
using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Soils {
	public class ItemSoilLoam : ItemSoil {
		public ItemSoilLoam() {
			title = "Loam";
			description = "Soil made of high density dirt";
			recipe = new Item[] { new ItemMaterialSand(), new ItemMaterialSilt(), new ItemMaterialClay() };
			filtering = 1f;
		}
	}
}
