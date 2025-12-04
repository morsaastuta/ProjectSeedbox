using Resources.Objects.Items.Soils;
using Unity.VisualScripting;
using static Resources.Utils.Enums;

namespace Resources.Objects.Constructs.Crops {
	public class ConstructCropPotato : ConstructCrop {
		public ConstructCropPotato() {
			title = "Potato";
			description = "A planted potato crop.";
			taxonomy = new[] { EType.Tuberous, EType.Flowering };
			cyclesPerSoil.Add(typeof(ItemSoilPeatMoss), 7);
			cyclesPerSoil.Add(typeof(ItemSoilSandySoil), 6);
			cyclesPerSoil.Add(typeof(ItemSoilSiltySoil), 8);
			cyclesPerSoil.Add(typeof(ItemSoilClaySoil), 9);
			cyclesPerSoil.Add(typeof(ItemSoilLoam), 5);
			resilience = 6;
			reqWater = new[] { EWater.Moist };
			reqSunlight = new[] { ESunlight.Low, ESunlight.Mid, ESunlight.High };
			reqTemperature = new[] { ETemperature.Mild };
		}
	}
}
