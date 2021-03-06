﻿// <copyright file="IPlayer.cs" company="Mark-James McDougall">
// Licensed under the GNU GPL v3 License. See LICENSE in the project root for license information.
// </copyright>

namespace MusicSharp
{
    /// <summary>
    /// Defines the methods an audio player class should implement.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Gets or sets the last file opened by the player.
        /// </summary>
        string LastFileOpened { get; set; }

        /// <summary>
        /// Method to play audio.
        /// </summary>
        /// <param name="path">The filepath of the audio file to play.</param>
        void OpenFile(string path);

        /// <summary>
        /// Method to play an audio stream from a URL.
        /// </summary>
        /// <param name="streamURL">The stream URL of the audio file to play.</param>
        void OpenStream(string streamURL);

        /// <summary>
        /// Method to pause audio playback.
        /// </summary>
        void PlayPause();

        /// <summary>
        /// Method to stop audio playback.
        /// </summary>
        void Stop();

        /// <summary>
        /// Method to increase audio playback volume.
        /// </summary>
        void IncreaseVolume();

        /// <summary>
        /// Method to decrease audio playback volume.
        /// </summary>
        void DecreaseVolume();

        /// <summary>
        /// Play an audio file contained in a playlist.
        /// </summary>
        /// <param name="path">The path to the audio file.</param>
        void PlayFromPlaylist(string path);
    }
}
