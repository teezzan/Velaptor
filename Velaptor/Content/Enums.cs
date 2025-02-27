﻿// <copyright file="Enums.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace Velaptor.Content
{
    /// <summary>
    /// The type of content that can be loaded.
    /// </summary>
    public enum ContentType
    {
        /// <summary>
        /// Graphic content.
        /// </summary>
        Graphics,

        /// <summary>
        /// Sound content.
        /// </summary>
        Sounds,

        /// <summary>
        /// Texture atlas content.
        /// </summary>
        Atlas,
    }

    /// <summary>
    /// Describes the type of texture.
    /// </summary>
    public enum TextureType
    {
        /// <summary>
        /// The entire texture.
        /// </summary>
        WholeTexture,

        /// <summary>
        /// A small area of the entire texture.
        /// </summary>
        SubTexture,
    }

    /// <summary>
    /// The kind of font styles.
    /// </summary>
    public enum FontStyle
    {
        /// <summary>
        /// Regular font style.
        /// </summary>
        Regular,

        /// <summary>
        /// Bold font style.
        /// </summary>
        Bold,

        /// <summary>
        /// Italic font style.
        /// </summary>
        Italic,
    }
}
