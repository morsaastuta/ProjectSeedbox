using System;
using System.Collections.Generic;
using NaughtyAttributes;
using Resources.Components.Managers;
using Resources.Utils.MUtils;
using UnityEngine;
using UnityEngine.Events;

namespace Resources.Components.Behaviours.Interactables {
	public abstract class BehaviourInteractable : MBehaviour {
		[Dropdown("Interactable")] [SerializeField] protected Dictionary<string, Action> events;

		public void Interact() {
			ManagerInteraction.Instance.Prompt(events);
		}
	}
}
