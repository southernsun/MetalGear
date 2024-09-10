namespace DrawSprites.PlayerSprite;

public class SpriteAttribute
{
    public byte YOffset { get; set; }
    public byte XOffset { get; set; }
    public byte Pattern { get; set; }
    public byte Color { get; set; }

    public SpriteAttribute(byte yOffset, byte xOffset, byte pattern, byte color)
    {
        YOffset = yOffset;
        XOffset = xOffset;
        Pattern = pattern;
        Color = color;
    }
}