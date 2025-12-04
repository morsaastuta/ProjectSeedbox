using NaughtyAttributes;
using Resources.Components.Behaviours.Interactables;
using Resources.Utils.MUtils;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Resources.Components.Behaviours {
	public class BehaviourPlayer : MBehaviour {
		[Dropdown("References")] [SerializeField] protected InputActionAsset inputActions;
		[Dropdown("References")] [SerializeField] protected Rigidbody2D body;
		[Dropdown("References")] [SerializeField] protected Animator animator;
		[Dropdown("Properties")] [ReadOnly] protected Vector2 velocity;
		[Dropdown("Properties")] [ReadOnly] protected float speed = 1f;
		[Dropdown("Properties")] [ReadOnly] protected float range = 1f;
		[Dropdown("Properties")] [ReadOnly] protected BehaviourInteractable interactable;

		// Input system
		protected InputAction inputMove;
		protected InputAction inputInteract;
		protected InputAction inputMenu;

		protected void Awake() {
			inputMove = InputSystem.actions.FindAction("Move");
			inputInteract = InputSystem.actions.FindAction("Interact");
			inputMenu = InputSystem.actions.FindAction("Menu");
		}

		protected void OnEnable() {
			inputActions.FindActionMap("Player").Enable();
		}

		protected void OnDisable() {
			inputActions.FindActionMap("Player").Disable();
		}

		protected void Update() {
			velocity = inputMove.ReadValue<Vector2>();
			if (inputInteract.WasPressedThisFrame() && interactable) {
				interactable.Interact();
			}
		}

		protected void FixedUpdate() {
			Move(velocity);
			FindClosestInteractable();
		}

		protected void FindClosestInteractable() {
			float closestDistance = range;
			interactable = null;
			foreach (Collider2D c in Physics2D.OverlapCircleAll(transform.position, range)) {
				if (!c.CompareTag("Interactable")) continue;
				if (Vector2.Distance(transform.position, c.transform.position) <= closestDistance) {
					interactable = c.GetComponent<BehaviourInteractable>();
				}
			}
		}

		public void Move(Vector2 dir) {
			body.linearVelocity = dir * speed * Time.deltaTime;
		}

		public void Interact() { }
	}
}
