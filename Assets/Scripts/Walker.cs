using UnityEngine;
using UnityEngine.InputSystem;

public class Walker : MonoBehaviour
{
    [Header("Values")]
    [SerializeField]
    float walkForce = 2f;

    [SerializeField]
    float dragForce = 2f;

    [SerializeField]
    float minForce;

    [SerializeField]
    float minTimeBetweenStrokes;

    [Header("References")]
    [SerializeField]
    InputActionReference leftControllerWalkReference;

    [SerializeField]
    InputActionReference leftControllerVelocity;

    [SerializeField]
    InputActionReference rightControllerWalkReference;

    [SerializeField]
    InputActionReference rightControllerVelocity;

    [SerializeField]
    Transform trackingReference;

    Rigidbody _rigidbody;
    float _cooldownTimer;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        _cooldownTimer += Time.fixedDeltaTime;
        if (
            _cooldownTimer > minTimeBetweenStrokes
            && leftControllerWalkReference.action.IsPressed()
            && rightControllerWalkReference.action.IsPressed()
        )
        {
            var leftHandVelocity = leftControllerVelocity.action.ReadValue<Vector3>();
            var rightHandVelocity = rightControllerVelocity.action.ReadValue<Vector3>();
            Vector3 localVelocity = leftHandVelocity + rightHandVelocity;
            localVelocity *= -1;

            if (localVelocity.sqrMagnitude > minForce * minForce)
            {
                Vector3 worldVelocity = trackingReference.TransformDirection(localVelocity);
                _rigidbody.AddForce(worldVelocity * walkForce, ForceMode.Acceleration);
                _cooldownTimer = 0f;
            }
        }

        if (_rigidbody.velocity.sqrMagnitude > 0.01f)
        {
            _rigidbody.AddForce(-_rigidbody.velocity * dragForce, ForceMode.Acceleration);
        }
    }
}
