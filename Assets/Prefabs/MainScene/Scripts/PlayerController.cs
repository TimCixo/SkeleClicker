using UnityEngine;

public static class PlayerController
{
    private static uint _commonBonesCount = 0;
    private static uint _blazeBonesCount = 0;
    private static uint _frostBonesCount = 0;

    [SerializeField]
    private static DropData _commonBoneData;
    [SerializeField]
    private static DropData _blazeBoneData;
    [SerializeField]
    private static DropData _frostBoneData;

    public static uint CommonBonesCount => _commonBonesCount;
    public static uint BlazeBonesCount => _blazeBonesCount;
    public static uint FrostBonesCount => _frostBonesCount;
}
