using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSprites
{
    public enum SnakeSprite
    {
        SprSnakeUp = 0,
        SprSnakeUp1 = 1,
        SprSnakeUp2 = 2,
        SprSnakeDown = 3,
        SprSnakeDown1 = 4,
        SprSnakeDown2 = 5,
        SprSnakeLeft = 6,
        SprSnakeLeft1 = 7,
        SprSnakeLeft2 = 8,
        SprSnakeRight = 9,
        SprSnakeRight1 = 10,  // 10
        SprSnakeRight2,
        SprSnakeUpW,
        SprSnakeUp1W,
        SprSnakeUp2W,
        SprSnakeDownW,
        SprSnakeDown1W,
        SprSnakeDown2W,
        SprSnakeLeftW,
        SprSnakeLeft1W,
        SprSnakeLeft2W,  // 20
        SprSnakeRightW,
        SprSnakeRight1W,
        SprSnakeRight2W,
        SprSnakePunchU,
        SprSnakePunchD,
        SprSnakePunchL,
        SprSnakePunchR,
        SprSnakeWaterU,
        SprSnakeWaterD,
        SprSnakeWaterL,  // 30
        SprSnakeWaterR,
        SprSnakeWaterUW,
        SprSnakeWaterDW,
        SprSnakeWaterLW,
        SprSnakeWaterRW,
        SprParachute,
        SprWaterShadow,
        SprWaterShadow2,
        SprSnakeClimb1,
        SprSnakeClimb2,  // 40
        SprSnakeLeaned,  // Dying animation
        SprBox,
        SprSnakeDead,
        SprBoxRepeat,    // Repeated box sprite
        SprSnakeWaterURepeat,  // Repeated water animation frames
        SprSnakeWaterDRepeat,
        SprSnakeWaterLRepeat,
        SprSnakeWaterRRepeat,
        SprSnakeWaterUWRepeat,
        SprSnakeWaterDWRepeat,
        SprSnakeWaterLWRepeat,
        SprSnakeWaterRWRepeat
    }
}
