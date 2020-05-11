# RidBot

![.NET Core](https://github.com/shighman/RidBot/workflows/.NET%20Core/badge.svg?branch=master)

## How to use

* Create one or more dotnet classlib projects 
* Add the package [Rid bot repo](https://www.nuget.org/packages/ridbot/)
* Create one or more classes which implement the IBot interface and you are done.

eg:
```
dotnet new classlib -n <class lib name>
cd <class lib name>
dotnet add package ridbot --version 1.0.1
```

A sample bot (needs GetRange and GetAngle):

```
    public class SampleBot : IBot
    {
        public string Name => "a unique name for you goes here";

        public BotAction GetBotAction(int turn, int totalTurns, IBotConfiguration yourConfiguration, IGameEntity you, IEnumerable<IGameEntity> gameAssets)
        {
            //TODO: Deal with non-player items in the arena 
            //eg gameAssets.OrderBy(x => GetRange(you.Position, x.Position)).FirstOrDefault(z => z.Entity != EntityTypeEnum.Player);
            //or gameAssets.FirstOrDefault(z => z.Entity == EntityTypeEnum.Health);
            //TODO: Deal with player items in the arena 
            //eg gameAssets.OrderBy(x => GetRange(you.Position, x.Position)).FirstOrDefault(z => z.Entity == EntityTypeEnum.Player);
        }

        public BotConfiguration GetBotConfiguration(PreviousResultEnum result, IBotConfiguration yourPrevious)
        {
            //You have a maximum of 100 to spread around the 4 stats
            return new BotConfiguration(
                damage: 40, 
                hitPoints: 20, 
                moveRate: 20, 
                range: 20);
        }
    }
```

All Objects have a position, which is an integer X and Y, Range is the distance between two points. And Angle is the angle in degrees measured from the north, 0 is north, 90 is to the east, 180 is south and 270 is west. The coordinates go up toward north and east and down toward south and west.

eg

(0,0) angle to (0,1) is 0 or 360
(0,0) angle to (1,0) is 90
(0,0) angle to (0,-1) is 180
(0,0) angle to (1,1) is 45.

I don't expect anyone to ever read this but if you do, welcome to the wide world of covid-19 social distancing boredom.