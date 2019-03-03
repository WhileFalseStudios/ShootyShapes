using System;
using System.Collections.Generic;
using DefaultEcs;
using DefaultEcs.System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ShootyShapes.Systems;

namespace ShootyShapes
{
    public class ShootyShapesGame : Game
    {
        GraphicsDeviceManager _graphics;
        World _gameWorld;

        PlayerControlSystem _controlSystem;

        public ShootyShapesGame() : base()
        {
            _graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
            Content.MountDataPath("ShootyShapes");

            _gameWorld = new World();
            _controlSystem = new PlayerControlSystem(_gameWorld);
        }

        protected override void Update(GameTime gameTime)
        {
            _controlSystem.UpdateInputState(Keyboard.GetState(), GamePad.GetState(PlayerIndex.One), Mouse.GetState());
        }

        protected override void Draw(GameTime gameTime)
        {

        }
    }
}
