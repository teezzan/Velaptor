﻿// <copyright file="PathResolverFactory.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace Velaptor.Factories
{
    using System.Diagnostics.CodeAnalysis;
    using System.IO.Abstractions;
    using Velaptor.Content;

    /// <summary>
    /// Creates path resolver instances.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class PathResolverFactory
    {
        private static IPathResolver? texturePathResolver;
        private static IPathResolver? atlasJSONDataPathResolver;
        private static IPathResolver? soundPathResolver;
        private static IPathResolver? fontPathResolver;

        /// <summary>
        /// Creates a path resolver that resolves paths to texture content.
        /// </summary>
        /// <returns>The resolver to texture content.</returns>
        public static IPathResolver CreateTexturePathResolver()
        {
            if (texturePathResolver is null)
            {
                texturePathResolver = new TexturePathResolver(IoC.Container.GetInstance<IDirectory>());
            }

            return texturePathResolver;
        }

        /// <summary>
        /// Creates a path resolver that resolves paths to atlas content.
        /// </summary>
        /// <returns>The resolver to atlas content.</returns>
        public static IPathResolver CreateAtlasJSONDataPathResolver()
        {
            if (atlasJSONDataPathResolver is null)
            {
                atlasJSONDataPathResolver = new AtlasJSONDataPathResolver(IoC.Container.GetInstance<IDirectory>());
            }

            return atlasJSONDataPathResolver;
        }

        /// <summary>
        /// Creates a path resolver that resolves paths to font content.
        /// </summary>
        /// <returns>The resolver to atlas content.</returns>
        public static IPathResolver CreateFontPathResolver()
        {
            if (fontPathResolver is null)
            {
                fontPathResolver = new FontPathResolver(IoC.Container.GetInstance<IDirectory>());
            }

            return fontPathResolver;
        }

        /// <summary>
        /// Creates a path resolver that resolves paths to sound content.
        /// </summary>
        /// <returns>The resolver to sound content.</returns>
        public static IPathResolver CreateSoundPathResolver()
        {
            if (soundPathResolver is null)
            {
                soundPathResolver = new SoundPathResolver(IoC.Container.GetInstance<IDirectory>());
            }

            return soundPathResolver;
        }
    }
}
