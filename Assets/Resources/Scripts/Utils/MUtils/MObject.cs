using System;

namespace Resources.Utils.MUtils {
	public class MObject {
		public bool InheritsFrom(Type t) {
			return t.IsAssignableFrom(GetType());
		}
	}
}
