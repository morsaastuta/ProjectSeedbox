using System;
using System.Collections.Generic;
using UnityEngine;

namespace Resources.Components.Managers {
	public class ManagerInteraction : MonoBehaviour {
		public static ManagerInteraction Instance;

		public bool Prompt(Dictionary<string, Action> events) {
			return true;
		}
	}
}
