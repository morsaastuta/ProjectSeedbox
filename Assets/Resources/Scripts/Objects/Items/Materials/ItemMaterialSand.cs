using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Materials {
	public class ItemMaterialSand : ItemMaterial {
		public ItemMaterialSand() {
			title = "Sand";
			description = "Dirt of low density.";
			sources = new[] { ELocation.Moor, ELocation.Bog, ELocation.Coast, ELocation.Thicket };
		}
	}
}
