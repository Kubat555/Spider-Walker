using System.Collections;
using System;
using UnityEngine;


public class Mech : MonoBehaviour
{
    [SerializeField]
    private LegData[] legs;

    [SerializeField]
    private float stepLength = 0.75f;

    private void Update()
    {
        for (int i = 0; i < legs.Length; i++)
        {
            ref var legData = ref legs[i];
            if (!CanMove(i)) continue;
            if (!legData.Leg.IsMoving &&
                !(Vector3.Distance(legData.Leg.Position, legData.Raycast.Position) > stepLength)) continue;
            legData.Leg.MoveTo(legData.Raycast.Position);
        }


    }

    private bool CanMove(int legIndex)
    {
        var legsCount = legs.Length;
        var n1 = legs[(legIndex + legsCount - 1) % legsCount];
        var n2 = legs[(legIndex + 1) % legsCount];
        return !n1.Leg.IsMoving && !n2.Leg.IsMoving;
    }

    [Serializable]
    public struct LegData
    {
        public LegTarget Leg;
        public LegRaycast Raycast;
    }
}
