using static Tensorflow.Binding;

class Lab02
{
    public static void Run()
    {
        var x_train = tf.constant(new float[] { 1, 2, 3, 4, 5 });
        var y_train = tf.constant(new float[] { 2, 4, 6, 8, 10 });

        // กำหนดค่า Learning Rate
        float learningRate = 0.01f;

        // ใช้ SGD Optimizer จาก Keras
        var optimizer = tf.keras.optimizers.SGD(learningRate);

        var W = tf.Variable(0.0f);
        var b = tf.Variable(0.0f);

        for (int i = 0; i < 1000; i++)
        {
            using var tape = tf.GradientTape();
            tape.watch(W);
            tape.watch(b);

            var prediction = W * x_train + b;
            var loss = tf.reduce_mean(tf.square(y_train - prediction));

            var grads = tape.gradient(loss, [W, b]);
            // ใช้ optimizer.apply_gradients()
            optimizer.apply_gradients(zip(grads, [W, b]));

            W.assign_sub(0.01f * grads[0]);
            b.assign_sub(0.01f * grads[1]);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Environment.NewLine}**********************");
        Console.WriteLine($"Trained W: {W.numpy()}");
        Console.WriteLine($"Trained b: {b.numpy()}");
        Console.ResetColor();
    }
}
