using DoubleGameEngine;
using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using DoubleGameEngine.Managers;
using MarioDGE.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarioDGE.GameScreens
{
    public class Level_1 : GameScreen
    {
        public Level_1(DoubleGameEngine.Game game) : base(game)
        {
            GameObjects["Mario"] = new Mario(this) { Position = Vector2.Zero * 64};
        }

        public override void Initialize()
        {
            _level = "Level_1";

            base.Initialize();

            InitializeGameObjects();
        }

        /// <summary>
        /// Инициализирует игровые объекты
        /// </summary>
        public void InitializeGameObjects() {
            foreach (Entity entity in _entities) {
                switch (entity.Type) {
                    case "LuckyBlock": 
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(), 
                            new LuckyBlock(this) { 
                                Position = new Vector2(entity.X, entity.Y), 
                                IsMushroom = (int)((JsonElement)entity.CustomFields["IsMushroom"]).ValueKind == 5 ? true: false
                            }); 
                        break;
                    case "Brick": 
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(), 
                            new Brick(this) { 
                                Position = new Vector2(entity.X, entity.Y)
                            }); 
                        break;
                    case "Coin": 
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(), 
                            new Coin(this) { 
                                Position = new Vector2(entity.X, entity.Y)
                            }); 
                        break;
                    case "Finish": 
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(), 
                            new Finish(this) { 
                                Position = new Vector2(entity.X, entity.Y)
                            }); 
                        break;
                    case "Pipe": 
                        GameObjects.Add(
                            entity.Type + "_" + Guid.NewGuid(), 
                            new Pipe(this) { 
                                Position = new Vector2(entity.X, entity.Y) 
                            }); 
                        break;
                }
            }
        }
    }
}
