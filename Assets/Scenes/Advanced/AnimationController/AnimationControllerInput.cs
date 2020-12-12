using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Mathematics;
using static Unity.Mathematics.math;

public class AnimationControllerInput
    : AnimationInputBase<AnimationControllerData>
    , Locomotion.IStandingActions
{
    public float DirectionStep = 0.1f;
    public float SpeedStep = 0.1f;

    private Locomotion locomotion;
    private float2 look;
    private float2 move;

    protected override void Awake()
    {
        base.Awake();
        locomotion = new Locomotion();
        locomotion.Standing.SetCallbacks(this);
    }

    private void OnEnable()
    {
        locomotion.Enable();
    }

    private void OnDisable()
    {
        locomotion.Disable();
    }

    protected override void UpdateComponentData(ref AnimationControllerData data)
    {
        data.Player = 1;

        var speed = clamp(length(move), 0, 1);
        var turning = speed == 0 ? 0 : move.x / speed;
        data.Direction = clamp(turning * 2f + 2f, 0f, 4f);
        data.Speed = clamp(length(move), 0f, 1f);

        // var deltaDir = Input.GetAxisRaw("Horizontal");
        // var deltaSpeed = Input.GetAxisRaw("Vertical");

        // data.Direction = clamp(data.Direction + deltaDir * DirectionStep, 0.0f, 4.0f);
        // data.Speed = clamp(data.Speed + deltaSpeed * SpeedStep, 0.0f, 1.0f);
    }

    void Locomotion.IStandingActions.OnLook(InputAction.CallbackContext context)
    {
        look = context.ReadValue<Vector2>();
        Debug.Log($"look:{look}");
    }

    void Locomotion.IStandingActions.OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        // Debug.Log($"move:{move}");
    }
}
