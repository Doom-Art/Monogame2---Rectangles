using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame2___Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D circleTexture;
        private Texture2D rectangleTexture;
        private Rectangle circRect = new Rectangle(100, 100, 40, 40);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = (800);
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load <Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SeaShell);
            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, new Rectangle(99, 99, 42, 150), Color.Black);
            _spriteBatch.Draw(circleTexture, circRect, Color.Red);
            _spriteBatch.Draw(circleTexture, new Rectangle(100, 200, 40, 40), Color.Yellow);
            _spriteBatch.Draw(circleTexture, new Rectangle(100, 150, 40, 40), Color.Green);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(110, 249, 21, 150), Color.Black);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}