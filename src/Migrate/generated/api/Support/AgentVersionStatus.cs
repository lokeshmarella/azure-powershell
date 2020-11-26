// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>A value indicating whether security update required.</summary>
    public partial struct AgentVersionStatus :
        System.IEquatable<AgentVersionStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus Deprecated = @"Deprecated";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus NotSupported = @"NotSupported";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus SecurityUpdateRequired = @"SecurityUpdateRequired";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus Supported = @"Supported";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus UpdateRequired = @"UpdateRequired";

        /// <summary>the value for an instance of the <see cref="AgentVersionStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AgentVersionStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AgentVersionStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AgentVersionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AgentVersionStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AgentVersionStatus(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AgentVersionStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AgentVersionStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AgentVersionStatus && Equals((AgentVersionStatus)obj);
        }

        /// <summary>Returns hashCode for enum AgentVersionStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AgentVersionStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AgentVersionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AgentVersionStatus" />.</param>

        public static implicit operator AgentVersionStatus(string value)
        {
            return new AgentVersionStatus(value);
        }

        /// <summary>Implicit operator to convert AgentVersionStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AgentVersionStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AgentVersionStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AgentVersionStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentVersionStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}