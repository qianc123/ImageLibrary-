﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary
{
    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct RGB : IEquatable<RGB>, IFormattable
    {
        [FieldOffset(0)]
        private Double r;

        [FieldOffset(8)]
        private Double g;

        [FieldOffset(16)]
        private Double b;

        /// <summary>
        /// Red
        /// </summary>
        public Double R
        {
            get { return this.r; }
            set { this.r = value; }
        }

        /// <summary>
        /// Green
        /// </summary>
        public Double G
        {
            get { return this.g; }
            set { this.g = value; }
        }

        /// <summary>
        /// Blue
        /// </summary>
        public Double B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public RGB(double red, double green, double blue)
        {
            this.r = red;
            this.g = green;
            this.b = blue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RGB operator +(RGB a, RGB b)
        {
            return new RGB(a.R + b.R, a.G + b.G, a.B + b.B);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RGB operator -(RGB a, RGB b)
        {
            return new RGB(a.R - b.R, a.G - b.G, a.B - b.B);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RGB operator *(RGB a, RGB b)
        {
            return new RGB(a.R * b.R, a.G * b.G, a.B * b.B);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RGB operator *(RGB a, double b)
        {
            return new RGB(a.R * b, a.G * b, a.B * b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RGB operator *(double b, RGB a)
        {
            return new RGB(a.R * b, a.G * b, a.B * b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RGB operator /(RGB a, RGB b)
        {
            return new RGB(a.R / b.R, a.G / b.G, a.B / b.B);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RGB operator /(RGB a, double b)
        {
            return new RGB(a.R / b, a.G / b, a.B / b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(RGB item1, RGB item2)
        {
            return (
                item1.R == item2.R
                && item1.G == item2.G
                && item1.B == item2.B
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(RGB item1, RGB item2)
        {
            return (
                item1.R != item2.R
                || item1.G != item2.G
                || item1.B != item2.B
                );
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            return (this == (RGB)obj);
        }

        public override int GetHashCode()
        {
            return R.GetHashCode() ^ G.GetHashCode() ^ B.GetHashCode();
        }

        public bool Equals(RGB other)
        {
            return this == other;
        }

        public override string ToString()
        {
            return this.ToString(null, null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return String.Format(formatProvider, "RGB [R:{0}, G:{1}, B:{2}]", this.r, this.g, this.b);
        }
    }
}