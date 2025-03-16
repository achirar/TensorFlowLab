using static Tensorflow.Binding;

class Lab01
{
    public static void Run()
    {
        tf.enable_eager_execution();
        var tensor = tf.constant(3.0);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Environment.NewLine}**********************");
        Console.WriteLine($"TensorFlow Version: {tf.VERSION}");
        Console.WriteLine(tensor);
        Console.ResetColor();
    }
}
