using System;

namespace OpenFTTH.Core
{
    /// <summary>
    /// This is a root class to provide common identification for all classes needing identification and naming attributes.
    /// </summary>
    public interface IIdentifiedObject
    {
        /// <summary>
        /// IEC CIM: Master resource identifier (mRID) issued by a model authority. The mRID is unique within an exchange context. Global uniqueness is easily achieved by using a UUID, as specified in RFC 4122, for the mRID. The use of UUID is strongly recommended.
        /// NB: We call this attribute Id and not mRID.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// IEC CIM: The name is any free human readable and possibly non unique text naming the object.
        /// </summary>
        public string? Name { get; }


        /// <summary>
        /// IEC CIM: The description is a free human readable text describing or naming the object. It may be non unique and may not correlate to a naming hierarchy.
        /// </summary>
        public string? Description { get; }
    }
}
