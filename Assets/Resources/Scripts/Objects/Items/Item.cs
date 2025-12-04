using Resources.Utils.MUtils;
using UnityEngine;

namespace Resources.Objects.Items {
	public abstract class Item : MObject {
		public string title;
		public string description;
		public Sprite sprite;
		public Item[] recipe;
		public float fuel = 0;
	}
}
