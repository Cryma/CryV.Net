using System.Drawing;
using System.Numerics;
using CryV.Net.Client.Enums;
using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public static class UserInterface
    {

        public static void DrawText(string text, Vector2 position, float scale)
        {
            DrawText(text, position, scale, Color.WhiteSmoke, TextFont.ChaletLondon, TextAlignment.Left, 0.0f);
        }

        public static void DrawText(string text, Vector2 position, float scale, Color color)
        {
            DrawText(text, position, scale, color, TextFont.ChaletLondon, TextAlignment.Left, 0.0f);
        }

        public static void DrawText(string text, Vector2 position, float scale, Color color, TextFont textFont)
        {
            DrawText(text, position, scale, color, textFont, TextAlignment.Left, 0.0f);
        }

        public static void DrawText(string text, Vector2 position, float scale, Color color, TextFont textFont, TextAlignment textAlignment)
        {
            DrawText(text, position, scale, color, textFont, textAlignment, 0.0f);
        }

        public static void DrawText(string text, Vector2 position, float scale, Color color, TextFont textFont, TextAlignment textAlignment, float textWrap)
        {
            CryVNative.Native_UserInterface_SetTextFont(CryVNative.Plugin, (int) textFont);
            CryVNative.Native_UserInterface_SetTextScale(CryVNative.Plugin, scale, scale);
            CryVNative.Native_UserInterface_SetTextColour(CryVNative.Plugin, color.R, color.G, color.B, color.A);
            CryVNative.Native_UserInterface_SetTextWrap(CryVNative.Plugin, 0, textWrap);
            CryVNative.Native_UserInterface_SetTextCentre(CryVNative.Plugin, textAlignment == TextAlignment.Center);
            CryVNative.Native_UserInterface_SetTextDropshadow(CryVNative.Plugin, 0, 0, 0, 0, 0);
            CryVNative.Native_UserInterface_SetTextEdge(CryVNative.Plugin, 1, 0, 0, 0, 205);

            using (var converter = new StringConverter())
            {
                var commandTypePointer = converter.StringToPointer("STRING");
                var textPointer = converter.StringToPointer(text);

                CryVNative.Native_UserInterface_BeginTextCommandDisplayText(CryVNative.Plugin, commandTypePointer);
                CryVNative.Native_UserInterface_AddTextComponentSubstringPlayerName(CryVNative.Plugin, textPointer);
                CryVNative.Native_UserInterface_EndTextCommandDisplayText(CryVNative.Plugin, position.X, position.Y);
            }
        }

        public static void DrawRect(Vector2 position, Vector2 size, Color color)
        {
            CryVNative.Native_UserInterface_DrawRect(CryVNative.Plugin, position.X, position.Y, size.X, size.Y, color.R, color.G, color.B, color.A);
        }

        public static void GetScreenResolution(out int x, out int y)
        {
            x = y = 0;

            CryVNative.Native_UserInterface_GetScreenResolution(CryVNative.Plugin, ref x, ref y);
        }

    }
}
