using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Materials {
	public class ItemMaterialSilt : ItemMaterial {
		public ItemMaterialSilt() {
			title = "Silt";
			description = "Dirt of mid density.";
			sources = new[] { ELocation.Bog, ELocation.Coast, ELocation.Thicket };
		}
	}
}
