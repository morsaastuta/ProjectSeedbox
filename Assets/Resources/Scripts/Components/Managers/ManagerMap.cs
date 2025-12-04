using System.Collections.Generic;
using System.Linq;
using Resources.Components.Behaviours.Interactables;
using UnityEngine;

namespace Resources.Components.Managers {
	public class ManagerMap : MonoBehaviour {
		public static ManagerMap Instance;
		List<BehaviourInteractableTile> tiles = new();
		List<BehaviourInteractableCrop> crops = new();
		[Header("References")] [SerializeField] public GameObject board;

		void Start() {
			Instance = this;
			foreach (BehaviourInteractableTile tile in board.GetComponentsInChildren<BehaviourInteractableTile>()) {
				tiles.Add(tile);
			}
		}

		public void AddCrop(BehaviourInteractableCrop c) {
			crops.Add(c);
		}

		public void RemCrop(BehaviourInteractableCrop c) {
			crops?.RemoveAll(crop => c == crop);
		}

		public BehaviourInteractableTile GetTileByPosition(Vector3 position) {
			return tiles.FirstOrDefault(tile => tile.transform.position == position);
		}
	}
}
