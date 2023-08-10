using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Lab.Controls
{
    public class Movement : MonoBehaviour
    {
        public float moveSpeed = 10;
        public float jumpHeight = 16;

        private Vector2 moveDirection = Vector2.zero;
        private Rigidbody2D rb;
        private InputAction Jump;
        private InputAction Move;
        private Controls controls;

        private void Awake()
        {
            controls = new Controls();
        }

        private void OnEnable()
        {
            var _plrCtrls = controls.Player;

            Move = _plrCtrls.Move;
            Move.Enable();

            Jump = _plrCtrls.Jump;
            Jump.Enable();
            Jump.performed += OnJump;
        }

        private void OnDisable()
        {
            Move.Disable();
            Jump.Disable();
        }

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            moveDirection = Move.ReadValue<Vector2>();
        }

        private void FixedUpdate()
        {
            rb.velocity = moveSpeed * moveDirection;
        }

        private void OnJump(InputAction.CallbackContext context)
        {
            rb.velocity += Vector2.up * jumpHeight;
        }
    }
}
