using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Flood_Control
{
    class GamePiece
    {
        public static string[] PieceTypes = 
        {
            "Left,Right",
            "Top,Bottom",
            "Left,Top",
            "Top,Right",
            "Right,Bottom",
            "Bottom,Left",
            "Empty"
        };

        public const int PieceHeight = 40;
        public const int PieceWidth = 40;

        public const int MaxPlayablePieceIndex = 5;
        public const int EmptyPieceIndex = 6;

        private const int textureOffsetX = 1;
        private const int textureOffsetY = 1;
        private const int texturePaddingX = 1;
        private const int texturePaddingY = 1;

        private string pieceType = "";
        private string pieceSuffix = "";

        public string PieceType
        {
            get { return pieceType; }
        }

        public string Suffix
        {
            get { return pieceSuffix; }
        }

        public GamePiece(string type, string suffix)
        {
            pieceType = type;
            pieceSuffix = suffix;
        }

        public GamePiece(string type)
        {
            pieceType = type;
            pieceSuffix = "";
        }

        public void SetPiece(string type, string suffix)
        {
            pieceType = type;
            pieceSuffix = suffix;
        }

        public void SetPiece(string type)
        {
            pieceType = type;
            pieceSuffix = "";
        }

        public void AddSuffix(string suffix)
        {
            if (!pieceSuffix.Contains(suffix))
                pieceSuffix += suffix;
        }

        public void RemoveSuffix(string suffix)
        {
            pieceSuffix = pieceSuffix.Replace(suffix, "");
        }
    }
}
