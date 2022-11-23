using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2_monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D squareTexture;
        Rectangle squareRect;
        Texture2D circleTexture;
        Rectangle circleRect;
        Texture2D circle2Texture;
        Rectangle circle2Rect;
        SpriteFont font;
        Rectangle square2Rect;
        Texture2D square2Texture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "MonoGame Pt2";
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            square2Rect = new Rectangle(250, 100, 400, 200);
            squareRect = new Rectangle(290, 200, 300, 75);
            circleRect = new Rectangle(300, 100, 100, 75);
            circle2Rect = new Rectangle(450,100,100,75);
            
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            squareTexture = Content.Load<Texture2D>("rectangle");
            circle2Texture = Content.Load<Texture2D>("circle (1)");
            square2Texture = Content.Load<Texture2D>("rectangle (2)");
            font = Content.Load<SpriteFont>("titleFont");

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
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(square2Texture, square2Rect, Color.Blue);
            _spriteBatch.Draw(squareTexture,squareRect, Color.White);
            _spriteBatch.Draw(circleTexture,circleRect, Color.White);
            _spriteBatch.Draw(circle2Texture, circle2Rect, Color.White);
            _spriteBatch.DrawString(font, "SMILE", new Vector2(100, 150),Color.White);
            _spriteBatch.End(); 
            
            base.Draw(gameTime);
        }
    }
}