using UnityEngine;

namespace UnityAtoms.Examples
{
    public static class Rigidbody2DExtensions
    {
        public static void Move(this Rigidbody2D body, Vector2 input, float speed, float deltaTime)
        {
            var direction = input.normalized;
            var targetVelocity = direction * speed;
            body.velocity = Vector2.Lerp(body.velocity, targetVelocity, 10f * deltaTime);

            if (direction.magnitude > 0f)
            {
                float lookAtTargetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                body.transform.rotation = Quaternion.AngleAxis(lookAtTargetAngle, Vector3.forward);
            }
        }
    }
}
