using System;
using System.Collections.Generic;
using static Resources.Utils.Enums;

namespace Resources.Objects.Constructs.Crops {
	public abstract class ConstructCrop : Construct {
		public EType[] taxonomy;
		public Dictionary<Type, int> cyclesPerSoil; // How many successful cycles a crop has to live through
		public int resilience; // How many withering a crop can withstand
		public EWater[] reqWater;
		public ESunlight[] reqSunlight;
		public ETemperature[] reqTemperature;
	}
}
