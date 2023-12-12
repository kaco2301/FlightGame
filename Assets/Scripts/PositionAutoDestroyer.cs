using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;
    private float destroyWeight = 2.0f;

    private void LateUpdate()
    {
        if (transform.position.y < stageData.Limitmin.y - destroyWeight ||
            transform.position.y > stageData.Limitmax.y + destroyWeight ||
            transform.position.x < stageData.Limitmin.x - destroyWeight ||
            transform.position.x > stageData.Limitmax.x + destroyWeight)
        {
            Destroy(gameObject);
        }

    }
}
