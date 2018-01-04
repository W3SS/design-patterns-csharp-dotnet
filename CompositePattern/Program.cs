using CompositePattern.GeometricShapes;
using CompositePattern.NeuralNetworks;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // GEOMETRIC SHAPES
            var drawing = new GraphicObject { Name = "My Drawing" };
            drawing.Children.Add(new Square { Color = "Red" });
            drawing.Children.Add(new Circle { Color = "Yellow" });

            var group = new GraphicObject();
            group.Children.Add(new Circle { Color = "Blue" });
            group.Children.Add(new Square { Color = "Blue" });
            drawing.Children.Add(group);

            Console.WriteLine(drawing);

            // NEURAL NETWORKS
            var neuron1 = new Neuron();
            var neuron2 = new Neuron();
            var layer1 = new NeuronLayer();
            var layer2 = new NeuronLayer();

            neuron1.ConnectTo(neuron2);
            neuron1.ConnectTo(layer1);
            layer1.ConnectTo(layer2);

            Console.ReadLine();
        }
    }
}
