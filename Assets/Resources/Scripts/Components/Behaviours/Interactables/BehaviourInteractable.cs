using System;
using NaughtyAttributes;
using Resources.Components.Managers;
using Resources.Utils.MUtils;
using UnityEngine;

namespace Resources.Components.Behaviours.Interactables {
	public abstract class BehaviourInteractable : MBehaviour {
		[SerializeField] [Foldout("Interactable")] [ReadOnly] protected MDictionary<string, Action> events = new();

		public void Interact() {
			ManagerInteraction.Instance.Prompt(events);
		}
	}
}
