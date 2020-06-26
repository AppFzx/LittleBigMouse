﻿using System.Windows;
using LittleBigMouse.ScreenConfigs;

namespace LittleBigMouse.ScreenConfig.Dimensions
{
    public static class ScreenRatioExt
    {
        public static IScreenSize Scale(this IScreenSize source, IScreenRatio ratio) => new ScreenScale(source, ratio);
        public static IScreenSize ScaleWithLocation(this IScreenSize source, IScreenRatio ratio) => new ScreenScaleWithLocation(source, ratio);
        public static IScreenSize Locate(this IScreenSize source, Point? point = null) => new ScreenLocate(source, point);
        public static IScreenSize Rotate(this IScreenSize source, int rotation) => new ScreenRotate(source, rotation);
        public static IScreenSize ScaleDip(this IScreenSize source, Screen screen) => new ScreenScaleDip(source, screen);

        public static IScreenRatio Multiply(this IScreenRatio sourceA, IScreenRatio sourceB) => new ScreenRatioRatio(sourceA, sourceB);
        public static IScreenRatio Inverse(this IScreenRatio source) => new ScreenInverseRatio(source);
    }
}