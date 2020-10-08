// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveVideoAnalytics.Models
{
    /// <summary> Enables a media graph to write media data to a destination outside of the Live Video Analytics IoT Edge module. </summary>
    public partial class MediaGraphSink
    {
        /// <summary> Initializes a new instance of MediaGraphSink. </summary>
        /// <param name="name"> Name to be used for the media graph sink. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this sink node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="inputs"/> is null. </exception>
        public MediaGraphSink(string name, IEnumerable<MediaGraphNodeInput> inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }

            Name = name;
            Inputs = inputs.ToList();
        }

        /// <summary> Initializes a new instance of MediaGraphSink. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="name"> Name to be used for the media graph sink. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this sink node. </param>
        internal MediaGraphSink(string type, string name, IList<MediaGraphNodeInput> inputs)
        {
            Type = type;
            Name = name;
            Inputs = inputs;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string Type { get; set; }
        /// <summary> Name to be used for the media graph sink. </summary>
        public string Name { get; set; }
        /// <summary> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this sink node. </summary>
        public IList<MediaGraphNodeInput> Inputs { get; }
    }
}
