﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Race.cs" company="Ascend">
//   Copyright 2011
// </copyright>
// <summary>
//   Defines the possible races of a player.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Starboard.Model
{
    /// <summary>
    /// Defines the possible races of a player.
    /// </summary>
    public enum Race
    {
        /// <summary> Race is currently unknown, displaying nothing. </summary>
        Unknown,

        /// <summary> Terran race. </summary>
        Terran,

        /// <summary> Zerg race. </summary>
        Zerg,

        /// <summary> Protoss race. </summary>
        Protoss,

        /// <summary> Random race. </summary>
        Random
    }
}
