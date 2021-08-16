using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
			//boxing
			int? x = 10;
			object obj = x;

			int int3 = (int)obj;
			Console.WriteLine($"Proof that boxing happens only on value int3={int3}");

			//unboxing
			object objNull = null;
			int? int1 = (int?)objNull;
			Console.WriteLine($"int1={int1 ?? -1}");

			int? int2 = (int?)obj;
			Console.WriteLine($"int2={int2 ?? -1}");
		}

		private static void NullableSamples()
        {
			//Nullable<bool> flag1 = null;

			bool? flag1 = true;
			Console.WriteLine($"flag1={flag1}");
			Console.WriteLine($"flag1.HasValue={flag1.HasValue}");
			Console.WriteLine($"flag1.Value={flag1.Value }");
			Console.WriteLine($"flag1.GetValueOrDefault={flag1.GetValueOrDefault()}");
			Console.WriteLine($"flag1.GetValueOrDefault(...)={flag1.GetValueOrDefault(false)}");
			Console.WriteLine($"flag1 (null coalesce)={flag1 ?? false}");

			int? int1 = 10;
			Console.WriteLine($"int1={int1}");
			Console.WriteLine($"int1={int1.HasValue}");
			// This throws InvalidOperationException
			// Console.WriteLine($"int1={int1.Value}");
			Console.WriteLine($"int1={int1.GetValueOrDefault()}");
			Console.WriteLine($"int1={int1.GetValueOrDefault(-1)}");
			Console.WriteLine($"int1={int1 ?? -1}");

			//worksbecause of operator elevation
			int? it2 = int1 + 20;
		}
    }
}
