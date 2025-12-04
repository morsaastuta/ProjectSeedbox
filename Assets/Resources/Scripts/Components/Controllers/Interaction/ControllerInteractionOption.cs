using System;
using TMPro;
using UnityEngine;

namespace Resources.Components.Controllers.Interaction {
	public class ControllerInteractionOption : MonoBehaviour {
		[SerializeField] TextMeshProUGUI title;
		[SerializeField] Action action;

		public void Set(string t, Action a) {
			title.SetText(t);
			action = a;
		}

		public void Select() {
			action();
		}
	}
}
