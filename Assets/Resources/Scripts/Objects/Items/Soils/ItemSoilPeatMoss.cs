using Resources.Objects.Items.Materials;
using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Soils {
	public class ItemSoilPeatMoss : ItemSoil {
		public ItemSoilPeatMoss() {
			title = "Peat moss";
			description = "Soil made of biomass from decaying plant life.";
			recipe = new Item[] { new ItemMaterialPeatMoss(), new ItemMaterialPeatMoss() };
		}
	}
}
