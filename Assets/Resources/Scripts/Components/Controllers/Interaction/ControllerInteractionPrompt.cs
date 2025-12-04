using System;
using System.Collections.Generic;
using UnityEngine;

namespace Resources.Components.Controllers.Interaction {
	public class ControllerInteractionPrompt : MonoBehaviour {
		[SerializeField] GameObject option;
		List<GameObject> options = new();

		public void Clear() {
			foreach (GameObject o in options) Destroy(o);
			options.Clear();
		}

		public void Fill(Dictionary<string, Action> o) {
			foreach (string s in o.Keys) {
				GameObject newOption = Instantiate(option);
				newOption.GetComponent<ControllerInteractionOption>().Set(s, o.GetValueOrDefault(s));
				options.Add(newOption);
			}
		}
	}
}
