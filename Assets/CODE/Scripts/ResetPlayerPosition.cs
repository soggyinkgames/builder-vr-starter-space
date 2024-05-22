using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPosition : MonoBehaviour
{
    [SerializeField] Transform resetTransform;
    [SerializeField] GameObject player;
    [SerializeField] Camera playerHead;

    [ContextMenu("ResetPosition")]
    public void ResetPosition()
    {
        var rotationAngleY = resetTransform.rotation.eulerAngles.y - playerHead.transform.rotation.eulerAngles.y;
        player.transform.Rotate(0, rotationAngleY, 0);
        var distanceDiff = resetTransform.position - playerHead.transform.position;
        player.transform. position += distanceDiff;
    }
}
