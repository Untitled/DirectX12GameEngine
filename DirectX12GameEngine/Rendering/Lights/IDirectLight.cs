﻿namespace DirectX12GameEngine.Rendering.Lights
{
    public interface IDirectLight : IColorLight
    {
        LightShadowMap? Shadow { get; }
    }
}
