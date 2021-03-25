using System;

namespace DelegateAndLinq
{
    public class Delegate
    {
        public event Func<int, int, int> SumHandler;

        public void Run()
        {
            SumHandler += Sum;
            SumHandler += Sum;
            var sum = 0;
            Try(() =>
            {
                var listDelegate = SumHandler.GetInvocationList();
                foreach (var item in listDelegate)
                {
                    var result = item.DynamicInvoke(5, 8);
                    sum += (int)result;
                }
            });
            Console.WriteLine(sum);
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public void Try(Action operation)
        {
            try
            {
              operation.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }
}
