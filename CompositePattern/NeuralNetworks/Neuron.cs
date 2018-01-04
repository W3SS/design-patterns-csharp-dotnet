using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CompositePattern.NeuralNetworks
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float Value;
        public List<Neuron> In = new List<Neuron>(), Out = new List<Neuron>();

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }

    public class NeuronLayer : Collection<Neuron>
    {

    }
}
