using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using static Terraria.Main;
using System.Collections.Generic;
using System.Linq;
using System;
using Terraria.UI;
namespace Class_Lock
{
    class TUIL : UIElement
    {
        public static int dps, list;
        public static List<Class> cl = new List<Class>();
        public static List<int> il = new List<int>();
        public override void Draw(SpriteBatch sb)
        {
            var dim = Vector2.Transform(new Vector2(Math.Max(97, 24 + il.Max()), 205), UIScaleMatrix);
            var pos = Vector2.Transform(new Vector2(2 + GetDimensions().X, 2 + GetDimensions().Y), UIScaleMatrix);
            var sr = sb.GraphicsDevice.ScissorRectangle;

            Height.Set(209, 0);
            Left.Set(7, 0);
            list = dps;
            UI.Panel(new Color(4, 97, 213), Color.Black, new Rectangle((int)GetDimensions().X, (int)GetDimensions().Y, (int)Width.Pixels, 209), sb);
            sb.End();
            sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.AnisotropicClamp, DepthStencilState.None, new RasterizerState { CullMode = CullMode.None, ScissorTestEnable = true }, null, UIScaleMatrix);
            sb.GraphicsDevice.ScissorRectangle = Rectangle.Intersect(new Rectangle((int)pos.X, (int)pos.Y, (int)dim.X, (int)dim.Y), sr);
            foreach (var _ in cl.OrderBy(_ => !_.chosen).ThenBy(_ => _.name))
            {
                _.Draw(sb);
                _.Top.Set(7 + list, 0);
                Append(_);
                il.Add((int)fontMouseText.MeasureString(_.name).X);
                list += 40;
            }
            sb.End();
            sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.AnisotropicClamp, DepthStencilState.None, sb.GraphicsDevice.RasterizerState, null, UIScaleMatrix);
            sb.GraphicsDevice.ScissorRectangle = sr;
            Top.Set(7, 0);
            Width.Set(Math.Max(101, 28 + il.Max()), 0);
        }
        public override void ScrollWheel(UIScrollWheelEvent evt)
        {
            dps += 0 < evt.ScrollWheelValue ? 40 : 0 > evt.ScrollWheelValue ? -40 : 0;
            ScrollBar.dps += 0 < evt.ScrollWheelValue ? 40 : 0 > evt.ScrollWheelValue ? -40 : 0;
        }
    }
}