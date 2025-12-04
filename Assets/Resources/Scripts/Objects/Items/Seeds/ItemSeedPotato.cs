using Resources.Objects.Constructs.Crops;

namespace Resources.Objects.Items.Seeds {
	public class ItemSeedPotato : ItemSeed {
		public ItemSeedPotato() {
			crop = new ConstructCropPotato();
		}
	}
}
