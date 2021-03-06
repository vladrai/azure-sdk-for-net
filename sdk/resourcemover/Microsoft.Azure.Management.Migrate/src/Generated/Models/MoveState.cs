// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{

    /// <summary>
    /// Defines values for MoveState.
    /// </summary>
    public static class MoveState
    {
        public const string AssignmentPending = "AssignmentPending";
        public const string PreparePending = "PreparePending";
        public const string PrepareInProgress = "PrepareInProgress";
        public const string PrepareFailed = "PrepareFailed";
        public const string MovePending = "MovePending";
        public const string MoveInProgress = "MoveInProgress";
        public const string MoveFailed = "MoveFailed";
        public const string DiscardInProgress = "DiscardInProgress";
        public const string DiscardFailed = "DiscardFailed";
        public const string CommitPending = "CommitPending";
        public const string CommitInProgress = "CommitInProgress";
        public const string CommitFailed = "CommitFailed";
        public const string Committed = "Committed";
        public const string DeleteSourcePending = "DeleteSourcePending";
        public const string ResourceMoveCompleted = "ResourceMoveCompleted";
    }
}
