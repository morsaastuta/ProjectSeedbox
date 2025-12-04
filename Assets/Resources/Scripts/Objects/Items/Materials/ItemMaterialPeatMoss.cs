using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Materials {
	public class ItemMaterialPeatMoss : ItemMaterial {
		public ItemMaterialPeatMoss() {
			title = "Peat Moss";
			description = "Biomass made of decaying plant life.";
			sources = new[] { ELocation.Moor, ELocation.Bog };
		}
	}
}
