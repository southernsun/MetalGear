namespace DrawSprites.PlayerSprite;

public class SnakeSpriteAttributes
{
    public byte NumberOfSprites { get; set; }
    public SpriteAttribute[] Attributes { get; set; }

    public SnakeSpriteAttributes(byte numberOfSprites, SpriteAttribute[] attributes)
    {
        NumberOfSprites = numberOfSprites;
        Attributes = attributes;
    }
}