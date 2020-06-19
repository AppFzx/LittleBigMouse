﻿/*
  LittleBigMouse.Plugin.Location
  Copyright (c) 2017 Mathieu GRENET.  All right reserved.

  This file is part of LittleBigMouse.Plugin.Location.

    LittleBigMouse.Plugin.Location is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LittleBigMouse.Plugin.Location is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MouseControl.  If not, see <http://www.gnu.org/licenses/>.

	  mailto:mathieu@mgth.fr
	  http://www.mgth.fr
*/

using HLab.Core.Annotations;
using HLab.DependencyInjection.Annotations;
using HLab.Mvvm.Annotations;
using LittleBigMouse.Control.Core;

namespace LittleBigMouse.Plugin.Location.Plugins.Location
{
    class ViewModeScreenLocation : ViewMode { }

    class ScreenLocationPlugin : IBootloader
    {
        private MainService _mainService;
        private IIconService _iconService;

        [Import]
        public ScreenLocationPlugin(MainService mainService, IIconService iconService)
        {
            _mainService = mainService;
            _iconService = iconService;
        }

        public void Load(IBootContext bootstrapper)
        {
            _mainService.MainViewModel.AddButton("Icons/IconLocation","Location",
                ()=> _mainService.MainViewModel.Presenter.ViewMode = typeof(ViewModeScreenLocation),
                ()=> _mainService.MainViewModel.Presenter.ViewMode = typeof(ViewModeDefault));
        }

    }
}
