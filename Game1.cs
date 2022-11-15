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
        private Rectangle redGrayRect;
        private Rectangle yellowGrayRect;
        private Rectangle greenGrayRect;
        private Rectangle redRect;
        private Rectangle yellowRect;
        private Rectangle greenRect;
        private Rectangle topTrafficRect;
        private Rectangle bottomTrafficRect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            redGrayRect = new Rectangle(100, 100, 40, 40);
            yellowGrayRect = new Rectangle(100, 200, 40, 40);
            greenGrayRect = new Rectangle(100, 150, 40, 40);
            redRect = new Rectangle(101, 101, 38, 38);
            yellowRect = new Rectangle(101, 201, 38, 38);
            greenRect = new Rectangle(101, 151, 38, 38);
            topTrafficRect = new Rectangle(99, 96, 42, 150);
            bottomTrafficRect = new Rectangle(110, 246, 21, 250);
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
            _spriteBatch.Draw(rectangleTexture, topTrafficRect, Color.Black);
            _spriteBatch.Draw(circleTexture, redGrayRect, Color.Gray);
            _spriteBatch.Draw(circleTexture, yellowGrayRect, Color.Gray);
            _spriteBatch.Draw(circleTexture, greenGrayRect, Color.Gray);
            _spriteBatch.Draw(circleTexture, redRect, Color.Red);
            _spriteBatch.Draw(circleTexture, yellowRect, Color.Yellow);
            _spriteBatch.Draw(circleTexture, greenRect, Color.Green);
            _spriteBatch.Draw(rectangleTexture, bottomTrafficRect, Color.Black);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}