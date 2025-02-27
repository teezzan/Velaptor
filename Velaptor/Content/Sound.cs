﻿// <copyright file="Sound.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace Velaptor.Content
{
    using System.Diagnostics.CodeAnalysis;
    using CASL;
    using CASLSound = CASL.Sound;

    /// <summary>
    /// A single sound that can be played, paused etc.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Sound : ISound
    {
        private readonly CASLSound sound;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sound"/> class.
        /// </summary>
        /// <param name="filePath">The path to the sound file.</param>
        public Sound(string filePath) => this.sound = new CASLSound(filePath);

        /// <summary>
        /// Gets or sets the volume of the sound.
        /// </summary>
        /// <remarks>
        ///     The only valid value accepted is 0-100. If a value outside of
        ///     this range is used, it will be set within that range.
        /// </remarks>
        public float Volume
        {
            get => this.sound.Volume;
            set => this.sound.Volume = value;
        }

        /// <summary>
        /// Gets the current time position of the sound.
        /// </summary>
        public SoundTime Position => this.sound.Position;

        /// <summary>
        /// Gets the length of the song.
        /// </summary>
        public SoundTime Length => this.sound.Length;

        /// <summary>
        /// Gets or sets a value indicating whether the sound loops back to the beginning once the end has been reached.
        /// </summary>
        public bool IsLooping
        {
            get => this.sound.IsLooping;
            set => this.sound.IsLooping = value;
        }

        /// <summary>
        /// Gets the state of the sound.
        /// </summary>
        public SoundState State => this.sound.State;

        /// <summary>
        /// Gets or sets the play speed to the given value.
        /// </summary>
        /// <param name="value">The speed that the sound should play at.</param>
        /// <remarks>
        ///     The valid range of <paramref name="value"/> is between 0.25 and 2.0
        ///     with a <paramref name="value"/> less then 0.25 defaulting to 0.25 and
        ///     with a <paramref name="value"/> greater then 2.0 defaulting to 2.0.
        /// </remarks>
        public float PlaySpeed
        {
            get => this.sound.PlaySpeed;
            set => this.sound.PlaySpeed = value;
        }

        /// <inheritdoc/>
        public string Name => this.sound.Name;

        /// <inheritdoc/>
        public string Path => this.sound.Path;

        /// <inheritdoc/>
        public bool Unloaded => this.sound.Unloaded;

        /// <inheritdoc/>
#pragma warning disable CA1816 // Dispose methods should call SuppressFinalize
        public void Dispose() => this.sound.Dispose();
#pragma warning restore CA1816 // Dispose methods should call SuppressFinalize

        /// <summary>
        /// Fast forwards the sound by the given amount of <paramref name="seconds"/>.
        /// </summary>
        /// <param name="seconds">The amount of seconds to fast forward the song.</param>
        public void FastForward(float seconds) => this.sound.FastForward(seconds);

        /// <summary>
        /// Pauses the sound.
        /// </summary>
        public void Pause() => this.sound.Pause();

        /// <summary>
        /// Plays the sound.
        /// </summary>
        public void Play() => this.sound.Play();

        /// <summary>
        /// Resets the sound.
        /// </summary>
        /// <remarks>
        ///     This will stop the sound and set the time position back to the beginning.
        /// </remarks>
        public void Reset() => this.sound.Reset();

        /// <summary>
        /// Rewinds the sound by the given amound of <paramref name="seconds"/>.
        /// </summary>
        /// <param name="seconds">The amount of seconds to rewind the song.</param>
        public void Rewind(float seconds) => this.sound.Rewind(seconds);

        /// <summary>
        /// Sets the time position of the sound to the given value.
        /// </summary>
        /// <param name="seconds">The time position in seconds of where to set the sound.</param>
        public void SetTimePosition(float seconds) => this.sound.SetTimePosition(seconds);

        /// <summary>
        /// Stops the sound.
        /// </summary>
        /// <remarks>This will set the time position back to the beginning.</remarks>
        public void Stop() => this.sound.Stop();
    }
}
