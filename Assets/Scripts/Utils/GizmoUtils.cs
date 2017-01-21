using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GizmoUtils {
    public static void DrawRect(Rect rect) {
        Vector3 bottomLeftCorner = new Vector3(rect.x, rect.y, 0);
        Vector3 topLeftCorner = new Vector3(rect.x, rect.yMax, 0);
        Vector3 topRightCorner = new Vector3(rect.xMax, rect.yMax, 0);
        Vector3 bottomRightCorner = new Vector3(rect.xMax, rect.y, 0);
        Gizmos.DrawLine(bottomLeftCorner, topLeftCorner);
        Gizmos.DrawLine(topLeftCorner, topRightCorner);
        Gizmos.DrawLine(topRightCorner, bottomRightCorner);
        Gizmos.DrawLine(bottomRightCorner, bottomLeftCorner);
    }
}
