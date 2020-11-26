// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The recovery point type.</summary>
    public partial struct InMageV2RpRecoveryPointType :
        System.IEquatable<InMageV2RpRecoveryPointType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType Latest = @"Latest";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType LatestApplicationConsistent = @"LatestApplicationConsistent";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType LatestCrashConsistent = @"LatestCrashConsistent";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType LatestProcessed = @"LatestProcessed";

        /// <summary>
        /// the value for an instance of the <see cref="InMageV2RpRecoveryPointType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to InMageV2RpRecoveryPointType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="InMageV2RpRecoveryPointType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new InMageV2RpRecoveryPointType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type InMageV2RpRecoveryPointType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type InMageV2RpRecoveryPointType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is InMageV2RpRecoveryPointType && Equals((InMageV2RpRecoveryPointType)obj);
        }

        /// <summary>Returns hashCode for enum InMageV2RpRecoveryPointType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="InMageV2RpRecoveryPointType" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private InMageV2RpRecoveryPointType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for InMageV2RpRecoveryPointType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to InMageV2RpRecoveryPointType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="InMageV2RpRecoveryPointType" />.</param>

        public static implicit operator InMageV2RpRecoveryPointType(string value)
        {
            return new InMageV2RpRecoveryPointType(value);
        }

        /// <summary>Implicit operator to convert InMageV2RpRecoveryPointType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="InMageV2RpRecoveryPointType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum InMageV2RpRecoveryPointType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum InMageV2RpRecoveryPointType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.InMageV2RpRecoveryPointType e2)
        {
            return e2.Equals(e1);
        }
    }
}