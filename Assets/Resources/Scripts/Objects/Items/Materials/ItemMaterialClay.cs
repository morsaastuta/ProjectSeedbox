using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Materials {
	public class ItemMaterialClay : ItemMaterial {
		public ItemMaterialClay() {
			title = "Clay";
			description = "Dirt of high density.";
			sources = new[] { ELocation.Thicket };
		}
	}
}
