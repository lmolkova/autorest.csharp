// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace LiveVideoAnalytics.Models
{
    /// <summary> A signal gate determines when to block (gate) incoming media, and when to allow it through. It gathers input events over the activationEvaluationWindow, and determines whether to open or close the gate. </summary>
    public partial class MediaGraphSignalGateProcessor : MediaGraphProcessor
    {
        /// <summary> Initializes a new instance of MediaGraphSignalGateProcessor. </summary>
        /// <param name="name"> The name for this processor node. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this processor node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="inputs"/> is null. </exception>
        public MediaGraphSignalGateProcessor(string name, IEnumerable<MediaGraphNodeInput> inputs) : base(name, inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }

            Type = "#Microsoft.Media.MediaGraphSignalGateProcessor";
        }

        /// <summary> The period of time over which the gate gathers input events, before evaluating them. </summary>
        public string ActivationEvaluationWindow { get; set; }
        /// <summary> Signal offset once the gate is activated (can be negative). It is an offset between the time the event is received, and the timestamp of the first media sample (eg. video frame) that is allowed through by the gate. </summary>
        public string ActivationSignalOffset { get; set; }
        /// <summary> The minimum period for which the gate remains open, in the absence of subsequent triggers (events). </summary>
        public string MinimumActivationTime { get; set; }
        /// <summary> The maximum period for which the gate remains open, in the presence of subsequent events. </summary>
        public string MaximumActivationTime { get; set; }
    }
}
