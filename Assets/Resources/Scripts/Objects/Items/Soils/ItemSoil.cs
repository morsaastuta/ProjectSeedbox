using Resources.Objects.Items.Materials;
using static Resources.Utils.Enums;

namespace Resources.Objects.Items.Soils {
	public abstract class ItemSoil : Item {
		public float filtering;
		public ItemMaterial[] loot;
	}
}
