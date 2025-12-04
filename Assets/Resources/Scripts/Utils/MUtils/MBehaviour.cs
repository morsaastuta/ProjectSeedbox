using System;
using UnityEngine;

namespace Resources.Utils.MUtils {
	public class MBehaviour : MonoBehaviour {
		public bool InheritsFrom(Type t) {
			return t.IsAssignableFrom(GetType());
		}
	}
}
