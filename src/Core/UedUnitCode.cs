namespace Ued.Core
{
    /// <summary>
    /// Enum of uint values that correspond to units when accessing a UED file
    /// </summary>
    public enum UedUnitCode : uint
    {
        KilogramPerHectare = 0x2a820603,
        Milimeter = 0x2043,
        CelsiusDegree = 0x100,
        MetersPerSecond = 0x16802000,
        MegaJoulesPerSquareMeterDay = 0x28804c06,
        Percent = 0x3
    };
}