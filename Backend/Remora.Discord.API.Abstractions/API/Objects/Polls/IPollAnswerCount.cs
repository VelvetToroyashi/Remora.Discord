//
//  IPollAnswerCount.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using JetBrains.Annotations;

namespace Remora.Discord.API.Abstractions.Objects;

/// <summary>
/// Represents a count for a poll answer.
/// </summary>
[PublicAPI]
public interface IPollAnswerCount
{
    /// <summary>
    /// Gets the ID of the answer.
    /// </summary>
    int ID { get; }

    /// <summary>
    /// Gets the number of votes for this answer.
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Gets a value indicating Whether the current user has voted for this answer.
    /// </summary>
    bool HasCurrentUserVoted { get; }
}
