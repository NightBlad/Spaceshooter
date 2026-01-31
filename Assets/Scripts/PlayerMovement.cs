using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Fractions of camera bounds allowed toward each side.
    [Range(0f, 1f)] public float leftLimitFactor = 0.75f;
    [Range(0f, 1f)] public float rightLimitFactor = 0.75f;
    [Range(0f, 1f)] public float topLimitFactor = 0.75f;
    [Range(0f, 1f)] public float bottomLimitFactor = 0.75f;

    void Update()
    {
        var cam = Camera.main;
        if (cam == null) return;

        var worldPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0f;

        // Orthographic camera bounds
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;
        Vector3 camPos = cam.transform.position;

        // Per-side bounds using individual factors
        float minX = camPos.x - (halfWidth * leftLimitFactor);
        float maxX = camPos.x + (halfWidth * rightLimitFactor);
        float minY = camPos.y - (halfHeight * bottomLimitFactor);
        float maxY = camPos.y + (halfHeight * topLimitFactor);

        float clampedX = Mathf.Clamp(worldPoint.x, minX, maxX);
        float clampedY = Mathf.Clamp(worldPoint.y, minY, maxY);

        transform.position = new Vector3(clampedX, clampedY, 0f);
    }
}
